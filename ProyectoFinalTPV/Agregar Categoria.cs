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
    public partial class Agregar_Categoria : Form
    {
        // Instancia de la clase Categoria para manejar operaciones relacionadas con categorías.
        Categoria c;

        /// <summary>
        /// Constructor de la clase Agregar_Categoria.
        /// Inicializa los componentes del formulario y crea una instancia de la clase Categoria.
        /// </summary>
        public Agregar_Categoria()
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
            c = new Categoria();  // Crea una instancia de la clase Categoria.
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Cancelar".
        /// Cierra el formulario actual.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual.
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Guardar".
        /// Verifica si el campo de nombre no está vacío y muestra un cuadro de diálogo de confirmación.
        /// Si el usuario confirma, agrega la categoría y cierra el formulario.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica si el campo de nombre no está vacío.
            if (nombreTextBox.Text != "")
            {
                // Muestra un cuadro de diálogo de confirmación.
                DialogResult result = MessageBox.Show(
                    "¿Estás seguro que quieres guardar la categoría " + nombreTextBox.Text + "?",
                    "Aviso",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // Si el usuario confirma, agrega la categoría y cierra el formulario.
                if (result == DialogResult.Yes)
                {
                    c.agregarCategoria(nombreTextBox.Text, this); // Llama al método para agregar la categoría.
                    this.Close(); // Cierra el formulario actual.
                }
            }
        }

        private void Agregar_Categoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string rutaejecutable = System.IO.Directory.GetCurrentDirectory();
                System.Diagnostics.Process.Start(rutaejecutable + "\\chm\\Manual de RestauranteTPV.html");

            }
        }
    }
}
