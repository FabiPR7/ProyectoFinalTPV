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
    public partial class AdministrarCuenta: Form
    {
       private Metodos m = new Metodos();
        public AdministrarCuenta(string nombre)
        {
            InitializeComponent();
            m.adaptarForm(this);
            nombreUs.Text = nombre;
        }

        private void cambiarUsBtn_Click(object sender, EventArgs e)
        {
            EligeCuenta eligeCuenta = new EligeCuenta("elegir");
            m.cargarForm(eligeCuenta, this);
        }

        private void cerrarSesionBtn_Click(object sender, EventArgs e)
        {
            InicioSesion inicioSesion = new InicioSesion();
            m.cargarForm(inicioSesion, this);
        }

        private void AgregarUsBtn_Click(object sender, EventArgs e)
        {
            AgregarEmpleado agregarEmpleado = new AgregarEmpleado();
            m.cargarForm(agregarEmpleado, this);
        }

        private void eliminarUsBtn_Click(object sender, EventArgs e)
        {
            EligeCuenta eligeCuenta = new EligeCuenta("eliminar");
            m.cargarForm(eligeCuenta, this);
        }
    }
}
