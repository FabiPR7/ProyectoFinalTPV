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
            if (precioTextBox.Text == "" || categoriaNombre.Text == "")
            {
                MessageBox.Show("Rellena todos los datos");
            }
            else {
                if (accion == "eliminar") {
                    EliminarComida(nombreCambiarTxt.Text);
                }
                if (accion == "editar") {

                    
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
                categriaComboBox.Visible = false;
                categoriaNombre.Visible = false;
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
        private void ActualizarCategoria(string nombreActual, string nuevoNombre, float precio)
        {
            string query = "UPDATE Producto SET nombre = @nuevoNombre, precio = @precio,  WHERE nombre = @nombreActual";

            using (SqlConnection conn = new SqlConnection(m.getConnectionString2()))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombreActual", nombreActual);
                        cmd.Parameters.AddWithValue("@nuevoNombre", nuevoNombre);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Categoría actualizada correctamente.");

                        }
                        else
                        {
                            MessageBox.Show("No se encontró la categoría para actualizar.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar categoría: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          this.Close();
        }
    }
}
