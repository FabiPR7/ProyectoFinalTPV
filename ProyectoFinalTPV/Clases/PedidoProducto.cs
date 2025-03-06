using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalTPV.Clases
{
    class PedidoProducto
    {
        Producto prod = new Producto();
        public int PedidoID { get; set; }
        public int ProductoID { get; set; }
        public int Cantidad { get; set; }

        public PedidoProducto(int pedidoID, int productoID, int cantidad)
        {
            PedidoID = pedidoID;
            ProductoID = productoID;
            Cantidad = cantidad;
        }

        public PedidoProducto()
        {
          
        }
        public void InsertarPedidosDetalle(int pedidoID, SqlConnection connection, SqlTransaction transaction,ListBox listBox)
        {
            List<string> pedidos = new List<string>();
            foreach (string text in listBox.Items)
            {
                pedidos.Add(text.Substring(0, text.IndexOf("    ")));

            }
            Dictionary<string, int> pedidosDic = ContarPalabras(pedidos);
            foreach (var producto in pedidosDic)
            {
                string insertDetalleQuery = @"
            INSERT INTO PedidoProducto (PedidoID, ProductoID, Cantidad)
            VALUES (@PedidoID, @ProductoID, @Cantidad);";

                using (SqlCommand command = new SqlCommand(insertDetalleQuery, connection, transaction))
                {
                    command.Parameters.AddWithValue("@PedidoID", pedidoID);
                    command.Parameters.AddWithValue("@ProductoID", prod.ObtenerProductoIDPorNombre(producto.Key));
                    command.Parameters.AddWithValue("@Cantidad", producto.Value);

                }
            }
        }
        public Dictionary<string, int> ContarPalabras(List<string> palabras)
        {
            Dictionary<string, int> conteoPalabras = new Dictionary<string, int>();

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

            return conteoPalabras;
        }


    }
}
