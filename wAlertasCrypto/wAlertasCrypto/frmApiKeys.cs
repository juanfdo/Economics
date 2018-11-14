using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.AccessControl;

namespace wAlertasCrypto
{
    public partial class frmApiKeys : Form
    {
        public frmApiKeys()
        {
            InitializeComponent();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmApiKeys_Load(object sender, EventArgs e)
        {
            int counter = 0;
            string line;
            string ruta = Application.StartupPath;
            // Decrypt the file.
            //RemoveEncryption(ruta + @"\keys.txt");
            //Application.DoEvents();   
            System.IO.StreamReader file = new System.IO.StreamReader(ruta + @"\keys.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (counter == 0)
                {
                    txtAPIKey.Text =  line.Trim();
                }
                else
                {
                    txtSecretKey.Text  = line.Trim();
                }
                counter++;
            }
            file.Close();
    }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            string ruta = Application.StartupPath;
            string path = ruta + @"\keys.txt";
            try
            {
                // This text is added only once to the file.
                //if (!File.Exists(path))
                //{
                // Create a file to write to.
                string createText = txtAPIKey.Text + "\n" + txtSecretKey.Text;
                File.WriteAllText(path, createText);
                //}

                //Application.DoEvents();
                // Encrypt the file.
               // AddEncryption(ruta + @"\keys.txt");
            }
            catch (Exception)
            {
                //throw;
                string path2 = ruta + @"\log\logErrors.txt";
                string debugText = "\n" + DateTime.Today.ToString() + "," + "Err: Acceso a las claves (API+Secret)";
                File.AppendAllText(path, debugText);
            }

        }

        // Encrypt a file.
        public static void AddEncryption(string FileName)
        {
            File.Encrypt(FileName);
        }
        // Decrypt a file.
        public static void RemoveEncryption(string FileName)
        {
            File.Decrypt(FileName);
        }

    }
}
