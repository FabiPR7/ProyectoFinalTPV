﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinalTPV.Clases;

namespace ProyectoFinalTPV
{
    public partial class EditarOEliminarCategoria : Form
    {
        private string accion;
        private MiForm m;
        Categoria c;
        public EditarOEliminarCategoria(string accion)
        {   
            InitializeComponent();
            this.accion = accion;
            cargarAccion(accion);
            m = new MiForm();
            c = new Categoria();
        }

        private void categoriaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriaBindingSource.EndEdit();

        }

        private void EditarOEliminarCategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'restauranteTPVDataSet1.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.restauranteTPVDataSet1.Categoria);
            // TODO: esta línea de código carga datos en la tabla 'restauranteTPVDataSet1.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.restauranteTPVDataSet1.Categoria);

        }

        public void cargarAccion(string accion) {

            if (accion.Equals("eliminar")) {
                accionCategoriaTxt.Text = "Eliminar Categoria";
                cambiarCategoriaTextBox.Visible = false;
                cambiarCategoriaTXT.Visible = false;
            }
            if (accion.Equals("editar"))
            {
                accionCategoriaTxt.Text = "Editar Categoria";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (accion.Equals("eliminar"))
            {
               DialogResult respuesta =  MessageBox.Show("¿Estas seguro que quieres eliminar esta categoria?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.OK) {
                   c.EliminarCategoria(nombreComboBox.Text);
                }
            }
            if (accion.Equals("editar"))
            {
                DialogResult respuesta = MessageBox.Show("¿Estas seguro que quieres editar esta categoria?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (respuesta == DialogResult.OK)
                {
                    c.ActualizarCategoria(nombreComboBox.Text, cambiarCategoriaTextBox.Text);
                }
            }
        }
     
        private void button2_Click(object sender, EventArgs e)
        {
            m.cerrarForm(this);
        }
    }
}
