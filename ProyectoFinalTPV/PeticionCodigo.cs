using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinalTPV.Clases;

namespace ProyectoFinalTPV
{
    /// <summary>
    /// Formulario para solicitar y validar un código de acceso.
    /// Permite al usuario ingresar un código y verificar si coincide con el código esperado.
    /// </summary>
    public partial class PeticionCodigo : Form
    {
        /// <summary>
        /// Indica si el código ingresado es válido.
        /// </summary>
        public bool codigoBooleano { get; private set; }

        // Código esperado para la validación.
        private string codigo;

        /// <summary>
        /// Constructor de la clase PeticionCodigo.
        /// Inicializa el formulario y establece el código esperado.
        /// </summary>
        /// <param name="codigo">Código esperado para la validación.</param>
        public PeticionCodigo(string codigo)
        {
            this.codigo = codigo; // Asigna el código esperado.
            codigoBooleano = false; // Inicializa el estado de validación como falso.
            InitializeComponent(); // Inicializa los componentes del formulario.
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Borrar".
        /// Elimina el último carácter del código ingresado.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void button11_Click(object sender, EventArgs e)
        {
            if (codigoTXT.Text.Length > 0)
            {
                // Elimina el último carácter del código ingresado.
                codigoTXT.Text = codigoTXT.Text.Substring(0, codigoTXT.Text.Length - 1);
            }
        }

        /// <summary>
        /// Escribe un carácter en el campo de texto del código.
        /// </summary>
        /// <param name="s">Carácter a agregar al código.</param>
        public void escribirCodigo(String s)
        {
            // Verifica que el código no exceda la longitud máxima de 4 caracteres.
            if (codigoTXT.Text.Length < 4)
            {
                // Si el campo no está vacío o no contiene solo "0", agrega el carácter.
                if (codigoTXT.Text != "0")
                {
                    codigoTXT.Text = codigoTXT.Text + s;
                }
                else
                {
                    // Si el campo contiene solo "0", lo reemplaza con el nuevo carácter.
                    codigoTXT.Text = s;
                }
            }
        }

        /// <summary>
        /// Maneja el evento de clic en los botones numéricos.
        /// Agrega el número correspondiente al campo de texto del código.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button; // Convierte el objeto sender a un botón.
            if (btn != null)
            {
                escribirCodigo(btn.Text); // Llama al método para agregar el número al código.
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Cancelar".
        /// Cierra el formulario sin validar el código.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void button12_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario.
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Aceptar".
        /// Valida el código ingresado con el código esperado.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void button13_Click(object sender, EventArgs e)
        {
            // Compara el código ingresado con el código esperado.
            if (codigo.Equals(codigoTXT.Text))
            {
                codigoBooleano = true; // Marca el código como válido.
                this.Close(); // Cierra el formulario.
            }
            else
            {
                // Muestra un mensaje de error si el código es incorrecto.
                MessageBox.Show("Código incorrecto");
            }
        }

        private void PeticionCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string rutaejecutable = System.IO.Directory.GetCurrentDirectory();
                System.Diagnostics.Process.Start(rutaejecutable + "\\chm\\Manual de RestauranteTPV.html");

            }
        }
    }
}
