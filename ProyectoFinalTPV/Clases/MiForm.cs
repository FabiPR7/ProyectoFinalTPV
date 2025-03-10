using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalTPV.Clases
{
    /// <summary>
    /// Clase que proporciona métodos para gestionar formularios y obtener cadenas de conexión a la base de datos.
    /// </summary>
    public class MiForm
    {
        // Cadena de conexión a la base de datos para el servidor FabiPadilla07.
        private string connectionString = "Data Source=FabiPadilla07\\SQLEXPRESS01;Initial Catalog=RestauranteTPV;Integrated Security=True;Encrypt=False";

        // Cadena de conexión a la base de datos para el servidor C06PC13.
        private string connectionString2 = "Data Source=C06PC13\\SQLEXPRESS;Initial Catalog=RestauranteTPV;Integrated Security=True;Encrypt=False";

        /// <summary>
        /// Carga un formulario dentro de otro formulario y lo muestra.
        /// </summary>
        /// <param name="formCargar">Formulario que se desea cargar y mostrar.</param>
        /// <param name="actual">Formulario actual que contendrá al formulario cargado.</param>
        /// <remarks>
        /// Este método ajusta el formulario cargado para que ocupe todo el espacio disponible
        /// dentro del formulario actual y lo muestra en primer plano.
        /// </remarks>
        public void cargarForm(Form formCargar, Form actual)
        {
            formCargar.Dock = DockStyle.Fill; // Ajusta el formulario para que ocupe todo el espacio.
            actual.Controls.Add(formCargar);  // Agrega el formulario cargado al formulario actual.
            formCargar.BringToFront();        // Muestra el formulario cargado en primer plano.
            formCargar.Show();                // Hace visible el formulario cargado.
        }

        /// <summary>
        /// Adapta un formulario para que no tenga bordes y no sea de nivel superior.
        /// </summary>
        /// <param name="form">Formulario que se desea adaptar.</param>
        /// <remarks>
        /// Este método es útil para formularios que se cargarán dentro de otros formularios.
        /// </remarks>
        public void adaptarForm(Form form)
        {
            form.FormBorderStyle = FormBorderStyle.None; // Elimina los bordes del formulario.
            form.TopLevel = false;                       // Indica que el formulario no es de nivel superior.
        }

        /// <summary>
        /// Cierra un formulario.
        /// </summary>
        /// <param name="form">Formulario que se desea cerrar.</param>
        public void cerrarForm(Form form)
        {
            form.Close(); // Cierra el formulario.
        }

        /// <summary>
        /// Obtiene la cadena de conexión a la base de datos para el servidor FabiPadilla07.
        /// </summary>
        /// <returns>La cadena de conexión configurada.</returns>
        public String getConnectionString()
        {
            return connectionString;
        }
    }
}

