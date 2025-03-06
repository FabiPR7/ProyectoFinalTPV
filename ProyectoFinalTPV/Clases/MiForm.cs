using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalTPV.Clases
{
    class MiForm
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

