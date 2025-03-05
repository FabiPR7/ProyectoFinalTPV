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
using static ProyectoFinalTPV.VerPedidos;

namespace ProyectoFinalTPV
{
    public partial class PagarPedido : Form
    {
        VerPedidos verPedidos;
        Metodos Metodos;
        public PagarPedido()
        {
            Metodos = new Metodos();
            Metodos.adaptarForm(this);
            verPedidos = new VerPedidos();
            InitializeComponent();
            ActualizarListView(verPedidos.ObtenerNoPagados());
        }

        public void ActualizarListView(List<Pedido> pedidos)
        {
            listBox1.Items.Clear();
            string inicio = "MESA               PRECIO               FECHA                PAGADO";    
            listBox1.Items.Add(inicio);
            foreach (var pedido in pedidos)
            {
                string item = pedido.Mesa.ToString() +"                          " +pedido.PrecioTotal.ToString()+"€" + 
                    "            " + pedido.Fecha.ToString("dd/MM/yyyy HH:mm") + "        " + (pedido.Pagado ? "Sí" : "No");
                listBox1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null) {
                PagarVentana pagarVentana = new PagarVentana(listBox1.SelectedItem.ToString());
                pagarVentana.ShowDialog();
                ActualizarListView(verPedidos.ObtenerNoPagados());
             }
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            Metodos.cerrarForm(this);
        }
    }
}
