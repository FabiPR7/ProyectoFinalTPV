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
        // Instancia de la clase MiForm para manejar operaciones relacionadas con el formulario.
        MiForm m;

        // Instancia de la clase Producto para manejar operaciones relacionadas con productos.
        Producto prod;

        // Instancia de la clase Categoria para manejar operaciones relacionadas con categorías.
        Categoria c;

        // Instancia de la clase Usuario para manejar operaciones relacionadas con usuarios.
        Usuario u;

        // Instancia de la clase Pedido para manejar operaciones relacionadas con pedidos.
        Pedido pedido;

        // Nombre del usuario que realiza el pedido.
        string usuario;

        // Instancia de la clase Mesa para manejar operaciones relacionadas con mesas.
        Mesa mesa;

        /// <summary>
        /// Constructor de la clase HacerPedido.
        /// Inicializa los componentes del formulario y las instancias de las clases necesarias.
        /// </summary>
        /// <param name="usuario">Nombre del usuario que realiza el pedido.</param>
        public HacerPedido(string usuario)
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
            m = new MiForm();      // Crea una instancia de la clase MiForm.
            prod = new Producto(); // Crea una instancia de la clase Producto.
            u = new Usuario();     // Crea una instancia de la clase Usuario.
            pedido = new Pedido(); // Crea una instancia de la clase Pedido.
            m.adaptarForm(this);   // Adapta el formulario actual.
            mesa = new Mesa();     // Crea una instancia de la clase Mesa.
            c = new Categoria();  // Crea una instancia de la clase Categoria.
            this.usuario = usuario; // Asigna el nombre del usuario.

            // Carga las categorías en el ComboBox y los números de mesa en el ComboBox correspondiente.
            c.cargarAComboBox(nombreCategoriaComboBox);
            mesa.rellenarRoles(comboNumeroMesa);
        }

        /// <summary>
        /// Maneja el evento Load del formulario.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void HacerPedido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'restauranteTPVDataSet1.Categoria'.
        }

        /// <summary>
        /// Rellena un Panel con el nombre y precio de un producto y lo agrega al FlowLayoutPanel.
        /// </summary>
        /// <param name="nombret">Nombre del producto.</param>
        /// <param name="preciot">Precio del producto.</param>
        public void rellenarFlowLayout(string nombret, string preciot)
        {
            Panel panel = new Panel();
            panel.BackColor = Color.White;
            panel.Size = new Size(123, 100); // Ajusta el tamaño según necesites.
            panel.BorderStyle = BorderStyle.FixedSingle; // Opcional, para ver el borde.
            panel.Tag = preciot; // Almacena el precio en la propiedad Tag.
            panel.Name = nombret; // Asigna el nombre del producto al panel.

            Label nombre = new Label();
            nombre.Text = nombret;
            nombre.Location = new Point(4, 31); // Posición dentro del Panel.
            nombre.ForeColor = Color.Black;
            nombre.AutoSize = true;
            nombre.TextAlign = ContentAlignment.MiddleCenter;

            Label precio = new Label();
            precio.Text = preciot;
            precio.AutoSize = true;
            precio.Location = new Point(4, 58); // Posición dentro del Panel.
            precio.ForeColor = Color.Black;
            precio.TextAlign = ContentAlignment.MiddleCenter;

            panel.Controls.Add(nombre);
            panel.Controls.Add(precio);
            panel.Click += Panel_Click; // Asocia el evento Click al panel.
            layaoutPanelCategoria.Controls.Add(panel); // Agrega el panel al FlowLayoutPanel.
        }

        /// <summary>
        /// Maneja el evento Click de los paneles en el FlowLayoutPanel.
        /// Agrega el producto seleccionado a la lista de pedidos y actualiza el precio acumulado.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void Panel_Click(object sender, EventArgs e)
        {
            Panel panelClickeado = sender as Panel;
            if (panelClickeado != null)
            {
                string nombreProducto = panelClickeado.Name;
                string precioProducto = panelClickeado.Tag.ToString();
                listpedidos.Items.Add(nombreProducto + "    " + precioProducto); // Agrega el producto a la lista.
                precioAcumuladolbl.Text = (float.Parse(precioProducto) + float.Parse(precioAcumuladolbl.Text)).ToString(); // Actualiza el precio acumulado.
            }
        }

        /// <summary>
        /// Maneja el evento SelectedValueChanged del ComboBox de categorías.
        /// Carga los productos de la categoría seleccionada en el FlowLayoutPanel.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void nombreComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            layaoutPanelCategoria.Controls.Clear(); // Limpia el FlowLayoutPanel.
            List<Producto> productos = prod.obtenerProductosPorCategoria(c.obtenerIdPorNombreCategoria(nombreCategoriaComboBox.Text));
            foreach (Producto pro in productos)
            {
                rellenarFlowLayout(pro.Nombre, pro.Precio.ToString()); // Rellena el FlowLayoutPanel con los productos.
            }
        }

        /// <summary>
        /// Maneja el evento Click del botón "Configurar Comida".
        /// Abre el formulario de configuración de comidas si el usuario es administrador.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (u.obtenerRolIDusuarioPorNombre(usuario) == 1) // Verifica si el usuario es administrador.
            {
                ConfigurComida configurComida = new ConfigurComida();
                m.cargarForm(configurComida, this); // Abre el formulario de configuración de comidas.
            }
            else
            {
                MessageBox.Show("Debes ser administrador para entrar aquí.");
            }
        }

        /// <summary>
        /// Maneja el evento Click del botón "Volver".
        /// Cierra el formulario actual.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void volverBtn_Click(object sender, EventArgs e)
        {
            m.cerrarForm(this); // Cierra el formulario actual.
        }

        /// <summary>
        /// Maneja el evento Click del botón "Eliminar Producto".
        /// Elimina el producto seleccionado de la lista de pedidos y actualiza el precio acumulado.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (listpedidos.SelectedItem != null)
            {
                string itemSeleccionado = listpedidos.SelectedItem.ToString();
                DialogResult resultado = MessageBox.Show($"¿Deseas eliminar '{itemSeleccionado}'?", "Confirmar eliminación",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    listpedidos.Items.Remove(listpedidos.SelectedItem); // Elimina el producto de la lista.
                    decimal restar = decimal.Parse(itemSeleccionado.Substring(itemSeleccionado.IndexOf("    ")));
                    precioAcumuladolbl.Text = (decimal.Parse(precioAcumuladolbl.Text) - restar).ToString(); // Actualiza el precio acumulado.
                }
            }
            else
            {
                MessageBox.Show("Selecciona un elemento antes de eliminar.");
            }
        }

        /// <summary>
        /// Maneja el evento Click del botón "Eliminar Todo".
        /// Elimina todos los productos de la lista de pedidos y reinicia el precio acumulado.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show($"¿Seguro que quieres eliminar todo el pedido?", "Confirmar eliminación",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                listpedidos.Items.Clear(); // Limpia la lista de pedidos.
                precioAcumuladolbl.Text = "0"; // Reinicia el precio acumulado.
            }
        }

        /// <summary>
        /// Maneja el evento Click del botón "Realizar Pedido".
        /// Inserta el pedido en la base de datos si hay productos seleccionados y se ha especificado una mesa.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void button4_Click(object sender, EventArgs e)
        {
            if (listpedidos.Items.Count > 0)
            {
                if (comboNumeroMesa.Text != "")
                {
                    pedido.insertarPedido(int.Parse(comboNumeroMesa.Text), u.obtenerUsuarioIDPorNombre(usuario), listpedidos);
                    listpedidos.Items.Clear(); // Limpia la lista de pedidos.
                    precioAcumuladolbl.Text = "0.00"; // Reinicia el precio acumulado.
                }
            }
            else
            {
                MessageBox.Show("No hay productos seleccionados.");
            }
        }

        /// <summary>
        /// Maneja el evento SelectedIndexChanged del ComboBox de categorías.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void nombreCategoriaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Este método está vacío y puede ser utilizado para manejar cambios en la selección de categorías.
        }

        private void HacerPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string rutaejecutable = System.IO.Directory.GetCurrentDirectory();
                System.Diagnostics.Process.Start(rutaejecutable + "\\chm\\Manual de RestauranteTPV.html");

            }
        }
    }
}

