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
        // Instancia de la clase MiForm para manejar operaciones relacionadas con el formulario.
        MiForm m;

        // Instancia de la clase Categoria para manejar operaciones relacionadas con categorías.
        Categoria c;

        // Lista de productos para almacenar los productos obtenidos de la base de datos.
        List<Producto> productos;

        /// <summary>
        /// Constructor de la clase ConfigurComida.
        /// Inicializa los componentes del formulario y crea instancias de las clases necesarias.
        /// </summary>
        public ConfigurComida()
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
            m = new MiForm();      // Crea una instancia de la clase MiForm.
            c = new Categoria();   // Crea una instancia de la clase Categoria.
            productos = new List<Producto>(); // Inicializa la lista de productos.
            m.adaptarForm(this);   // Adapta el formulario actual.
        }

        /// <summary>
        /// Maneja el evento Load del formulario.
        /// Carga las categorías en el ListBox correspondiente.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void ConfigurComida_Load(object sender, EventArgs e)
        {
            c.cargarCategoriasListBox(listaCategorias); // Carga las categorías en el ListBox.
        }

        /// <summary>
        /// Maneja el evento SelectedIndexChanged del ListBox de categorías.
        /// Carga los productos de la categoría seleccionada en el ListBox de comidas.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void listaCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaComidas.Items.Clear(); // Limpia el ListBox de comidas.
            if (listaCategorias.SelectedItem != null)
            {
                // Obtiene los productos de la categoría seleccionada.
                productos = new Producto().obtenerProductosPorCategoria(
                    c.obtenerIdPorNombreCategoria(listaCategorias.SelectedItem.ToString())
                );

                // Agrega los nombres de los productos al ListBox de comidas.
                foreach (Producto prod in productos)
                {
                    listaComidas.Items.Add(prod.Nombre);
                }
            }
        }

        /// <summary>
        /// Maneja el evento Click del menú "Agregar Categoría".
        /// Abre el formulario para agregar una nueva categoría y recarga las categorías en el ListBox.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Agregar_Categoria agregar_Categoria = new Agregar_Categoria();
            agregar_Categoria.ShowDialog(); // Abre el formulario para agregar una categoría.
            c.cargarCategoriasListBox(listaCategorias); // Recarga las categorías en el ListBox.
        }

        /// <summary>
        /// Maneja el evento Click del menú "Agregar Comida".
        /// Abre el formulario para agregar una nueva comida.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarComida agregar_Comida = new AgregarComida();
            agregar_Comida.ShowDialog(); // Abre el formulario para agregar una comida.
        }

        /// <summary>
        /// Maneja el evento Click del menú "Editar Comida".
        /// Abre el formulario para editar una comida existente.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarOEliminarComida editarOEliminarComida = new EditarOEliminarComida("editar");
            editarOEliminarComida.ShowDialog(); // Abre el formulario para editar una comida.
        }

        /// <summary>
        /// Maneja el evento Click del menú "Editar Categoría".
        /// Abre el formulario para editar una categoría existente y recarga las categorías en el ListBox.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditarOEliminarCategoria editarOEliminarCategoria = new EditarOEliminarCategoria("editar");
            editarOEliminarCategoria.ShowDialog(); // Abre el formulario para editar una categoría.
            c.cargarCategoriasListBox(listaCategorias); // Recarga las categorías en el ListBox.
        }

        /// <summary>
        /// Maneja el evento Click del menú "Eliminar Categoría".
        /// Abre el formulario para eliminar una categoría existente y recarga las categorías en el ListBox.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditarOEliminarCategoria editarOEliminarCategoria = new EditarOEliminarCategoria("eliminar");
            editarOEliminarCategoria.ShowDialog(); // Abre el formulario para eliminar una categoría.
            c.cargarCategoriasListBox(listaCategorias); // Recarga las categorías en el ListBox.
        }

        /// <summary>
        /// Maneja el evento Click del menú "Eliminar Comida".
        /// Abre el formulario para eliminar una comida existente.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarOEliminarComida editarOEliminarComida = new EditarOEliminarComida("eliminar");
            editarOEliminarComida.ShowDialog(); // Abre el formulario para eliminar una comida.
        }

        /// <summary>
        /// Maneja el evento Click del botón "Volver".
        /// Cierra el formulario actual.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void volverBtn_Click(object sender, EventArgs e)
        {
            m.cerrarForm(this); // Cierra el formulario actual.
        }

        // Los siguientes métodos son duplicados de los métodos anteriores y realizan la misma funcionalidad.
        // Se recomienda eliminar estos duplicados para mantener el código limpio y evitar redundancias.

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AgregarComida agregar_Comida = new AgregarComida();
            agregar_Comida.ShowDialog();
        }

        private void editarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EditarOEliminarComida editarOEliminarComida = new EditarOEliminarComida("editar");
            editarOEliminarComida.ShowDialog();
        }

        private void eliminarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EditarOEliminarComida editarOEliminarComida = new EditarOEliminarComida("eliminar");
            editarOEliminarComida.ShowDialog();
        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Agregar_Categoria agregar_Categoria = new Agregar_Categoria();
            agregar_Categoria.ShowDialog();
            c.cargarCategoriasListBox(listaCategorias);
        }

        private void eliminarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            EditarOEliminarCategoria editarOEliminarCategoria = new EditarOEliminarCategoria("eliminar");
            editarOEliminarCategoria.ShowDialog();
            c.cargarCategoriasListBox(listaCategorias);
        }

        private void editarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            EditarOEliminarCategoria editarOEliminarCategoria = new EditarOEliminarCategoria("editar");
            editarOEliminarCategoria.ShowDialog();
            c.cargarCategoriasListBox(listaCategorias);
        }

        private void ConfigurComida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string rutaejecutable = System.IO.Directory.GetCurrentDirectory();
                System.Diagnostics.Process.Start(rutaejecutable + "\\chm\\Manual de RestauranteTPV.html");

            }
        }
    }
}      
