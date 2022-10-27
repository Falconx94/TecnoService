using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Tecnoservice.Class;

namespace Tecnoservice.Formas
{
    public partial class proveedores : Form
    {
        SqlConnection con = new SqlConnection(BD_Conex.conectar());
        SqlCommand cmd;
        SqlDataReader dr;
        Cls_Cliente clsclt = new Cls_Cliente();
        Dispositivo dispo = new Dispositivo();
        bool band1 = false, band2 = false;
        char estado;
        string Conex;

        private void proveedores_Load(object sender, EventArgs e)
        {
            Actualiza_Datagrid();
            Consecutivo();
        }

        public proveedores()
        {
            InitializeComponent();
            Conex = BD_Conex.conectar();
        }

        public void Actualiza_Datagrid()
        {
            this.clientesTableAdapter.Fill(this.dsClientes.Clientes);
        }
        public void Consecutivo()
        {
            cmd = new SqlCommand("SELECT ISNULL(MAX(Prv_Id),0) + 1 FROM Proveedores", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtIDProveedor.Text = Convert.ToString(dr.GetInt32(0));
            }
            con.Close();
        }
    }
}
