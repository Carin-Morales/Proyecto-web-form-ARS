using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace Proyecto_web_form_ARS
{
    
    public partial class Ayuda : System.Web.UI.Page
    {
        public string cadena_conexion = "Data Source=DESKTOP-L3H0UEB;Initial Catalog=Prueba;Integrated Security=True";
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-L3H0UEB;Initial Catalog=Prueba;Integrated Security=True");
        //string usuario_modificar;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand f = new SqlCommand("insert into Contacto ([nombre],[correo],[mensaje] VALUES('" + Texn.Text + "','" + Texc.Text + "','" + Texm.Text + "')", conexion);
            f.ExecuteNonQuery();
            //MessageBox.Show("Registro guardado");

            Texn.Text = "";
            Texc.Text = "";
            Texm.Text = "";
            

            // lstnivel.Text = "";
            //lblmensaje.Text = "El usuario fue guardado";
            conexion.Close();
        }
    }
}