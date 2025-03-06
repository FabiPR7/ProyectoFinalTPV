using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalTPV.Clases
{
    class Categoria
    {
        MiForm m = new MiForm();

        public bool CategoriaExiste(int id)
        {
            using (SqlConnection conn = new SqlConnection(m.getConnectionString2()))
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
        public void EliminarCategoria(string nombreCategoria)
        {

            string query = "DELETE FROM Categoria WHERE nombre = @nombre";

            using (SqlConnection conn = new SqlConnection(m.getConnectionString2()))
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
        public void ActualizarCategoria(string nombreActual, string nuevoNombre)
        {
            string query = "UPDATE Categoria SET nombre = @nuevoNombre WHERE nombre = @nombreActual";

            using (SqlConnection conn = new SqlConnection(m.getConnectionString2()))
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
        public void AgregarCategoria(string nombreCategoria, Form form)
        {
            // Query para insertar una nueva categoría
            string query = "INSERT INTO Categoria (Nombre) VALUES (@nombre)";

            // Usar la cadena de conexión (asumiendo que m.getConnectionString2() devuelve la cadena correcta)
            using (SqlConnection conn = new SqlConnection(m.getConnectionString2()))
            {
                try
                {
                    conn.Open(); // Abrir la conexión

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Agregar el parámetro para evitar inyección SQL
                        cmd.Parameters.AddWithValue("@nombre", nombreCategoria);

                        // Ejecutar la consulta
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        // Verificar si se insertó correctamente
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
                    // Manejar errores
                    MessageBox.Show("Error al agregar categoría: " + ex.Message);
                }
            }
        }
        public void CargarCategorias(ListBox listaCategorias)
        {
            string query = "SELECT CategoriaID, nombre FROM Categoria";
            listaCategorias.Items.Clear();
            using (SqlConnection conn = new SqlConnection(m.getConnectionString2()))
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
        public int ObtenerIdPorNombre(string nombreCategoria)
        {
            int id = 0;

            string connectionString = m.getConnectionString2();

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
                            MessageBox.Show("Es null");
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
