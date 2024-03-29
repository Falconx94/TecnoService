﻿using System;
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
    public partial class Clientes : Form
    {
        SqlConnection con = new SqlConnection(BD_Conex.conectar());
        SqlCommand cmd;
        SqlDataReader dr;
        Cls_Cliente clsclt = new Cls_Cliente();
        Dispositivo dispo = new Dispositivo();
        bool band1 = false, band2 = false;
        char estado;
        string Conex;

        public Clientes()
        {
            InitializeComponent();
            Conex = BD_Conex.conectar();
            //ClientesTableAdapter.Connection.ConnectionString = Conex;
        }
        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsClientes.Clientes' Puede moverla o quitarla según sea necesario.
            Actualiza_Datagrid();
            Consecutivo();
        }
        public void Actualiza_Datagrid()
        {
            this.clientesTableAdapter.Fill(this.dsClientes.Clientes);
        }
        public bool Valida_Info()
        {
            if (txtNombre.Text == "" || txtAp_Paterno.Text == "" || txtAp_Materno.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Asegurese de que todos los campos esten llenados");
                band1 = false;
            }
            else band1 = true;
            return band1;
        }
        public void GuardarCliente()
        {
            if (Valida_Info())
            {
                Valida_estado();
                //MANDA A LLAMAR A LA CLASE Cls_Cliente PARA GUARDAR 
                clsclt.Clt_Id = Convert.ToInt32(txtID.Text);
                clsclt.Clt_Nombre = txtNombre.Text;
                clsclt.Clt_Ap_Paterno = txtAp_Paterno.Text;
                clsclt.Clt_Ap_Materno = txtAp_Materno.Text;
                clsclt.Clt_Telefono = txtTelefono.Text;
                clsclt.Clt_Estatus = estado;
                if (clsclt.Guardar())
                {
                    MessageBox.Show("Datos guardados exitosamente");
                }
                else
                {
                    MessageBox.Show("Los datos no se guardaron");
                }
                con.Close();
                Consecutivo();
                Actualiza_Datagrid();
            }
        }
        public void Actualizar()
        {
            if (Valida_Info())
            {
                Valida_estado();
                //MANDA A LLAMAR A LA CLASE Cls_Cliente PARA GUARDAR 
                clsclt.Clt_Id = Convert.ToInt32(txtID.Text);
                clsclt.Clt_Nombre = txtNombre.Text;
                clsclt.Clt_Ap_Paterno = txtAp_Paterno.Text;
                clsclt.Clt_Ap_Materno = txtAp_Materno.Text;
                clsclt.Clt_Telefono = txtTelefono.Text;
                clsclt.Clt_Estatus = estado;
                if (clsclt.Actualizar())
                {
                    MessageBox.Show("Datos guardados exitosamente");
                }
                else
                {
                    MessageBox.Show("Los datos no se guardaron");
                }
                con.Close();
                Consecutivo();
                Actualiza_Datagrid();
            }
        }
        public void Eliminar()
        {
            clsclt.Clt_Id = Convert.ToInt32(txtID.Text);
            if(clsclt.Eliminar())
            {
                MessageBox.Show("Datos eliminados exitosamente");
            }
            else
            {
                MessageBox.Show("Los datos no se eliminaron");
            }
            con.Close();
            Consecutivo();
            Actualiza_Datagrid();
        }

        public void Limpiar()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtAp_Paterno.Text = "";
            txtAp_Materno.Text = "";
            txtTelefono.Text = "";
            Consecutivo();
            Actualiza_Datagrid();
        }

        public void Consecutivo()
        {
            cmd = new SqlCommand("SELECT ISNULL(MAX(Clt_Id),0) + 1 FROM Clientes", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtID.Text = Convert.ToString(dr.GetInt32(0));
            }
            con.Close();
        }

        public void Valida_estado()
        {
            if (band2 == true)
                estado = 'A';
            else
                estado = 'I';
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarCliente();
            Limpiar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtID.Text = this.DsCliente.Clientes[cClientesBindingSource.Position.Id.ToString()];
            txtID.Text = this.dsClientes.Clientes[clientesBindingSource.Position].Clt_Id.ToString();
            txtNombre.Text = this.dsClientes.Clientes[clientesBindingSource.Position].Clt_Nombre.ToString();
            txtAp_Paterno.Text = this.dsClientes.Clientes[clientesBindingSource.Position].Clt_Ap_Paterno.ToString();
            txtAp_Materno.Text = this.dsClientes.Clientes[clientesBindingSource.Position].Clt_Ap_Materno.ToString();
            txtTelefono.Text = this.dsClientes.Clientes[clientesBindingSource.Position].Clt_Telefono.ToString();
            char Status = Convert.ToChar(dsClientes.Clientes[clientesBindingSource.Position].Clt_Estatus);
            switch (Status)
            {
                case 'A':
                    Radbtn_Activo.Checked = true;
                    break;
                case 'I':
                    Radbtn_Inactivo.Checked = true;
                    break;
                default:
                    Radbtn_Activo.Checked = false;
                    Radbtn_Inactivo.Checked = false;
                    break;
            }
        }
        public void Desarmar()
        {
            txtID.Enabled = true;
            btnDelete.Visible = true;
            txtNombre.Enabled = false;
            txtAp_Paterno.Enabled = false;
            txtAp_Materno.Enabled = false;
            txtTelefono.Enabled = false;
        }
        public void Armar()
        {
            txtID.Enabled = false;
            btnDelete.Visible = false;
            txtNombre.Enabled = true;
            txtAp_Paterno.Enabled = true;
            txtAp_Materno.Enabled = true;
            txtTelefono.Enabled = true;
        }
        private void btnDeleteActive_Click(object sender, EventArgs e)
        {
            Desarmar();
        }
        
        private void btnDispositivo_Click(object sender, EventArgs e)
        {
            dispo.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
            Limpiar();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Eliminar();
            Limpiar();
            Armar();
        }

        private void Radbtn_Activo_Click(object sender, EventArgs e)
        {
            band1 = false;
            if (Radbtn_Activo.Checked)
            {
                Radbtn_Inactivo.Checked = band1;
                band2 = true;
            }
            else
            {
                Radbtn_Activo.Checked = band1;
                band2 = false;
            }
        }

    }
}