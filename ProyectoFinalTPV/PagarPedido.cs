using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinalTPV.Clases;
using static ProyectoFinalTPV.VerPedidos;

namespace ProyectoFinalTPV
{
    public partial class PagarPedido : Form
    {
        Pedido p;
        MiForm m;
        public PagarPedido()
        {           
            InitializeComponent();
            m = new MiForm();
            p = new Pedido();
            m.adaptarForm(this);
           p.ActualizarListBox(p.ObtenerNoPagados(),listBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null) {
                PagarVentana pagarVentana = new PagarVentana(listBox1.SelectedItem.ToString());
                pagarVentana.ShowDialog();
                p.ActualizarListBox(p.ObtenerNoPagados(),listBox1);
                UsuariosReport usuariosReport = new UsuariosReport();

             }
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            m.cerrarForm(this);
        }
    }
}
