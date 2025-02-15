using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async Task cargarProgressBarAsync()
        {   Random random = new Random();
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
                        progressBar1.Value = progressBar1.Value + 1 ;
                    }
                    else
                    {
                        
                        break;
                    }
                }
            }

            
                InicioSesion form = new InicioSesion();
                form.Show();
            this.Enabled = false;
            this.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
