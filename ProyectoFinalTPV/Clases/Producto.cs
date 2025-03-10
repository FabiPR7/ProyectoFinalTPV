using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalTPV.Clases
{/// <summary>
 /// Clase que representa un producto y proporciona métodos para interactuar con la base de datos.
 /// </summary>
    public class Producto
    {
        // Dependencia
        private MiForm m = new MiForm();

        // Propiedades
        /// <summary>
        /// Obtiene o establece el nombre del producto.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Obtiene o establece el precio del producto.
        /// </summary>
        public decimal Precio { get; set; }

        /// <summary>
        /// Obtiene o establece el identificador único del producto.
        /// </summary>
        public int ProductoID { get; set; }

        // Constructores
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Producto"/> con el nombre y precio especificados.
        /// </summary>
        /// <param name="nombre">Nombre del producto.</param>
        /// <param name="precio">Precio del producto.</param>
        public Producto(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Producto"/> con el precio y el identificador especificados.
        /// </summary>
        /// <param name="precio">Precio del producto.</param>
        /// <param name="productoID">Identificador único del producto.</param>
        public Producto(decimal precio, int productoID)
        {
            Precio = precio;
            ProductoID = productoID;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Producto"/> con valores predeterminados.
        /// </summary>
        public Producto() { }

        // Métodos públicos
        /// <summary>
        /// Elimina un producto de la base de datos por su nombre.
        /// </summary>
        /// <param name="nombreProducto">Nombre del producto a eliminar.</param>
        public void eliminarProducto(string nombreProducto)
        {
            string query = "DELETE FROM Producto WHERE Nombre = @nombre";

            using (SqlConnection conn = new SqlConnection(m.getConnectionString()))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombreProducto); // Evita inyección SQL

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Producto eliminado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el producto.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar producto: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Actualiza un producto en la base de datos.
        /// </summary>
        /// <param name="nombreActual">Nombre actual del producto.</param>
        /// <param name="nuevoNombre">Nuevo nombre del producto.</param>
        /// <param name="precio">Nuevo precio del producto.</param>
        /// <param name="existeCategoria">Indica si la categoría especificada existe.</param>
        /// <param name="idCategoria">Identificador de la categoría del producto.</param>
        public void actualizarProducto(string nombreActual, string nuevoNombre, decimal precio, bool existeCategoria, int idCategoria)
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
                        cmd.Parameters.AddWithValue("@categoria", idCategoria);

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

        /// <summary>
        /// Agrega un nuevo producto a la base de datos.
        /// </summary>
        /// <param name="nombre">Nombre del producto.</param>
        /// <param name="precio">Precio del producto.</param>
        /// <param name="categoriaID">Identificador de la categoría del producto.</param>
        public void agregarProducto(string nombre, decimal precio, int categoriaID)
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
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Obtiene el identificador único de un producto por su nombre.
        /// </summary>
        /// <param name="nombreProducto">Nombre del producto.</param>
        /// <returns>El identificador único del producto.</returns>
        public int obtenerProductoIDPorNombre(string nombreProducto)
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

        /// <summary>
        /// Obtiene el precio de un producto por su nombre.
        /// </summary>
        /// <param name="nombreProducto">Nombre del producto.</param>
        /// <returns>El precio del producto, o -1 si no se encuentra.</returns>
        public decimal obtenerPrecioPorNombre(string nombreProducto)
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

        /// <summary>
        /// Rellena un ComboBox con los nombres de los productos obtenidos de la base de datos.
        /// </summary>
        /// <param name="comboBox">ComboBox que se actualizará con los nombres de los productos.</param>
        public void rellenarProductos(ComboBox comboBox)
        {
            using (SqlConnection sqlConnection = new SqlConnection(m.getConnectionString()))
            {
                string query = "SELECT Nombre FROM Producto";
                SqlCommand command = new SqlCommand(query, sqlConnection);

                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();

                comboBox.Items.Clear();

                while (reader.Read())
                {
                    comboBox.Items.Add(reader["Nombre"].ToString());
                }
            }
        }

        /// <summary>
        /// Obtiene una lista de productos asociados a una categoría específica.
        /// </summary>
        /// <param name="idCategoria">Identificador de la categoría.</param>
        /// <returns>Una lista de objetos <see cref="Producto"/>.</returns>
        public List<Producto> obtenerProductosPorCategoria(int idCategoria)
        {
            List<Producto> productos = new List<Producto>();
            string connectionString = m.getConnectionString();
            string query = "SELECT Nombre, Precio FROM Producto WHERE CategoriaID = @IdCategoria";

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
                                    reader["Nombre"].ToString(),
                                    Convert.ToDecimal(reader["Precio"])
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
