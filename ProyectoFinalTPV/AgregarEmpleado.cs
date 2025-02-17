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

namespace ProyectoFinalTPV
{

    public partial class AgregarEmpleado : Form
    {
        private Metodos metodos = new Metodos();
        public AgregarEmpleado()
        {
            InitializeComponent();
            metodos.adaptarForm(this);
        }


        private void aceptarAgregarEmpleadoBtn_Click(object sender, EventArgs e)
        {
            if (verificarCampos()) { 
                InsertarUsuario(Convert.ToInt32(codigoAgregarEmpleadoTXT.Text), nameAgregarEmpleadoTXT.Text, rolAgregarEmpeladoTXT.Text == "Admin" ? 1 : 2);
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
                        if(obtenerCodigosEmpleados().Contains(n))
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
        public List<int> obtenerCodigosEmpleados()
        {
            List<int> codigosEmpleados = new List<int>();

            string query = "select UsuarioID from Usuario";

            using (SqlConnection connection = new SqlConnection(metodos.getConnectionString2()))
            {
                try
                {
                    connection.Open(); 
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int codigoEmpleado = reader.GetInt32(0); // Obtener el valor de la columna CodigoEmpleado
                                codigosEmpleados.Add(codigoEmpleado);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener los códigos de empleados: " + ex.Message);
                }
            }

            return codigosEmpleados;
        }
     

        public void InsertarUsuario(int id, string nombre, int rol)
        {
            string query = @"
            SET IDENTITY_INSERT Usuario ON;
            INSERT INTO Usuario (UsuarioID, Nombre, RolID) VALUES (@UsuarioID, @Nombre, @RolID);
            SET IDENTITY_INSERT Usuario OFF;";
            using (SqlConnection connection = new SqlConnection(metodos.getConnectionString2()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UsuarioID", id);
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@RolID", rol);
                        int result = command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            metodos.cerrarForm(this);
        }
    }
    }

