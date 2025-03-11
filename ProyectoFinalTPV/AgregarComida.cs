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
    /// <summary>
    /// Formulario para agregar un nuevo producto (comida) a la base de datos.
    /// </summary>
    public partial class AgregarComida : Form
    {
        // Instancia de la clase Producto para gestionar operaciones relacionadas con productos.
        private Producto p;

        // Instancia de la clase Categoria para gestionar operaciones relacionadas con categorías.
        private Categoria c;

        /// <summary>
        /// Constructor de la clase AgregarComida.
        /// Inicializa los componentes del formulario y carga las categorías en el ComboBox.
        /// </summary>
        public AgregarComida()
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
            p = new Producto();   // Crea una instancia de la clase Producto.
            c = new Categoria();  // Crea una instancia de la clase Categoria.

            // Carga las categorías en el ComboBox.
            c.cargarAComboBox(nombreCategoriaComboBox);
        }

        /// <summary>
        /// Maneja el evento de clic en el botón para agregar un nuevo producto.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        /// <remarks>
        /// Verifica que todos los campos estén completos antes de agregar el producto.
        /// Si los campos están vacíos, muestra un mensaje de error.
        /// Si los campos están completos, agrega el producto y cierra el formulario.
        /// </remarks>
        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica si los campos obligatorios están vacíos.
            if (nombreCategoriaComboBox.Text == "" || precioTextBox.Text == "" || nombreTextBox.Text == "")
            {
                MessageBox.Show("Rellena todos los datos"); // Muestra un mensaje de error.
            }
            else
            {
                // Agrega el producto a la base de datos.
                p.agregarProducto(
                    nombreTextBox.Text, // Nombre del producto.
                    (decimal)float.Parse(precioTextBox.Text), // Precio del producto.
                    c.obtenerIdPorNombreCategoria(nombreCategoriaComboBox.Text) // ID de la categoría.
                );

                this.Close(); // Cierra el formulario después de agregar el producto.
            }
        }

        private void AgregarComida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string rutaejecutable = System.IO.Directory.GetCurrentDirectory();
                System.Diagnostics.Process.Start(rutaejecutable + "\\chm\\Manual de RestauranteTPV.html");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
