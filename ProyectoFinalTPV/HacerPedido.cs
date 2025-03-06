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
using ProyectoFinalTPV.Clases;

namespace ProyectoFinalTPV
{
    public partial class HacerPedido : Form
    {
        MiForm m;
        Producto prod;
        Categoria c;
        Usuario u;
        Pedido pedido;
        string usuario;

        public HacerPedido(string usuario)
        {
            InitializeComponent();
            m = new MiForm();
            prod = new Producto();
            u = new Usuario();
            pedido = new Pedido();
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
       
        private void nombreComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            layaoutPanelCategoria.Controls.Clear();
            List<Producto> productos = prod.ObtenerProductosPorCategoria(c.ObtenerIdPorNombre(nombreComboBox.Text));
            foreach (Producto pro in productos)
            {
                rellenarFlowLayout(pro.Nombre, pro.Precio.ToString());
            }

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
        private void button4_Click(object sender, EventArgs e)
        {
            if (listpedidos.Items.Count > 0)
            {
                pedido.GuardarPedido(numeroMesa,u.ObtenerUsuarioIDPorNombre(usuario),listpedidos);
            }
            else {
                MessageBox.Show("No hay productos seleccionados");
            }
        }
    }
}

