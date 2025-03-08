using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalTPV.Clases
{
    class Usuario
    {
        MiForm miForm = new MiForm();

        public bool VerificarSiHayUsuarios()
        {
            string query = "SELECT COUNT(*) FROM Usuario";
            using (SqlConnection connection = new SqlConnection(miForm.getConnectionString()))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        int cantidadUsuarios = (int)command.ExecuteScalar();

                        return cantidadUsuarios > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar usuarios: " + ex.Message);
                    return false;
                }
            }
        }
        public void eliminarUsuario(int id)
        {
            string sql = "DELETE FROM Usuario WHERE UsuarioID = @UsuarioID";
            using (SqlConnection connection = new SqlConnection(miForm.getConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@UsuarioID", id);
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Usuario eliminado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el usuario.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
                }
            }
        }
        public string obtenerCodigo(string nombre)
        {
            return ObtenerUsuarioIDPorNombre(nombre).ToString();
        }

       

        public List<int> obtenerCodigosEmpleados()
        {
            List<int> codigosEmpleados = new List<int>();

            string query = "select UsuarioID from Usuario";

            using (SqlConnection connection = new SqlConnection(miForm.getConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int codigoEmpleado = reader.GetInt32(0); // Obtener el valor de la columna CodigoEmpleado
                                codigosEmpleados.Add(codigoEmpleado);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener los códigos de empleados: " + ex.Message);
                }
            }

            return codigosEmpleados;
        }

        public string[] obtenerNombresUsuarios()
        {
            string query = "SELECT Nombre FROM Usuario";
            using (SqlConnection connection = new SqlConnection(miForm.getConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            List<string> nombres = new List<string>();


                            while (reader.Read())
                            {
                                string nombre = reader["Nombre"].ToString();
                                nombres.Add(nombre);
                            }

                            return nombres.ToArray();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los nombres de los usuarios: " + ex.Message);
                    return null;
                }
            }

        }
        public int ObtenerUsuarioIDPorNombre(string nombre)
        {
            string query = "SELECT UsuarioID FROM Usuario WHERE Nombre = @Nombre";
            using (SqlConnection connection = new SqlConnection(miForm.getConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Nombre", nombre);

                        object result = command.ExecuteScalar();


                        if (result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                        else
                        {
                            return -1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el UsuarioID: " + ex.Message);
                    return -1;
                }
            }
        }


        public void InsertarUsuario(int id, string nombre, int rol)
        {
            string query = @"
            SET IDENTITY_INSERT Usuario ON;
            INSERT INTO Usuario (UsuarioID, Nombre, RolID) VALUES (@UsuarioID, @Nombre, @RolID);
            SET IDENTITY_INSERT Usuario OFF;";
            using (SqlConnection connection = new SqlConnection(miForm.getConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UsuarioID", id);
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@RolID", rol);
                        int result = command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }
    }
}
