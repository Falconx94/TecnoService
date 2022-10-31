using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Tecnoservice.Class;
namespace Tecnoservice.Class
{
    class Cls_Proveedores
    {
        BD_Conex scon = new BD_Conex();
        SqlDataReader dr;
        bool band;

        public int Prv_Id { get; set; }
        public string Prv_Razomsocial { get; set; }
        public string Prv_Nombre_Contaco { get; set; }
        public string Prv_Telefono { get; set; }
        public string Prv_Direccion { get; set; }
        public char Prv_Estatus { get; set; }

        public bool Guardar()
        {
            SqlConnection con = new SqlConnection(BD_Conex.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_Proveedores";

            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@Pro_id", Prv_Id);
            cmd.Parameters.AddWithValue("@Pro_Ras_Soci", Prv_Razomsocial);
            cmd.Parameters.AddWithValue("@Pro_Nom_Contac", Prv_Nombre_Contaco);
            cmd.Parameters.AddWithValue("@Pro_Telefono", Prv_Telefono);
            cmd.Parameters.AddWithValue("@Pro_Direccion", Prv_Direccion);
            cmd.Parameters.AddWithValue("@Pro_Estatus", Prv_Estatus);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                band = true;
            }
            catch (Exception ex)
            {
                band = false;
                MessageBox.Show("Error datos no Guardados" + ex);
            }
            con.Close();
            return band;
        }

        public bool Actualizar()
        {
            SqlConnection con = new SqlConnection(BD_Conex.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_Proveedores";
            cmd.Parameters.AddWithValue("@OP", 3);
            cmd.Parameters.AddWithValue("@Pro_id", Prv_Id);
            cmd.Parameters.AddWithValue("@Pro_Ras_Soci", Prv_Razomsocial);
            cmd.Parameters.AddWithValue("@Pro_Nom_Contac", Prv_Nombre_Contaco);
            cmd.Parameters.AddWithValue("@Pro_Telefono", Prv_Telefono);
            cmd.Parameters.AddWithValue("@Pro_Direccion", Prv_Direccion);
            cmd.Parameters.AddWithValue("@Pro_Estatus", Prv_Estatus);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                band = true;
            }
            catch (Exception ex)
            {
                band = false;
                MessageBox.Show("Error al actualizar datos" + ex);
            }
            con.Close();
            return band;

        }

        public bool Eliminar()
        {
            SqlConnection con = new SqlConnection(BD_Conex.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_Proveedores";
            cmd.Parameters.AddWithValue("@OP", 5);
            cmd.Parameters.AddWithValue("@Pro_id",Prv_Id);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                band = true;
            }
            catch (Exception ex)
            {
                band = false;
                MessageBox.Show("Error al borrar los datos =>" + ex);
            }
            con.Close();
            return band;
        }
    }
}
