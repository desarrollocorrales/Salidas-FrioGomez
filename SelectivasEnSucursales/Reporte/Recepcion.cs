using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace SelectivasEnSucursales.Reporte
{
    public partial class Recepcion : DevExpress.XtraReports.UI.XtraReport
    {
        public string sCliente;

        public Recepcion()
        {
            InitializeComponent();
        }

        private void Impresion_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text  = DateTime.Now.ToString("hh:mm:ss tt");
        }

    }
}
