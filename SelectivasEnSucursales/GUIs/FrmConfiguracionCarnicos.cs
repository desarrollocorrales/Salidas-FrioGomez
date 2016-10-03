using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SelectivasEnSucursales.Entity;
using MySql.Data.MySqlClient;

namespace SelectivasEnSucursales.GUIs
{
    public partial class FrmConfiguracionCarnicos : Form
    {
        public FrmConfiguracionCarnicos()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                webPreview.Url = new Uri(txbUrl.Text);
                webPreview.Update();
            }
            catch 
            {
                MessageBox.Show("Error en la URL...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmConfiguracionCarnicos_Load(object sender, EventArgs e)
        {
            txbUrl.Text = Properties.Settings.Default.URLWebService;
            txbUrlFriolala.Text = Properties.Settings.Default.URLWebServiceFriolala;
            CargarTextBox();
        }
        private void CargarTextBox()
        {
            txbServidorDb.Text = Properties.Settings.Default.DB_Server;
            txbUserDb.Text = Properties.Settings.Default.DB_User;
            txbPassDb.Text = Properties.Settings.Default.DB_Pass;
            txbPortDb.Text = Properties.Settings.Default.DB_Port;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.URLWebServiceFriolala = txbUrlFriolala.Text;
            Properties.Settings.Default.URLWebService = txbUrl.Text;
            Properties.Settings.Default.Save();

            MessageBox.Show("Las URLs han sido guardadas con éxito!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCargarFriolala_Click(object sender, EventArgs e)
        {
            try
            {
                webPreview.Url = new Uri(txbUrlFriolala.Text);
                webPreview.Update();
            }
            catch
            {
                MessageBox.Show("Error en la URL...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarDb_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarDatosDB();
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }
        private void GuardarDatosDB()
        {
            var StringConn = 
                @"metadata=res://*/Entity.ModelTrazabilidad.csdl|
                           res://*/Entity.ModelTrazabilidad.ssdl|
                           res://*/Entity.ModelTrazabilidad.msl;
                  provider=MySql.Data.MySqlClient;
                  provider connection string='server={{servidor}};
                                             user id={{user}};
                                            password={{pass}};
                                                port={{port}};
                                            database={{db}};
                               Convert Zero Datetime=True;'";
            string NewStringConn;
            NewStringConn =    StringConn.Replace("{{servidor}}", txbServidorDb.Text);
            NewStringConn = NewStringConn.Replace("{{user}}", txbUserDb.Text);
            NewStringConn = NewStringConn.Replace("{{pass}}", txbPassDb.Text);
            NewStringConn = NewStringConn.Replace("{{port}}", txbPortDb.Text);
            NewStringConn = NewStringConn.Replace("{{db}}", cmbDB.SelectedItem.ToString());

            Properties.Settings.Default.EntityString = NewStringConn;
            Properties.Settings.Default.DB_Server = txbServidorDb.Text;
            Properties.Settings.Default.DB_User = txbUserDb.Text;
            Properties.Settings.Default.DB_Pass = txbPassDb.Text;
            Properties.Settings.Default.DB_Port = txbPortDb.Text;
            Properties.Settings.Default.Save();

            MessageBox.Show("¡Los datos se guardaron con éxito!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnCargarDb_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDb();
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }
        private void CargarDb()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = txbServidorDb.Text;
            sb.UserID = txbUserDb.Text;
            sb.Password = txbPassDb.Text;
            sb.Port = Convert.ToUInt32(txbPortDb.Text);

            MySqlConnection myConn = new MySqlConnection(sb.ToString());
            try
            {
                myConn.Open();
                MySqlCommand myComm = new MySqlCommand("Show Databases", myConn);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(myComm);
                DataTable dtResultado = new DataTable();
                myAdapter.Fill(dtResultado);
                foreach (DataRow row in dtResultado.Rows)
                {
                    cmbDB.Items.Add(row[0]);
                }
                if (cmbDB.Items.Count != 0)
                    cmbDB.SelectedIndex = 0;
                myConn.Close();
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
                if (myConn.State != ConnectionState.Closed)
                    myConn.Close();
            }
        }
    }
}
