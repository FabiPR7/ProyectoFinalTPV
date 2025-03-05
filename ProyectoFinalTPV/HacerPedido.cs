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
    public partial class HacerPedido : Form
    {
        Metodos m = new Metodos();
        string usuario;

        public HacerPedido(string usuario)
        {
            InitializeComponent();
            m.adaptarForm(this);
            this.usuario = usuario;
        }

        private void HacerPedido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'restauranteTPVDataSet1.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.restauranteTPVDataSet1.Categoria);

        }

        public void rellenarFlowLayout(string nombret, string preciot)
        {
            Panel panel = new Panel();
            panel.BackColor = Color.White;
            panel.Size = new Size(123, 100); // Ajusta el tamaño según necesites
            panel.BorderStyle = BorderStyle.FixedSingle; // Opcional, para ver el borde
            panel.Tag = preciot;
            panel.Name = nombret;
            Label nombre = new Label();
            nombre.Text = nombret;
            nombre.Location = new Point(4, 31); // Posición dentro del Panel
            nombre.ForeColor = Color.Black;
            nombre.AutoSize = true;
            nombre.TextAlign = ContentAlignment.MiddleCenter;
            Label precio = new Label();
            precio.Text = preciot;
            precio.AutoSize = true;
            precio.Location = new Point(4, 58); // Posición dentro del Panel
            precio.ForeColor = Color.Black;
            precio.TextAlign = ContentAlignment.MiddleCenter;
            panel.Controls.Add(nombre);
            panel.Controls.Add(precio);
            panel.Click += Panel_Click;
            layaoutPanelCategoria.Controls.Add(panel);
        }
        private void Panel_Click(object sender, EventArgs e)
        {
            Panel panelClickeado = sender as Panel;
            if (panelClickeado != null)
            {
                string nombreProducot = panelClickeado.Name;
                string precioProducto = panelClickeado.Tag.ToString();
                listpedidos.Items.Add(nombreProducot + "    " + precioProducto);
                precioAcumuladolbl.Text = (float.Parse(precioProducto) + float.Parse(precioAcumuladolbl.Text)).ToString();
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
        public List<Producto> ObtenerProductosPorCategoria(int idCategoria)
        {
            List<Producto> productos = new List<Producto>();

            string connectionString = m.getConnectionString2();
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
                                Producto producto = new Producto
                                {
                                    Nombre = reader["nombre"].ToString(),
                                    Precio = Convert.ToDecimal(reader["precio"])
                                };
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

        private void nombreComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            layaoutPanelCategoria.Controls.Clear();
            List<Producto> productos = ObtenerProductosPorCategoria(ObtenerIdPorNombre(nombreComboBox.Text));
            foreach (Producto pro in productos)
            {
                rellenarFlowLayout(pro.Nombre, pro.Precio.ToString());
            }

        }


        public class Producto
        {
            public string Nombre { get; set; }
            public decimal Precio { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfigurComida configurComida = new ConfigurComida();
            m.cargarForm(configurComida, this);
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            m.cerrarForm(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listpedidos.SelectedItem != null) 
            {
                string itemSeleccionado = listpedidos.SelectedItem.ToString();
                DialogResult resultado = MessageBox.Show($"¿Deseas eliminar '{itemSeleccionado}'?", "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    listpedidos.Items.Remove(listpedidos.SelectedItem);
                    decimal restar = decimal.Parse(itemSeleccionado.Substring(itemSeleccionado.IndexOf("    ")));
                    precioAcumuladolbl.Text = (decimal.Parse(precioAcumuladolbl.Text) - restar).ToString();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un elemento antes de eliminar.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show($"¿Seguro que quieres eliminar todo el pedido?", "Confirmar eliminación",
                                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            precioAcumuladolbl.Text = "0";
            if (resultado == DialogResult.Yes)
            {
                listpedidos.Items.Clear(); 

            }
        }

        public decimal ObtenerPrecioPorNombre(string nombreProducto)
        {
            decimal precio = -1; 

            using (SqlConnection conn = new SqlConnection(m.getConnectionString2()))
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listpedidos.Items.Count > 0)
            {
                GuardarPedido();
            }
            else {
                MessageBox.Show("No hay productos seleccionados");
            }

        }
        public int ObtenerUsuarioIDPorNombre(string nombre)
        {
            MessageBox.Show(nombre);
            string query = "SELECT UsuarioID FROM Usuario WHERE Nombre = @Nombre";
            using (SqlConnection connection = new SqlConnection(m.getConnectionString2()))
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
        public void GuardarPedido()
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
                        command.Parameters.AddWithValue("@UsuarioID", ObtenerUsuarioIDPorNombre(usuario));
                        command.Parameters.AddWithValue("@FechaPedido", DateTime.Now);
                        command.Parameters.AddWithValue("@Pagado", 0);

                        int pedidoID = Convert.ToInt32(command.ExecuteScalar());
                        if (pedidoID > 0) {
                            MessageBox.Show("Pedido Guardado");
                        }

                        InsertarPedidosDetalle(pedidoID, connection, transaction);
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

        private void InsertarPedidosDetalle(int pedidoID, SqlConnection connection, SqlTransaction transaction)
        {
            List<string> pedidos = new List<string>();
            foreach (string text in listpedidos.Items)
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
                    command.Parameters.AddWithValue("@ProductoID", ObtenerProductoIDPorNombre(producto.Key));
                    command.Parameters.AddWithValue("@Cantidad", producto.Value);
               
                }
            }
        }

        private int ObtenerProductoIDPorNombre(string nombreProducto)
        {
            using (SqlConnection connection = new SqlConnection(m.getConnectionString2()))
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

    }
}

