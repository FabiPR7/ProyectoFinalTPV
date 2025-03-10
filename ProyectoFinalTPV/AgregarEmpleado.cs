using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinalTPV.Clases;

namespace ProyectoFinalTPV
{
    /// <summary>
    /// Clase que representa la ventana para agregar un nuevo empleado.
    /// Permite ingresar los datos del empleado y validar su correcta inserción.
    /// </summary>
    public partial class AgregarEmpleado : Form
    {
        private MiForm metodos = new MiForm(); // Instancia de MiForm para manejar el formulario.
        private Usuario u = new Usuario(); // Instancia de Usuario para gestionar la lógica del usuario.
        Rol rol = new Rol(); // Instancia de Rol para gestionar los roles de los empleados.

        /// <summary>
        /// Constructor de la clase AgregarEmpleado.
        /// Inicializa el formulario y rellena el ComboBox con los roles disponibles.
        /// </summary>
        public AgregarEmpleado()
        {
            InitializeComponent();
            metodos.adaptarForm(this); // Adapta el formulario actual.
            rol.rellenarRoles(rolAgregarEmpeladoTXT); // Rellena el ComboBox con los roles disponibles.
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Aceptar".
        /// Valida los campos y, si son correctos, inserta el nuevo empleado en la base de datos.
        /// </summary>
        private void aceptarAgregarEmpleadoBtn_Click(object sender, EventArgs e)
        {
            if (verificarCampos()) // Verifica que los campos estén correctamente llenos.
            {
                // Inserta el nuevo empleado en la base de datos.
                u.insertarUsuario(
                    Convert.ToInt32(codigoAgregarEmpleadoTXT.Text), // Código del empleado.
                    nameAgregarEmpleadoTXT.Text, // Nombre del empleado.
                    rolAgregarEmpeladoTXT.Text == "Admin" ? 1 : 2 // Rol del empleado (1 para Admin, 2 para Empleado).
                );
                this.Close(); // Cierra el formulario.
            }
        }

        /// <summary>
        /// Verifica que los campos del formulario estén correctamente llenos.
        /// </summary>
        /// <returns>True si los campos son válidos, False en caso contrario.</returns>
        public bool verificarCampos()
        {
            // Verifica que ningún campo esté vacío.
            if (nameAgregarEmpleadoTXT.Text == "" || rolAgregarEmpeladoTXT.Text == "" || codigoAgregarEmpleadoTXT.Text == "")
            {
                MessageBox.Show("Por favor, rellene todos los campos");
                return false;
            }
            else
            {
                // Verifica que el rol seleccionado sea válido.
                if (rolAgregarEmpeladoTXT.Text == "Empleado" || rolAgregarEmpeladoTXT.Text == "Admin")
                {
                    try
                    {
                        // Verifica que el código sea un número válido de 4 dígitos.
                        int n = Convert.ToInt32(codigoAgregarEmpleadoTXT.Text);
                        if (n < 1000 || n > 9999)
                        {
                            MessageBox.Show("El código debe tener 4 números");
                            return false;
                        }

                        // Verifica que el código no esté duplicado.
                        if (u.obtenerCodigosEmpleados().Contains(n))
                        {
                            MessageBox.Show("El código ya existe");
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("El código debe tener solo números");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Rol incorrecto, por favor, introduzca 'Empleado' o 'Admin'");
                    return false;
                }
            }
            return true; // Retorna true si todos los campos son válidos.
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Volver".
        /// Cierra el formulario actual.
        /// </summary>
        private void volverBtn_Click(object sender, EventArgs e)
        {
            metodos.cerrarForm(this); // Cierra el formulario actual.
        }
    }
}

