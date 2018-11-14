namespace wAlertasCrypto
{
    partial class frmEstrategias
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEstrategia = new System.Windows.Forms.TabPage();
            this.grpEstrategia = new System.Windows.Forms.GroupBox();
            this.dtEstrategias = new System.Windows.Forms.DataGridView();
            this.CrytoMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Confirmar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabDistrib = new System.Windows.Forms.TabPage();
            this.gpRules = new System.Windows.Forms.GroupBox();
            this.dtRules = new System.Windows.Forms.DataGridView();
            this.Logo = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabEditor = new System.Windows.Forms.TabPage();
            this.tabRNACompra = new System.Windows.Forms.TabPage();
            this.picRDDCompra = new System.Windows.Forms.PictureBox();
            this.tabRNAVenta = new System.Windows.Forms.TabPage();
            this.picRDDVenta = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabEstrategia.SuspendLayout();
            this.grpEstrategia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEstrategias)).BeginInit();
            this.tabDistrib.SuspendLayout();
            this.gpRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtRules)).BeginInit();
            this.tabRNACompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRDDCompra)).BeginInit();
            this.tabRNAVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRDDVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(352, 693);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(84, 30);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(569, 693);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 30);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEstrategia);
            this.tabControl1.Controls.Add(this.tabDistrib);
            this.tabControl1.Controls.Add(this.tabEditor);
            this.tabControl1.Controls.Add(this.tabRNACompra);
            this.tabControl1.Controls.Add(this.tabRNAVenta);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1029, 651);
            this.tabControl1.TabIndex = 3;
            // 
            // tabEstrategia
            // 
            this.tabEstrategia.BackColor = System.Drawing.Color.DimGray;
            this.tabEstrategia.Controls.Add(this.grpEstrategia);
            this.tabEstrategia.Location = new System.Drawing.Point(4, 25);
            this.tabEstrategia.Name = "tabEstrategia";
            this.tabEstrategia.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstrategia.Size = new System.Drawing.Size(1021, 622);
            this.tabEstrategia.TabIndex = 0;
            this.tabEstrategia.Text = "Estrategia";
            // 
            // grpEstrategia
            // 
            this.grpEstrategia.Controls.Add(this.dtEstrategias);
            this.grpEstrategia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEstrategia.Location = new System.Drawing.Point(37, 35);
            this.grpEstrategia.Name = "grpEstrategia";
            this.grpEstrategia.Size = new System.Drawing.Size(505, 344);
            this.grpEstrategia.TabIndex = 1;
            this.grpEstrategia.TabStop = false;
            this.grpEstrategia.Text = "Estrategias";
            // 
            // dtEstrategias
            // 
            this.dtEstrategias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtEstrategias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CrytoMoneda,
            this.Confirmar});
            this.dtEstrategias.Location = new System.Drawing.Point(19, 27);
            this.dtEstrategias.Name = "dtEstrategias";
            this.dtEstrategias.RowTemplate.Height = 24;
            this.dtEstrategias.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dtEstrategias.Size = new System.Drawing.Size(459, 291);
            this.dtEstrategias.TabIndex = 32;
            // 
            // CrytoMoneda
            // 
            this.CrytoMoneda.HeaderText = "Estrategia";
            this.CrytoMoneda.Name = "CrytoMoneda";
            this.CrytoMoneda.Width = 150;
            // 
            // Confirmar
            // 
            this.Confirmar.HeaderText = "Confirmar";
            this.Confirmar.Name = "Confirmar";
            // 
            // tabDistrib
            // 
            this.tabDistrib.BackColor = System.Drawing.Color.DimGray;
            this.tabDistrib.Controls.Add(this.gpRules);
            this.tabDistrib.Location = new System.Drawing.Point(4, 25);
            this.tabDistrib.Name = "tabDistrib";
            this.tabDistrib.Size = new System.Drawing.Size(1021, 622);
            this.tabDistrib.TabIndex = 2;
            this.tabDistrib.Text = "Reglas de Distrib.";
            // 
            // gpRules
            // 
            this.gpRules.Controls.Add(this.dtRules);
            this.gpRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpRules.Location = new System.Drawing.Point(18, 19);
            this.gpRules.Name = "gpRules";
            this.gpRules.Size = new System.Drawing.Size(843, 585);
            this.gpRules.TabIndex = 34;
            this.gpRules.TabStop = false;
            this.gpRules.Text = "Distribución de Capital";
            // 
            // dtRules
            // 
            this.dtRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtRules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Logo,
            this.dataGridViewTextBoxColumn1,
            this.Porcentaje,
            this.Cantidad});
            this.dtRules.Location = new System.Drawing.Point(15, 26);
            this.dtRules.Name = "dtRules";
            this.dtRules.RowTemplate.Height = 24;
            this.dtRules.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtRules.Size = new System.Drawing.Size(680, 528);
            this.dtRules.TabIndex = 32;
            // 
            // Logo
            // 
            this.Logo.HeaderText = "Logo";
            this.Logo.Name = "Logo";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Moneda";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // Porcentaje
            // 
            this.Porcentaje.HeaderText = "Porcentaje";
            this.Porcentaje.Name = "Porcentaje";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // tabEditor
            // 
            this.tabEditor.Location = new System.Drawing.Point(4, 25);
            this.tabEditor.Name = "tabEditor";
            this.tabEditor.Size = new System.Drawing.Size(1021, 622);
            this.tabEditor.TabIndex = 3;
            this.tabEditor.Text = "Editor";
            this.tabEditor.UseVisualStyleBackColor = true;
            // 
            // tabRNACompra
            // 
            this.tabRNACompra.BackColor = System.Drawing.Color.Black;
            this.tabRNACompra.Controls.Add(this.picRDDCompra);
            this.tabRNACompra.Location = new System.Drawing.Point(4, 25);
            this.tabRNACompra.Name = "tabRNACompra";
            this.tabRNACompra.Size = new System.Drawing.Size(1021, 622);
            this.tabRNACompra.TabIndex = 5;
            this.tabRNACompra.Text = "RNA Compra";
            // 
            // picRDDCompra
            // 
            this.picRDDCompra.ImageLocation = "D:\\robot\\++Desarrollos\\Bot\\wAlertasCrypto\\wAlertasCrypto\\bin\\Debug\\resources\\RDD3" +
    "_compra.png";
            this.picRDDCompra.Location = new System.Drawing.Point(36, -2);
            this.picRDDCompra.Name = "picRDDCompra";
            this.picRDDCompra.Size = new System.Drawing.Size(948, 627);
            this.picRDDCompra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRDDCompra.TabIndex = 1;
            this.picRDDCompra.TabStop = false;
            // 
            // tabRNAVenta
            // 
            this.tabRNAVenta.BackColor = System.Drawing.Color.Black;
            this.tabRNAVenta.Controls.Add(this.picRDDVenta);
            this.tabRNAVenta.Location = new System.Drawing.Point(4, 25);
            this.tabRNAVenta.Name = "tabRNAVenta";
            this.tabRNAVenta.Size = new System.Drawing.Size(1021, 622);
            this.tabRNAVenta.TabIndex = 4;
            this.tabRNAVenta.Text = "RNA Venta";
            // 
            // picRDDVenta
            // 
            this.picRDDVenta.ImageLocation = "D:\\robot\\++Desarrollos\\Bot\\wAlertasCrypto\\wAlertasCrypto\\bin\\Debug\\resources\\RDD3" +
    "_venta.png";
            this.picRDDVenta.Location = new System.Drawing.Point(35, -2);
            this.picRDDVenta.Name = "picRDDVenta";
            this.picRDDVenta.Size = new System.Drawing.Size(950, 627);
            this.picRDDVenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRDDVenta.TabIndex = 2;
            this.picRDDVenta.TabStop = false;
            // 
            // frmEstrategias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1055, 735);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "frmEstrategias";
            this.Text = "Despliegues de Estrategias";
            this.Load += new System.EventHandler(this.frmEstrategias_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabEstrategia.ResumeLayout(false);
            this.grpEstrategia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtEstrategias)).EndInit();
            this.tabDistrib.ResumeLayout(false);
            this.gpRules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtRules)).EndInit();
            this.tabRNACompra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRDDCompra)).EndInit();
            this.tabRNAVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRDDVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEstrategia;
        private System.Windows.Forms.TabPage tabDistrib;
        private System.Windows.Forms.TabPage tabEditor;
        private System.Windows.Forms.TabPage tabRNAVenta;
        private System.Windows.Forms.TabPage tabRNACompra;
        private System.Windows.Forms.GroupBox grpEstrategia;
        private System.Windows.Forms.DataGridView dtEstrategias;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrytoMoneda;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Confirmar;
        private System.Windows.Forms.PictureBox picRDDCompra;
        private System.Windows.Forms.PictureBox picRDDVenta;
        private System.Windows.Forms.GroupBox gpRules;
        private System.Windows.Forms.DataGridView dtRules;
        private System.Windows.Forms.DataGridViewImageColumn Logo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}