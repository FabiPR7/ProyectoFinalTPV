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
{/// <summary>
 /// Formulario para editar o eliminar una categoría existente en la base de datos.
 /// </summary>
    public partial class EditarOEliminarCategoria : Form
    {
        // Variable para almacenar la acción a realizar (editar o eliminar).
        private string accion;

        // Instancia de la clase MiForm para gestionar operaciones relacionadas con formularios.
        private MiForm m;

        // Instancia de la clase Categoria para gestionar operaciones relacionadas con categorías.
        private Categoria c;

        /// <summary>
        /// Constructor de la clase EditarOEliminarCategoria.
        /// Inicializa los componentes del formulario y configura la interfaz según la acción seleccionada.
        /// </summary>
        /// <param name="accion">Acción a realizar: "editar" o "eliminar".</param>
        public EditarOEliminarCategoria(string accion)
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
            this.accion = accion; // Asigna la acción recibida al campo privado.

            // Configura la interfaz según la acción seleccionada.
            cargarAccion(accion);

            m = new MiForm(); // Crea una instancia de la clase MiForm.
            c = new Categoria(); // Crea una instancia de la clase Categoria.

            // Carga las categorías en el ComboBox.
            c.cargarAComboBox(nombreCategoriaBox);
        }

        /// <summary>
        /// Configura la interfaz del formulario según la acción seleccionada.
        /// </summary>
        /// <param name="accion">Acción a realizar: "editar" o "eliminar".</param>
        public void cargarAccion(string accion)
        {
            if (accion.Equals("eliminar"))
            {
                // Configura la interfaz para la acción de eliminar.
                accionCategoriaTxt.Text = "Eliminar Categoria";
                cambiarCategoriaTextBox.Visible = false; // Oculta el TextBox para editar.
                cambiarCategoriaTXT.Visible = false;     // Oculta la etiqueta asociada.
            }
            if (accion.Equals("editar"))
            {
                // Configura la interfaz para la acción de editar.
                accionCategoriaTxt.Text = "Editar Categoria";
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón principal (Aceptar).
        /// Realiza la acción correspondiente (editar o eliminar) según la selección del usuario.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (accion.Equals("eliminar"))
            {
                // Muestra un cuadro de diálogo de confirmación para eliminar la categoría.
                DialogResult respuesta = MessageBox.Show(
                    "¿Estás seguro que quieres eliminar esta categoría?",
                    "Aviso",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );

                // Si el usuario confirma, elimina la categoría y cierra el formulario.
                if (respuesta == DialogResult.OK)
                {
                    c.borrarCategoria(nombreCategoriaBox.Text); // Llama al método para eliminar la categoría.
                    this.Close(); // Cierra el formulario.
                }
            }
            if (accion.Equals("editar"))
            {
                // Muestra un cuadro de diálogo de confirmación para editar la categoría.
                DialogResult respuesta = MessageBox.Show(
                    "¿Estás seguro que quieres editar esta categoría?",
                    "Aviso",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Exclamation
                );

                // Si el usuario confirma, edita la categoría y cierra el formulario.
                if (respuesta == DialogResult.OK)
                {
                    c.actualizarCategoria(nombreCategoriaBox.Text, cambiarCategoriaTextBox.Text); // Llama al método para editar la categoría.
                    this.Close(); // Cierra el formulario.
                }
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón secundario (Cancelar).
        /// Cierra el formulario actual.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            m.cerrarForm(this); // Cierra el formulario actual.
        }
    }
}
