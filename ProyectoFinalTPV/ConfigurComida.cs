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

namespace ProyectoFinalTPV
{
    public partial class ConfigurComida : Form
    {
       private string usuario = "";
        Metodos m = new Metodos();
        HacerPedido HacerPedido;
      List<HacerPedido.Producto > productos = new List<HacerPedido.Producto> ();

        public ConfigurComida()
        {
            InitializeComponent();
            HacerPedido = new HacerPedido(usuario);
            m.adaptarForm(this);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void listaComidas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void ConfigurComida_Load(object sender, EventArgs e)
        {
            CargarCategorias();

        }
        private void CargarCategorias()
        {
            string query = "SELECT CategoriaID, nombre FROM Categoria";
            listaCategorias.Items.Clear();
            using (SqlConnection conn = new SqlConnection(m.getConnectionString2()))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listaCategorias.Items.Add($"{reader["nombre"]}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void listaCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaComidas.Items.Clear();
         productos =  HacerPedido.ObtenerProductosPorCategoria(HacerPedido.ObtenerIdPorNombre(listaCategorias.SelectedItem.ToString()));
            foreach (HacerPedido.Producto prod in productos) { 
                listaComidas.Items.Add(prod.Nombre);
            }
        }

        private void listaCategorias_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Agregar_Categoria agregar_Categoria = new Agregar_Categoria();
            agregar_Categoria.ShowDialog();
            CargarCategorias();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarComida agregar_Comida = new AgregarComida();
           agregar_Comida.ShowDialog();
            CargarCategorias();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarOEliminarComida editarOEliminarComida = new EditarOEliminarComida("editar");
            editarOEliminarComida.ShowDialog();
            CargarCategorias();
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditarOEliminarCategoria editarOEliminarCategoria = new EditarOEliminarCategoria("editar");
            editarOEliminarCategoria.ShowDialog();
            CargarCategorias();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditarOEliminarCategoria editarOEliminarCategoria = new EditarOEliminarCategoria("eliminar");
            editarOEliminarCategoria.ShowDialog();
            CargarCategorias();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarOEliminarComida editarOEliminarComida = new EditarOEliminarComida("eliminar");
            editarOEliminarComida.ShowDialog();
            CargarCategorias();
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            m.cerrarForm(this);
        }
    }
}      
