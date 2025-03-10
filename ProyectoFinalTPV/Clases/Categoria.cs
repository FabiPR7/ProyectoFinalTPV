using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoFinalTPV.Clases
{
    /// <summary>
    /// Clase que gestiona las operaciones relacionadas con las categorías en la base de datos.
    /// Permite verificar la existencia de una categoría, agregar, actualizar, eliminar categorías,
    /// y cargar categorías en controles de interfaz de usuario como ComboBox y ListBox.
    /// </summary>
    public class Categoria
    {
        // Instancia de la clase MiForm para obtener la cadena de conexión a la base de datos.
        private MiForm m = new MiForm();

        /// <summary>
        /// Verifica si una categoría existe en la base de datos según su ID.
        /// </summary>
        /// <param name="id">ID de la categoría a verificar.</param>
        /// <returns>True si la categoría existe, False en caso contrario.</returns>
        public bool categoriaExiste(int id)
        {
            using (SqlConnection conn = new SqlConnection(m.getConnectionString()))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Categoria WHERE CategoriaID = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        /// <summary>
        /// Elimina una categoría de la base de datos según su nombre.
        /// </summary>
        /// <param name="nombreCategoria">Nombre de la categoría a eliminar.</param>
        /// <remarks>
        /// Muestra un mensaje de éxito o error dependiendo del resultado de la operación.
        /// </remarks>
        public void borrarCategoria(string nombreCategoria)
        {
            string query = "DELETE FROM Categoria WHERE nombre = @nombre";

            using (SqlConnection conn = new SqlConnection(m.getConnectionString()))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombreCategoria); // Evita inyección SQL

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Categoría eliminada correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró la categoría.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar categoría: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Actualiza el nombre de una categoría en la base de datos.
        /// </summary>
        /// <param name="nombreActual">Nombre actual de la categoría.</param>
        /// <param name="nuevoNombre">Nuevo nombre para la categoría.</param>
        /// <remarks>
        /// Muestra un mensaje de éxito o error dependiendo del resultado de la operación.
        /// </remarks>
        public void actualizarCategoria(string nombreActual, string nuevoNombre)
        {
            string query = "UPDATE Categoria SET nombre = @nuevoNombre WHERE nombre = @nombreActual";

            using (SqlConnection conn = new SqlConnection(m.getConnectionString()))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombreActual", nombreActual);
                        cmd.Parameters.AddWithValue("@nuevoNombre", nuevoNombre);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Categoría actualizada correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró la categoría para actualizar.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar categoría: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Agrega una nueva categoría a la base de datos.
        /// </summary>
        /// <param name="nombreCategoria">Nombre de la categoría a agregar.</param>
        /// <param name="form">Formulario que se cerrará después de agregar la categoría.</param>
        /// <remarks>
        /// Muestra un mensaje de éxito o error dependiendo del resultado de la operación.
        /// </remarks>
        public void agregarCategoria(string nombreCategoria, Form form)
        {
            string query = "INSERT INTO Categoria (Nombre) VALUES (@nombre)";

            using (SqlConnection conn = new SqlConnection(m.getConnectionString()))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombreCategoria);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Categoría agregada correctamente.");
                            form.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar la categoría.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar categoría: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Carga los nombres de las categorías en un ComboBox.
        /// </summary>
        /// <param name="comboBox">ComboBox que se desea rellenar con los nombres de las categorías.</param>
        public void cargarAComboBox(System.Windows.Forms.ComboBox comboBox)
        {
            using (SqlConnection sqlConnection = new SqlConnection(m.getConnectionString()))
            {
                using (SqlCommand comando = new SqlCommand("SELECT Nombre FROM Categoria", sqlConnection))
                {
                    sqlConnection.Open();
                    using (SqlDataReader sqlDataReader = comando.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            comboBox.Items.Add(sqlDataReader["Nombre"]);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Carga los nombres de las categorías en un ListBox.
        /// </summary>
        /// <param name="listaCategorias">ListBox que se desea rellenar con los nombres de las categorías.</param>
        public void cargarCategoriasListBox(ListBox listaCategorias)
        {
            string query = "SELECT CategoriaID, nombre FROM Categoria";
            listaCategorias.Items.Clear();

            using (SqlConnection conn = new SqlConnection(m.getConnectionString()))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listaCategorias.Items.Add($"{reader["nombre"]}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Obtiene el ID de una categoría según su nombre.
        /// </summary>
        /// <param name="nombreCategoria">Nombre de la categoría.</param>
        /// <returns>El ID de la categoría si existe, o 0 si no se encuentra.</returns>
        public int obtenerIdPorNombreCategoria(string nombreCategoria)
        {
            int id = 0;
            string connectionString = m.getConnectionString();
            string query = "SELECT CategoriaID FROM categoria WHERE nombre = @Nombre";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombreCategoria);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            id = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró la categoría.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return id;
        }
    }

}
