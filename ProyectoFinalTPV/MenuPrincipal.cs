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

namespace ProyectoFinalTPV
{
    public partial class MenuPrincipal : Form
    {
        // Instancia de la clase MiForm para manejar operaciones relacionadas con el formulario.
        MiForm m;

        // Nombre del usuario que ha iniciado sesión.
        private string nombreUsuario;

        // Instancia de la clase Usuario para manejar operaciones relacionadas con usuarios.
        Usuario u;

        /// <summary>
        /// Constructor de la clase MenuPrincipal.
        /// Inicializa los componentes del formulario y las instancias de las clases necesarias.
        /// </summary>
        /// <param name="nombreUsuario">Nombre del usuario que ha iniciado sesión.</param>
        public MenuPrincipal(string nombreUsuario)
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
            m = new MiForm();      // Crea una instancia de la clase MiForm.
            m.adaptarForm(this);   // Adapta el formulario actual.
            u = new Usuario();     // Crea una instancia de la clase Usuario.
            this.nombreUsuario = nombreUsuario; // Asigna el nombre del usuario.
            nombreUs.Text = nombreUsuario; // Muestra el nombre del usuario en el formulario.
        }

        /// <summary>
        /// Maneja el evento Click del botón "Perfil".
        /// Abre el formulario para administrar la cuenta del usuario.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void perfilButton_Click(object sender, EventArgs e)
        {
            AdministrarCuenta administrarCuenta = new AdministrarCuenta(nombreUsuario);
            m.cargarForm(administrarCuenta, this); // Abre el formulario de administración de cuenta.
        }

        /// <summary>
        /// Maneja el evento Click del botón "Hacer Pedido".
        /// Abre el formulario para realizar un nuevo pedido.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void hacerPedidoBtn_Click(object sender, EventArgs e)
        {
            HacerPedido hacerPedido = new HacerPedido(nombreUsuario);
            m.cargarForm(hacerPedido, this); // Abre el formulario para hacer un pedido.
        }

        /// <summary>
        /// Maneja el evento Click del botón "Ver Pedidos".
        /// Abre el formulario para ver los pedidos realizados.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void verPedidoBtn_Click(object sender, EventArgs e)
        {
            VerPedidos verPedidos = new VerPedidos();
            m.cargarForm(verPedidos, this); // Abre el formulario para ver pedidos.
        }

        /// <summary>
        /// Maneja el evento Click del botón "Pagar Pedido".
        /// Abre el formulario para pagar un pedido.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void PagarPedido_Click(object sender, EventArgs e)
        {
            PagarPedido pag = new PagarPedido();
            m.cargarForm(pag, this); // Abre el formulario para pagar un pedido.
        }

        /// <summary>
        /// Maneja el evento Click del botón "Informes".
        /// Abre el formulario de informes si el usuario es administrador.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (u.obtenerRolIDusuarioPorNombre(nombreUsuario) == 1) // Verifica si el usuario es administrador.
            {
                Informe informes = new Informe(nombreUsuario);
                m.cargarForm(informes, this); // Abre el formulario de informes.
            }
            else
            {
                MessageBox.Show("Debes ser administrador para tener acceso a los informes.");
            }
        }
    }
}
