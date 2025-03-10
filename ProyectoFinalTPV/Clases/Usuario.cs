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
        // Instancia de la clase MiForm para obtener la cadena de conexión.
        MiForm miForm = new MiForm();

        /// <summary>
        /// Verifica si hay usuarios registrados en la base de datos.
        /// </summary>
        /// <returns>
        /// True si hay al menos un usuario registrado, False en caso contrario.
        /// </returns>
        public bool verificarSiHayUsuarios()
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

        /// <summary>
        /// Elimina un usuario de la base de datos según su ID.
        /// </summary>
        /// <param name="id">ID del usuario a eliminar.</param>
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
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Obtiene el código de un usuario basado en su nombre.
        /// </summary>
        /// <param name="nombre">Nombre del usuario.</param>
        /// <returns>El código del usuario como una cadena.</returns>
        public string obtenerCodigo(string nombre)
        {
            return obtenerUsuarioIDPorNombre(nombre).ToString();
        }

        /// <summary>
        /// Obtiene una lista de códigos de empleados registrados en la base de datos.
        /// </summary>
        /// <returns>Lista de códigos de empleados.</returns>
        public List<int> obtenerCodigosEmpleados()
        {
            List<int> codigosEmpleados = new List<int>();
            string query = "SELECT UsuarioID FROM Usuario";

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
                                int codigoEmpleado = reader.GetInt32(0); // Obtener el valor de la columna UsuarioID
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

        /// <summary>
        /// Obtiene una lista de nombres de usuarios registrados en la base de datos.
        /// </summary>
        /// <returns>Arreglo de nombres de usuarios.</returns>
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

        /// <summary>
        /// Obtiene el ID de un usuario basado en su nombre.
        /// </summary>
        /// <param name="nombre">Nombre del usuario.</param>
        /// <returns>El ID del usuario si existe, de lo contrario, -1.</returns>
        public int obtenerUsuarioIDPorNombre(string nombre)
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

        /// <summary>
        /// Obtiene el ID del rol de un usuario basado en su nombre.
        /// </summary>
        /// <param name="nombre">Nombre del usuario.</param>
        /// <returns>El ID del rol si existe, de lo contrario, -1.</returns>
        public int obtenerRolIDusuarioPorNombre(string nombre)
        {
            SqlConnection conexion = new SqlConnection(miForm.getConnectionString());
            SqlCommand comando = new SqlCommand("SELECT RolID FROM Usuario WHERE Nombre = @nombre", conexion);
            comando.Parameters.AddWithValue("@nombre", nombre);
            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                return int.Parse(reader["RolID"].ToString());
            }
            MessageBox.Show("Error no va");
            return -1;
        }

        /// <summary>
        /// Inserta un nuevo usuario en la base de datos.
        /// </summary>
        /// <param name="id">ID del usuario.</param>
        /// <param name="nombre">Nombre del usuario.</param>
        /// <param name="rol">ID del rol del usuario.</param>
        public void insertarUsuario(int id, string nombre, int rol)
        {
            if (obtenerNombresUsuarios().Contains(nombre))
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
            else
            {
                MessageBox.Show("Ya existe alguien con este nombre, intenta con otro");
            }
        }
    }
}
