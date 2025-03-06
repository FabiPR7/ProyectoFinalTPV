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
    public partial class VerPedidos : Form
    {
        MiForm m;
        Pedido p;
        public VerPedidos()
        {
            InitializeComponent();
            m = new MiForm();
            p = new Pedido();
            m.adaptarForm(this);
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            m.cerrarForm(this);
        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton1.Checked)
            {
                p.ActualizarListView(p.ObtenerTodos(),listView1);
            }
        }

        private void radioButton3_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton3.Checked)
            {
                p.ActualizarListView(p.ObtenerPagados(),listView1);
            }
        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton2.Checked)
            {
                p.ActualizarListView(p.ObtenerNoPagados(), listView1);
            }
        }
    }
}


