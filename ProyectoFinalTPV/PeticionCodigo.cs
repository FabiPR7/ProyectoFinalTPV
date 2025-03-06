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
using ProyectoFinalTPV.Clases;

namespace ProyectoFinalTPV
{
    public partial class PeticionCodigo : Form
    {
        public bool codigoBooleano { get; private set; }
        private string codigo;
        public PeticionCodigo(string codigo)
        {
            this.codigo = codigo;
            codigoBooleano = false;
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (codigoTXT.Text.Length > 0) {
                codigoTXT.Text = codigoTXT.Text.Substring(0, codigoTXT.Text.Length - 1);
            }
            
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
      private void Button_Click(object sender, EventArgs e)
{
    Button btn = sender as Button;
    if (btn != null)
    {
        escribirCodigo(btn.Text);
    }
}
        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (codigo.Equals(codigoTXT.Text))
            {
                codigoBooleano = true;
                this.Close();
            }
            else {
               MessageBox.Show("Código incorrecto");
            }
        }
    }
}
