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
    public partial class Login : Form
    {
        Main_Form mn = new Main_Form(); 
        string user, pass;
       public Login()
        {
            InitializeComponent();
        }
        public bool Validar_Usuario()
        {
            if (user != "Usuario" && pass != "12345")
            {
                Txbx_User.Clear();
                Txbx_Pass.Clear();
                MessageBox.Show("Error de usuario o contraseña");
                return false;
            }
            else 
            {
                return true;
            }
        }

        private void BT_Login_Click(object sender, EventArgs e)
        {
            if (Validar_Usuario())
            {
                mn.Show();
                this.Hide();
            }
        }

        private void Bt_Cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                user = Txbx_User.Text;
                pass = Txbx_Pass.Text;
                if(Validar_Usuario())
                {
                    mn.Show();
                    this.Hide();
                }
            }
        }
    }
}
