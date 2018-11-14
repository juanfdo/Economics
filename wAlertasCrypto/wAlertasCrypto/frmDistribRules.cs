using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wAlertasCrypto
{
    public partial class frmDistribRules : Form
    {
        public frmDistribRules()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //TODO: Grabar todos los registros por cada moneda, porcentaje
            // y cantidades máximas de compra!
            //MessageBox.Show("Implementar!");
            Bitmap img;
            string ruta = Application.StartupPath;
            img = new Bitmap(ruta + "\\resources\\pivx.png");
            dtRules.Rows.Add();
            dtRules.Rows[1].Cells[0].Value = img;

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}
