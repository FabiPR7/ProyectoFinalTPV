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
    public partial class InicioSesion: Form
    {
        private MiForm m = new MiForm();
      
        public InicioSesion()
        {
            InitializeComponent();
            m.adaptarForm(this);
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            if (u.verificarSiHayUsuarios())
            {
             iniciarSesionBtn.Enabled = true;
             crearCuentaBtn.Enabled = false;
             nohaycuentasTXT.Visible = false;
            }
            else
            {
                iniciarSesionBtn.Enabled = false;
                iniciarSesionBtn.Visible = false;
                crearCuentaBtn.Enabled = true;
                nohaycuentasTXT.Visible = true;
            }
        }
       
        private void crearCuentaBtn_Click(object sender, EventArgs e)
        {
            m.cargarForm(new AgregarEmpleado(), this);
        }

        private void iniciarSesionBtn_Click(object sender, EventArgs e)
        {
            m.cargarForm(new EligeCuenta("elegir"), this);
        }
    }
}
