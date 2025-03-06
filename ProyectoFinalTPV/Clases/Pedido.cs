using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ProyectoFinalTPV.Clases
{
    class Pedido
    {
        public int Mesa { get; set; }
        public decimal PrecioTotal { get; set; }
        public DateTime Fecha { get; set; }
        public bool Pagado { get; set; }
        MiForm m = new MiForm();
        PedidoProducto p = new PedidoProducto();
        public Pedido(int mesa, decimal precioTotal, DateTime fecha, bool pagado)
        {
            Mesa = mesa;
            PrecioTotal = precioTotal;
            Fecha = fecha;
            Pagado = pagado;
        }

        public Pedido()
        {
        }
        public void ActualizarListBox(List<Pedido> pedidos, System.Windows.Forms.ListBox listBox1)
        {
            listBox1.Items.Clear();
            string inicio = "MESA               PRECIO               FECHA                PAGADO";
            listBox1.Items.Add(inicio);
            foreach (var pedido in pedidos)
            {
                string item = pedido.Mesa.ToString() + "                          " + pedido.PrecioTotal.ToString() + "€" +
                    "            " + pedido.Fecha.ToString("dd/MM/yyyy HH:mm") + "        " + (pedido.Pagado ? "Sí" : "No");
                listBox1.Items.Add(item);
            }
        }
        public void ActualizarListView(List<Pedido> pedidos, ListView listView1)
        {
            listView1.Items.Clear();
            foreach (var pedido in pedidos)
            {
                var item = new ListViewItem(pedido.Mesa.ToString());
                item.SubItems.Add(pedido.PrecioTotal.ToString("C"));
                item.SubItems.Add(pedido.Fecha.ToString("dd/MM/yyyy HH:mm"));
                item.SubItems.Add(pedido.Pagado ? "Sí" : "No");

                listView1.Items.Add(item);
            }
        }
        public  void ActualizarPedidoAPagado(int numeroMesa, DateTime fechaPedido)
        {
            string query = @"
            UPDATE Pedido
            SET Pagado = 1
            WHERE MesaID = @MesaID AND FechaPedido = @Fecha";

            using (SqlConnection connection = new SqlConnection(new MiForm().getConnectionString2()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MesaID", numeroMesa);
                command.Parameters.AddWithValue("@Fecha", fechaPedido);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Pedido actualizado a Pagado correctamente.");
                }
                else
                {
                    Console.WriteLine("No se encontró el pedido con la mesa y fecha especificadas.");
                }
            }
        }

        public List<Pedido> ObtenerTodos()
        {
            List<Pedido> pedidos = new List<Pedido>();
            string query = @"
            SELECT p.MesaID, SUM(pp.Cantidad * prod.Precio) AS PrecioTotal, p.FechaPedido, p.Pagado
            FROM Pedido p
            INNER JOIN PedidoProducto pp ON p.PedidoID = pp.PedidoID
            INNER JOIN Producto prod ON pp.ProductoID = prod.ProductoID
            GROUP BY p.MesaID, p.FechaPedido, p.Pagado";
            using (SqlConnection connection = new SqlConnection(m.getConnectionString2()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int mesa = reader.IsDBNull(0) ? 1 : reader.GetInt32(0);
                    decimal precioTotal = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                    DateTime fecha = reader.IsDBNull(2) ? DateTime.MinValue : reader.GetDateTime(2);
                    int pagado = reader.IsDBNull(3) ? 0 : reader.GetInt32(3);

                    pedidos.Add(new Pedido
                    {
                        Mesa = mesa,
                        PrecioTotal = precioTotal,
                        Fecha = fecha,
                        Pagado = pagado == 1
                    });
                }
            }
            return pedidos;
        }

        public List<Pedido> ObtenerPagados()
        {
            return ObtenerTodos().Where(p => p.Pagado).ToList();
        }

        public List<Pedido> ObtenerNoPagados()
        {
            return ObtenerTodos().Where(p => !p.Pagado).ToList();
        }
        public void GuardarPedido(NumericUpDown numeroMesa, int usuario, System.Windows.Forms.ListBox mibox)
        {
            using (SqlConnection connection = new SqlConnection(m.getConnectionString2()))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    if (numeroMesa.Value <= 0)
                    {
                        MessageBox.Show("Elige un número de mesa válido.");
                        return;
                    }
                    string insertPedidoQuery = @"
                INSERT INTO Pedido (MesaID, UsuarioID, FechaPedido, Pagado)
                VALUES (@MesaID, @UsuarioID, @FechaPedido,@Pagado);
                SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(insertPedidoQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@MesaID", numeroMesa.Value);
                        command.Parameters.AddWithValue("@UsuarioID",usuario);
                        command.Parameters.AddWithValue("@FechaPedido", DateTime.Now);
                        command.Parameters.AddWithValue("@Pagado", 0);

                        int pedidoID = Convert.ToInt32(command.ExecuteScalar());
                        if (pedidoID > 0)
                        {
                            MessageBox.Show("Pedido Guardado");
                        }
                        p.InsertarPedidosDetalle(pedidoID, connection, transaction,  mibox);
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error al guardar el pedido, no hay mesas con este numero");
                }
            }
        }
    }
}
