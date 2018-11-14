using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wAlertasCrypto
{
    public partial class frmEstrategias : Form
    {
        public frmEstrategias()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            sumidero.estrategiaActiva = "Estrategia en corto";

        }

        private void frmEstrategias_Load(object sender, EventArgs e)
        {
            string line;
            string ruta = Application.StartupPath;
            string path = ruta + @"\config\RNA_compra.txt";
            System.IO.StreamReader file = new System.IO.StreamReader(ruta + @"\config\RNA_compra.txt");
            while ((line = file.ReadLine()) != null)
            {

            }
            //string createText = "m1_com," + txtm1_com.Text + "\n" + "m5_com," + txtm5_com.Text + "\n" + "m15_com," + txtm15_com.Text + "\n" + "m30_com," + txtm30_com.Text + "\n" + "SAR_com," + txtSAR_com.Text + "\n" + "MACD_com," + txtMACD_com.Text + "\n" + "RSI_com," + txtRSI_com.Text + "\n" + "EMA_com," + txtEMA_com.Text;
           // File.WriteAllText(path, createText);

            dtEstrategias.Rows.Add("En Corto (técnico)", false);
            dtEstrategias.Rows.Add("Red Neuronal ", false);
            dtEstrategias.Rows.Add("Velas Envolventes", false);
        }
    }
}
