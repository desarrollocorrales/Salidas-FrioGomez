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
            this.btnBorrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridEtiquetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etiquetasGridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEtiquetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCargando)).BeginInit();
            this.grpEscaneados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(934, 18);
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
            this.label1.Size = new System.Drawing.Size(934, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grupo Corrales";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.AutoSize = true;
            this.btnConsultar.Location = new System.Drawing.Point(824, 24);
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
            this.txbRutaArchivoEscaneo.Location = new System.Drawing.Point(154, 25);
            this.txbRutaArchivoEscaneo.Name = "txbRutaArchivoEscaneo";
            this.txbRutaArchivoEscaneo.Size = new System.Drawing.Size(618, 26);
            this.txbRutaArchivoEscaneo.TabIndex = 6;
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
            // gridEtiquetas
            // 
            this.gridEtiquetas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEtiquetas.DataSource = this.etiquetasGridBindingSource;
            this.gridEtiquetas.Location = new System.Drawing.Point(213, 57);
            this.gridEtiquetas.MainView = this.gvEtiquetas;
            this.gridEtiquetas.Name = "gridEtiquetas";
            this.gridEtiquetas.Size = new System.Drawing.Size(691, 352);
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
            this.colUnidad});
            this.gvEtiquetas.GridControl = this.gridEtiquetas;
            this.gvEtiquetas.GroupCount = 1;
            this.gvEtiquetas.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "NumeroDeEtiqueta", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cantidad", this.colCantidad, "")});
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
            this.btnImprimir.Image = global::SelectivasEnSucursales.Properties.Resources.printer2;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(412, 509);
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
            // btnBuscarArchivo
            // 
            this.btnBuscarArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarArchivo.AutoSize = true;
            this.btnBuscarArchivo.Location = new System.Drawing.Point(774, 24);
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
            this.pbCargando.Location = new System.Drawing.Point(383, 233);
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
            this.lbltiempo.Location = new System.Drawing.Point(6, 412);
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
            this.lblTiempoFriolala.Location = new System.Drawing.Point(6, 428);
            this.lblTiempoFriolala.Name = "lblTiempoFriolala";
            this.lblTiempoFriolala.Size = new System.Drawing.Size(140, 13);
            this.lblTiempoFriolala.TabIndex = 13;
            this.lblTiempoFriolala.Text = "Tiempo de consulta Friolala:";
            // 
            // tvTarimas
            // 
            this.tvTarimas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.tvTarimas.Location = new System.Drawing.Point(6, 57);
            this.tvTarimas.Name = "tvTarimas";
            this.tvTarimas.Size = new System.Drawing.Size(201, 352);
            this.tvTarimas.TabIndex = 15;
            this.tvTarimas.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvTarimas_AfterSelect);
            // 
            // grpEscaneados
            // 
            this.grpEscaneados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEscaneados.Controls.Add(this.btnBorrar);
            this.grpEscaneados.Controls.Add(this.lblTiempoFriolala);
            this.grpEscaneados.Controls.Add(this.tvTarimas);
            this.grpEscaneados.Controls.Add(this.btnConsultar);
            this.grpEscaneados.Controls.Add(this.lbltiempo);
            this.grpEscaneados.Controls.Add(this.label3);
            this.grpEscaneados.Controls.Add(this.txbRutaArchivoEscaneo);
            this.grpEscaneados.Controls.Add(this.btnBuscarArchivo);
            this.grpEscaneados.Controls.Add(this.gridEtiquetas);
            this.grpEscaneados.Location = new System.Drawing.Point(15, 59);
            this.grpEscaneados.Name = "grpEscaneados";
            this.grpEscaneados.Size = new System.Drawing.Size(910, 444);
            this.grpEscaneados.TabIndex = 16;
            this.grpEscaneados.TabStop = false;
            this.grpEscaneados.Text = "Escaneado";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrar.AutoSize = true;
            this.btnBorrar.Location = new System.Drawing.Point(826, 410);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(78, 28);
            this.btnBorrar.TabIndex = 16;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SelectivasEnSucursales.Properties.Resources.ios_settings_icon;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // FrmRecepciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbCargando);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpEscaneados);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRecepciones";
            this.Text = "Friolala S.A. de C.V.";
            ((System.ComponentModel.ISupportInitialize)(this.gridEtiquetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etiquetasGridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEtiquetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCargando)).EndInit();
            this.grpEscaneados.ResumeLayout(false);
            this.grpEscaneados.PerformLayout();
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
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}