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
    public partial class Rdocentes : System.Web.UI.Page
    {
        //Conecxion 

        public string cadena_conexion = "Data Source=DESKTOP-L3H0UEB;Initial Catalog=Prueba;Integrated Security=True";
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-L3H0UEB;Initial Catalog=Prueba;Integrated Security=True");
        string usuario_modificar;

        protected void Page_Load(object sender, EventArgs e)
        {

            Txnombre.Enabled = false;
            Txdui.Enabled = false;
            txfecha.Enabled = false;
            Txdireccion.Enabled = false;
            Txtelefono.Enabled = false;
            Txcorreo.Enabled = false;
            txp.Enabled = false;
            Txa.Enabled = false;
            Txusuario.Enabled = false;
            Txc.Enabled = false;


            //SqlCommand cmd = new SqlCommand("select * from registro_docentes", conexion);
            //conexion.Open();
            //SqlDataReader sdr = cmd.ExecuteReader();
            //GridView1.DataSource = sdr;
            //GridView1.DataBind();
            //conexion.Close();
        }

        protected void btguardar_Click(object sender, EventArgs e)
        {

            conexion.Open();
            SqlCommand f = new SqlCommand("insert into Rdocentes ([nombre] ,[dui],[fecha_nacimiento],[direccion],[telefono],[Correo],[profesion],[id_area],[usuario],[contraseña]) VALUES ('" + Txnombre.Text + "','" + Txdui.Text + "','" + txfecha.Text + "','" + Txdireccion.Text + "','" + Txtelefono.Text + "' ,'" + Txcorreo.Text + "' ,'" + txp.Text + "' ,'" + Txa.Text + "','" + Txusuario.Text + "','" + Txc.Text + "') ", conexion);
            f.ExecuteNonQuery();
            //MessageBox.Show("Registro guardado");

            Txnombre.Text = "";
            Txdui.Text = "";
            txfecha.Text = "";
            Txdireccion.Text = "";
            Txtelefono.Text = "";
            Txcorreo.Text = "";
            txp.Text = "";
            Txa.Text = "";
            Txusuario.Text = "";
            Txc.Text = "";

    
            Lblmensaje.Text = "El usuario fue guardado";
            conexion.Close();
        }

        protected void btnuevo_Click(object sender, EventArgs e)
        {
            Txnombre.Enabled = true;
            Txdui.Enabled = true;
            txfecha.Enabled = true;
            Txdireccion.Enabled = true;
            Txtelefono.Enabled = true;
            Txcorreo.Enabled = true;
            txp.Enabled = true;
            Txa.Enabled = true;
            Txusuario.Enabled = true;
            Txc.Enabled = true;

            Txnombre.Text = "";
            Txdui.Text = "";
            txfecha.Text = "";
            Txdireccion.Text = "";
            Txtelefono.Text = "";
            Txcorreo.Text = "";
            txp.Text = "";
            Txa.Text = "";
            Txusuario.Text = "";
            Txc.Text = "";


            Txusuario.Focus();
            btnuevo.Visible = false;
            btguardar.Visible = true;
        }
    }
}