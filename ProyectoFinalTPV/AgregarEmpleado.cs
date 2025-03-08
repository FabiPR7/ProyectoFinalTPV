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

    public partial class AgregarEmpleado : Form
    {
        private MiForm metodos = new MiForm();
        private Usuario u = new Usuario();
        Rol rol = new Rol();
        public AgregarEmpleado()
        {
            InitializeComponent();
            metodos.adaptarForm(this);
            rol.rellenarRoles(rolAgregarEmpeladoTXT);
        }


        private void aceptarAgregarEmpleadoBtn_Click(object sender, EventArgs e)
        {
            if (verificarCampos()) { 
                u.InsertarUsuario(Convert.ToInt32(codigoAgregarEmpleadoTXT.Text), nameAgregarEmpleadoTXT.Text, rolAgregarEmpeladoTXT.Text == "Admin" ? 1 : 2);
                this.Close();
                MessageBox.Show("Cerrar la aplicacion para notar cambios.");
            }
        }

        public bool verificarCampos()
        {
            if (nameAgregarEmpleadoTXT.Text == "" || rolAgregarEmpeladoTXT.Text == "" || codigoAgregarEmpleadoTXT.Text == "")
            {
                MessageBox.Show("Por favor, rellene todos los campos");
                return false;
            }
            else
            {
                if (rolAgregarEmpeladoTXT.Text == "Empleado" || rolAgregarEmpeladoTXT.Text == "Admin")
                {
                    try
                    {
                        int n = Convert.ToInt32(codigoAgregarEmpleadoTXT.Text);
                        if (n<1000 || n>9999) {
                            MessageBox.Show("El código debe tener 4 numeros");
                            return false;
                        }
                        if(u.obtenerCodigosEmpleados().Contains(n))
                        {
                            MessageBox.Show("El código ya existe");
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("El código debe tener solo numeros");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Rol incorrecto, por favor, introduzca 'Empleado' o 'Admin'");
                    return false;
                }
            }
            return true;
        }
     

        private void volverBtn_Click(object sender, EventArgs e)
        {
            metodos.cerrarForm(this);
        }
    }
    }

