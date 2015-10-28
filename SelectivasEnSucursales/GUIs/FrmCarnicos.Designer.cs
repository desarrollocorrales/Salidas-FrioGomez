namespace SelectivasEnSucursales.GUIs
{
    partial class FrmCarnicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCarnicos));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txbRutaArchivoEscaneo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gridEtiquetas = new DevExpress.XtraGrid.GridControl();
            this.etiquetasGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvEtiquetas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumeroDeEtiqueta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClaveNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaDeEmpaque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaDeCaducidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.ofdEscaneo = new System.Windows.Forms.OpenFileDialog();
            this.btnBuscarArchivo = new System.Windows.Forms.Button();
            this.bgwConsulta = new System.ComponentModel.BackgroundWorker();
            this.pbCargando = new System.Windows.Forms.PictureBox();
            this.lbltiempo = new System.Windows.Forms.Label();
            this.bgwConsultaFriolala = new System.ComponentModel.BackgroundWorker();
            this.lblTiempoFriolala = new System.Windows.Forms.Label();
            this.tvTarimas = new System.Windows.Forms.TreeView();
            this.grpEscaneados = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbCliente = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.grpAgregados = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAgregarAlGrid = new System.Windows.Forms.Button();
            this.txbPeso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbArticulosExtras = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridEtiquetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etiquetasGridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEtiquetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCargando)).BeginInit();
            this.grpEscaneados.SuspendLayout();
            this.grpAgregados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salida de Mercancía";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grupo Corrales";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.AutoSize = true;
            this.btnConsultar.Location = new System.Drawing.Point(826, 57);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(78, 28);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txbRutaArchivoEscaneo
            // 
            this.txbRutaArchivoEscaneo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbRutaArchivoEscaneo.BackColor = System.Drawing.Color.White;
            this.txbRutaArchivoEscaneo.Enabled = false;
            this.txbRutaArchivoEscaneo.Location = new System.Drawing.Point(152, 57);
            this.txbRutaArchivoEscaneo.Name = "txbRutaArchivoEscaneo";
            this.txbRutaArchivoEscaneo.Size = new System.Drawing.Size(618, 26);
            this.txbRutaArchivoEscaneo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Archivo de escaneo:";
            // 
            // gridEtiquetas
            // 
            this.gridEtiquetas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEtiquetas.DataSource = this.etiquetasGridBindingSource;
            this.gridEtiquetas.Location = new System.Drawing.Point(213, 91);
            this.gridEtiquetas.MainView = this.gvEtiquetas;
            this.gridEtiquetas.Name = "gridEtiquetas";
            this.gridEtiquetas.Size = new System.Drawing.Size(691, 292);
            this.gridEtiquetas.TabIndex = 8;
            this.gridEtiquetas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEtiquetas});
            // 
            // etiquetasGridBindingSource
            // 
            this.etiquetasGridBindingSource.DataSource = typeof(SelectivasEnSucursales.SegConService.EtiquetasGrid);
            // 
            // gvEtiquetas
            // 
            this.gvEtiquetas.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvEtiquetas.Appearance.FooterPanel.Options.UseFont = true;
            this.gvEtiquetas.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvEtiquetas.Appearance.GroupFooter.Options.UseFont = true;
            this.gvEtiquetas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumeroDeEtiqueta,
            this.colClaveNombre,
            this.colFechaDeEmpaque,
            this.colFechaDeCaducidad,
            this.colCantidad,
            this.colUnidad});
            this.gvEtiquetas.GridControl = this.gridEtiquetas;
            this.gvEtiquetas.GroupCount = 1;
            this.gvEtiquetas.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "NumeroDeEtiqueta", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cantidad", this.colCantidad, "")});
            this.gvEtiquetas.Name = "gvEtiquetas";
            this.gvEtiquetas.OptionsBehavior.Editable = false;
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
            this.colClaveNombre.Visible = true;
            this.colClaveNombre.VisibleIndex = 1;
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
            this.colFechaDeEmpaque.VisibleIndex = 1;
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
            this.colFechaDeCaducidad.VisibleIndex = 2;
            // 
            // colCantidad
            // 
            this.colCantidad.AppearanceHeader.Options.UseTextOptions = true;
            this.colCantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 3;
            // 
            // colUnidad
            // 
            this.colUnidad.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colUnidad.FieldName = "Unidad";
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.Visible = true;
            this.colUnidad.VisibleIndex = 4;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImprimir.Location = new System.Drawing.Point(430, 622);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 28);
            this.btnImprimir.TabIndex = 9;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // ofdEscaneo
            // 
            this.ofdEscaneo.FileName = "*.txt";
            this.ofdEscaneo.Filter = "Archivos de Texto | *.txt";
            // 
            // btnBuscarArchivo
            // 
            this.btnBuscarArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarArchivo.AutoSize = true;
            this.btnBuscarArchivo.Location = new System.Drawing.Point(776, 57);
            this.btnBuscarArchivo.Name = "btnBuscarArchivo";
            this.btnBuscarArchivo.Size = new System.Drawing.Size(44, 28);
            this.btnBuscarArchivo.TabIndex = 10;
            this.btnBuscarArchivo.Text = "...";
            this.btnBuscarArchivo.UseVisualStyleBackColor = true;
            this.btnBuscarArchivo.Click += new System.EventHandler(this.btnBuscarArchivo_Click);
            // 
            // bgwConsulta
            // 
            this.bgwConsulta.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwConsulta_DoWork);
            this.bgwConsulta.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwConsulta_RunWorkerCompleted);
            // 
            // pbCargando
            // 
            this.pbCargando.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbCargando.Image = global::SelectivasEnSucursales.Properties.Resources.cargando;
            this.pbCargando.Location = new System.Drawing.Point(383, 284);
            this.pbCargando.Name = "pbCargando";
            this.pbCargando.Size = new System.Drawing.Size(169, 94);
            this.pbCargando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCargando.TabIndex = 11;
            this.pbCargando.TabStop = false;
            this.pbCargando.Visible = false;
            // 
            // lbltiempo
            // 
            this.lbltiempo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbltiempo.AutoSize = true;
            this.lbltiempo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltiempo.Location = new System.Drawing.Point(6, 386);
            this.lbltiempo.Name = "lbltiempo";
            this.lbltiempo.Size = new System.Drawing.Size(127, 13);
            this.lbltiempo.TabIndex = 12;
            this.lbltiempo.Text = "Tiempo de consulta ACC:";
            // 
            // bgwConsultaFriolala
            // 
            this.bgwConsultaFriolala.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwConsultaFriolala_DoWork);
            this.bgwConsultaFriolala.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwConsultaFriolala_RunWorkerCompleted);
            // 
            // lblTiempoFriolala
            // 
            this.lblTiempoFriolala.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTiempoFriolala.AutoSize = true;
            this.lblTiempoFriolala.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoFriolala.Location = new System.Drawing.Point(6, 402);
            this.lblTiempoFriolala.Name = "lblTiempoFriolala";
            this.lblTiempoFriolala.Size = new System.Drawing.Size(140, 13);
            this.lblTiempoFriolala.TabIndex = 13;
            this.lblTiempoFriolala.Text = "Tiempo de consulta Friolala:";
            // 
            // tvTarimas
            // 
            this.tvTarimas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvTarimas.Location = new System.Drawing.Point(6, 91);
            this.tvTarimas.Name = "tvTarimas";
            this.tvTarimas.Size = new System.Drawing.Size(201, 292);
            this.tvTarimas.TabIndex = 15;
            this.tvTarimas.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvTarimas_AfterSelect);
            // 
            // grpEscaneados
            // 
            this.grpEscaneados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEscaneados.Controls.Add(this.label9);
            this.grpEscaneados.Controls.Add(this.txbCliente);
            this.grpEscaneados.Controls.Add(this.btnBorrar);
            this.grpEscaneados.Controls.Add(this.lblTiempoFriolala);
            this.grpEscaneados.Controls.Add(this.tvTarimas);
            this.grpEscaneados.Controls.Add(this.btnConsultar);
            this.grpEscaneados.Controls.Add(this.lbltiempo);
            this.grpEscaneados.Controls.Add(this.label3);
            this.grpEscaneados.Controls.Add(this.txbRutaArchivoEscaneo);
            this.grpEscaneados.Controls.Add(this.btnBuscarArchivo);
            this.grpEscaneados.Controls.Add(this.gridEtiquetas);
            this.grpEscaneados.Location = new System.Drawing.Point(15, 66);
            this.grpEscaneados.Name = "grpEscaneados";
            this.grpEscaneados.Size = new System.Drawing.Size(910, 418);
            this.grpEscaneados.TabIndex = 16;
            this.grpEscaneados.TabStop = false;
            this.grpEscaneados.Text = "Escaneado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(91, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Cliente:";
            // 
            // txbCliente
            // 
            this.txbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCliente.BackColor = System.Drawing.Color.White;
            this.txbCliente.Location = new System.Drawing.Point(152, 25);
            this.txbCliente.Name = "txbCliente";
            this.txbCliente.Size = new System.Drawing.Size(618, 26);
            this.txbCliente.TabIndex = 18;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrar.AutoSize = true;
            this.btnBorrar.Location = new System.Drawing.Point(826, 384);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(78, 28);
            this.btnBorrar.TabIndex = 16;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // grpAgregados
            // 
            this.grpAgregados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAgregados.Controls.Add(this.btnAgregar);
            this.grpAgregados.Controls.Add(this.label8);
            this.grpAgregados.Controls.Add(this.btnAgregarAlGrid);
            this.grpAgregados.Controls.Add(this.txbPeso);
            this.grpAgregados.Controls.Add(this.label7);
            this.grpAgregados.Controls.Add(this.label6);
            this.grpAgregados.Controls.Add(this.txbCantidad);
            this.grpAgregados.Controls.Add(this.label5);
            this.grpAgregados.Controls.Add(this.label4);
            this.grpAgregados.Controls.Add(this.cbArticulosExtras);
            this.grpAgregados.Location = new System.Drawing.Point(21, 490);
            this.grpAgregados.Name = "grpAgregados";
            this.grpAgregados.Size = new System.Drawing.Size(898, 126);
            this.grpAgregados.TabIndex = 17;
            this.grpAgregados.TabStop = false;
            this.grpAgregados.Text = "Agregados";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(762, 25);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(36, 26);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(627, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "Kg";
            // 
            // btnAgregarAlGrid
            // 
            this.btnAgregarAlGrid.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregarAlGrid.Location = new System.Drawing.Point(409, 92);
            this.btnAgregarAlGrid.Name = "btnAgregarAlGrid";
            this.btnAgregarAlGrid.Size = new System.Drawing.Size(75, 28);
            this.btnAgregarAlGrid.TabIndex = 10;
            this.btnAgregarAlGrid.Text = "Agregar";
            this.btnAgregarAlGrid.UseVisualStyleBackColor = true;
            this.btnAgregarAlGrid.Click += new System.EventHandler(this.btnAgregarAlGrid_Click);
            // 
            // txbPeso
            // 
            this.txbPeso.Location = new System.Drawing.Point(521, 62);
            this.txbPeso.Name = "txbPeso";
            this.txbPeso.Size = new System.Drawing.Size(100, 26);
            this.txbPeso.TabIndex = 7;
            this.txbPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPeso_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Peso por pieza:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Piezas";
            // 
            // txbCantidad
            // 
            this.txbCantidad.Location = new System.Drawing.Point(214, 62);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(100, 26);
            this.txbCantidad.TabIndex = 4;
            this.txbCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCantidad_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Artículo:";
            // 
            // cbArticulosExtras
            // 
            this.cbArticulosExtras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbArticulosExtras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArticulosExtras.FormattingEnabled = true;
            this.cbArticulosExtras.Location = new System.Drawing.Point(214, 25);
            this.cbArticulosExtras.Name = "cbArticulosExtras";
            this.cbArticulosExtras.Size = new System.Drawing.Size(542, 26);
            this.cbArticulosExtras.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SelectivasEnSucursales.Properties.Resources.ios_settings_icon;
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // FrmCarnicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 662);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpAgregados);
            this.Controls.Add(this.pbCargando);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpEscaneados);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCarnicos";
            this.Text = "Selectivas de Carnicos";
            this.Load += new System.EventHandler(this.FrmCarnicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEtiquetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etiquetasGridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEtiquetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCargando)).EndInit();
            this.grpEscaneados.ResumeLayout(false);
            this.grpEscaneados.PerformLayout();
            this.grpAgregados.ResumeLayout(false);
            this.grpAgregados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txbRutaArchivoEscaneo;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl gridEtiquetas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEtiquetas;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.OpenFileDialog ofdEscaneo;
        private System.Windows.Forms.Button btnBuscarArchivo;
        private System.Windows.Forms.BindingSource etiquetasGridBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroDeEtiqueta;
        private DevExpress.XtraGrid.Columns.GridColumn colClaveNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaDeEmpaque;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaDeCaducidad;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidad;
        private System.ComponentModel.BackgroundWorker bgwConsulta;
        private System.Windows.Forms.PictureBox pbCargando;
        private System.Windows.Forms.Label lbltiempo;
        private System.ComponentModel.BackgroundWorker bgwConsultaFriolala;
        private System.Windows.Forms.Label lblTiempoFriolala;
        private System.Windows.Forms.TreeView tvTarimas;
        private System.Windows.Forms.GroupBox grpEscaneados;
        private System.Windows.Forms.GroupBox grpAgregados;
        private System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbArticulosExtras;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregarAlGrid;
        private System.Windows.Forms.TextBox txbPeso;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}