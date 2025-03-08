using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalTPV.Clases
{
    class Producto
    {
        MiForm m = new MiForm();
      public  string Nombre { get; set; }
     public   decimal Precio { set; get; }
        public int ProductoID { get; set; }
        

        public Producto(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public Producto(decimal precio, int productoID)
        {
            Precio = precio;
            ProductoID = productoID;
        }

        public Producto() { 
        
        }

        public void EliminarComida(string nombreCategoria)
        {

            string query = "DELETE FROM Producto WHERE nombre = @nombre";

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
        public void ActualizarProdudcto(string nombreActual, string nuevoNombre, float precio, bool existeCategoria, int idCategoria)
        {
            using (SqlConnection conn = new SqlConnection(m.getConnectionString()))
            {
                try
                {
                    conn.Open();

                    if (!existeCategoria)
                    {
                        MessageBox.Show("Error: La categoría especificada no existe en la base de datos.");
                        return;
                    }

                    string query = "UPDATE Producto SET Nombre = @nuevoNombre, Precio = @precio, CategoriaID = @categoria WHERE Nombre = @nombreActual";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombreActual", nombreActual);
                        cmd.Parameters.AddWithValue("@nuevoNombre", nuevoNombre);
                        cmd.Parameters.AddWithValue("@precio", precio);
                        cmd.Parameters.AddWithValue("@categoria",idCategoria);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Producto actualizado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el producto para actualizar.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar producto: " + ex.Message);
                }
            }
        }
        public void agregarComida(string nombre, float precio, int categoriaID)
        {
            using (SqlConnection conn = new SqlConnection(m.getConnectionString()))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Producto (Nombre, Precio, CategoriaID) VALUES (@Nombre, @Precio, @CategoriaID)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Precio", precio);
                        cmd.Parameters.AddWithValue("@CategoriaID", categoriaID);
                        MessageBox.Show("Lo ejecuta");
                        cmd.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        public int ObtenerProductoIDPorNombre(string nombreProducto)
        {
            using (SqlConnection connection = new SqlConnection(m.getConnectionString()))
            {
                connection.Open();
                string query = "SELECT ProductoID FROM Producto WHERE Nombre = @Nombre";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombreProducto);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        throw new Exception($"Producto no encontrado: {nombreProducto}");
                    }
                }
            }
        }
        public decimal ObtenerPrecioPorNombre(string nombreProducto)
        {
            decimal precio = -1;

            using (SqlConnection conn = new SqlConnection(m.getConnectionString()))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Precio FROM Producto WHERE Nombre = @Nombre";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombreProducto);
                        object resultado = cmd.ExecuteScalar();

                        if (resultado != null)
                        {
                            precio = Convert.ToDecimal(resultado);
                        }
                        else
                        {
                            MessageBox.Show("Producto no encontrado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return precio;
        }
        public void rellenarProducto(ComboBox comboBox)
        {
            SqlConnection sqlConnection = new SqlConnection(m.getConnectionString());
            SqlCommand comadno = new SqlCommand("select Nombre from Producto", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = comadno.ExecuteReader();
            while (sqlDataReader.Read())
            {
                comboBox.Items.Add(sqlDataReader["Nombre"].ToString());
            }

        }
        public List<Producto> ObtenerProductosPorCategoria(int idCategoria)
        {
            List<Producto> productos = new List<Producto>();

            string connectionString = m.getConnectionString();
            string query = "SELECT nombre, precio FROM producto WHERE CategoriaID = @IdCategoria";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdCategoria", idCategoria);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Producto producto = new Producto(
                                    reader["nombre"].ToString(),
                                    Convert.ToDecimal(reader["precio"])
                                );
                                productos.Add(producto);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            return productos;
        }
    }
}
