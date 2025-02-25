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
    public partial class AgregarComida : Form
    {
        Metodos m = new Metodos();
        public AgregarComida()
        {
            InitializeComponent();
        }

        private void categoriaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteTPVDataSet1);

        }

        private void AgregarComida_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'restauranteTPVDataSet1.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.restauranteTPVDataSet1.Categoria);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nombreCategoriaComboBox.Text == "" || precioTextBox.Text == "" || nombreTextBox.Text == "")
            {
                MessageBox.Show("Rellena todos los datos");
            }
            else {
                MessageBox.Show("Aqui entra");
                agregarComida(nombreTextBox.Text, float.Parse(precioTextBox.Text), ObtenerCategoriaID(nombreCategoriaComboBox.Text));
                MessageBox.Show("Ya lo probo");
            }
        }

        public void agregarComida(string nombre, float precio, int categoriaID)
        {
            using (SqlConnection conn = new SqlConnection(m.getConnectionString2()))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Producto (Nombre, Precio, CategoriaID) VALUES (@Nombre, @Precio, @CategoriaID)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Precio", precio);
                        cmd.Parameters.AddWithValue("@CategoriaID", categoriaID);
                        MessageBox.Show("Lo ejecuta");
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                            MessageBox.Show("Comida agregada correctamente.");
                        else
                            MessageBox.Show("No se pudo agregar la comida.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public int ObtenerCategoriaID(string nombreCategoria)
        {
            int categoriaID = -1; // Valor por defecto si no se encuentra

            using (SqlConnection conn = new SqlConnection(m.getConnectionString2()))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT CategoriaID FROM Categoria WHERE Nombre = @Nombre";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombreCategoria);
                        object resultado = cmd.ExecuteScalar(); 

                        if (resultado != null)
                        {
                            categoriaID = Convert.ToInt32(resultado);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return categoriaID;
        }
    }
}
