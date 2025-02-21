using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            m.adaptarForm(this);
        }

        private void Agregar_Categoria_Load(object sender, EventArgs e)
        {

        }
    }
}
