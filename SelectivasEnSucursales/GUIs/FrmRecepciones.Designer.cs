namespace SelectivasEnSucursales.GUIs
{
    partial class FrmRecepciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecepciones));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.etiquetasGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnImprimir = new System.Windows.Forms.Button();
            this.ofdEscaneo = new System.Windows.Forms.OpenFileDialog();
            this.bgwConsulta = new System.ComponentModel.BackgroundWorker();
            this.bgwConsultaFriolala = new System.ComponentModel.BackgroundWorker();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.tbContainer = new System.Windows.Forms.TabControl();
            this.tbEscaneo = new System.Windows.Forms.TabPage();
            this.grpEscaneados = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.pbCargando = new System.Windows.Forms.PictureBox();
            this.lblTiempoFriolala = new System.Windows.Forms.Label();
            this.tvTarimas = new System.Windows.Forms.TreeView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lbltiempo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbRutaArchivoEscaneo = new System.Windows.Forms.TextBox();
            this.btnBuscarArchivo = new System.Windows.Forms.Button();
            this.gridEtiquetas = new DevExpress.XtraGrid.GridControl();
            this.gvEtiquetas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumeroDeEtiqueta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClaveNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaDeEmpaque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaDeCaducidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtpFechaEmbarque = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txbCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbPropietario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoSalida = new System.Windows.Forms.ComboBox();
            this.txbFolioSalida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gridRastreabilidad = new DevExpress.XtraGrid.GridControl();
            this.gvRastreabilidad = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumeroDeEtiqueta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPedido1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClaveNombre1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaDeEmpaque1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidad1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.etiquetasGridBindingSource)).BeginInit();
            this.tbContainer.SuspendLayout();
            this.tbEscaneo.SuspendLayout();
            this.grpEscaneados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCargando)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEtiquetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEtiquetas)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRastreabilidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRastreabilidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(984, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salida de Mercancía";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(984, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grupo Corrales";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // etiquetasGridBindingSource
            // 
            this.etiquetasGridBindingSource.DataSource = typeof(SelectivasEnSucursales.SegConService.EtiquetasGrid);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImprimir.Image = global::SelectivasEnSucursales.Properties.Resources.printer2;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(437, 559);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(110, 40);
            this.btnImprimir.TabIndex = 9;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // ofdEscaneo
            // 
            this.ofdEscaneo.FileName = "*.txt";
            this.ofdEscaneo.Filter = "Archivos de Texto | *.txt";
            // 
            // bgwConsulta
            // 
            this.bgwConsulta.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwConsulta_DoWork);
            this.bgwConsulta.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwConsulta_RunWorkerCompleted);
            // 
            // bgwConsultaFriolala
            // 
            this.bgwConsultaFriolala.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwConsultaFriolala_DoWork);
            this.bgwConsultaFriolala.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwConsultaFriolala_RunWorkerCompleted);
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Image = global::SelectivasEnSucursales.Properties.Resources.ios_settings_icon;
            this.btnConfigurar.Location = new System.Drawing.Point(5, 5);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(48, 48);
            this.btnConfigurar.TabIndex = 19;
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // tbContainer
            // 
            this.tbContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbContainer.Controls.Add(this.tbEscaneo);
            this.tbContainer.Controls.Add(this.tabPage2);
            this.tbContainer.Location = new System.Drawing.Point(3, 59);
            this.tbContainer.Name = "tbContainer";
            this.tbContainer.SelectedIndex = 0;
            this.tbContainer.Size = new System.Drawing.Size(981, 494);
            this.tbContainer.TabIndex = 20;
            // 
            // tbEscaneo
            // 
            this.tbEscaneo.Controls.Add(this.grpEscaneados);
            this.tbEscaneo.Location = new System.Drawing.Point(4, 27);
            this.tbEscaneo.Name = "tbEscaneo";
            this.tbEscaneo.Padding = new System.Windows.Forms.Padding(3);
            this.tbEscaneo.Size = new System.Drawing.Size(973, 463);
            this.tbEscaneo.TabIndex = 0;
            this.tbEscaneo.Text = "Escaneo";
            this.tbEscaneo.UseVisualStyleBackColor = true;
            // 
            // grpEscaneados
            // 
            this.grpEscaneados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEscaneados.Controls.Add(this.btnBorrar);
            this.grpEscaneados.Controls.Add(this.pbCargando);
            this.grpEscaneados.Controls.Add(this.lblTiempoFriolala);
            this.grpEscaneados.Controls.Add(this.tvTarimas);
            this.grpEscaneados.Controls.Add(this.btnConsultar);
            this.grpEscaneados.Controls.Add(this.lbltiempo);
            this.grpEscaneados.Controls.Add(this.label3);
            this.grpEscaneados.Controls.Add(this.txbRutaArchivoEscaneo);
            this.grpEscaneados.Controls.Add(this.btnBuscarArchivo);
            this.grpEscaneados.Controls.Add(this.gridEtiquetas);
            this.grpEscaneados.Location = new System.Drawing.Point(6, 0);
            this.grpEscaneados.Name = "grpEscaneados";
            this.grpEscaneados.Size = new System.Drawing.Size(961, 457);
            this.grpEscaneados.TabIndex = 17;
            this.grpEscaneados.TabStop = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrar.AutoSize = true;
            this.btnBorrar.Location = new System.Drawing.Point(877, 423);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(78, 28);
            this.btnBorrar.TabIndex = 16;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // pbCargando
            // 
            this.pbCargando.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbCargando.Image = global::SelectivasEnSucursales.Properties.Resources.cargando;
            this.pbCargando.Location = new System.Drawing.Point(396, 182);
            this.pbCargando.Name = "pbCargando";
            this.pbCargando.Size = new System.Drawing.Size(169, 94);
            this.pbCargando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCargando.TabIndex = 11;
            this.pbCargando.TabStop = false;
            this.pbCargando.Visible = false;
            // 
            // lblTiempoFriolala
            // 
            this.lblTiempoFriolala.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTiempoFriolala.AutoSize = true;
            this.lblTiempoFriolala.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoFriolala.Location = new System.Drawing.Point(6, 441);
            this.lblTiempoFriolala.Name = "lblTiempoFriolala";
            this.lblTiempoFriolala.Size = new System.Drawing.Size(140, 13);
            this.lblTiempoFriolala.TabIndex = 13;
            this.lblTiempoFriolala.Text = "Tiempo de consulta Friolala:";
            // 
            // tvTarimas
            // 
            this.tvTarimas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.tvTarimas.Location = new System.Drawing.Point(11, 57);
            this.tvTarimas.Name = "tvTarimas";
            this.tvTarimas.Size = new System.Drawing.Size(201, 365);
            this.tvTarimas.TabIndex = 15;
            this.tvTarimas.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvTarimas_AfterSelect);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.AutoSize = true;
            this.btnConsultar.Location = new System.Drawing.Point(877, 23);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(78, 28);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lbltiempo
            // 
            this.lbltiempo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbltiempo.AutoSize = true;
            this.lbltiempo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltiempo.Location = new System.Drawing.Point(6, 425);
            this.lbltiempo.Name = "lbltiempo";
            this.lbltiempo.Size = new System.Drawing.Size(127, 13);
            this.lbltiempo.TabIndex = 12;
            this.lbltiempo.Text = "Tiempo de consulta ACC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Archivo de escaneo:";
            // 
            // txbRutaArchivoEscaneo
            // 
            this.txbRutaArchivoEscaneo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbRutaArchivoEscaneo.BackColor = System.Drawing.Color.White;
            this.txbRutaArchivoEscaneo.Enabled = false;
            this.txbRutaArchivoEscaneo.Location = new System.Drawing.Point(154, 25);
            this.txbRutaArchivoEscaneo.Name = "txbRutaArchivoEscaneo";
            this.txbRutaArchivoEscaneo.Size = new System.Drawing.Size(667, 26);
            this.txbRutaArchivoEscaneo.TabIndex = 6;
            // 
            // btnBuscarArchivo
            // 
            this.btnBuscarArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarArchivo.AutoSize = true;
            this.btnBuscarArchivo.Location = new System.Drawing.Point(827, 23);
            this.btnBuscarArchivo.Name = "btnBuscarArchivo";
            this.btnBuscarArchivo.Size = new System.Drawing.Size(44, 28);
            this.btnBuscarArchivo.TabIndex = 10;
            this.btnBuscarArchivo.Text = "...";
            this.btnBuscarArchivo.UseVisualStyleBackColor = true;
            this.btnBuscarArchivo.Click += new System.EventHandler(this.btnBuscarArchivo_Click);
            // 
            // gridEtiquetas
            // 
            this.gridEtiquetas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEtiquetas.DataSource = this.etiquetasGridBindingSource;
            this.gridEtiquetas.Location = new System.Drawing.Point(213, 57);
            this.gridEtiquetas.MainView = this.gvEtiquetas;
            this.gridEtiquetas.Name = "gridEtiquetas";
            this.gridEtiquetas.Size = new System.Drawing.Size(742, 365);
            this.gridEtiquetas.TabIndex = 8;
            this.gridEtiquetas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEtiquetas});
            // 
            // gvEtiquetas
            // 
            this.gvEtiquetas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvEtiquetas.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvEtiquetas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvEtiquetas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvEtiquetas.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvEtiquetas.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.gvEtiquetas.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.gvEtiquetas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.gvEtiquetas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvEtiquetas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvEtiquetas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvEtiquetas.Appearance.Empty.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvEtiquetas.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvEtiquetas.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvEtiquetas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvEtiquetas.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvEtiquetas.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvEtiquetas.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gvEtiquetas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvEtiquetas.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.gvEtiquetas.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.gvEtiquetas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvEtiquetas.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvEtiquetas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvEtiquetas.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvEtiquetas.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvEtiquetas.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvEtiquetas.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvEtiquetas.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvEtiquetas.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvEtiquetas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvEtiquetas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvEtiquetas.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gvEtiquetas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvEtiquetas.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvEtiquetas.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvEtiquetas.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvEtiquetas.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvEtiquetas.Appearance.GroupRow.Options.UseFont = true;
            this.gvEtiquetas.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvEtiquetas.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvEtiquetas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvEtiquetas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvEtiquetas.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvEtiquetas.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.gvEtiquetas.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gvEtiquetas.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gvEtiquetas.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvEtiquetas.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.OddRow.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.OddRow.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.gvEtiquetas.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.gvEtiquetas.Appearance.Preview.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.Preview.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvEtiquetas.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.Row.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.Row.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvEtiquetas.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.gvEtiquetas.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gvEtiquetas.Appearance.VertLine.Options.UseBackColor = true;
            this.gvEtiquetas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumeroDeEtiqueta,
            this.colClaveNombre,
            this.colFechaDeEmpaque,
            this.colFechaDeCaducidad,
            this.colCantidad,
            this.colUnidad,
            this.colIdPedido});
            this.gvEtiquetas.GridControl = this.gridEtiquetas;
            this.gvEtiquetas.GroupCount = 1;
            this.gvEtiquetas.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "NumeroDeEtiqueta", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cantidad", this.colCantidad, "{0:#,0.00}")});
            this.gvEtiquetas.Name = "gvEtiquetas";
            this.gvEtiquetas.OptionsBehavior.Editable = false;
            this.gvEtiquetas.OptionsView.EnableAppearanceEvenRow = true;
            this.gvEtiquetas.OptionsView.EnableAppearanceOddRow = true;
            this.gvEtiquetas.OptionsView.ShowFooter = true;
            this.gvEtiquetas.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colClaveNombre, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvEtiquetas.EndGrouping += new System.EventHandler(this.gvEtiquetas_EndGrouping);
            // 
            // colNumeroDeEtiqueta
            // 
            this.colNumeroDeEtiqueta.AppearanceCell.Options.UseTextOptions = true;
            this.colNumeroDeEtiqueta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumeroDeEtiqueta.AppearanceHeader.Options.UseTextOptions = true;
            this.colNumeroDeEtiqueta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumeroDeEtiqueta.FieldName = "NumeroDeEtiqueta";
            this.colNumeroDeEtiqueta.Name = "colNumeroDeEtiqueta";
            this.colNumeroDeEtiqueta.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "NumeroDeEtiqueta", "{0:0,0}")});
            this.colNumeroDeEtiqueta.Visible = true;
            this.colNumeroDeEtiqueta.VisibleIndex = 0;
            // 
            // colClaveNombre
            // 
            this.colClaveNombre.FieldName = "ClaveNombre";
            this.colClaveNombre.Name = "colClaveNombre";
            // 
            // colFechaDeEmpaque
            // 
            this.colFechaDeEmpaque.AppearanceCell.Options.UseTextOptions = true;
            this.colFechaDeEmpaque.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaDeEmpaque.AppearanceHeader.Options.UseTextOptions = true;
            this.colFechaDeEmpaque.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaDeEmpaque.FieldName = "FechaDeEmpaque";
            this.colFechaDeEmpaque.Name = "colFechaDeEmpaque";
            this.colFechaDeEmpaque.Visible = true;
            this.colFechaDeEmpaque.VisibleIndex = 2;
            // 
            // colFechaDeCaducidad
            // 
            this.colFechaDeCaducidad.AppearanceCell.Options.UseTextOptions = true;
            this.colFechaDeCaducidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaDeCaducidad.AppearanceHeader.Options.UseTextOptions = true;
            this.colFechaDeCaducidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaDeCaducidad.FieldName = "FechaDeCaducidad";
            this.colFechaDeCaducidad.Name = "colFechaDeCaducidad";
            this.colFechaDeCaducidad.Visible = true;
            this.colFechaDeCaducidad.VisibleIndex = 3;
            // 
            // colCantidad
            // 
            this.colCantidad.AppearanceHeader.Options.UseTextOptions = true;
            this.colCantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 4;
            // 
            // colUnidad
            // 
            this.colUnidad.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colUnidad.FieldName = "Unidad";
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.Visible = true;
            this.colUnidad.VisibleIndex = 5;
            // 
            // colIdPedido
            // 
            this.colIdPedido.AppearanceCell.Options.UseTextOptions = true;
            this.colIdPedido.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdPedido.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdPedido.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdPedido.Caption = "Lote";
            this.colIdPedido.FieldName = "IdPedido";
            this.colIdPedido.Name = "colIdPedido";
            this.colIdPedido.Visible = true;
            this.colIdPedido.VisibleIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtpFechaEmbarque);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txbCliente);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txbPropietario);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cmbTipoSalida);
            this.tabPage2.Controls.Add(this.txbFolioSalida);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnGuardar);
            this.tabPage2.Controls.Add(this.gridRastreabilidad);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(973, 463);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rastreabilidad";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtpFechaEmbarque
            // 
            this.dtpFechaEmbarque.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFechaEmbarque.CustomFormat = "dd/MMMM/yyyy";
            this.dtpFechaEmbarque.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaEmbarque.Location = new System.Drawing.Point(754, 6);
            this.dtpFechaEmbarque.Name = "dtpFechaEmbarque";
            this.dtpFechaEmbarque.Size = new System.Drawing.Size(200, 26);
            this.dtpFechaEmbarque.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(625, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "Fecha embarque:";
            // 
            // txbCliente
            // 
            this.txbCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbCliente.Location = new System.Drawing.Point(574, 41);
            this.txbCliente.Name = "txbCliente";
            this.txbCliente.Size = new System.Drawing.Size(380, 26);
            this.txbCliente.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(513, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Cliente:";
            // 
            // txbPropietario
            // 
            this.txbPropietario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbPropietario.Location = new System.Drawing.Point(105, 38);
            this.txbPropietario.Name = "txbPropietario";
            this.txbPropietario.Size = new System.Drawing.Size(380, 26);
            this.txbPropietario.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Propietario:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tipo de salida:";
            // 
            // cmbTipoSalida
            // 
            this.cmbTipoSalida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbTipoSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoSalida.FormattingEnabled = true;
            this.cmbTipoSalida.Items.AddRange(new object[] {
            "Factura",
            "Traspaso"});
            this.cmbTipoSalida.Location = new System.Drawing.Point(419, 6);
            this.cmbTipoSalida.Name = "cmbTipoSalida";
            this.cmbTipoSalida.Size = new System.Drawing.Size(200, 26);
            this.cmbTipoSalida.TabIndex = 27;
            // 
            // txbFolioSalida
            // 
            this.txbFolioSalida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbFolioSalida.Location = new System.Drawing.Point(105, 6);
            this.txbFolioSalida.Name = "txbFolioSalida";
            this.txbFolioSalida.Size = new System.Drawing.Size(200, 26);
            this.txbFolioSalida.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Folio salida:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.Location = new System.Drawing.Point(396, 427);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(180, 30);
            this.btnGuardar.TabIndex = 31;
            this.btnGuardar.Text = "Guardar Trazabilidad";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gridRastreabilidad
            // 
            this.gridRastreabilidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridRastreabilidad.DataSource = this.etiquetasGridBindingSource;
            this.gridRastreabilidad.Location = new System.Drawing.Point(9, 73);
            this.gridRastreabilidad.MainView = this.gvRastreabilidad;
            this.gridRastreabilidad.Name = "gridRastreabilidad";
            this.gridRastreabilidad.Size = new System.Drawing.Size(956, 348);
            this.gridRastreabilidad.TabIndex = 9;
            this.gridRastreabilidad.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRastreabilidad});
            // 
            // gvRastreabilidad
            // 
            this.gvRastreabilidad.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvRastreabilidad.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvRastreabilidad.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvRastreabilidad.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvRastreabilidad.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvRastreabilidad.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvRastreabilidad.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvRastreabilidad.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvRastreabilidad.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.gvRastreabilidad.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.gvRastreabilidad.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.gvRastreabilidad.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvRastreabilidad.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvRastreabilidad.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvRastreabilidad.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvRastreabilidad.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvRastreabilidad.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvRastreabilidad.Appearance.Empty.Options.UseBackColor = true;
            this.gvRastreabilidad.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvRastreabilidad.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvRastreabilidad.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvRastreabilidad.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvRastreabilidad.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvRastreabilidad.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvRastreabilidad.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvRastreabilidad.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvRastreabilidad.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvRastreabilidad.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvRastreabilidad.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gvRastreabilidad.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvRastreabilidad.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvRastreabilidad.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvRastreabilidad.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.gvRastreabilidad.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvRastreabilidad.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.gvRastreabilidad.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvRastreabilidad.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvRastreabilidad.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvRastreabilidad.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvRastreabilidad.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvRastreabilidad.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvRastreabilidad.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvRastreabilidad.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvRastreabilidad.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvRastreabilidad.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvRastreabilidad.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvRastreabilidad.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvRastreabilidad.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvRastreabilidad.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvRastreabilidad.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvRastreabilidad.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvRastreabilidad.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvRastreabilidad.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvRastreabilidad.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvRastreabilidad.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvRastreabilidad.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvRastreabilidad.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gvRastreabilidad.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvRastreabilidad.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvRastreabilidad.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvRastreabilidad.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvRastreabilidad.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvRastreabilidad.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvRastreabilidad.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvRastreabilidad.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvRastreabilidad.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvRastreabilidad.Appearance.GroupRow.Options.UseFont = true;
            this.gvRastreabilidad.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvRastreabilidad.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvRastreabilidad.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvRastreabilidad.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvRastreabilidad.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvRastreabilidad.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvRastreabilidad.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvRastreabilidad.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvRastreabilidad.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvRastreabilidad.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.gvRastreabilidad.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gvRastreabilidad.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvRastreabilidad.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvRastreabilidad.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gvRastreabilidad.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvRastreabilidad.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvRastreabilidad.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvRastreabilidad.Appearance.OddRow.Options.UseBackColor = true;
            this.gvRastreabilidad.Appearance.OddRow.Options.UseForeColor = true;
            this.gvRastreabilidad.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.gvRastreabilidad.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.gvRastreabilidad.Appearance.Preview.Options.UseBackColor = true;
            this.gvRastreabilidad.Appearance.Preview.Options.UseForeColor = true;
            this.gvRastreabilidad.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvRastreabilidad.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvRastreabilidad.Appearance.Row.Options.UseBackColor = true;
            this.gvRastreabilidad.Appearance.Row.Options.UseForeColor = true;
            this.gvRastreabilidad.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvRastreabilidad.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvRastreabilidad.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.gvRastreabilidad.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvRastreabilidad.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvRastreabilidad.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvRastreabilidad.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gvRastreabilidad.Appearance.VertLine.Options.UseBackColor = true;
            this.gvRastreabilidad.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumeroDeEtiqueta1,
            this.colIdPedido1,
            this.colClaveNombre1,
            this.colFechaDeEmpaque1,
            this.colCantidad1,
            this.colUnidad1});
            this.gvRastreabilidad.GridControl = this.gridRastreabilidad;
            this.gvRastreabilidad.GroupCount = 1;
            this.gvRastreabilidad.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "NumeroDeEtiqueta", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cantidad", this.colCantidad1, "{0:#,0.00}")});
            this.gvRastreabilidad.Name = "gvRastreabilidad";
            this.gvRastreabilidad.OptionsBehavior.Editable = false;
            this.gvRastreabilidad.OptionsView.EnableAppearanceEvenRow = true;
            this.gvRastreabilidad.OptionsView.EnableAppearanceOddRow = true;
            this.gvRastreabilidad.OptionsView.ShowFooter = true;
            this.gvRastreabilidad.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colClaveNombre1, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvRastreabilidad.EndGrouping += new System.EventHandler(this.gvEtiquetas_EndGrouping);
            // 
            // colNumeroDeEtiqueta1
            // 
            this.colNumeroDeEtiqueta1.AppearanceCell.Options.UseTextOptions = true;
            this.colNumeroDeEtiqueta1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumeroDeEtiqueta1.AppearanceHeader.Options.UseTextOptions = true;
            this.colNumeroDeEtiqueta1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumeroDeEtiqueta1.FieldName = "NumeroDeEtiqueta";
            this.colNumeroDeEtiqueta1.Name = "colNumeroDeEtiqueta1";
            this.colNumeroDeEtiqueta1.Visible = true;
            this.colNumeroDeEtiqueta1.VisibleIndex = 0;
            // 
            // colIdPedido1
            // 
            this.colIdPedido1.AppearanceCell.Options.UseTextOptions = true;
            this.colIdPedido1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colIdPedido1.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdPedido1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colIdPedido1.Caption = "Lote";
            this.colIdPedido1.FieldName = "IdPedido";
            this.colIdPedido1.Name = "colIdPedido1";
            this.colIdPedido1.Visible = true;
            this.colIdPedido1.VisibleIndex = 1;
            // 
            // colClaveNombre1
            // 
            this.colClaveNombre1.FieldName = "ClaveNombre";
            this.colClaveNombre1.Name = "colClaveNombre1";
            // 
            // colFechaDeEmpaque1
            // 
            this.colFechaDeEmpaque1.AppearanceCell.Options.UseTextOptions = true;
            this.colFechaDeEmpaque1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaDeEmpaque1.AppearanceHeader.Options.UseTextOptions = true;
            this.colFechaDeEmpaque1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaDeEmpaque1.FieldName = "FechaDeEmpaque";
            this.colFechaDeEmpaque1.Name = "colFechaDeEmpaque1";
            this.colFechaDeEmpaque1.Visible = true;
            this.colFechaDeEmpaque1.VisibleIndex = 2;
            // 
            // colCantidad1
            // 
            this.colCantidad1.AppearanceCell.Options.UseTextOptions = true;
            this.colCantidad1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCantidad1.AppearanceHeader.Options.UseTextOptions = true;
            this.colCantidad1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCantidad1.FieldName = "Cantidad";
            this.colCantidad1.Name = "colCantidad1";
            this.colCantidad1.Visible = true;
            this.colCantidad1.VisibleIndex = 3;
            // 
            // colUnidad1
            // 
            this.colUnidad1.AppearanceCell.Options.UseTextOptions = true;
            this.colUnidad1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colUnidad1.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnidad1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colUnidad1.FieldName = "Unidad";
            this.colUnidad1.Name = "colUnidad1";
            this.colUnidad1.Visible = true;
            this.colUnidad1.VisibleIndex = 4;
            // 
            // FrmRecepciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.tbContainer);
            this.Controls.Add(this.btnConfigurar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRecepciones";
            this.Text = "Friolala S.A. de C.V.";
            this.Load += new System.EventHandler(this.FrmRecepciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.etiquetasGridBindingSource)).EndInit();
            this.tbContainer.ResumeLayout(false);
            this.tbEscaneo.ResumeLayout(false);
            this.grpEscaneados.ResumeLayout(false);
            this.grpEscaneados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCargando)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEtiquetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEtiquetas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRastreabilidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRastreabilidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.OpenFileDialog ofdEscaneo;
        private System.Windows.Forms.BindingSource etiquetasGridBindingSource;
        private System.ComponentModel.BackgroundWorker bgwConsulta;
        private System.ComponentModel.BackgroundWorker bgwConsultaFriolala;
        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.TabControl tbContainer;
        private System.Windows.Forms.TabPage tbEscaneo;
        private System.Windows.Forms.GroupBox grpEscaneados;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.PictureBox pbCargando;
        private System.Windows.Forms.Label lblTiempoFriolala;
        private System.Windows.Forms.TreeView tvTarimas;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lbltiempo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbRutaArchivoEscaneo;
        private System.Windows.Forms.Button btnBuscarArchivo;
        private DevExpress.XtraGrid.GridControl gridEtiquetas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEtiquetas;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroDeEtiqueta;
        private DevExpress.XtraGrid.Columns.GridColumn colClaveNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaDeEmpaque;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaDeCaducidad;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidad;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipoSalida;
        private System.Windows.Forms.TextBox txbFolioSalida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private DevExpress.XtraGrid.GridControl gridRastreabilidad;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRastreabilidad;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroDeEtiqueta1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPedido1;
        private DevExpress.XtraGrid.Columns.GridColumn colClaveNombre1;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaDeEmpaque1;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad1;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidad1;
        private System.Windows.Forms.DateTimePicker dtpFechaEmbarque;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbPropietario;
        private System.Windows.Forms.Label label7;
    }
}