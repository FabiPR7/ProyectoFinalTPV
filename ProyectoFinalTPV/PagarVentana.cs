using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinalTPV.Clases;

namespace ProyectoFinalTPV
{
    /// <summary>
    /// Clase que representa la ventana para realizar el pago de un pedido.
    /// Permite ingresar el importe y calcular el cambio, además de marcar el pedido como pagado.
    /// </summary>
    public partial class PagarVentana : Form
    {
        private string pedido; // Cadena que representa el pedido seleccionado.
        private Pedido p; // Instancia de Pedido para gestionar la lógica de los pedidos.

        /// <summary>
        /// Constructor de la clase PagarVentana.
        /// Inicializa el formulario y extrae el precio del pedido para mostrarlo.
        /// </summary>
        /// <param name="pedido">Cadena que representa el pedido seleccionado.</param>
        public PagarVentana(string pedido)
        {
            this.pedido = pedido; // Asigna el pedido.
            InitializeComponent();
            p = new Pedido(); // Inicializa Pedido.

            // Extrae el precio del pedido usando una expresión regular.
            string patron = @"\d+,\d{2}€";
            Match match = Regex.Match(pedido, patron);
            precio.Text = match.Value; // Muestra el precio en el campo correspondiente.

            // Si no se encuentra un precio válido, se establece como "0".
            if (precio.Text.Length <= 0)
            {
                precio.Text = "0";
            }
        }

        /// <summary>
        /// Maneja el evento de clic en los botones numéricos y de punto decimal.
        /// Escribe el valor del botón en el campo de código.
        /// </summary>
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button; // Convierte el sender a Button.
            if (btn != null)
            {
                escribirCodigo(btn.Text); // Escribe el texto del botón en el campo de código.
            }
        }

        /// <summary>
        /// Escribe el texto proporcionado en el campo de código.
        /// </summary>
        /// <param name="s">Texto a escribir en el campo de código.</param>
        public void escribirCodigo(string s)
        {
            if (codigoTXT.Text.Length < 100) // Limita la longitud del campo de código.
            {
                if (codigoTXT.Text != "0") // Si el campo no es "0", concatena el texto.
                {
                    codigoTXT.Text = codigoTXT.Text + s;
                }
                else // Si el campo es "0", lo reemplaza con el texto.
                {
                    codigoTXT.Text = s;
                }
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Borrar".
        /// Elimina el último carácter del campo de código.
        /// </summary>
        private void button11_Click_1(object sender, EventArgs e)
        {
            if (codigoTXT.Text.Length > 0) // Verifica que el campo no esté vacío.
            {
                codigoTXT.Text = codigoTXT.Text.Substring(0, codigoTXT.Text.Length - 1); // Elimina el último carácter.
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Activar".
        /// Habilita todos los botones y el campo de código.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = true;
            b4.Enabled = true;
            b5.Enabled = true;
            b6.Enabled = true;
            b7.Enabled = true;
            b8.Enabled = true;
            b9.Enabled = true;
            b0.Enabled = true;
            bpunto.Enabled = true;
            baceptar.Enabled = true;
            bborrar.Enabled = true;
            codigoTXT.Enabled = true;
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Volver".
        /// Cierra el formulario actual.
        /// </summary>
        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario.
        }

        /// <summary>
        /// Extrae el ID del pedido desde la cadena que representa el pedido.
        /// </summary>
        /// <returns>El ID del pedido.</returns>
        public int sacarId()
        {
            return int.Parse(pedido.Substring(0, pedido.IndexOf(" "))); // Extrae el ID del pedido.
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Aceptar".
        /// Realiza la validación del pago, calcula el cambio y marca el pedido como pagado.
        /// </summary>
        private void baceptar_Click(object sender, EventArgs e)
        {
            if (!precio.Text.Equals("0")) // Verifica que el precio no sea "0".
            {
                // Convierte el precio y el importe a decimal.
                decimal precioDecimal = decimal.Parse(precio.Text.Substring(0, precio.Text.IndexOf("€")));
                decimal importeDecimal = decimal.Parse(codigoTXT.Text);

                if (precioDecimal > importeDecimal) // Verifica si el importe es menor que el precio.
                {
                    MessageBox.Show("El importe dado es menor que el costo del pedido");
                }
                else
                {
                    if (precioDecimal < importeDecimal) // Calcula el cambio si el importe es mayor.
                    {
                        MessageBox.Show("Cambio: " + (importeDecimal - precioDecimal));
                    }
                    else
                    {
                        MessageBox.Show("Cambio: 0.00");
                    }

                    p.actualizarPedidoAPagado(sacarId()); // Marca el pedido como pagado.
                    MessageBox.Show("Pedido pagado");
                    this.Close(); // Cierra el formulario.
                }
            }
            else // Si el precio es "0".
            {
                MessageBox.Show("Este pedido no tiene productos");

                decimal precioDecimal = decimal.Parse("0");
                decimal importeDecimal = decimal.Parse(codigoTXT.Text);

                if (precioDecimal > importeDecimal) // Verifica si el importe es menor que el precio.
                {
                    MessageBox.Show("El importe dado es menor que el costo del pedido");
                }
                else
                {
                    if (precioDecimal < importeDecimal) // Calcula el cambio si el importe es mayor.
                    {
                        MessageBox.Show("Cambio: " + (importeDecimal - precioDecimal));
                    }
                    else
                    {
                        MessageBox.Show("Cambio: 0.00");
                    }

                    p.actualizarPedidoAPagado(sacarId()); // Marca el pedido como pagado.
                    MessageBox.Show("Pedido pagado");
                    this.Close(); // Cierra el formulario.
                }
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Datafono".
        /// Muestra un mensaje indicando que no hay un datáfono conectado.
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No se detecta un datáfono conectado");
        }
    }                         
}
