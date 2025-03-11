using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalTPV.Clases
{
    /// <summary>
    /// Clase que representa la relación entre un pedido y un producto.
    /// Permite gestionar los detalles de un pedido, como la cantidad de productos,
    /// y realizar operaciones como la inserción de detalles en una base de datos.
    /// </summary>
    public class PedidoProducto
    {
        // Instancia de la clase Producto para obtener información relacionada con los productos.
        private Producto prod = new Producto();

        /// <summary>
        /// Identificador único del pedido.
        /// </summary>
        public int PedidoID { get; set; }

        /// <summary>
        /// Identificador único del producto.
        /// </summary>
        public int ProductoID { get; set; }

        /// <summary>
        /// Cantidad del producto en el pedido.
        /// </summary>
        public int Cantidad { get; set; }

        /// <summary>
        /// Constructor que inicializa una nueva instancia de la clase <see cref="PedidoProducto"/> con valores específicos.
        /// </summary>
        /// <param name="pedidoID">Identificador único del pedido.</param>
        /// <param name="productoID">Identificador único del producto.</param>
        /// <param name="cantidad">Cantidad del producto en el pedido.</param>
        public PedidoProducto(int pedidoID, int productoID, int cantidad)
        {
            PedidoID = pedidoID;
            ProductoID = productoID;
            Cantidad = cantidad;
        }

        /// <summary>
        /// Constructor sin parámetros que permite crear una instancia de la clase <see cref="PedidoProducto"/> sin inicializar sus propiedades.
        /// </summary>
        public PedidoProducto()
        {
            // Constructor vacío.
        }

        /// <summary>
        /// Inserta los detalles de un pedido en la base de datos.
        /// </summary>
        /// <param name="pedidoID">Identificador único del pedido.</param>
        /// <param name="connection">Conexión a la base de datos.</param>
        /// <param name="transaction">Transacción SQL para asegurar la atomicidad de las operaciones.</param>
        /// <param name="listBox">ListBox que contiene los productos seleccionados.</param>
        /// <remarks>
        /// Este método recorre los elementos del ListBox, cuenta la cantidad de cada producto
        /// y realiza la inserción en la tabla PedidoProducto de la base de datos.
        /// </remarks>
        public void insertarPedidosDetalle(int pedidoID, SqlConnection connection, SqlTransaction transaction, ListBox listBox)
        {
            // Lista para almacenar los nombres de los productos.
            List<string> pedidos = new List<string>();

            // Recorre los elementos del ListBox y extrae los nombres de los productos.
            foreach (string text in listBox.Items)
            {
                pedidos.Add(text.Substring(0, text.IndexOf("    ")));
            }
            // Diccionario para contar la cantidad de cada producto en la lista.
            Dictionary<string, int> pedidosDic = contarPalabras(pedidos);
            // Recorre el diccionario y realiza la inserción de cada producto en la base de datos.
            foreach (var producto in pedidosDic)
            {
                // Consulta SQL para insertar un detalle de pedido.
                string insertDetalleQuery = @"
                INSERT INTO PedidoProducto (PedidoID, ProductoID, Cantidad)
                VALUES (@PedidoID, @ProductoID, @Cantidad);";

                // Creación del comando SQL para ejecutar la consulta.
                using (SqlCommand command = new SqlCommand(insertDetalleQuery, connection, transaction))
                {
                    // Asignación de valores a los parámetros de la consulta.
                    command.Parameters.AddWithValue("@PedidoID", pedidoID);
                    command.Parameters.AddWithValue("@ProductoID", prod.obtenerProductoIDPorNombre(producto.Key));
                    command.Parameters.AddWithValue("@Cantidad", producto.Value);

                    // Ejecución del comando (no se muestra en el código proporcionado).
                     command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Cuenta la frecuencia de cada producto en una lista.
        /// </summary>
        /// <param name="palabras">Lista de nombres de productos.</param>
        /// <returns>
        /// Un diccionario donde la clave es el nombre del producto y el valor es la cantidad de veces que aparece en la lista.
        /// </returns>
        public Dictionary<string, int> contarPalabras(List<string> palabras)
        {
            // Diccionario para almacenar el conteo de cada producto.
            Dictionary<string, int> conteoPalabras = new Dictionary<string, int>();

            // Recorre la lista de productos y cuenta su frecuencia.
            foreach (string palabra in palabras)
            {
                if (conteoPalabras.ContainsKey(palabra))
                {
                    conteoPalabras[palabra]++;
                }
                else
                {
                    conteoPalabras[palabra] = 1;
                }
            }

            // Retorna el diccionario con el conteo de productos.
            return conteoPalabras;
        }
    }
}
