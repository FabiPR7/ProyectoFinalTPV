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
    public partial class Agregar_Categoria : Form
    {
        Metodos m = new Metodos();
        public Agregar_Categoria()
        {
            InitializeComponent();
        }

        private void Agregar_Categoria_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text != "") {
              DialogResult result =  MessageBox.Show("¿Estas seguro que quieres guardar la categoria "+nombreTextBox.Text+ " ?", "Aviso",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) {
                    AgregarCategoria(nombreTextBox.Text);
                }
            }
        }

        private void AgregarCategoria(string nombreCategoria)
        {
            // Query para insertar una nueva categoría
            string query = "INSERT INTO Categoria (Nombre) VALUES (@nombre)";

            // Usar la cadena de conexión (asumiendo que m.getConnectionString2() devuelve la cadena correcta)
            using (SqlConnection conn = new SqlConnection(m.getConnectionString2()))
            {
                try
                {
                    conn.Open(); // Abrir la conexión

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Agregar el parámetro para evitar inyección SQL
                        cmd.Parameters.AddWithValue("@nombre", nombreCategoria);

                        // Ejecutar la consulta
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        // Verificar si se insertó correctamente
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Categoría agregada correctamente.");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar la categoría.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejar errores
                    MessageBox.Show("Error al agregar categoría: " + ex.Message);
                }
            }
        }
    }
}
