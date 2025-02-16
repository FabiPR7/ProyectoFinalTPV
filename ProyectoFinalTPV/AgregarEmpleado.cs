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

        private void rolesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rolesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteTPVDataSet);

        }

        private void AgregarEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'restauranteTPVDataSet1.Roles' Puede moverla o quitarla según sea necesario.
            this.rolesTableAdapter.Fill(this.restauranteTPVDataSet1.Roles);
            // TODO: esta línea de código carga datos en la tabla 'restauranteTPVDataSet.Roles' Puede moverla o quitarla según sea necesario.
            this.rolesTableAdapter.Fill(this.restauranteTPVDataSet.Roles);

        }

        private void aceptarAgregarEmpleadoBtn_Click(object sender, EventArgs e)
        {
            if (verificarCampos()) { 
                MessageBox.Show("Empleado añadido correctamente");
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

            // Consulta SQL para obtener los códigos de los empleados
            string query = "select UsuarioID from Usuario"; // Ajusta el nombre de la tabla y columna

            using (SqlConnection connection = new SqlConnection(metodos.getConnectionString()))
            {
                try
                {
                    connection.Open(); // Abrir la conexión

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Leer los resultados
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
    }
}
