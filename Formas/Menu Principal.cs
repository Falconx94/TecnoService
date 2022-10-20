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

namespace Tecnoservice.Formas
{
    public partial class Menu_Principal : Form
    {
        Abonos ab = new Abonos();
        Clientes clt = new Clientes();
        compras cmp = new compras();
        Dispositivo dsp = new Dispositivo();
        proveedores prv = new proveedores();
        Servicios srv = new Servicios();
        Venta vnt = new Venta();
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void btnAbonos_Click(object sender, EventArgs e)
        {
            this.Hide();
            ab.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            clt.Show();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            this.Hide();
            cmp.Show();
        }

        private void btnDispositivo_Click(object sender, EventArgs e)
        {
            this.Hide();
            dsp.Show();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            this.Hide();
            prv.Show();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            this.Hide();
            srv.Show();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            vnt.Show();
        }
    }
}
