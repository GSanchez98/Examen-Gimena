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

namespace Reseña_Analisis_de_productos
{
    public partial class frmPrincipal : Form
    {
        // establecemos la conexión de manera global ya que la usaremos en diversas partes de
        // la estructura del codigo.

        SqlConnection conn = new SqlConnection(@"server = (local)\sqlexpress;
                                 integrated security = true; database = AdventureWorks2014;");

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Creamos el query de selección de la tabla Products
            string sql1 = "Select * FROM Production.Product WHERE FinishedGoodsFlag = 1";

            // Creamos el comando
            SqlCommand cmd = new SqlCommand(sql1, conn);

            // establecemos la conexión y llenado el dataGridView
            try
            {
                // abrimos la conexión.
                conn.Open();

                // Ejecutamos el query via un DataReader y llenamo el Grid.
                SqlDataReader rdr = cmd.ExecuteReader();

                // llenamos el DataGeid
                while (rdr.Read())
                {
                    lbListadoProductos.Items.Add(rdr[1]);

                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la exepción");

            }
            finally
            {
                // Cerramos la conexión.
                conn.Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (lbListadoProductos.SelectedIndex == -1)
            {
                MessageBox.Show(" Debe seleccionar un producto ", " Error en ingreso ", MessageBoxButtons.OK);

            }else if (txtNombre.Text == "" || txtCorreo.Text == "" || txtValoracion.Text == "")
            {
                MessageBox.Show("Debe llenar todos los datos", "Error en ingreso", MessageBoxButtons.OK);
            }
            else
            {
                // Creamos el comando sql
                SqlCommand cmd = new SqlCommand("sp_RegistrarComentario", conn);

                // Establecemos el comando como un storeProcedure
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    // defiinimos los parametros del store Procedure
                    cmd.Parameters.Add(new SqlParameter("@IDProducto", SqlDbType.NVarChar));
                    cmd.Parameters["@IDProducto"].Value = lbListadoProductos.SelectedItems[0].ToString();

                    cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.NVarChar, 50));
                    cmd.Parameters["@Nombre"].Value = txtNombre.Text;

                    cmd.Parameters.Add(new SqlParameter("@Correo", SqlDbType.NVarChar, 50));
                    cmd.Parameters["@Correo"].Value = txtCorreo.Text;

                    cmd.Parameters.Add(new SqlParameter("@Valoracion", SqlDbType.Int));
                    cmd.Parameters["@Valoracion"].Value = txtValoracion.Text;

                    cmd.Parameters.Add(new SqlParameter("@Comentarios", SqlDbType.NVarChar, 3850));
                    cmd.Parameters["@Comentarios"].Value = txtComentarios.Text;

                    cmd.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.DateTime));
                    cmd.Parameters["@Fecha"].Value = System.DateTime.Now;

                    // Abrimos la conexión
                    conn.Open();

                    // ejecutamos el query
                    cmd.ExecuteNonQuery();

                    //Mostramos un mensaje de confirmación.
                    MessageBox.Show("Comentario almacenado satifactoriamente", "Comentarios", MessageBoxButtons.OK);

                    // Limpiamos los Textbox
                    txtNombre.Text = "";
                    txtCorreo.Text = "";
                    txtValoracion.Text = "";
                    txtComentarios.Text = "";

                    //indicamos el focus en el primer TextBox
                    txtNombre.Focus();
                }
                catch (SqlException ex)
                {

                    MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la exepción");
                }
                finally
                {
                    // Cerramos la conexión
                    conn.Close();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbPrincipal_Enter(object sender, EventArgs e)
        {

        }
    }
}
