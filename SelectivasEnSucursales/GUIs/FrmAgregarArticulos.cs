using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SelectivasEnSucursales.Modelos.SqliteDal;
using SelectivasEnSucursales.Modelos;

namespace SelectivasEnSucursales.GUIs
{
    public partial class FrmAgregarArticulos : Form
    {
        public FrmAgregarArticulos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar() == true)
                {
                    Agregar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Agregar()
        {
            string sClave = txbClave.Text.ToUpper();
            string sNombre = txbNombre.Text.ToUpper();
            SqliteDAL DAL = new SqliteDAL();

            string respuesta = DAL.AgregarArticulo(sClave, sNombre);

            if (respuesta == string.Empty)
            {
                llenarGridArticulosExtra();
                MessageBox.Show("El articulo fue dado de alta con exito!!!!");                
            }
            else
            {
                MessageBox.Show("Courrio un error: " + Environment.NewLine + respuesta);
            }
        }

        private bool Validar()
        {
            if (txbClave.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Por favor, teclee una clave para el producto...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txbNombre.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Por favor, teclee el nombre del producto...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                DialogResult dr = MessageBox.Show("¿Son datos correctos?", "Validar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    return false;
                }
            }
            return true;
        }

        private void FrmAgregarArticulos_Load(object sender, EventArgs e)
        {
            llenarGridArticulosExtra();
        }
        private void llenarGridArticulosExtra()
        {
            SqliteDAL DAL = new SqliteDAL();
            gridArticulosExtras.DataSource = DAL.ObtenerArticulosExtra();
            gvArticulosExtras.BestFitColumns();
        }

        private void gridArticulosExtras_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(e.KeyChar.ToString());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            /* Obtener el articulo seleccionado */
            int index = gvArticulosExtras.GetSelectedRows()[0];
            ArticuloExtra articuloex = (ArticuloExtra)gvArticulosExtras.GetRow(index);

            if (ValidarEliminar(articuloex) == true)
            {
                EliminarArticulo(articuloex);                
            }
        }
        private void EliminarArticulo(ArticuloExtra articuloex)
        {           
            /* Borrar el articulo*/
            SqliteDAL DAL = new SqliteDAL();
            string resultado = DAL.EliminarArticulo(articuloex.Clave);

            if (resultado == string.Empty)
            {
                llenarGridArticulosExtra();
                MessageBox.Show("El proceso terminó con exito...", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidarEliminar(ArticuloExtra ae)
        {
            DialogResult dr = 
                MessageBox.Show(string.Format("Esta apunto de eliminar de la lista al articulo '{0}'. ¿Desea Continuar?"
                                    , ae.Nombre.ToUpper()), "Validar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (dr == DialogResult.Yes)
                return true;
            
            return false;
        }
    }
}
