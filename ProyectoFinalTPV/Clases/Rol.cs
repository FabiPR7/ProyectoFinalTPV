using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalTPV.Clases
{
    /// <summary>
    /// Clase que representa un rol y proporciona métodos para interactuar con la base de datos.
    /// </summary>
    public class Rol
    {
        // Dependencia
        private MiForm m = new MiForm();

        /// <summary>
        /// Rellena un ComboBox con los nombres de los roles obtenidos de la base de datos.
        /// </summary>
        /// <param name="comboBox">ComboBox que se actualizará con los nombres de los roles.</param>
        public void rellenarRoles(ComboBox comboBox)
        {
            // Establece la conexión con la base de datos
            using (SqlConnection sqlConnection = new SqlConnection(m.getConnectionString()))
            {
                // Define la consulta SQL para obtener los nombres de los roles
                string query = "SELECT Nombre FROM Roles";
                SqlCommand command = new SqlCommand(query, sqlConnection);

                // Abre la conexión y ejecuta la consulta
                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();

                // Limpia el ComboBox antes de agregar nuevos elementos
                comboBox.Items.Clear();

                // Recorre los resultados y agrega los nombres de los roles al ComboBox
                while (reader.Read())
                {
                    comboBox.Items.Add(reader["Nombre"].ToString());
                }
            }
        }
    }
}
