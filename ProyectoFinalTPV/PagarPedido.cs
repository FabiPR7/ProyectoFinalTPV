using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinalTPV.Clases;
using static ProyectoFinalTPV.VerPedidos;

namespace ProyectoFinalTPV
{
    /// <summary>
    /// Clase que representa la ventana para pagar un pedido.
    /// Permite seleccionar un pedido no pagado y abrir una ventana para realizar el pago.
    /// </summary>
    public partial class PagarPedido : Form
    {
        private Pedido p; // Instancia de Pedido para gestionar la lógica de los pedidos.
        private MiForm m; // Instancia de MiForm para manejar el formulario.

        /// <summary>
        /// Constructor de la clase PagarPedido.
        /// Inicializa el formulario y carga los pedidos no pagados en el ListBox.
        /// </summary>
        public PagarPedido()
        {
            InitializeComponent();
            m = new MiForm(); // Inicializa MiForm.
            p = new Pedido(); // Inicializa Pedido.
            m.adaptarForm(this); // Adapta el formulario actual.
            p.actualizarListBox(p.obtenerNoPagados(), listBox1); // Carga los pedidos no pagados en el ListBox.
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Pagar".
        /// Abre una ventana para realizar el pago del pedido seleccionado.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica que se haya seleccionado un pedido en el ListBox.
            if (listBox1.SelectedItem != null)
            {
                // Abre la ventana de pago con el pedido seleccionado.
                PagarVentana pagarVentana = new PagarVentana(listBox1.SelectedItem.ToString());
                pagarVentana.ShowDialog();

                // Actualiza el ListBox con los pedidos no pagados.
                p.actualizarListBox(p.obtenerNoPagados(), listBox1);
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Volver".
        /// Cierra el formulario actual.
        /// </summary>
        private void volverBtn_Click(object sender, EventArgs e)
        {
            m.cerrarForm(this); // Cierra el formulario.
        }

        private void PagarPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string rutaejecutable = System.IO.Directory.GetCurrentDirectory();
                System.Diagnostics.Process.Start(rutaejecutable + "\\chm\\Manual de RestauranteTPV.html");

            }
        }
    }
}
