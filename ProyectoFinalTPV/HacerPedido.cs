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
    public partial class HacerPedido: Form
    {
        Metodos m = new Metodos();
        public HacerPedido()
        {
            InitializeComponent();
            m.adaptarForm(this);
        }

        private void HacerPedido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'restauranteTPVDataSet1.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.restauranteTPVDataSet1.Categoria);

        }
       
        public void rellenarFlowLayout(string nombret, string preciot) {
            Panel panel = new Panel();
            panel.BackColor = Color.White;
            panel.Size = new Size(123, 100); // Ajusta el tamaño según necesites
            panel.BorderStyle = BorderStyle.FixedSingle; // Opcional, para ver el borde

            Label nombre = new Label();
            nombre.Text = nombret;
            nombre.Location = new Point(4, 31); // Posición dentro del Panel
            nombre.ForeColor = Color.Black;
            nombre.AutoSize = true; 
            nombre.TextAlign= ContentAlignment.MiddleCenter;
            Label precio = new Label();
            precio.Text = preciot;
            precio.AutoSize = true;
            precio.Location = new Point(4, 58); // Posición dentro del Panel
            precio.ForeColor = Color.Black;
            precio.TextAlign= ContentAlignment.MiddleCenter;
            panel.Controls.Add(nombre);
            panel.Controls.Add(precio);

            layaoutPanelCategoria.Controls.Add(panel);
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
                        else {
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
            foreach(Producto pro in productos) {
                rellenarFlowLayout(pro.Nombre, pro.Precio.ToString());
            }
           
        }

        
            public class Producto
        {
            public string Nombre { get; set; }
            public decimal Precio { get; set; }
        }
    }
}
