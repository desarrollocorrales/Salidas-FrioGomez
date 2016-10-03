namespace SelectivasEnSucursales.GUIs
{
    partial class FrmConfiguracionCarnicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguracionCarnicos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.webPreview = new System.Windows.Forms.WebBrowser();
            this.txbUrl = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Guardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbUrlFriolala = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCargarFriolala = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpWebServices = new System.Windows.Forms.TabPage();
            this.tpBaseDeDatos = new System.Windows.Forms.TabPage();
            this.btnGuardarDb = new System.Windows.Forms.Button();
            this.btnCargarDb = new System.Windows.Forms.Button();
            this.cmbDB = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbPortDb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbPassDb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbUserDb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbServidorDb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpWebServices.SuspendLayout();
            this.tpBaseDeDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.webPreview);
            this.panel1.Location = new System.Drawing.Point(7, 124);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 346);
            this.panel1.TabIndex = 0;
            // 
            // webPreview
            // 
            this.webPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.webPreview.Location = new System.Drawing.Point(3, 4);
            this.webPreview.Margin = new System.Windows.Forms.Padding(4);
            this.webPreview.MinimumSize = new System.Drawing.Size(27, 28);
            this.webPreview.Name = "webPreview";
            this.webPreview.Size = new System.Drawing.Size(881, 338);
            this.webPreview.TabIndex = 0;
            // 
            // txbUrl
            // 
            this.txbUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbUrl.Location = new System.Drawing.Point(7, 25);
            this.txbUrl.Margin = new System.Windows.Forms.Padding(4);
            this.txbUrl.Name = "txbUrl";
            this.txbUrl.Size = new System.Drawing.Size(810, 26);
            this.txbUrl.TabIndex = 1;
            this.txbUrl.Text = "http://";
            // 
            // btnCargar
            // 
            this.btnCargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargar.AutoSize = true;
            this.btnCargar.Location = new System.Drawing.Point(825, 24);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(70, 28);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Selectivas de Almacén - Cárnicos";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Carnicerias Los Corrales";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "URL del Web Service Abastecedora:";
            // 
            // Guardar
            // 
            this.Guardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Guardar.AutoSize = true;
            this.Guardar.Location = new System.Drawing.Point(406, 478);
            this.Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(70, 28);
            this.Guardar.TabIndex = 7;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nota: la URL deberá ser como la siguiente: \"http://servidor:85\"";
            // 
            // txbUrlFriolala
            // 
            this.txbUrlFriolala.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbUrlFriolala.Location = new System.Drawing.Point(7, 77);
            this.txbUrlFriolala.Margin = new System.Windows.Forms.Padding(4);
            this.txbUrlFriolala.Name = "txbUrlFriolala";
            this.txbUrlFriolala.Size = new System.Drawing.Size(810, 26);
            this.txbUrlFriolala.TabIndex = 9;
            this.txbUrlFriolala.Text = "http://";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "URL del Web Service Friolala:";
            // 
            // btnCargarFriolala
            // 
            this.btnCargarFriolala.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargarFriolala.AutoSize = true;
            this.btnCargarFriolala.Location = new System.Drawing.Point(825, 76);
            this.btnCargarFriolala.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargarFriolala.Name = "btnCargarFriolala";
            this.btnCargarFriolala.Size = new System.Drawing.Size(70, 28);
            this.btnCargarFriolala.TabIndex = 11;
            this.btnCargarFriolala.Text = "Cargar";
            this.btnCargarFriolala.UseVisualStyleBackColor = true;
            this.btnCargarFriolala.Click += new System.EventHandler(this.btnCargarFriolala_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpWebServices);
            this.tabControl1.Controls.Add(this.tpBaseDeDatos);
            this.tabControl1.Location = new System.Drawing.Point(12, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(910, 544);
            this.tabControl1.TabIndex = 12;
            // 
            // tpWebServices
            // 
            this.tpWebServices.Controls.Add(this.Guardar);
            this.tpWebServices.Controls.Add(this.btnCargarFriolala);
            this.tpWebServices.Controls.Add(this.panel1);
            this.tpWebServices.Controls.Add(this.label3);
            this.tpWebServices.Controls.Add(this.txbUrl);
            this.tpWebServices.Controls.Add(this.label5);
            this.tpWebServices.Controls.Add(this.label4);
            this.tpWebServices.Controls.Add(this.txbUrlFriolala);
            this.tpWebServices.Controls.Add(this.btnCargar);
            this.tpWebServices.Location = new System.Drawing.Point(4, 27);
            this.tpWebServices.Name = "tpWebServices";
            this.tpWebServices.Padding = new System.Windows.Forms.Padding(3);
            this.tpWebServices.Size = new System.Drawing.Size(902, 513);
            this.tpWebServices.TabIndex = 0;
            this.tpWebServices.Text = "Servicios Web";
            this.tpWebServices.UseVisualStyleBackColor = true;
            // 
            // tpBaseDeDatos
            // 
            this.tpBaseDeDatos.Controls.Add(this.btnGuardarDb);
            this.tpBaseDeDatos.Controls.Add(this.btnCargarDb);
            this.tpBaseDeDatos.Controls.Add(this.cmbDB);
            this.tpBaseDeDatos.Controls.Add(this.label10);
            this.tpBaseDeDatos.Controls.Add(this.txbPortDb);
            this.tpBaseDeDatos.Controls.Add(this.label9);
            this.tpBaseDeDatos.Controls.Add(this.txbPassDb);
            this.tpBaseDeDatos.Controls.Add(this.label8);
            this.tpBaseDeDatos.Controls.Add(this.txbUserDb);
            this.tpBaseDeDatos.Controls.Add(this.label7);
            this.tpBaseDeDatos.Controls.Add(this.txbServidorDb);
            this.tpBaseDeDatos.Controls.Add(this.label6);
            this.tpBaseDeDatos.Location = new System.Drawing.Point(4, 27);
            this.tpBaseDeDatos.Name = "tpBaseDeDatos";
            this.tpBaseDeDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tpBaseDeDatos.Size = new System.Drawing.Size(902, 513);
            this.tpBaseDeDatos.TabIndex = 1;
            this.tpBaseDeDatos.Text = "Base de datos";
            this.tpBaseDeDatos.UseVisualStyleBackColor = true;
            // 
            // btnGuardarDb
            // 
            this.btnGuardarDb.Location = new System.Drawing.Point(406, 276);
            this.btnGuardarDb.Name = "btnGuardarDb";
            this.btnGuardarDb.Size = new System.Drawing.Size(90, 30);
            this.btnGuardarDb.TabIndex = 11;
            this.btnGuardarDb.Text = "Guardar";
            this.btnGuardarDb.UseVisualStyleBackColor = true;
            this.btnGuardarDb.Click += new System.EventHandler(this.btnGuardarDb_Click);
            // 
            // btnCargarDb
            // 
            this.btnCargarDb.Location = new System.Drawing.Point(642, 237);
            this.btnCargarDb.Name = "btnCargarDb";
            this.btnCargarDb.Size = new System.Drawing.Size(75, 30);
            this.btnCargarDb.TabIndex = 10;
            this.btnCargarDb.Text = "Cargar";
            this.btnCargarDb.UseVisualStyleBackColor = true;
            this.btnCargarDb.Click += new System.EventHandler(this.btnCargarDb_Click);
            // 
            // cmbDB
            // 
            this.cmbDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDB.FormattingEnabled = true;
            this.cmbDB.Location = new System.Drawing.Point(188, 239);
            this.cmbDB.Name = "cmbDB";
            this.cmbDB.Size = new System.Drawing.Size(448, 26);
            this.cmbDB.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(185, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 18);
            this.label10.TabIndex = 8;
            this.label10.Text = "Base de datos:";
            // 
            // txbPortDb
            // 
            this.txbPortDb.Location = new System.Drawing.Point(188, 189);
            this.txbPortDb.Name = "txbPortDb";
            this.txbPortDb.Size = new System.Drawing.Size(100, 26);
            this.txbPortDb.TabIndex = 7;
            this.txbPortDb.Text = "3306";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(185, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Puerto:";
            // 
            // txbPassDb
            // 
            this.txbPassDb.Location = new System.Drawing.Point(188, 139);
            this.txbPassDb.Name = "txbPassDb";
            this.txbPassDb.PasswordChar = '*';
            this.txbPassDb.Size = new System.Drawing.Size(223, 26);
            this.txbPassDb.TabIndex = 5;
            this.txbPassDb.Text = "friolala";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Contraseña:";
            // 
            // txbUserDb
            // 
            this.txbUserDb.Location = new System.Drawing.Point(188, 89);
            this.txbUserDb.Name = "txbUserDb";
            this.txbUserDb.Size = new System.Drawing.Size(223, 26);
            this.txbUserDb.TabIndex = 3;
            this.txbUserDb.Text = "etiquetas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Usuario:";
            // 
            // txbServidorDb
            // 
            this.txbServidorDb.Location = new System.Drawing.Point(188, 39);
            this.txbServidorDb.Name = "txbServidorDb";
            this.txbServidorDb.Size = new System.Drawing.Size(448, 26);
            this.txbServidorDb.TabIndex = 1;
            this.txbServidorDb.Text = "Servidor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Servidor:";
            // 
            // FrmConfiguracionCarnicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmConfiguracionCarnicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuración Cárnicos";
            this.Load += new System.EventHandler(this.FrmConfiguracionCarnicos_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpWebServices.ResumeLayout(false);
            this.tpWebServices.PerformLayout();
            this.tpBaseDeDatos.ResumeLayout(false);
            this.tpBaseDeDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webPreview;
        private System.Windows.Forms.TextBox txbUrl;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbUrlFriolala;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCargarFriolala;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpWebServices;
        private System.Windows.Forms.TabPage tpBaseDeDatos;
        private System.Windows.Forms.Button btnGuardarDb;
        private System.Windows.Forms.Button btnCargarDb;
        private System.Windows.Forms.ComboBox cmbDB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbPortDb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbPassDb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbUserDb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbServidorDb;
        private System.Windows.Forms.Label label6;
    }
}