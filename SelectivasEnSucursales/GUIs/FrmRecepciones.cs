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
using SelectivasEnSucursales.Entity;
using System.Data;

namespace SelectivasEnSucursales.GUIs
{
    public partial class FrmRecepciones : Form
    {
        private TimeSpan tiempoConsultaInicial, tiempoConsultaFinal;
        private string sError;
        private string sEtiquetas;
        private string sArchivoDeEscaneo;
        private List<Etiqueta> lstEtiquetas;
        private List<Etiqueta> lstEtiquetasAImprimir;
        private List<SegConService.EtiquetasGrid> lstEtiquetasACC;
        private List<WebServiceFriolala.EtiquetasGrid> lstEtiquetasFriolala;
        

        // Creando componentes de impresión.
        PrintingSystem SistemaImpresion = new PrintingSystem();
        PrintableComponentLink ComponenteImpresion = new PrintableComponentLink();

        public FrmRecepciones()
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
                    etiqueta.IdPedido = DatosEtiqueta.IdPedido;
                    etiqueta.EtiquetaTarima = DatosEtiqueta.EtiquetaTarima;

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

                    gridRastreabilidad.DataSource = lstEtiquetas;
                    gvRastreabilidad.BestFitColumns();

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
            Recepcion Reporte = new Recepcion();
            Reporte.sCliente = string.Empty;
            //Reporte.DataSource = lstEtiquetas.Distinct().ToList();
            Reporte.DataSource = lstEtiquetasAImprimir;
            Reporte.ShowPreviewDialog();
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
                    etiqueta.IdPedido = DatosEtiqueta.IdPedido;
                    etiqueta.EtiquetaTarima = DatosEtiqueta.EtiquetaTarima;

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

                    gridRastreabilidad.DataSource = lstEtiquetas;
                    gvRastreabilidad.BestFitColumns();

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
                lstEtiquetasAMostrar.AddRange(lstEtiquetas.FindAll(o => o.EtiquetaTarima == numeroetiqueta));
            }

            lstEtiquetasAMostrar.RemoveAll(o=>o == null);
            lstEtiquetasAMostrar = lstEtiquetasAMostrar.Distinct().ToList();
            lstEtiquetasAImprimir = lstEtiquetasAMostrar;
            gridEtiquetas.DataSource = lstEtiquetasAMostrar;
            gvEtiquetas.BestFitColumns();

            gridRastreabilidad.DataSource = lstEtiquetasAMostrar;
            gvRastreabilidad.BestFitColumns();
        }

        private void tvTarimas_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode SelectedNode = tvTarimas.SelectedNode;
            ActualizarGridPorTarima(tvTarimas.SelectedNode.Index);
            tvTarimas.SelectedNode = SelectedNode;
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

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            new FrmConfiguracionCarnicos().ShowDialog();
        }

        private void FrmRecepciones_Load(object sender, EventArgs e)
        {
            IniciarControles();
        }
        private void IniciarControles()
        {
            cmbTipoSalida.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarGuardar() == true)
                    GuardarTrazabilidad();
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }
        private void GuardarTrazabilidad()
        {
            trazabilidad traza;
            var srcEtiquetas = (List<Etiqueta>)gridRastreabilidad.DataSource;
            TrazabilidadEntities Contexto = new TrazabilidadEntities(Properties.Settings.Default.EntityString);

            Contexto.Connection.Open();
            IDbTransaction Transaccion = Contexto.Connection.BeginTransaction();
            try
            {
                foreach (Etiqueta e in srcEtiquetas)
                {
                    traza = new trazabilidad();
                    traza.numero_etiqueta = e.NumeroDeEtiqueta;
                    traza.folio_salida = txbFolioSalida.Text.ToUpper();
                    traza.folio_compra = txbFolioCompra.Text.ToUpper();
                    traza.tipo_salida = cmbTipoSalida.SelectedItem.ToString().ToUpper();
                    traza.fecha_embarque = dtpFechaEmbarque.Value;
                    traza.propietario = txbPropietario.Text.ToUpper();
                    traza.cliente = txbCliente.Text.ToUpper();
                    Contexto.trazabilidad.AddObject(traza);
                }
                
                Contexto.SaveChanges();

                Transaccion.Commit();
                Contexto.Connection.Close();
                
                MessageBox.Show("¡¡¡Los datos fueron guardados con éxito!!!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                StringBuilder sb = new StringBuilder();
                var auxEx = ex;
                while (auxEx != null)
                {
                    sb.AppendLine(auxEx.Message + Environment.NewLine);
                    auxEx = auxEx.InnerException;
                }
                sb = sb.Replace("Duplicate entry", "Ya fue registrada la trazabilidad para la etiqueta ");
                sb = sb.Replace("for key 'PRIMARY'", string.Empty);
                
                Transaccion.Rollback();
                Contexto.Connection.Close();

                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidarGuardar()
        {
            if (gvRastreabilidad.DataRowCount == 0)
                return false;

            if (txbFolioSalida.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe ingresar el folio del documento de salida...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txbPropietario.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe ingresar el propietario de la mercancia...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txbCliente.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe ingresar el cliente...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            DialogResult dr = MessageBox.Show("¿Los datos son correctos?", "Validar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No)
                return false;

            return true;
        }

        private void MostrarExcepcion(Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            var exType = ex.GetType().ToString();
            while (ex != null)
            {
                sb.AppendLine(ex.Message + " --> ");
                ex = ex.InnerException;
            }

            MessageBox.Show(sb.ToString(), exType, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
