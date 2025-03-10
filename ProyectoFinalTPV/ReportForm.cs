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
using ProyectoFinalTPV.Informes.Comidas;
using ProyectoFinalTPV.Informes.Pedidos;
using ProyectoFinalTPV.Informes.Usuarios;

namespace ProyectoFinalTPV
{
    public partial class ReportForm : Form
    {
        // Instancia de la clase MiForm para manejar operaciones relacionadas con el formulario.
        MiForm m;

        /// <summary>
        /// Constructor de la clase ReportForm.
        /// Inicializa los componentes del formulario y configura el informe inicial.
        /// </summary>
        /// <param name="mireporte">Informe que se mostrará inicialmente en el CrystalReportViewer.</param>
        public ReportForm(ReportClass mireporte)
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
            m = new MiForm();      // Crea una instancia de la clase MiForm.
            m.adaptarForm(this);   // Adapta el formulario actual.
            crystalReportViewer1.ReportSource = mireporte; // Configura el informe inicial.
        }

        /// <summary>
        /// Maneja el evento Click del menú "Pedidos".
        /// Carga y muestra el informe de pedidos en el CrystalReportViewer.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProyectoFinalTPV.Informes.Pedidos.Pedidos pedidos = new ProyectoFinalTPV.Informes.Pedidos.Pedidos();
            crystalReportViewer1.ReportSource = pedidos; // Carga el informe de pedidos.
        }

        /// <summary>
        /// Maneja el evento Click del menú "Usuarios".
        /// Carga y muestra el informe de usuarios en el CrystalReportViewer.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProyectoFinalTPV.Informes.Usuarios.UsuariosReport usuarios = new ProyectoFinalTPV.Informes.Usuarios.UsuariosReport();
            crystalReportViewer1.ReportSource = usuarios; // Carga el informe de usuarios.
        }

        /// <summary>
        /// Maneja el evento Click del menú "Comidas".
        /// Carga y muestra el informe de comidas en el CrystalReportViewer.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void comidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProyectoFinalTPV.Informes.Comidas.Comidas comidas = new ProyectoFinalTPV.Informes.Comidas.Comidas();
            crystalReportViewer1.ReportSource = comidas; // Carga el informe de comidas.
        }

        /// <summary>
        /// Maneja el evento Click del menú "Salir".
        /// Cierra el formulario actual.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m.cerrarForm(this); // Cierra el formulario actual.
        }

        /// <summary>
        /// Maneja el evento Load del CrystalReportViewer.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            // Este método está vacío y puede ser utilizado para manejar eventos de carga del CrystalReportViewer.
        }

        /// <summary>
        /// Maneja el evento Click del menú "Comida".
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void comidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Este método está vacío y puede ser utilizado para manejar eventos relacionados con el menú "Comida".
        }

        /// <summary>
        /// Maneja el evento Click del menú "Todos" (Comidas).
        /// Carga y muestra el informe de todas las comidas en el CrystalReportViewer.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProyectoFinalTPV.Informes.Comidas.Comidas comidas = new ProyectoFinalTPV.Informes.Comidas.Comidas();
            crystalReportViewer1.ReportSource = comidas; // Carga el informe de todas las comidas.
        }

        /// <summary>
        /// Maneja el evento Click del menú "Venta de Comidas".
        /// Carga y muestra el informe de ventas de comidas en el CrystalReportViewer.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void ventaDeComidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProyectoFinalTPV.Informes.Comidas.Ventas ventas = new ProyectoFinalTPV.Informes.Comidas.Ventas();
            crystalReportViewer1.ReportSource = ventas; // Carga el informe de ventas de comidas.
        }

        /// <summary>
        /// Maneja el evento Click del menú "Busca por Categoría".
        /// Carga y muestra el informe de comidas por categoría en el CrystalReportViewer.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void buscaPorCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProyectoFinalTPV.Informes.Comidas.ComidaPorCategoria comida = new ProyectoFinalTPV.Informes.Comidas.ComidaPorCategoria();
            crystalReportViewer1.ReportSource = comida; // Carga el informe de comidas por categoría.
        }

        /// <summary>
        /// Maneja el evento Click del menú "Todos" (Usuarios).
        /// Carga y muestra el informe de todos los usuarios en el CrystalReportViewer.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void todosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProyectoFinalTPV.Informes.Usuarios.UsuariosReport usuarios = new ProyectoFinalTPV.Informes.Usuarios.UsuariosReport();
            crystalReportViewer1.ReportSource = usuarios; // Carga el informe de todos los usuarios.
        }

        /// <summary>
        /// Maneja el evento Click del menú "Admin".
        /// Carga y muestra el informe de administradores en el CrystalReportViewer.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProyectoFinalTPV.Informes.Usuarios.admin admi = new ProyectoFinalTPV.Informes.Usuarios.admin();
            crystalReportViewer1.ReportSource = admi; // Carga el informe de administradores.
        }

        /// <summary>
        /// Maneja el evento Click del menú "Empleados".
        /// Carga y muestra el informe de empleados en el CrystalReportViewer.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProyectoFinalTPV.Informes.Usuarios.Empleados empleados = new ProyectoFinalTPV.Informes.Usuarios.Empleados();
            crystalReportViewer1.ReportSource = empleados; // Carga el informe de empleados.
        }

        /// <summary>
        /// Maneja el evento Click del menú "Todos" (Pedidos).
        /// Carga y muestra el informe de todos los pedidos en el CrystalReportViewer.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void todosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ProyectoFinalTPV.Informes.Pedidos.Pedidos pedidos = new ProyectoFinalTPV.Informes.Pedidos.Pedidos();
            crystalReportViewer1.ReportSource = pedidos; // Carga el informe de todos los pedidos.
        }

        /// <summary>
        /// Maneja el evento Click del menú "Pagados".
        /// Carga y muestra el informe de pedidos pagados en el CrystalReportViewer.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void pagadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProyectoFinalTPV.Informes.Pedidos.Pagados pagados = new ProyectoFinalTPV.Informes.Pedidos.Pagados();
            crystalReportViewer1.ReportSource = pagados; // Carga el informe de pedidos pagados.
        }

        /// <summary>
        /// Maneja el evento Click del menú "No Pagados".
        /// Carga y muestra el informe de pedidos no pagados en el CrystalReportViewer.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void noPagadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProyectoFinalTPV.Informes.Pedidos.NoPagados nopagados = new ProyectoFinalTPV.Informes.Pedidos.NoPagados();
            crystalReportViewer1.ReportSource = nopagados; // Carga el informe de pedidos no pagados.
        }
    }
}
