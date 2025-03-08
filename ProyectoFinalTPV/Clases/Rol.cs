using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalTPV.Clases
{
    class Rol
    {
        MiForm m = new MiForm();
        public void rellenarRoles(ComboBox comboBox) {
            SqlConnection sqlConnection = new SqlConnection(m.getConnectionString());
            SqlCommand comadno = new SqlCommand("select Nombre from Roles",sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = comadno.ExecuteReader();
            while (sqlDataReader.Read()) {
                comboBox.Items.Add(sqlDataReader["Nombre"]);
            }
            
        }
    }
}
