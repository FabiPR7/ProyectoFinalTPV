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
    /// Clase que representa una mesa y proporciona métodos para interactuar con la base de datos.
    /// </summary>
    public class Mesa
    {
        // Instancia de la clase MiForm para obtener la cadena de conexión a la base de datos.
        private MiForm m = new MiForm();

        /// <summary>
        /// Rellena un ComboBox con los números de mesa obtenidos de la base de datos.
        /// </summary>
        /// <param name="comboBox">ComboBox que se desea rellenar con los números de mesa.</param>
        /// <remarks>
        /// Este método realiza una consulta a la base de datos para obtener los números de mesa
        /// y los agrega como ítems en el ComboBox proporcionado.
        /// </remarks>
        public void rellenarRoles(ComboBox comboBox)
        {
            // Creación de la conexión a la base de datos utilizando la cadena de conexión obtenida de MiForm.
            using (SqlConnection sqlConnection = new SqlConnection(m.getConnectionString()))
            {
                // Creación del comando SQL para seleccionar los números de mesa.
                using (SqlCommand comando = new SqlCommand("SELECT numMesa FROM Mesa", sqlConnection))
                {
                    // Apertura de la conexión a la base de datos.
                    sqlConnection.Open();

                    // Ejecución del comando y obtención de un lector de datos.
                    using (SqlDataReader sqlDataReader = comando.ExecuteReader())
                    {
                        // Recorre los resultados y agrega cada número de mesa al ComboBox.
                        while (sqlDataReader.Read())
                        {
                            comboBox.Items.Add(sqlDataReader["numMesa"].ToString());
                        }
                    }
                }
            }
        }
    }
}
