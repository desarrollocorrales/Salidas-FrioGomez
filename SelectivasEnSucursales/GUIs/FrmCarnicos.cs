using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using SelectivasEnSucursales.Modelos;
using SelectivasEnSucursales.Modelos.SqliteDal;
using SelectivasEnSucursales.Reporte;

namespace SelectivasEnSucursales.GUIs
{
    public partial class FrmCarnicos : Form
    {
        private TimeSpan tiempoConsultaInicial, tiempoConsultaFinal;
        private string sError;
        private string sEtiquetas;
        private string sArchivoDeEscaneo;
        private List<Etiqueta> lstEtiquetas;
        private List<SegConService.EtiquetasGrid> lstEtiquetasACC;
        private List<WebServiceFriolala.EtiquetasGrid> lstEtiquetasFriolala;
        

        // Creando componentes de impresión.
        PrintingSystem SistemaImpresion = new PrintingSystem();
        PrintableComponentLink ComponenteImpresion = new PrintableComponentLink();

        public FrmCarnicos()
        {
            InitializeComponent();
            lstEtiquetas = new List<Etiqueta>();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                lstEtiquetas = new List<Etiqueta>();
                sEtiquetas = obtenerListaDeEtiquetetasDeEscaneo();
                pbCargando.Visible = true;
                ConsultarEtiquetas();
            }
            catch (Exception ex)
            {
                ShowException(ex);
            }
        }

        private void btnBuscarArchivo_Click(object sender, EventArgs e)
        {
            obtenerArchivoDeEscaneo();
        }

