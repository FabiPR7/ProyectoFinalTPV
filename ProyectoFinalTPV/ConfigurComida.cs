using System;
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
    public partial class ConfigurComida : Form
    {
        MiForm m;
        Categoria c;
        List<Producto> productos;

        public ConfigurComida()
        {
            InitializeComponent();
            m = new MiForm();
            c = new Categoria();
            productos = new List<Producto>();
            m.adaptarForm(this);
        }
        private void ConfigurComida_Load(object sender, EventArgs e)
        {

            c.CargarCategorias(listaCategorias);
        }
        private void listaCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaComidas.Items.Clear();
            if (listaCategorias.SelectedItem != null) {
                productos = new Producto().ObtenerProductosPorCategoria(c.ObtenerIdPorNombre(listaCategorias.SelectedItem.ToString()));
                foreach (Producto prod in productos) {
                    listaComidas.Items.Add(prod.Nombre);
                } 
            }
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Agregar_Categoria agregar_Categoria = new Agregar_Categoria();
            agregar_Categoria.ShowDialog();
            c.CargarCategorias(listaCategorias);
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarComida agregar_Comida = new AgregarComida();
           agregar_Comida.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarOEliminarComida editarOEliminarComida = new EditarOEliminarComida("editar");
            editarOEliminarComida.ShowDialog();
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditarOEliminarCategoria editarOEliminarCategoria = new EditarOEliminarCategoria("editar");
            editarOEliminarCategoria.ShowDialog();
            c.CargarCategorias(listaCategorias);
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditarOEliminarCategoria editarOEliminarCategoria = new EditarOEliminarCategoria("eliminar");
            editarOEliminarCategoria.ShowDialog();
              c.CargarCategorias(listaCategorias);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarOEliminarComida editarOEliminarComida = new EditarOEliminarComida("eliminar");
            editarOEliminarComida.ShowDialog();
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            m.cerrarForm(this);
        }
    }
}      
