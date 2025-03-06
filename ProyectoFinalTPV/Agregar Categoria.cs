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
    public partial class Agregar_Categoria : Form
    {
        Categoria c;
        public Agregar_Categoria()
        {
            InitializeComponent();
            c = new Categoria();
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
                    c.AgregarCategoria(nombreTextBox.Text,this);
                }
            }
        }
    }
}
