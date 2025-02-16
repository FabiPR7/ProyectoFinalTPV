using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalTPV
{
    public partial class EligeCuenta: Form
    {
        Metodos metodos = new Metodos();
        public EligeCuenta()
        {
            InitializeComponent();
            metodos.adaptarForm(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EligeCuenta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btn10_Click(object sender, EventArgs e)
        {

        }

        public void listBotones() { 
        List<Button> botones = new List<Button>();
            botones.Add(btn1);
            botones.Add(btn2);
            botones.Add(btn3);
            botones.Add(btn4);
            botones.Add(btn5);
            botones.Add(btn6);
            botones.Add(btn7);
            botones.Add(btn8);
            botones.Add(btn9);
            botones.Add(btn10);
            botones.Add(btn11);
            botones.Add(btn12);
            botones.Add(btn13);
            botones.Add(btn14);
            botones.Add(btn15);


        }
    }
}
