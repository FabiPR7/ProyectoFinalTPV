using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalTPV
{
    public partial class PagarVentana : Form
    {
        string pedido;
        public PagarVentana(string pedido)
        {
            this.pedido = pedido;
            InitializeComponent();
            string patron = @"\d+,\d{2}€";
            Match match = Regex.Match(pedido, patron);
            precio.Text = match.Value;
        }

        private void button11_Click(object sender, EventArgs e)
        {
          

        }



        public void escribirCodigo(String s)
        {
            if (codigoTXT.Text.Length < 100)
            {
                if (codigoTXT.Text != "0")
                {
                    codigoTXT.Text = codigoTXT.Text + s;
                }
                else
                {
                    codigoTXT.Text = s;
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            escribirCodigo("1");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            escribirCodigo("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            escribirCodigo("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            escribirCodigo("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            escribirCodigo("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            escribirCodigo("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            escribirCodigo("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            escribirCodigo("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            escribirCodigo("9");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            escribirCodigo(".");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            escribirCodigo("0");
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            if (codigoTXT.Text.Length > 0)
            {
                codigoTXT.Text = codigoTXT.Text.Substring(0, codigoTXT.Text.Length - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = true;
            b4.Enabled = true;
            b5.Enabled = true;
            b6.Enabled = true;
            b7.Enabled = true;
            b8.Enabled = true;
            b9.Enabled = true;
            b0.Enabled = true;
            bpunto.Enabled = true;
            baceptar.Enabled = true;
            bborrar.Enabled = true;
            codigoTXT.Enabled = true;
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void baceptar_Click(object sender, EventArgs e)
        {
            if (decimal.Parse(precio.Text.Substring(0,precio.Text.IndexOf("€"))) > decimal.Parse(codigoTXT.Text))
            {

                MessageBox.Show("El importe dado es menor que el costo del pedido");
            }
            else {
                if (decimal.Parse(precio.Text.Substring(0, precio.Text.IndexOf("€"))) < decimal.Parse(codigoTXT.Text))
                {
                    decimal precioDecimal = decimal.Parse(precio.Text.Substring(0, precio.Text.IndexOf("€")));
                    decimal importeDecimal = decimal.Parse(codigoTXT.Text);
                    MessageBox.Show("Cambio: " + (importeDecimal - precioDecimal));

                }
                else {
                    MessageBox.Show("Cambio: 0.00");
                }
                int numeroMesa = ExtraerNumeroMesa(pedido);      
                DateTime fechaPedido = ExtraerFecha(pedido);
                ActualizarPedidoAPagado(numeroMesa, fechaPedido);
                MessageBox.Show("Pedido pagado");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No se detecta un datafono conectado");
        }

        public static int ExtraerNumeroMesa(string input)
        {
            string patron = @"^\d+"; // Coincide con el primer número en el string
            Match match = Regex.Match(input, patron);

            if (match.Success)
            {
                return int.Parse(match.Value); // Convertir a entero
            }
            else
            {
                throw new Exception("No se encontró el número de mesa.");
            }
        }



        // Método para extraer la fecha
        public static DateTime ExtraerFecha(string input)
        {
            string patron = @"\d{2}/\d{2}/\d{4} \d{2}:\d{2}"; // Coincide con el formato dd/MM/yyyy HH:mm
            Match match = Regex.Match(input, patron);

            if (match.Success)
            {
                return DateTime.ParseExact(match.Value, "dd/MM/yyyy HH:mm", null); // Convertir a DateTime
            }
            else
            {
                throw new Exception("No se encontró la fecha.");
            }
        }

        public static void ActualizarPedidoAPagado(int numeroMesa, DateTime fechaPedido)
        {
         
            string query = @"
            UPDATE Pedido
            SET Pagado = 1
            WHERE MesaID = @MesaID AND FechaPedido = @Fecha";

            using (SqlConnection connection = new SqlConnection(new Metodos().getConnectionString2()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MesaID", numeroMesa);
                command.Parameters.AddWithValue("@Fecha", fechaPedido);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Pedido actualizado a Pagado correctamente.");
                }
                else
                {
                    Console.WriteLine("No se encontró el pedido con la mesa y fecha especificadas.");
                }
            }
        }
    }
    }
