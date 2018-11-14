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
    public partial class frmNeuralNet : Form
    {
        public frmNeuralNet()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Guardar configuración para Compra
            string ruta = Application.StartupPath;
            string path = ruta + @"\config\RNA_compra.txt";
            try
            {
                //VALIDAR VALORES EN CERO!!!
                txtMACD_com.Text.Trim();
                if (txtMACD_com.Text == "")
                {
                    txtMACD_com.Text = "0";
                }
                txtRSI_com.Text.Trim();
                if (txtRSI_com.Text == "")
                {
                    txtRSI_com.Text = "0";
                }
                txtSAR_com.Text.Trim();
                if (txtSAR_com.Text == "")
                {
                    txtSAR_com.Text = "0";
                }
                txtEMA_com.Text.Trim();
                if (txtEMA_com.Text == "")
                {
                    txtEMA_com.Text = "0";
                }
                txtm1_com.Text.Trim();
                if (txtm1_com.Text == "")
                {
                    txtm1_com.Text = "0";
                }
                txtm5_com.Text.Trim();
                if (txtm5_com.Text == "")
                {
                    txtm5_com.Text = "0";
                }
                txtm15_com.Text.Trim();
                if (txtm15_com.Text == "")
                {
                    txtm15_com.Text = "0";
                }
                txtm30_com.Text.Trim();
                if (txtm30_com.Text == "")
                {
                    txtm30_com.Text = "0";
                }
                
                // This text is added only once to the file.
                //if (!File.Exists(path))
                //{
                // Create a file to write to.
                string createText = "m1_com," + txtm1_com.Text + "\n" + "m5_com," + txtm5_com.Text + "\n" +"m15_com,"+ txtm15_com.Text + "\n" +"m30_com," + txtm30_com.Text + "\n" + "SAR_com," + txtSAR_com.Text + "\n" + "MACD_com," + txtMACD_com.Text + "\n" + "RSI_com," + txtRSI_com.Text + "\n" + "EMA_com," + txtEMA_com.Text;
                File.WriteAllText(path, createText);
                //}

                //Application.DoEvents();
                // Encrypt the file.
                // AddEncryption(ruta + @"\keys.txt");
            }
            catch (Exception)
            {
                //throw;
                string path3 = ruta + @"\log\logErrors.txt";
                string debugText = "\n" + DateTime.Today.ToString() + "," + "Err: Acceso a las claves (API+Secret)";
                File.AppendAllText(path3, debugText);
            }

            //Ahora validar Venta
            //Guardar configuración para Venta
            //string ruta2 = Application.StartupPath;
            string path2 = ruta + @"\config\RNA_venta.txt";
            try
            {
                //VALIDAR VALORES EN CERO!!!
                txtMACD_vta.Text.Trim();
                if (txtMACD_vta.Text == "")
                {
                    txtMACD_vta.Text = "0";
                }
                txtRSI_vta.Text.Trim();
                if (txtRSI_vta.Text == "")
                {
                    txtRSI_vta.Text = "0";
                }
                txtSAR_vta.Text.Trim();
                if (txtSAR_vta.Text == "")
                {
                    txtSAR_vta.Text = "0";
                }
                txtEMA_vta.Text.Trim();
                if (txtEMA_vta.Text == "")
                {
                    txtEMA_vta.Text = "0";
                }
                txtm1_com.Text.Trim();
                if (txtM1_vta.Text == "")
                {
                    txtM1_vta.Text = "0";
                }
                txtM5_vta.Text.Trim();
                if (txtM5_vta.Text == "")
                {
                    txtM5_vta.Text = "0";
                }
                txtM15_vta.Text.Trim();
                if (txtM15_vta.Text == "")
                {
                    txtM15_vta.Text = "0";
                }
                txtM30_vta.Text.Trim();
                if (txtM30_vta.Text == "")
                {
                    txtM30_vta.Text = "0";
                }

                // This text is added only once to the file.
                //if (!File.Exists(path))
                //{
                // Create a file to write to.
                string createText = "m1_vta," + txtM1_vta.Text + "\n" + "m5_vta," + txtM5_vta.Text + "\n" + "m15_vta," + txtM15_vta.Text + "\n" + "m30_vta," + txtM30_vta.Text + "\n" + "SAR_vta," + txtSAR_vta.Text + "\n" + "MACD_vta," + txtMACD_vta.Text + "\n" + "RSI_vta," + txtRSI_vta.Text + "\n" + "EMA_vta," + txtEMA_vta.Text;
                File.WriteAllText(path2, createText);
                //}

                //Application.DoEvents();
                // Encrypt the file.
                // AddEncryption(ruta + @"\keys.txt");
            }
            catch (Exception)
            {
                //throw;
                string path3 = ruta + @"\log\logErrors.txt";
                string debugText = "\n" + DateTime.Today.ToString() + "," + "Err: Acceso a las claves (API+Secret)";
                File.AppendAllText(path3, debugText);
            }
        }

        private void frmNeuralNet_Load(object sender, EventArgs e)
        {
            int counter = 0;
            string line;
            string ruta = Application.StartupPath;
            picRDDCompra.ImageLocation = (ruta + "\\resources\\RDD3_compra.png");
            picRDDVenta.ImageLocation = (ruta + "\\resources\\RDD3_venta.png");
            System.IO.StreamReader file = new System.IO.StreamReader(ruta + @"\config\RNA_compra.txt");
            while ((line = file.ReadLine()) != null)
            {
                String[] words3;
                words3 = line.Split(',');

                switch (words3[0])
                {
                    case "m1_com":
                        txtm1_com.Text = words3[1];
                        break;
                    case "m5_com":
                        txtm5_com.Text = words3[1];
                        break;
                    case "m15_com":
                        txtm15_com.Text = words3[1];
                        break;
                    case "m30_com":
                        txtm30_com.Text = words3[1];
                        break;
                    case "SAR_com":
                        txtSAR_com.Text = words3[1];
                        break;
                    case "MACD_com":
                        txtMACD_com.Text = words3[1];
                        break;
                    case "RSI_com":
                        txtRSI_com.Text = words3[1];
                        break;
                    case "EMA_com":
                        txtEMA_com.Text = words3[1];
                        break;
                    default:
                        break;
                }
                
                counter++;
            }
            file.Close();
            //Lectura del archivo de configuración para VENTA
            System.IO.StreamReader file2 = new System.IO.StreamReader(ruta + @"\config\RNA_venta.txt");
            while ((line = file2.ReadLine()) != null)
            {
                String[] words3;
                words3 = line.Split(',');

                switch (words3[0])
                {
                    case "m1_vta":
                        txtM1_vta.Text = words3[1];
                        break;
                    case "m5_vta":
                        txtM5_vta.Text = words3[1];
                        break;
                    case "m15_vta":
                        txtM15_vta.Text = words3[1];
                        break;
                    case "m30_vta":
                        txtM30_vta.Text = words3[1];
                        break;
                    case "SAR_vta":
                        txtSAR_vta.Text = words3[1];
                        break;
                    case "MACD_vta":
                        txtMACD_vta.Text = words3[1];
                        break;
                    case "RSI_vta":
                        txtRSI_vta.Text = words3[1];
                        break;
                    case "EMA_vta":
                        txtEMA_vta.Text = words3[1];
                        break;
                    default:
                        break;
                }

                counter++;
            }
            file.Close();
        }
    }
}
