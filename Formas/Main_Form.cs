using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tecnoservice.Formas;

namespace Tecnoservice
{
    public partial class Main_Form : Form
    {
        Venta vnt = new Venta();
        public Main_Form()
        {
            InitializeComponent();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vnt.ShowDialog();
            this.Close();
        }


        /*
        private void Main_Form_Load(object sender, EventArgs e)
        {

        }*/
    }
}
