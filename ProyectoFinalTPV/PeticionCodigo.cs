using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalTPV
{
    public partial class PeticionCodigo : Form
    {
        private string codigo;
        public PeticionCodigo(string codigo)
        {
            this.codigo = codigo;
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (codigoTXT.Text.Length > 0) {
                codigoTXT.Text = codigoTXT.Text.Substring(0, codigoTXT.Text.Length - 1);
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            escribirCodigo("9");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            escribirCodigo("1");
        }

        public void escribirCodigo(String s) {
            if (codigoTXT.Text.Length < 4) {
                if (codigoTXT.Text != "0")
                {
                    codigoTXT.Text = codigoTXT.Text + s;
                }
                else {
                    codigoTXT.Text = s;
                } 
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button10_Click(object sender, EventArgs e)
        {
            escribirCodigo("0");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void codigoTXT_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (codigo.Equals(codigoTXT.Text))
            {
                MessageBox.Show("Codigo correcto");
            }
            else {
                MessageBox.Show("Codigo incorrecto");
            }
        }
    }
}
