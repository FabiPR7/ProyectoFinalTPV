using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinalTPV.Clases;

namespace ProyectoFinalTPV
{
    public partial class PagarVentana : Form
    {
        string pedido;
        Pedido p;
        public PagarVentana(string pedido)
        {
            this.pedido = pedido;
            InitializeComponent();
            p = new Pedido();
            string patron = @"\d+,\d{2}€";
            Match match = Regex.Match(pedido, patron);
            precio.Text = match.Value;
        }
        private void Button_Click(object sender, EventArgs e)
        {    
            Button btn = sender as Button;
            if (btn != null)
            {
                escribirCodigo(btn.Text);
            }
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
                p.ActualizarPedidoAPagado(numeroMesa, fechaPedido);
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
    }
    }
