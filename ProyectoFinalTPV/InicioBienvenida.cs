using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalTPV
{
    public partial class InicioBienvenida : Form
    {
        public InicioBienvenida()
        {
            InitializeComponent();
            cargarProgressBarAsync();
        }

        private async Task cargarProgressBarAsync()
        {
            Random random = new Random();
            for (int i = 0; i <= 100; i++)
            {
                if (i < 80)
                {
                    i += random.Next(20);
                    progressBar1.Value = i;
                    await Task.Delay(random.Next(1000));
                }
                else
                {
                    if (i <= 100)
                    {
                        progressBar1.Value = progressBar1.Value + 1;
                    }
                    else
                    {

                        break;
                    }
                }
            }


            InicioSesion form = new InicioSesion();
            Metodos metodos = new Metodos();
            metodos.cargarForm(form, this);


        }

        private void InicioBienvenida_Load(object sender, EventArgs e)
        {

        }
    }

    class Metodos
    {

        private string connectionString = "Data Source=FabiPadilla07\\SQLEXPRESS01;Initial Catalog=RestauranteTPV;Integrated Security=True;Encrypt=False";
        private string connectionString2 = "Data Source=C06PC13\\SQLEXPRESS;Initial Catalog=RestauranteTPV;Integrated Security=True;Encrypt=False";
        public void cargarForm(Form formCargar, Form actual)
        {
            formCargar.Dock = DockStyle.Fill;
            actual.Controls.Add(formCargar);
            formCargar.BringToFront();
            formCargar.Show();
        }

        public void adaptarForm(Form form)
        {
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
        }

        public void cerrarForm(Form form)
        {
            form.Close();
        }

        public String getConnectionString()
        {
            return connectionString;
        }
        public String getConnectionString2()
        {
            return connectionString2;
        }
    }
}
