using System;

public class Usuario
{
	public Usuario()
	{
	}
    public bool VerificarSiHayUsuarios()
    {

        string query = "SELECT COUNT(*) FROM Usuario";

        using (SqlConnection connection = new SqlConnection(m.getConnectionString()))
        {
            try
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    int cantidadUsuarios = (int)command.ExecuteScalar();

                    return cantidadUsuarios > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar usuarios: " + ex.Message);
                return false;
            }
        }
    }
}
