using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinalTPV.Clases;

namespace ProyectoFinalTPV
{
    /// <summary>
    /// Clase que representa la ventana para elegir una cuenta de usuario.
    /// Permite seleccionar una cuenta para realizar acciones como elegir o eliminar.
    /// </summary>
    public partial class EligeCuenta : Form
    {
        private MiForm metodos; // Instancia de MiForm para manejar el formulario.
        private string nombreUsuario = ""; // Nombre del usuario seleccionado.
        private string accion; // Acción a realizar: "elegir" o "eliminar".
        private string usuario; // Nombre del usuario actual (para evitar autoeliminación).
        private Usuario u; // Instancia de Usuario para gestionar la lógica del usuario.

        /// <summary>
        /// Constructor de la clase EligeCuenta.
        /// Inicializa el formulario y configura los controles según la acción especificada.
        /// </summary>
        /// <param name="accion">Acción a realizar: "elegir" o "eliminar".</param>
        public EligeCuenta(string accion)
        {
            InitializeComponent();
            metodos = new MiForm(); // Inicializa MiForm.
            u = new Usuario(); // Inicializa Usuario.
            metodos.adaptarForm(this); // Adapta el formulario actual.
            this.accion = accion; // Asigna la acción.
            visibilizarBotones(); // Configura la visibilidad de los botones.
        }

        /// <summary>
        /// Constructor sobrecargado de la clase EligeCuenta.
        /// Inicializa el formulario con el nombre del usuario actual y configura los controles según la acción especificada.
        /// </summary>
        /// <param name="accion">Acción a realizar: "elegir" o "eliminar".</param>
        /// <param name="usuario">Nombre del usuario actual.</param>
        public EligeCuenta(string accion, string usuario)
        {
            InitializeComponent();
            metodos = new MiForm(); // Inicializa MiForm.
            u = new Usuario(); // Inicializa Usuario.
            this.usuario = usuario; // Asigna el nombre del usuario actual.
            metodos.adaptarForm(this); // Adapta el formulario actual.
            this.accion = accion; // Asigna la acción.
            visibilizarBotones(); // Configura la visibilidad de los botones.
        }

        /// <summary>
        /// Maneja el evento de clic en los botones de usuario.
        /// Asigna el nombre del usuario seleccionado y activa la acción correspondiente.
        /// </summary>
        private void Button_Click(object sender, EventArgs e)
        {
            // Convierte el sender a Button.
            Button btn = sender as Button;

            // Verifica que el botón no sea nulo.
            if (btn != null)
            {
                nombreUsuario = btn.Text; // Asigna el nombre del usuario seleccionado.
                activarPeticionCodigo(); // Activa la acción correspondiente.
            }
        }

        /// <summary>
        /// Devuelve un arreglo con los botones de usuario del formulario.
        /// </summary>
        /// <returns>Arreglo de botones.</returns>
        public Button[] listBotones()
        {
            Button[] botones = new Button[15];
            botones[0] = btn1;
            botones[1] = btn2;
            botones[2] = btn3;
            botones[3] = btn4;
            botones[4] = btn5;
            botones[5] = btn6;
            botones[6] = btn7;
            botones[7] = btn8;
            botones[8] = btn9;
            botones[9] = btn10;
            botones[10] = btn11;
            botones[11] = btn12;
            botones[12] = btn13;
            botones[13] = btn14;
            botones[14] = btn15;
            return botones;
        }

        /// <summary>
        /// Configura la visibilidad de los botones de usuario según los nombres de usuarios disponibles.
        /// </summary>
        public void visibilizarBotones()
        {
            Button[] b = listBotones(); // Obtiene los botones.
            string[] nombresUsuarios = u.obtenerNombresUsuarios(); // Obtiene los nombres de usuarios.

            if (nombresUsuarios != null && nombresUsuarios.Length > 0)
            {
                int maxBotones = Math.Min(nombresUsuarios.Length, b.Length); // Calcula el número máximo de botones a mostrar.

                for (int i = 0; i < maxBotones; i++)
                {
                    b[i].Visible = true; // Hace visible el botón.
                    b[i].Text = nombresUsuarios[i]; // Asigna el nombre del usuario al botón.
                }
            }
            else
            {
                MessageBox.Show("No se encontraron usuarios o hubo un error.");
            }
        }

        /// <summary>
        /// Activa la acción correspondiente según la selección del usuario.
        /// </summary>
        public void activarPeticionCodigo()
        {
            if (accion.Equals("elegir"))
            {
                // Muestra un cuadro de diálogo para ingresar el código de acceso.
                PeticionCodigo p = new PeticionCodigo(u.obtenerCodigo(nombreUsuario));
                p.ShowDialog();

                // Verifica si el código ingresado es correcto.
                bool codigo = p.codigoBooleano;
                if (codigo)
                {
                    // Abre el menú principal con el nombre del usuario seleccionado.
                    MenuPrincipal menu = new MenuPrincipal(nombreUsuario);
                    metodos.cargarForm(menu, this);
                }
            }
            else if (accion.Equals("eliminar"))
            {
                // Verifica que el usuario no esté intentando eliminarse a sí mismo.
                if (nombreUsuario != usuario)
                {
                    // Muestra un cuadro de diálogo de confirmación para eliminar el usuario.
                    DialogResult result = MessageBox.Show(
                        "¿Estás seguro de que quieres eliminar a este usuario?",
                        "Confirmación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        // Obtiene el ID del usuario y lo elimina.
                        int id = u.obtenerUsuarioIDPorNombre(nombreUsuario);
                        if (id != -1)
                        {
                            u.eliminarUsuario(id);
                            metodos.cerrarForm(this); // Cierra el formulario.
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No puedes eliminarte a ti mismo, debes cerrar esta cuenta de Administrador");
                }
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Volver".
        /// Cierra el formulario actual.
        /// </summary>
        private void volverBtn_Click(object sender, EventArgs e)
        {
            metodos.cerrarForm(this); // Cierra el formulario.
        }
    }
}
