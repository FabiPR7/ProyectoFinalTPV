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
    public partial class MenuPrincipal : Form
    {
        Metodos m = new Metodos();
       private string nombreUsuario;
        public MenuPrincipal(string nombreUsuario)
        {

            InitializeComponent();
            m.adaptarForm(this);
            this.nombreUsuario = nombreUsuario;
            nombreUs.Text = nombreUsuario;
        }

        private void perfilButton_Click(object sender, EventArgs e)
        {
            AdministrarCuenta administrarCuenta = new AdministrarCuenta(nombreUsuario);
            m.cargarForm(administrarCuenta, this);
        }
    }
}
