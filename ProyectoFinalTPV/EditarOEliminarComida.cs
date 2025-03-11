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
    /// Clase que representa la ventana para editar o eliminar un producto (comida).
    /// Permite realizar acciones de edición o eliminación según la acción especificada.
    /// </summary>
    public partial class EditarOEliminarComida : Form
    {
        private string accion; // Acción a realizar: "editar" o "eliminar".
        private MiForm m; // Instancia de MiForm para manejar el formulario.
        private Producto p; // Instancia de Producto para gestionar la lógica del producto.
        private Categoria c; // Instancia de Categoria para gestionar las categorías.

        /// <summary>
        /// Constructor de la clase EditarOEliminarComida.
        /// Inicializa el formulario y configura los controles según la acción especificada.
        /// </summary>
        /// <param name="accion">Acción a realizar: "editar" o "eliminar".</param>
        public EditarOEliminarComida(string accion)
        {
            InitializeComponent();
            this.accion = accion; // Asigna la acción.
            m = new MiForm(); // Inicializa MiForm.
            p = new Producto(); // Inicializa Producto.
            c = new Categoria(); // Inicializa Categoria.
            cargarAccion(accion); // Configura los controles según la acción.
            p.rellenarProductos(nombeAcambiarText); // Rellena el ComboBox con los productos.
            c.cargarAComboBox(categriaComboBox); // Rellena el ComboBox con las categorías.
        }

        /// <summary>
        /// Maneja el evento de clic en el botón principal (aceptar/confirmar).
        /// Realiza la acción de editar o eliminar según la configuración del formulario.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            if (accion == "eliminar")
            {
                // Muestra un cuadro de diálogo de confirmación para eliminar el producto.
                DialogResult resultado = MessageBox.Show(
                    "¿Estás seguro de eliminar el Producto: " + nombeAcambiarText.Text + "?",
                    "Aviso",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.OK)
                {
                    p.eliminarProducto(nombeAcambiarText.Text); // Elimina el producto.
                }
            }
            if (accion == "editar")
            {
                // Verifica que todos los campos estén llenos.
                if (precioTextBox.Text == "" || categoriaNombre.Text == "" || textBox1.Text == "" || nombeAcambiarText.Text == "")
                {
                    MessageBox.Show("Rellena todos los datos");
                }
                else
                {
                    // Actualiza el producto con los nuevos datos.
                    p.actualizarProducto(
                        nombeAcambiarText.Text, // Nombre actual del producto.
                        textBox1.Text, // Nuevo nombre del producto.
                        (decimal)float.Parse(precioTextBox.Text), // Nuevo precio del producto.
                        c.categoriaExiste(c.obtenerIdPorNombreCategoria(categriaComboBox.Text)), // Verifica si la categoría existe.
                        c.obtenerIdPorNombreCategoria(categriaComboBox.Text) // Obtiene el ID de la categoría.
                    );
                }
            }
        }

        /// <summary>
        /// Configura los controles del formulario según la acción especificada.
        /// </summary>
        /// <param name="accion">Acción a realizar: "editar" o "eliminar".</param>
        public void cargarAccion(string accion)
        {
            if (accion.Equals("eliminar"))
            {
                accionTxt.Text = "Eliminar Comida"; // Cambia el texto del título.
                precioTextBox.Visible = false; // Oculta el campo de precio.
                precioLbl.Visible = false; // Oculta la etiqueta de precio.
                cambiarAText.Visible = false; // Oculta el campo de cambio.
                categriaComboBox.Visible = false; // Oculta el ComboBox de categorías.
                categoriaNombre.Visible = false; // Oculta la etiqueta de categoría.
                textBox1.Visible = false; // Oculta el campo de nuevo nombre.
                label1.Visible = false; // Oculta la etiqueta de nuevo nombre.
            }
            if (accion.Equals("editar"))
            {
                accionTxt.Text = "Editar Comida"; // Cambia el texto del título.
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Volver".
        /// Cierra el formulario actual.
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario.
        }

        private void EditarOEliminarComida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string rutaejecutable = System.IO.Directory.GetCurrentDirectory();
                System.Diagnostics.Process.Start(rutaejecutable + "\\chm\\Manual de RestauranteTPV.html");

            }
        }
    }
}
