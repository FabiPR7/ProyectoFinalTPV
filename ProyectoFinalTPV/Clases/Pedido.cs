using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ProyectoFinalTPV.Clases
{
    /// <summary>
    /// Representa un pedido realizado en un restaurante.
    /// </summary>
    public class Pedido
    {
        // Propiedades
        /// <summary>
        /// Obtiene o establece el identificador único del pedido.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Obtiene o establece el número de mesa asociado al pedido.
        /// </summary>
        public int Mesa { get; set; }

        /// <summary>
        /// Obtiene o establece el precio total del pedido.
        /// </summary>
        public decimal PrecioTotal { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha y hora en que se realizó el pedido.
        /// </summary>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Obtiene o establece un valor que indica si el pedido ha sido pagado.
        /// </summary>
        public bool Pagado { get; set; }

        // Dependencias
        private MiForm m = new MiForm();
        private PedidoProducto p = new PedidoProducto();

        // Constructores
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Pedido"/> con los valores especificados.
        /// </summary>
        /// <param name="mesa">Número de mesa asociado al pedido.</param>
        /// <param name="precioTotal">Precio total del pedido.</param>
        /// <param name="fecha">Fecha y hora en que se realizó el pedido.</param>
        /// <param name="pagado">Indica si el pedido ha sido pagado.</param>
        public Pedido(int mesa, decimal precioTotal, DateTime fecha, bool pagado)
        {
            Mesa = mesa;
            PrecioTotal = precioTotal;
            Fecha = fecha;
            Pagado = pagado;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Pedido"/> con valores predeterminados.
        /// </summary>
        public Pedido()
        {
        }

        // Métodos públicos
        /// <summary>
        /// Actualiza un ListBox con la lista de pedidos proporcionada.
        /// </summary>
        /// <param name="pedidos">Lista de pedidos a mostrar.</param>
        /// <param name="listBox1">ListBox que se actualizará con los pedidos.</param>
        public void actualizarListBox(List<Pedido> pedidos, System.Windows.Forms.ListBox listBox1)
        {
            listBox1.Items.Clear();
            string inicio = "ID           MESA               PRECIO               FECHA                PAGADO";
            listBox1.Items.Add(inicio);
            foreach (var pedido in pedidos)
            {
                string item = pedido.Id + "        " + pedido.Mesa.ToString() + "                          " + pedido.PrecioTotal.ToString() + "€" +
                    "            " + pedido.Fecha.ToString("dd/MM/yyyy HH:mm") + "        " + (pedido.Pagado ? "Sí" : "No");
                listBox1.Items.Add(item);
            }
        }

        /// <summary>
        /// Actualiza un ListView con la lista de pedidos proporcionada.
        /// </summary>
        /// <param name="pedidos">Lista de pedidos a mostrar.</param>
        /// <param name="listView1">ListView que se actualizará con los pedidos.</param>
        public void actualizarListView(List<Pedido> pedidos, ListView listView1)
        {
            listView1.Items.Clear();

            foreach (var pedido in pedidos)
            {
                var item = new ListViewItem(pedido.Id.ToString());
                item.SubItems.Add(pedido.Mesa.ToString());
                item.SubItems.Add(pedido.PrecioTotal.ToString("C"));
                item.SubItems.Add(pedido.Fecha.ToString("dd/MM/yyyy HH:mm"));
                item.SubItems.Add(pedido.Pagado ? "Sí" : "No");

                listView1.Items.Add(item);
            }
        }

        /// <summary>
        /// Actualiza el estado de un pedido a "Pagado" en la base de datos.
        /// </summary>
        /// <param name="id">Identificador del pedido a actualizar.</param>
        public void actualizarPedidoAPagado(int id)
        {
            string query = @"
        UPDATE Pedido
        SET Pagado = 1
        WHERE PedidoID = @id";

            MessageBox.Show("Entra a actualizar");

            using (SqlConnection connection = new SqlConnection(m.getConnectionString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Obtiene todos los pedidos registrados en la base de datos.
        /// </summary>
        /// <returns>Una lista de objetos <see cref="Pedido"/>.</returns>
        public List<Pedido> obtenerTodos()
        {
            List<Pedido> pedidos = new List<Pedido>();

            string query = @"
        SELECT 
            p.PedidoID,
            p.MesaID, 
            SUM(pp.Cantidad * prod.Precio) AS PrecioTotal, 
            MAX(p.FechaPedido) AS FechaPedido, 
            MAX(p.Pagado) AS Pagado
        FROM 
            Pedido p
        INNER JOIN 
            PedidoProducto pp ON p.PedidoID = pp.PedidoID
        INNER JOIN 
            Producto prod ON pp.ProductoID = prod.ProductoID
        GROUP BY 
            p.PedidoID, p.MesaID;";

            using (SqlConnection connection = new SqlConnection(m.getConnectionString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.IsDBNull(0) ? 1 : reader.GetInt32(0);
                    int mesa = reader.IsDBNull(1) ? 1 : reader.GetInt32(1);
                    decimal precioTotal = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2);
                    DateTime fecha = reader.IsDBNull(3) ? DateTime.MinValue : reader.GetDateTime(3);
                    int pagado = reader.IsDBNull(4) ? 0 : reader.GetInt32(4);

                    pedidos.Add(new Pedido
                    {
                        Id = id,
                        Mesa = mesa,
                        PrecioTotal = precioTotal,
                        Fecha = fecha,
                        Pagado = pagado == 1
                    });
                }
            }

            return pedidos;
        }

        /// <summary>
        /// Obtiene todos los pedidos que han sido pagados.
        /// </summary>
        /// <returns>Una lista de objetos <see cref="Pedido"/> que han sido pagados.</returns>
        public List<Pedido> obtenerPagados()
        {
            return obtenerTodos().Where(p => p.Pagado).ToList();
        }

        /// <summary>
        /// Obtiene todos los pedidos que no han sido pagados.
        /// </summary>
        /// <returns>Una lista de objetos <see cref="Pedido"/> que no han sido pagados.</returns>
        public List<Pedido> obtenerNoPagados()
        {
            return obtenerTodos().Where(p => !p.Pagado).ToList();
        }

        /// <summary>
        /// Inserta un nuevo pedido en la base de datos.
        /// </summary>
        /// <param name="idMesa">Número de mesa asociado al pedido.</param>
        /// <param name="usuario">Identificador del usuario que realiza el pedido.</param>
        /// <param name="mibox">ListBox que contiene los detalles del pedido.</param>
        public void insertarPedido(int idMesa, int usuario, System.Windows.Forms.ListBox mibox)
        {
            using (SqlConnection connection = new SqlConnection(m.getConnectionString()))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    if (idMesa <= 0)
                    {
                        MessageBox.Show("Elige un número de mesa válido.");
                        return;
                    }

                    string insertPedidoQuery = @"
                INSERT INTO Pedido (MesaID, UsuarioID, FechaPedido, Pagado)
                VALUES (@MesaID, @UsuarioID, @FechaPedido, @Pagado);
                SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(insertPedidoQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@MesaID", idMesa);
                        command.Parameters.AddWithValue("@UsuarioID", usuario);
                        command.Parameters.AddWithValue("@FechaPedido", DateTime.Now);
                        command.Parameters.AddWithValue("@Pagado", 0);

                        int pedidoID = Convert.ToInt32(command.ExecuteScalar());

                        if (pedidoID > 0)
                        {
                            MessageBox.Show("Pedido Guardado");
                        }

                        p.insertarPedidosDetalle(pedidoID, connection, transaction, mibox);
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error al guardar el pedido, no hay mesas con este número.");
                }
            }
        }
    }
}