        private string obtenerListaDeEtiquetetasDeEscaneo()
        {
            //Leer el archivo de escaneo
            string ArrayEtiquetas = string.Empty;

            try
            {                
                if (sArchivoDeEscaneo != null)
                {
                    StreamReader sr = new StreamReader(sArchivoDeEscaneo);
                    ArrayEtiquetas = sr.ReadToEnd();
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                ShowException(ex);
            }

            Tarimificar(ArrayEtiquetas);

            return ArrayEtiquetas;
        }
        private void ConsultarEtiquetas()
        {
            tiempoConsultaInicial = DateTime.Now.TimeOfDay;
            btnConsultar.Enabled = false;
            bgwConsulta.RunWorkerAsync();
            bgwConsultaFriolala.RunWorkerAsync();
        }
        
        private void obtenerArchivoDeEscaneo()
        {
            DialogResult DR = ofdEscaneo.ShowDialog();

            if (DR == DialogResult.OK)
            {
                sArchivoDeEscaneo = ofdEscaneo.FileName;
                txbRutaArchivoEscaneo.Text = ofdEscaneo.FileName;
            }
        }        

        private void bgwConsulta_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                SegConService.ServicioWeb Servicio = new SegConService.ServicioWeb();
                Servicio.Url = Properties.Settings.Default.URLWebService;

                lstEtiquetasACC = Servicio.ConsultarEtiquetas(sEtiquetas).ToList();

                Etiqueta etiqueta;
                foreach (SegConService.EtiquetasGrid DatosEtiqueta in lstEtiquetasACC)
                {
                    etiqueta = new Etiqueta();
                    etiqueta.ClaveNombre = DatosEtiqueta.ClaveNombre;
                    etiqueta.NumeroDeEtiqueta = DatosEtiqueta.NumeroDeEtiqueta;
                    etiqueta.FechaDeEmpaque = DatosEtiqueta.FechaDeEmpaque;
                    etiqueta.FechaDeCaducidad = DatosEtiqueta.FechaDeCaducidad;
                    etiqueta.Cantidad = DatosEtiqueta.Cantidad;
                    etiqueta.Unidad = DatosEtiqueta.Unidad;

                    lstEtiquetas.Add(etiqueta);
                }
                sError = string.Empty;
            }
            catch (Exception ex)
            {
                sError = "Ocurrio un error con el Servicio Web: " + Environment.NewLine + ex.Message;
            }
        }
        private void bgwConsulta_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (sError.Equals(string.Empty))
            {
                if (bgwConsultaFriolala.IsBusy == false)
                {
                    gridEtiquetas.DataSource = lstEtiquetas;
                    gvEtiquetas.BestFitColumns();
                    pbCargando.Visible = false;
                    btnConsultar.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show(sError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            tiempoConsultaFinal = DateTime.Now.TimeOfDay;
            TimeSpan tiempoTotal = tiempoConsultaFinal - tiempoConsultaInicial;
            lbltiempo.Text = "Tiempo de consulta ACC: " + tiempoTotal.Seconds + " segundos.";
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }
        private void Imprimir()
        {
            if (txbCliente.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Error en el campo \"Cliente\"","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Impresion Reporte = new Impresion();
                Reporte.sCliente = txbCliente.Text;
                var lstSource = ((List<Etiqueta>)gridEtiquetas.DataSource);
                //Reporte.DataSource = lstEtiquetas.Distinct().ToList();
                Reporte.DataSource = lstSource;
                Reporte.ShowPreviewDialog();
            }
        }

        private void bgwConsultaFriolala_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                WebServiceFriolala.ServicioWeb Servicio = new WebServiceFriolala.ServicioWeb();
                Servicio.Url = Properties.Settings.Default.URLWebServiceFriolala;

                lstEtiquetasFriolala = Servicio.ConsultarEtiquetas(sEtiquetas).ToList();

                Etiqueta etiqueta;
                foreach (WebServiceFriolala.EtiquetasGrid DatosEtiqueta in lstEtiquetasFriolala)
                {
                    etiqueta = new Etiqueta();
                    etiqueta.ClaveNombre = DatosEtiqueta.ClaveNombre;
                    etiqueta.NumeroDeEtiqueta = DatosEtiqueta.NumeroDeEtiqueta;
                    etiqueta.FechaDeEmpaque = DatosEtiqueta.FechaDeEmpaque;
                    etiqueta.FechaDeCaducidad = DatosEtiqueta.FechaDeCaducidad;
                    etiqueta.Cantidad = DatosEtiqueta.Cantidad;
                    etiqueta.Unidad = DatosEtiqueta.Unidad;

                    lstEtiquetas.Add(etiqueta);
                }

                sError = string.Empty;
            }
            catch (Exception ex)
            {
                sError = "Ocurrio un error con el Servicio Web: " + Environment.NewLine + ex.Message;
            }
        }
        private void bgwConsultaFriolala_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (sError.Equals(string.Empty))
            {
                if (bgwConsulta.IsBusy == false)
                {
                    gridEtiquetas.DataSource = lstEtiquetas;
                    gvEtiquetas.BestFitColumns();
                    pbCargando.Visible = false;
                    btnConsultar.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show(sError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            tiempoConsultaFinal = DateTime.Now.TimeOfDay;
            TimeSpan tiempoTotal = tiempoConsultaFinal - tiempoConsultaInicial;
            lblTiempoFriolala.Text = "Tiempo de consulta Friolala: " + tiempoTotal.Seconds + " segundos.";
        }

        private void gvEtiquetas_EndGrouping(object sender, EventArgs e)
        {
            //Expandir los grupos
            (sender as DevExpress.XtraGrid.Views.Grid.GridView).ExpandAllGroups();
        }

        private void ShowException(Exception ex)
        {
            string TipoException = ex.GetType().ToString();
            StringBuilder SB = new StringBuilder();
            if (ex.InnerException != null)
                SB.AppendLine(ex.InnerException.Message);
            else
                SB.AppendLine(ex.Message);

            MessageBox.Show(SB.ToString(), TipoException, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }        

        private void Tarimificar(string sEscaneo)
        {
            string[] sTarimificado = sEscaneo.Split('.');

            int i = 1;
            tvTarimas.Nodes.Clear();
            foreach (string tarima in sTarimificado)
            {
                tvTarimas.Nodes.Add("Tarima " + (i++).ToString().PadLeft(3));
            }
        }

        private void ActualizarGridPorTarima(int indexTarima)
        {
            string sEscaneo = obtenerListaDeEtiquetetasDeEscaneo();
            string[] sTarimificado = sEscaneo.Split('.');
            string sEtiquetas = sTarimificado[indexTarima];
            string[] numerosdeetiquetas = sEtiquetas.Replace("\r\n","\n").Split('\n');

            List<Etiqueta> lstEtiquetasAMostrar = new List<Etiqueta>();
            foreach (string numeroetiqueta in numerosdeetiquetas)
            {
                lstEtiquetasAMostrar.Add(lstEtiquetas.FirstOrDefault(o => o.NumeroDeEtiqueta == numeroetiqueta));
            }

            lstEtiquetasAMostrar.RemoveAll(o=>o == null);
            gridEtiquetas.DataSource = lstEtiquetasAMostrar;
            gvEtiquetas.BestFitColumns();
        }

        private void tvTarimas_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode SelectedNode = tvTarimas.SelectedNode;
            ActualizarGridPorTarima(tvTarimas.SelectedNode.Index);
            tvTarimas.SelectedNode = SelectedNode;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            new FrmAgregarArticulos().ShowDialog();
            llenarComboArticulosExtra();
        }

        private void FrmCarnicos_Load(object sender, EventArgs e)
        {
            llenarComboArticulosExtra();
        }

        private void llenarComboArticulosExtra()
        {
            SqliteDAL DAL = new SqliteDAL();
            List<ArticuloExtra> lstArticulosExtra = DAL.ObtenerArticulosExtra();

            cbArticulosExtras.DataSource = lstArticulosExtra;
            cbArticulosExtras.DisplayMember = "nombre";
            cbArticulosExtras.ValueMember = "clave";
        }

        private void btnAgregarAlGrid_Click(object sender, EventArgs e)
        {
            if (txbCantidad.Text.Trim() == string.Empty)
                MessageBox.Show("Error en la cantidad...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txbPeso.Text.Trim() == string.Empty)
                MessageBox.Show("Error en el peso...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                AgregarAlGrid();
        }
        private void AgregarAlGrid()
        {
            /* Obtener los datos del grid */
            var lstSource = ((List<Etiqueta>)gridEtiquetas.DataSource);

            /* Obtener Articulo del Combobox*/
            ArticuloExtra artiEx = (ArticuloExtra)cbArticulosExtras.SelectedItem;

            /* Obtener cantidades */
            int iCantidad = Convert.ToInt32(txbCantidad.Text);
            decimal dPeso = Convert.ToDecimal(txbPeso.Text);

            Etiqueta nuevaEntrada;
            for (int i = 0; i < iCantidad; i++)
            {
                nuevaEntrada = new Etiqueta();
                nuevaEntrada.NumeroDeEtiqueta = "Sin Etiqueta " + (i + 1);
                nuevaEntrada.ClaveNombre = artiEx.Clave + " - " + artiEx.Nombre;
                nuevaEntrada.Cantidad = Convert.ToDecimal(txbPeso.Text);
                nuevaEntrada.FechaDeEmpaque = null;
                nuevaEntrada.FechaDeCaducidad = null;
                nuevaEntrada.Unidad = "KG";
                lstSource.Add(nuevaEntrada);
            }

            gridEtiquetas.DataSource = lstSource;
            gridEtiquetas.RefreshDataSource();
            gvEtiquetas.BestFitColumns();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lstEtiquetas = new List<Etiqueta>();
            gridEtiquetas.DataSource = lstEtiquetas;
            gridEtiquetas.RefreshDataSource();
        }

        private void txbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            new FrmConfiguracionCarnicos().ShowDialog();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Size = new System.Drawing.Size(50, 50);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new System.Drawing.Size(48, 48);
        }
    }
}
