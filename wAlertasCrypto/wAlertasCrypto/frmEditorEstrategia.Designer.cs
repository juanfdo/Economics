namespace wAlertasCrypto
{
    partial class frmEditorEstrategia
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
            this.gpVela1 = new System.Windows.Forms.GroupBox();
            this.txtLow = new System.Windows.Forms.TextBox();
            this.txtHigh = new System.Windows.Forms.TextBox();
            this.txtClose = new System.Windows.Forms.TextBox();
            this.txtOpen = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLow = new System.Windows.Forms.Label();
            this.lblHigh = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Label();
            this.lblOpen = new System.Windows.Forms.Label();
            this.gpResultado = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.gpVela1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpVela1
            // 
            this.gpVela1.Controls.Add(this.numericUpDown1);
            this.gpVela1.Controls.Add(this.txtLow);
            this.gpVela1.Controls.Add(this.txtHigh);
            this.gpVela1.Controls.Add(this.txtClose);
            this.gpVela1.Controls.Add(this.txtOpen);
            this.gpVela1.Controls.Add(this.pictureBox1);
            this.gpVela1.Controls.Add(this.lblLow);
            this.gpVela1.Controls.Add(this.lblHigh);
            this.gpVela1.Controls.Add(this.Close);
            this.gpVela1.Controls.Add(this.lblOpen);
            this.gpVela1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpVela1.Location = new System.Drawing.Point(16, 36);
            this.gpVela1.Name = "gpVela1";
            this.gpVela1.Size = new System.Drawing.Size(659, 89);
            this.gpVela1.TabIndex = 0;
            this.gpVela1.TabStop = false;
            this.gpVela1.Text = "Descripcion Vela 1";
            this.gpVela1.Enter += new System.EventHandler(this.gpVela1_Enter);
            // 
            // txtLow
            // 
            this.txtLow.Location = new System.Drawing.Point(208, 47);
            this.txtLow.Name = "txtLow";
            this.txtLow.Size = new System.Drawing.Size(47, 28);
            this.txtLow.TabIndex = 9;
            // 
            // txtHigh
            // 
            this.txtHigh.Location = new System.Drawing.Point(145, 47);
            this.txtHigh.Name = "txtHigh";
            this.txtHigh.Size = new System.Drawing.Size(47, 28);
            this.txtHigh.TabIndex = 8;
            // 
            // txtClose
            // 
            this.txtClose.Location = new System.Drawing.Point(82, 47);
            this.txtClose.Name = "txtClose";
            this.txtClose.Size = new System.Drawing.Size(47, 28);
            this.txtClose.TabIndex = 7;
            // 
            // txtOpen
            // 
            this.txtOpen.Location = new System.Drawing.Point(19, 47);
            this.txtOpen.Name = "txtOpen";
            this.txtOpen.Size = new System.Drawing.Size(47, 28);
            this.txtOpen.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Lime;
            this.pictureBox1.Location = new System.Drawing.Point(274, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 32);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblLow
            // 
            this.lblLow.AutoSize = true;
            this.lblLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLow.Location = new System.Drawing.Point(209, 24);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(40, 20);
            this.lblLow.TabIndex = 3;
            this.lblLow.Text = "Low";
            // 
            // lblHigh
            // 
            this.lblHigh.AutoSize = true;
            this.lblHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHigh.Location = new System.Drawing.Point(148, 24);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(44, 20);
            this.lblHigh.TabIndex = 2;
            this.lblHigh.Text = "High";
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(79, 24);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(52, 20);
            this.Close.TabIndex = 1;
            this.Close.Text = "Close";
            // 
            // lblOpen
            // 
            this.lblOpen.AutoSize = true;
            this.lblOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpen.Location = new System.Drawing.Point(17, 24);
            this.lblOpen.Name = "lblOpen";
            this.lblOpen.Size = new System.Drawing.Size(49, 20);
            this.lblOpen.TabIndex = 0;
            this.lblOpen.Text = "Open";
            // 
            // gpResultado
            // 
            this.gpResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpResultado.Location = new System.Drawing.Point(16, 620);
            this.gpResultado.Name = "gpResultado";
            this.gpResultado.Size = new System.Drawing.Size(659, 89);
            this.gpResultado.TabIndex = 1;
            this.gpResultado.TabStop = false;
            this.gpResultado.Text = "Visual Aproximada";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(687, 28);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(357, 47);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(59, 28);
            this.numericUpDown1.TabIndex = 10;
            // 
            // frmEditorEstrategia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 721);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gpResultado);
            this.Controls.Add(this.gpVela1);
            this.Name = "frmEditorEstrategia";
            this.Text = "Editor de Estrategias - Velas Japonesas";
            this.gpVela1.ResumeLayout(false);
            this.gpVela1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpVela1;
        private System.Windows.Forms.GroupBox gpResultado;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Label lblOpen;
        private System.Windows.Forms.TextBox txtLow;
        private System.Windows.Forms.TextBox txtHigh;
        private System.Windows.Forms.TextBox txtClose;
        private System.Windows.Forms.TextBox txtOpen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}