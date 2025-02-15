using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalTPV
{
    public partial class InicioSesion: Form
    {
      
        private string connectionString = "Data Source=FabiPadilla07\\SQLEXPRESS01;Initial Catalog=RestauranteTPV;Integrated Security=True;Encrypt=False";
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            bool hayUsuarios = VerificarSiHayUsuarios();

            if (hayUsuarios)
            {
                MessageBox.Show("Hay usuarios registrados en la base de datos.");
            }
            else
            {
                MessageBox.Show("No hay usuarios registrados en la base de datos.");
            }
        }
        private bool VerificarSiHayUsuarios()
        {
            // Consulta SQL para contar los usuarios
            string query = "SELECT COUNT(*) FROM Usuario";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open(); // Abrir la conexión

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Ejecutar la consulta y obtener el número de usuarios
                        int cantidadUsuarios = (int)command.ExecuteScalar();

                        // Si hay al menos un usuario, devolver true
                        return cantidadUsuarios > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar usuarios: " + ex.Message);
                    return false; // En caso de error, asumimos que no hay usuarios
                }
            }
        }
    }
}
