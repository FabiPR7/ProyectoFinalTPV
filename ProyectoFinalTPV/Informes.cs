using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinalTPV.Clases;

namespace ProyectoFinalTPV
{
    public partial class Informes: Form
    {
        MiForm m;
        public Informes(string usuario)
        {
            InitializeComponent();
            m = new MiForm();
            m.adaptarForm(this);
            label2.Text = usuario;
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            m.cerrarForm(this);
        }

        private void hacerPedidoBtn_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm(new UsuariosReport());
            m.cargarForm(reportForm,this);
        }

        private void PagarPedido_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm(new Pedidos());
            m.cargarForm(reportForm, this);
        }

        private void verPedidoBtn_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm(new Comidas());
            m.cargarForm(reportForm, this);
        }
    }
}
