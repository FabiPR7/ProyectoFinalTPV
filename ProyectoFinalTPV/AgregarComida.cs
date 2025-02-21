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
    public partial class AgregarComida : Form
    {
        Metodos m = new Metodos();
        public AgregarComida()
        {
            InitializeComponent();
            m.adaptarForm(this);
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
    }
}
