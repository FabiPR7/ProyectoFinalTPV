using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinalTPV.Clases;
using ProyectoFinalTPV.Informes.Comidas;
using ProyectoFinalTPV.Informes.Pedidos;
using ProyectoFinalTPV.Informes.Usuarios;

namespace ProyectoFinalTPV
{/// <summary>
 /// Formulario para gestionar y visualizar informes relacionados con usuarios, pedidos y comidas.
 /// </summary>
    public partial class Informe : Form
    {
        // Instancia de la clase MiForm para gestionar operaciones relacionadas con formularios.
        private MiForm m;

        /// <summary>
        /// Constructor de la clase Informe.
        /// Inicializa los componentes del formulario y configura la interfaz.
        /// </summary>
        /// <param name="usuario">Nombre del usuario que está utilizando el formulario.</param>
        public Informe(string usuario)
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
            m = new MiForm();     // Crea una instancia de la clase MiForm.

            // Adapta el formulario para que no tenga bordes y no sea de nivel superior.
            m.adaptarForm(this);

            // Muestra el nombre del usuario en la etiqueta correspondiente.
            label2.Text = usuario;
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
        /// Maneja el evento de clic en el botón "Hacer Pedido".
        /// Carga y muestra el formulario de informe de usuarios.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void hacerPedidoBtn_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario de informe de usuarios.
            ReportForm reportForm = new ReportForm(new ProyectoFinalTPV.Informes.Usuarios.UsuariosReport());

            // Carga y muestra el formulario de informe dentro del formulario actual.
            m.cargarForm(reportForm, this);
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Pagar Pedido".
        /// Carga y muestra el formulario de informe de pedidos.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void PagarPedido_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario de informe de pedidos.
            ReportForm reportForm = new ReportForm(new ProyectoFinalTPV.Informes.Pedidos.Pedidos());

            // Carga y muestra el formulario de informe dentro del formulario actual.
            m.cargarForm(reportForm, this);
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Ver Pedido".
        /// Carga y muestra el formulario de informe de comidas.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void verPedidoBtn_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario de informe de comidas.
            ReportForm reportForm = new ReportForm(new ProyectoFinalTPV.Informes.Comidas.Comidas());

            // Carga y muestra el formulario de informe dentro del formulario actual.
            m.cargarForm(reportForm, this);
        }
    }
}
