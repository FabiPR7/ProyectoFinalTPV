using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinalTPV.Clases;

namespace ProyectoFinalTPV
{
    public partial class EligeCuenta: Form
    {
        MiForm metodos;
        private string nombreUsuario = "";
        private string accion;
        Usuario u;

        public EligeCuenta(string accion)
        {
            InitializeComponent();
            metodos = new MiForm();
            u = new Usuario();
            metodos.adaptarForm(this);
            this.accion = accion;
            visibilizarBotones();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            // Convertir el sender a Button
            Button btn = sender as Button;

            // Verificar que el botón no sea nulo
            if (btn != null)
            {
                nombreUsuario = btn.Text;
                activarPeticionCodigo();
            }
        }
        public Button[] listBotones()
        {
            Button[] botones = new Button[15];
            botones[0] = btn1;
            botones[1] = btn2;
            botones[2] = btn3;
            botones[3] = btn4;
            botones[4] = btn5;
            botones[5] = btn6;
            botones[6] = btn7;
            botones[7] = btn8;
            botones[8] = btn9;
            botones[9] = btn10;
            botones[10] = btn11;
            botones[11] = btn12;
            botones[12] = btn13;
            botones[13] = btn14;
            botones[14] = btn15;
            return botones;
        }

        public void visibilizarBotones()
        {
            Button[] b = listBotones();
            string[] nombresUsuarios = u.obtenerNombresUsuarios();
            if (nombresUsuarios != null && nombresUsuarios.Length > 0)
            {

                int maxBotones = Math.Min(nombresUsuarios.Length, b.Length);
                for (int i = 0; i < maxBotones; i++)
                {
                    b[i].Visible = true;
                    b[i].Text = nombresUsuarios[i];
                }
            }
            else
            {
                MessageBox.Show("No se encontraron usuarios o hubo un error.");
            }
        }

        public void activarPeticionCodigo()
        {
            if (accion.Equals("elegir"))
            {
                PeticionCodigo p = new PeticionCodigo(u.obtenerCodigo(nombreUsuario));
                p.ShowDialog();
                bool codigo = p.codigoBooleano;
                if (codigo)
                {
                    MenuPrincipal menu = new MenuPrincipal(nombreUsuario);
                    metodos.cargarForm(menu, this);
                }
            }
            else if (accion.Equals("eliminar"))
            {
                DialogResult result = MessageBox.Show(
                            "¿Estás seguro de que quieres eliminar a este usuario?",
                             "Confirmación",                          
                             MessageBoxButtons.YesNo,                 
                             MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                     int id = u.ObtenerUsuarioIDPorNombre(nombreUsuario);
                        if (id != -1)
                        {
                            u.eliminarUsuario(id);
                        MessageBox.Show("Usuario eliminado,cerrar aplicación para notar cambios");
                        }
                }
              
              
            }
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            metodos.cerrarForm(this);
        }
    }
}
