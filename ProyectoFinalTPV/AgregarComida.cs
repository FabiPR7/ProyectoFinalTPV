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
    public partial class AgregarComida : Form
    {
        Producto p;
        Categoria c;
        public AgregarComida()
        {
            InitializeComponent();
            p = new Producto();
            c = new Categoria();
            c.cargarAComboBox(nombreCategoriaComboBox);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nombreCategoriaComboBox.Text == "" || precioTextBox.Text == "" || nombreTextBox.Text == "")
            {
                MessageBox.Show("Rellena todos los datos");
            }
            else {            
                p.agregarComida(nombreTextBox.Text, float.Parse(precioTextBox.Text), c.ObtenerIdPorNombre(nombreCategoriaComboBox.Text));
                  this.Close();
            }
        }

    }
}
