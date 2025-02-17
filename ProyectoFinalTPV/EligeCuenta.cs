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

namespace ProyectoFinalTPV
{
    public partial class EligeCuenta: Form
    {
        Metodos metodos = new Metodos();
        private string nombreUsuario = "";
        private string accion;

        public EligeCuenta(string accion)
        {
            InitializeComponent();
            metodos.adaptarForm(this);
            this.accion = accion;
            visibilizarBotones();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EligeCuenta_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombreUsuario = btn1.Text;
            activarPeticionCodigo();
         
        }

        private void button5_Click(object sender, EventArgs e)
        {    nombreUsuario = btn5.Text;
            activarPeticionCodigo();

         
        }

        private void button4_Click(object sender, EventArgs e)
        { nombreUsuario = btn4.Text;
            activarPeticionCodigo();

           
        }

        private void button6_Click(object sender, EventArgs e)
        {  nombreUsuario = btn6.Text;
            activarPeticionCodigo();
        }


        private void btn10_Click(object sender, EventArgs e)
        { nombreUsuario = btn10.Text;
            activarPeticionCodigo();
        }

        private void btn2_Click(object sender, EventArgs e)
        {  nombreUsuario = btn2.Text;
            activarPeticionCodigo();
          
        }

        private void btn3_Click(object sender, EventArgs e)
        { nombreUsuario = btn3.Text;
            activarPeticionCodigo();
           
        }

        private void btn7_Click(object sender, EventArgs e)
        { nombreUsuario = btn7.Text;
            activarPeticionCodigo();
           
        }

        private void btn8_Click(object sender, EventArgs e)
        {nombreUsuario = btn8.Text;
            activarPeticionCodigo();
            
        }

        private void btn9_Click(object sender, EventArgs e)
        {  nombreUsuario = btn9.Text;
            activarPeticionCodigo();
          
        }

        private void btn11_Click(object sender, EventArgs e)
        { nombreUsuario = btn2.Text;
            activarPeticionCodigo();
           
        }

        private void btn12_Click(object sender, EventArgs e)
        {  nombreUsuario = btn2.Text;
            activarPeticionCodigo();
          
        }

        private void btn13_Click(object sender, EventArgs e)
        {nombreUsuario = btn13.Text;
            activarPeticionCodigo();

            
        }

        private void btn14_Click(object sender, EventArgs e)
        {   nombreUsuario = btn14.Text;
            activarPeticionCodigo();

            
        }

        private void btn15_Click(object sender, EventArgs e)
        {  nombreUsuario = btn15.Text;
            activarPeticionCodigo();
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
            string[] nombresUsuarios = obtenerNombresUsuarios();
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


        private string[] obtenerNombresUsuarios()
        {
            string query = "SELECT Nombre FROM Usuario";
            using (SqlConnection connection = new SqlConnection(metodos.getConnectionString2()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            List<string> nombres = new List<string>();


                            while (reader.Read())
                            {
                                string nombre = reader["Nombre"].ToString();
                                nombres.Add(nombre);
                            }

                            return nombres.ToArray();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los nombres de los usuarios: " + ex.Message);
                    return null;
                }
            }

        }
        public int ObtenerUsuarioIDPorNombre(string nombre)
        {
            string query = "SELECT UsuarioID FROM Usuario WHERE Nombre = @Nombre";
            using (SqlConnection connection = new SqlConnection(metodos.getConnectionString2()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Nombre", nombre);

                        object result = command.ExecuteScalar();


                        if (result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                        else
                        {
                            return -1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el UsuarioID: " + ex.Message);
                    return -1;
                }
            }
        }
        public void activarPeticionCodigo()
        {
            if (accion.Equals("elegir"))
            {
                PeticionCodigo p = new PeticionCodigo(obtenerCodigo());
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
                     int id = ObtenerUsuarioIDPorNombre(getNombreUsuario());
                        if (id != -1)
                        {
                            eliminarUsuario(id);
                        MessageBox.Show("Usuario eliminado,cerrar aplicación para notar cambios");
                        }
                }
              
              
            }
        }

        public void eliminarUsuario(int id)
        {
            string sql = "DELETE FROM Usuario WHERE UsuarioID = @UsuarioID";
            using (SqlConnection connection = new SqlConnection(metodos.getConnectionString2()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@UsuarioID", id);
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Usuario eliminado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el usuario.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
                }
            }
        }
        public string obtenerCodigo() {
            return ObtenerUsuarioIDPorNombre(getNombreUsuario()).ToString();
        }

        public string getNombreUsuario() { 
            return nombreUsuario;
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            metodos.cerrarForm(this);
        }
    }
}
