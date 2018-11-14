namespace wAlertasCrypto
{
    partial class frmDistribRules
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
            this.dtRules = new System.Windows.Forms.DataGridView();
            this.Logo = new System.Windows.Forms.DataGridViewImageColumn();
            this.CrytoMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpRules = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtRules)).BeginInit();
            this.gpRules.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtRules
            // 
            this.dtRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtRules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Logo,
            this.CrytoMoneda,
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
            // CrytoMoneda
            // 
            this.CrytoMoneda.HeaderText = "Moneda";
            this.CrytoMoneda.Name = "CrytoMoneda";
            this.CrytoMoneda.Width = 150;
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
            // gpRules
            // 
            this.gpRules.Controls.Add(this.dtRules);
            this.gpRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpRules.Location = new System.Drawing.Point(21, 26);
            this.gpRules.Name = "gpRules";
            this.gpRules.Size = new System.Drawing.Size(701, 585);
            this.gpRules.TabIndex = 33;
            this.gpRules.TabStop = false;
            this.gpRules.Text = "Distribución de Capital";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(238, 620);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 40);
            this.btnAceptar.TabIndex = 34;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(414, 620);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 40);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmDistribRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(734, 672);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gpRules);
            this.Name = "frmDistribRules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reglas de Distribución";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dtRules)).EndInit();
            this.gpRules.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtRules;
        private System.Windows.Forms.DataGridViewImageColumn Logo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrytoMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.GroupBox gpRules;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}