using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinalTPV.Clases;

namespace ProyectoFinalTPV
{
    /// <summary>
    /// Clase que representa la ventana de administración de cuentas de usuario.
    /// Permite cambiar de cuenta, cerrar sesión, agregar o eliminar empleados, y gestionar permisos de administrador.
    /// </summary>
    public partial class AdministrarCuenta : Form
    {
        private MiForm m; // Instancia de MiForm para manejar el formulario.
        private Usuario u; // Instancia de Usuario para gestionar la lógica del usuario.

        /// <summary>
        /// Constructor de la clase AdministrarCuenta.
        /// </summary>
        /// <param name="nombre">Nombre del usuario actual.</param>
        public AdministrarCuenta(string nombre)
        {
            InitializeComponent();
            m = new MiForm();
            m.adaptarForm(this); // Adapta el formulario actual.
            nombreUs.Text = nombre; // Muestra el nombre del usuario en el formulario.
            u = new Usuario(); // Inicializa la instancia de Usuario.
            gestionarAdmin(); // Gestiona los permisos de administrador.
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Cambiar Usuario".
        /// Abre la ventana para elegir una cuenta diferente.
        /// </summary>
        private void cambiarUsBtn_Click(object sender, EventArgs e)
        {
            EligeCuenta eligeCuenta = new EligeCuenta("elegir");
            m.cargarForm(eligeCuenta, this); // Carga el formulario de elección de cuenta.
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Cerrar Sesión".
        /// Abre la ventana de inicio de sesión.
        /// </summary>
        private void cerrarSesionBtn_Click(object sender, EventArgs e)
        {
            InicioSesion inicioSesion = new InicioSesion();
            m.cargarForm(inicioSesion, this); // Carga el formulario de inicio de sesión.
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Agregar Usuario".
        /// Abre la ventana para agregar un nuevo empleado.
        /// </summary>
        private void AgregarUsBtn_Click(object sender, EventArgs e)
        {
            AgregarEmpleado agregarEmpleado = new AgregarEmpleado();
            m.cargarForm(agregarEmpleado, this); // Carga el formulario de agregar empleado.
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Eliminar Usuario".
        /// Abre la ventana para elegir una cuenta y eliminarla.
        /// </summary>
        private void eliminarUsBtn_Click(object sender, EventArgs e)
        {
            EligeCuenta eligeCuenta = new EligeCuenta("eliminar", nombreUs.Text);
            m.cargarForm(eligeCuenta, this); // Carga el formulario de elección de cuenta para eliminar.
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Volver".
        /// Cierra el formulario actual.
        /// </summary>
        private void volverBtn_Click(object sender, EventArgs e)
        {
            m.cerrarForm(this); // Cierra el formulario actual.
        }

        /// <summary>
        /// Gestiona los permisos de administrador.
        /// Deshabilita los botones de agregar y eliminar usuarios si el usuario actual no es administrador.
        /// </summary>
        public void gestionarAdmin()
        {
            if (u.obtenerRolIDusuarioPorNombre(nombreUs.Text) != 1) // Verifica si el usuario no es administrador.
            {
                eliminarUsBtn.Enabled = false; // Deshabilita el botón de eliminar usuario.
                AgregarUsBtn.Enabled = false; // Deshabilita el botón de agregar usuario.
            }
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AdministrarCuenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                // Ruta del archivo CHM
                string rutaejecutable = System.IO.Directory.GetCurrentDirectory();
                System.Diagnostics.Process.Start(rutaejecutable + "\\chm\\Manual de RestauranteTPV.html");

            }
        }
    }
}
