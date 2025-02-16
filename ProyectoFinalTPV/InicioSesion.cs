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
    public partial class InicioSesion: Form
    {
        private Metodos m = new Metodos();
      
        public InicioSesion()
        {
            InitializeComponent();
            m.adaptarForm(this);
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            bool hayUsuarios = VerificarSiHayUsuarios();

            if (hayUsuarios)
            {
             iniciarSesionBtn.Enabled = true;
             crearCuentaBtn.Enabled = false;
             crearCuentaBtn.Visible = false;
             nohaycuentasTXT.Visible = false;
            }
            else
            {
                iniciarSesionBtn.Enabled = false;
          
            }
        }
        private bool VerificarSiHayUsuarios()
        {
         
            string query = "SELECT COUNT(*) FROM Usuario";

            using (SqlConnection connection = new SqlConnection(m.getConnectionString()))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                       
                        int cantidadUsuarios = (int)command.ExecuteScalar();

                        return cantidadUsuarios > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar usuarios: " + ex.Message);
                    return false; 
                }
            }
        }

        private void crearCuentaBtn_Click(object sender, EventArgs e)
        {
            m.cargarForm(new AgregarEmpleado(), this);
        }
    }
}
