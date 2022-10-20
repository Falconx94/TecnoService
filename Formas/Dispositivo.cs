using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tecnoservice.Formas
{
    public partial class Dispositivo : Form
    {
        public Dispositivo()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        public void Datos_Fijos()
        {
            txtDispositivo.Enabled = false;
            txtDetDispositivo.Enabled = false;
            txtIMEIDispo.Enabled = false;
            txtMarcaDispo.Enabled = false;
            txtModeloDispo.Enabled = false;
        }
    }
}
