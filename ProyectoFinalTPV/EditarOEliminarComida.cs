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
using ProyectoFinalTPV.Clases;

namespace ProyectoFinalTPV
{
    public partial class EditarOEliminarComida : Form
    {
        private string accion;
        private MiForm m;
        Producto p;
        Categoria c;
        public EditarOEliminarComida(string accion)
        {

            InitializeComponent();
            
            this.accion = accion;
            m = new MiForm();
            p = new Producto();
            c = new Categoria();
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
            this.categoriaTableAdapter.Fill(this.restauranteTPVDataSet1.Categoria);
            this.productoTableAdapter.Fill(this.restauranteTPVDataSet1.Producto);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (accion == "eliminar")
            {
                DialogResult resultado = MessageBox.Show("¿Estas seguro de eliminar el Producto: " + nombeAcambiarText.Text + "?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (resultado == DialogResult.OK)
                {
                    p.EliminarComida(nombeAcambiarText.Text);
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
                    p.ActualizarProdudcto(nombeAcambiarText.Text, textBox1.Text, float.Parse(precioTextBox.Text),c.CategoriaExiste(c.ObtenerIdPorNombre(categriaComboBox.Text)),c.ObtenerIdPorNombre(categriaComboBox.Text));
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


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
