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
    public partial class EditarOEliminarComida : Form
    {
        private string accion;
        private Metodos m;
        public EditarOEliminarComida(string accion)
        {

            InitializeComponent();
            
            this.accion = accion;
            m = new Metodos();
            cargarAccion(accion);

        }

        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteTPVDataSet1);

        }

        private void EditarOEliminarComida_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'restauranteTPVDataSet1.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.restauranteTPVDataSet1.Categoria);
            // TODO: esta línea de código carga datos en la tabla 'restauranteTPVDataSet1.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.restauranteTPVDataSet1.Producto);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (accion == "eliminar")
            {
                DialogResult resultado = MessageBox.Show("¿Estas seguro de eliminar el Producto: " + nombeAcambiarText.Text + "?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (resultado == DialogResult.OK)
                {
                    EliminarComida(nombeAcambiarText.Text);
                }
            }
            if (accion == "editar")
            {

                if (precioTextBox.Text == "" || categoriaNombre.Text == "" || textBox1.Text == "" || nombeAcambiarText.Text == "")
                {
                    MessageBox.Show("Rellena todos los datos");
                }
                else
                {
                    ActualizarProdudcto(nombeAcambiarText.Text, textBox1.Text, float.Parse(precioTextBox.Text), ObtenerCategoriaID(categriaComboBox.Text));
                }

            }
        }

        public void cargarAccion(string accion)
        {

            if (accion.Equals("eliminar"))
            {
                accionTxt.Text = "Eliminar Categoria";
                precioTextBox.Visible = false;
                precioLbl.Visible = false;
                cambiarAText.Visible = false;
                categriaComboBox.Visible = false;
                categoriaNombre.Visible = false;
                textBox1.Visible = false;
                label1.Visible = false;
            }
            if (accion.Equals("editar"))
            {
                accionTxt.Text = "Editar Categoria";
            }
        }

        private void precioLabel_Click(object sender, EventArgs e)
        {

        }

        private void EliminarComida(string nombreCategoria)
        {

            string query = "DELETE FROM Producto WHERE nombre = @nombre";

            using (SqlConnection conn = new SqlConnection(m.getConnectionString2()))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombreCategoria); // Evita inyección SQL

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Categoría eliminada correctamente.");

                        }
                        else
                        {
                            MessageBox.Show("No se encontró la categoría.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar categoría: " + ex.Message);
                }
            }
        }
        private void ActualizarProdudcto(string nombreActual, string nuevoNombre, float precio, int id)
        {
            using (SqlConnection conn = new SqlConnection(m.getConnectionString2()))
            {
                try
                {
                    conn.Open();

                    // 🔹 Verificar si el categoriaID existe en la tabla Categoria antes de actualizar
                    if (!CategoriaExiste(ObtenerCategoriaID(categriaComboBox.Text)))
                    {
                        MessageBox.Show("Error: La categoría especificada no existe en la base de datos.");
                        return;
                    }

                    string query = "UPDATE Producto SET Nombre = @nuevoNombre, Precio = @precio, CategoriaID = @categoria WHERE Nombre = @nombreActual";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombreActual", nombreActual);
                        cmd.Parameters.AddWithValue("@nuevoNombre", nuevoNombre);
                        cmd.Parameters.AddWithValue("@precio", precio);
                        cmd.Parameters.AddWithValue("@categoria", ObtenerCategoriaID(categriaComboBox.Text));

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Producto actualizado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el producto para actualizar.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar producto: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private bool CategoriaExiste(int id)
        {
            using (SqlConnection conn = new SqlConnection(m.getConnectionString2()))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Categoria WHERE CategoriaID = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}
