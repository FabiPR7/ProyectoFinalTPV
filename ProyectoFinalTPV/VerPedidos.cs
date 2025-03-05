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
    public partial class VerPedidos : Form
    {
        Metodos m;
        public VerPedidos()
        {
            m= new Metodos();
            InitializeComponent();
            m.adaptarForm(this);
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

        public void ActualizarListView(List<Pedido> pedidos)
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

        public class Pedido
        {
            public int Mesa { get; set; }
            public decimal PrecioTotal { get; set; }
            public DateTime Fecha { get; set; }
            public bool Pagado { get; set; }
        }

        public class PedidoProducto
        {
            public int PedidoID { get; set; }
            public int ProductoID { get; set; }
            public int Cantidad { get; set; }
        }

        public class Producto
        {
            public int ProductoID { get; set; }
            public decimal Precio { get; set; }
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            m.cerrarForm(this);
        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)

        {
          
            if (radioButton1.Checked)
            {
             
                ActualizarListView(ObtenerTodos());
            }
          
            
        }

        private void radioButton3_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton3.Checked)
            {

                ActualizarListView(ObtenerPagados());
            }
        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton2.Checked)
            {

                ActualizarListView(ObtenerNoPagados());
            }
        }
    }
}
