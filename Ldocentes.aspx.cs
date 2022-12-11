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
    public partial class Ldocentes : System.Web.UI.Page
    {
        public string cadena_conexion = "Data Source=DESKTOP-L3H0UEB;Initial Catalog=Prueba;Integrated Security=True";
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-L3H0UEB;Initial Catalog=Prueba;Integrated Security=True");
        string usuario_modificar;
        protected void Page_Load(object sender, EventArgs e)
        {
            txusuario.Enabled = false;
            txcontraseña.Enabled = false;

            SqlCommand cmd = new SqlCommand("select*from Rdocentes", conexion);
            conexion.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            GridView1.DataSource = sdr;
            GridView1.DataBind();
            conexion.Close();

        }

        protected void btmodificar_Click(object sender, EventArgs e)
        {
            txusuario.Enabled = true;
            txcontraseña.Enabled = true;
            //txtelefono.Enabled = true;


            txusuario.Focus();

            btmodificar.Visible = false;
            btactualizar.Visible = true;

            usuario_modificar = txusuario.Text.ToString();
        }

        protected void btbuscar_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection myConnection = new SqlConnection(cadena_conexion);

                string myInsertQuery = "select * from Rdocentes Where id = " + txbuscar.Text + "";
                SqlCommand myCommand = new SqlCommand(myInsertQuery, myConnection);

                myCommand.Connection = myConnection;
                myConnection.Open();

                SqlDataReader myReader;
                myReader = myCommand.ExecuteReader();

                if (myReader.Read())
                {
                    txusuario.Text = (myReader.GetString(9));
                    txcontraseña.Text = (myReader.GetString(10));
                    //txtelefono.Value= (myReader.GetString(5));

                }
                else
                {
                    //MessageBox.Show("El usuario no existe", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txmensaje.Text = "El usuario no existe";
                }
                myReader.Close();
                myConnection.Close();

            }
            catch (SqlException)
            {
                //MessageBox.Show("Campo de busqueda está vacío", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //lblmensaje.Text = "Campo de busqueda está vacío";
            }

            //bnuevo_ok.Visible = true;
            //btguardar.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro
            txusuario.Enabled = false;
            txcontraseña.Enabled = false;
            //txtelefono.Enabled = false;
            btmodificar.Focus();

            /*
            SqlConnection myConnection = new SqlConnection(cadena_conexion);
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = myConnection;
            comando.CommandText = ("select * from usuarios Where idusuario = '" + txtbuscar.Text + "'");
            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {
                txtusuario.Text = leer["nombre"].ToString();
                txtclave.Text = leer["clave"].ToString();
                lstnivel.Text = leer["nivel"].ToString();
            }
            conexion.Close();
           */
        }

        protected void btactualizar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Rdocentes SET usuario= '" + this.txusuario.Text + "', contraseña= '" + this.txcontraseña.Text + "'WHERE id=" + Convert.ToInt32(this.txbuscar.Text + ""), conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();

            try
            {
                SqlConnection myConnection = new SqlConnection(cadena_conexion);

                string nom = txusuario.Text.ToString();
                string cla = txcontraseña.Text.ToString();
                //string niv = txtelefono.Text;
                Lsmensaje.Text = "El usuario fue actualizado";
                //Hay dos formas de pasar los valores



                string consulta = "select * from Rdocentes";

                SqlConnection conexion = new SqlConnection(cadena_conexion);
                SqlDataAdapter da = new SqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "Prueba");
            }

            //GridView1.DataSource = ds;
            //GridView1.DataMember = "sistemapro1";
            catch (SqlException)
            {
                //MessageBox.Show("Error al modificar el usuario", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        protected void bteliminar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand("delete from Rdocentes where id= '" + txbuscar.Text + "'", conexion);
            comando.ExecuteNonQuery();
            //MessageBox.Show("Registro guardado");

            txusuario.Text = "";
            txcontraseña.Text = "";
            lblmensaje.Text = "El usuario fue eliminado";
            //// lstnivel.Text = "";

            conexion.Close();
            //string cadena = "delete from usuarios where idusuario = '" + txtbuscar.Text + "'";
            //SqlCommand myCommand = new SqlCommand(cadena, conexion);
            //myCommand.ExecuteNonQuery();
            /*
            
            try
            {

                SqlConnection myConnection = new SqlConnection(cadena_conexion);

                string myInsertQuery = "delete from usuarios Where idusuario = " + txtbuscar.Text + "";
                SqlCommand myCommand = new SqlCommand(myInsertQuery);

               // myCommand.Connection = myConnection;
                myConnection.Open();
                SqlCommand.ExecuteNonQuery();
                SqlCommand.myConnection.Close();

                //MessageBox.Show("Usuario eliminado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);


                string consulta = "select * from usuarios";

                SqlConnection conexion = new SqlConnection(cadena_conexion);
                SqlDataAdapter da = new SqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "SqlDataSource");
                GridView1.DataSource = ds;
                GridView1.DataMember = "SqlDataSource";
                

        }
            catch (MySqlException)
            {
                //MessageBox.Show("Error al eliminar el usuario, primero realice búsqueda del usuario y después puede eliminar.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bnuevo.Visible = true;
            bguardar.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro
            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;

            txtusuario.Text = "";
            txtclave.Text = "";
            //lstnivel.Text = "Seleccione nivel";
            txtbuscar.Focus();
            
            */
        }

        protected void txusuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}






