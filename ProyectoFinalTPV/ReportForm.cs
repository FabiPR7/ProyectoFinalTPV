using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using ProyectoFinalTPV.Clases;

namespace ProyectoFinalTPV
{
    public partial class ReportForm: Form
    {
        MiForm m;   
        public ReportForm(ReportClass mireporte)
        {
            InitializeComponent();
            m = new MiForm();
            m.adaptarForm(this);
            crystalReportViewer1.ReportSource = mireporte;
        }
        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            crystalReportViewer1.ReportSource = pedidos;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosReport pedidos = new UsuariosReport();
            crystalReportViewer1.ReportSource = pedidos;
        }

        private void comidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comidas pedidos = new Comidas();
            crystalReportViewer1.ReportSource = pedidos;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m.cerrarForm(this);
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
