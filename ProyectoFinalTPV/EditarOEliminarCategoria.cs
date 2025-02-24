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
    public partial class EditarOEliminarCategoria : Form
    {
        private string accion;
        private Metodos m;

        public EditarOEliminarCategoria(string accion)
        {   
            InitializeComponent();
            this.accion = accion;
            cargarAccion(accion);
            m = new Metodos();
        }

        private void categoriaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriaBindingSource.EndEdit();

        }

        private void EditarOEliminarCategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'restauranteTPVDataSet1.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.restauranteTPVDataSet1.Categoria);
            // TODO: esta línea de código carga datos en la tabla 'restauranteTPVDataSet1.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.restauranteTPVDataSet1.Categoria);

        }

        public void cargarAccion(string accion) {

            if (accion.Equals("eliminar")) {
                accionCategoriaTxt.Text = "Eliminar Categoria";
                cambiarCategoriaTextBox.Visible = false;
                cambiarCategoriaTXT.Visible = false;
            }
            if (accion.Equals("editar"))
            {
                accionCategoriaTxt.Text = "Editar Categoria";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (accion.Equals("eliminar"))
            {
               DialogResult respuesta =  MessageBox.Show("¿Estas seguro que quieres eliminar esta categoria?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.OK) {
                    EliminarCategoria(nombreComboBox.Text);
                }
            }
            if (accion.Equals("editar"))
            {
                DialogResult respuesta = MessageBox.Show("¿Estas seguro que quieres editar esta categoria?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (respuesta == DialogResult.OK)
                {
                    ActualizarCategoria(nombreComboBox.Text, cambiarCategoriaTXT.Text);
                }
            }
        }
        private void EliminarCategoria(string nombreCategoria)
        {
          
            string query = "DELETE FROM Categoria WHERE nombre = @nombre";

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
        private void ActualizarCategoria(string nombreActual, string nuevoNombre)
        {
            string query = "UPDATE Categoria SET nombre = @nuevoNombre WHERE nombre = @nombreActual";

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
            m.cerrarForm(this);
        }

        private void cambiarCategoriaTXT_Click(object sender, EventArgs e)
        {

        }
    }
}
