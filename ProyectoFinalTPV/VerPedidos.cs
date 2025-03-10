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
    /// Formulario para visualizar pedidos según su estado (todos, pagados o no pagados).
    /// Permite filtrar y mostrar los pedidos en un ListView.
    /// </summary>
    public partial class VerPedidos : Form
    {
        // Instancia de la clase MiForm para gestionar operaciones relacionadas con formularios.
        private MiForm m;

        // Instancia de la clase Pedido para gestionar operaciones relacionadas con pedidos.
        private Pedido p;

        /// <summary>
        /// Constructor de la clase VerPedidos.
        /// Inicializa los componentes del formulario y configura la interfaz.
        /// </summary>
        public VerPedidos()
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
            m = new MiForm();     // Crea una instancia de la clase MiForm.
            p = new Pedido();     // Crea una instancia de la clase Pedido.

            // Adapta el formulario para que no tenga bordes y no sea de nivel superior.
            m.adaptarForm(this);
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Volver".
        /// Cierra el formulario actual.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void volverBtn_Click(object sender, EventArgs e)
        {
            m.cerrarForm(this); // Cierra el formulario actual.
        }

        /// <summary>
        /// Maneja el evento de clic en el RadioButton "Todos".
        /// Actualiza el ListView con todos los pedidos.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton1.Checked)
            {
                // Actualiza el ListView con todos los pedidos.
                p.actualizarListView(p.obtenerTodos(), listView1);
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el RadioButton "Pagados".
        /// Actualiza el ListView con los pedidos pagados.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void radioButton3_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton3.Checked)
            {
                // Actualiza el ListView con los pedidos pagados.
                p.actualizarListView(p.obtenerPagados(), listView1);
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el RadioButton "No Pagados".
        /// Actualiza el ListView con los pedidos no pagados.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton2.Checked)
            {
                // Actualiza el ListView con los pedidos no pagados.
                p.actualizarListView(p.obtenerNoPagados(), listView1);
            }
        }

        /// <summary>
        /// Maneja el evento de carga del formulario.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void VerPedidos_Load(object sender, EventArgs e)
        {
            // Este método está vacío, pero puede utilizarse para inicializar datos al cargar el formulario.
        }

        /// <summary>
        /// Maneja el evento de cambio de estado del RadioButton "Todos".
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Este método está vacío, pero puede utilizarse para manejar cambios en el estado del RadioButton.
        }
    }
}


