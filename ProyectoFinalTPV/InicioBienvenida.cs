using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinalTPV.Clases;

namespace ProyectoFinalTPV
{
    /// <summary>
    /// Formulario de bienvenida que muestra una barra de progreso simulando una carga inicial.
    /// Una vez completada la carga, redirige al formulario de inicio de sesión.
    /// </summary>
    public partial class InicioBienvenida : Form
    {
        /// <summary>
        /// Constructor de la clase InicioBienvenida.
        /// Inicializa los componentes del formulario y comienza la carga de la barra de progreso.
        /// </summary>
        public InicioBienvenida()
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
            cargarProgressBarAsync(); // Inicia la carga de la barra de progreso.
        }

        /// <summary>
        /// Simula la carga de una barra de progreso de manera asíncrona.
        /// Una vez que la barra de progreso alcanza el 100%, redirige al formulario de inicio de sesión.
        /// </summary>
        /// <returns>Tarea asíncrona que representa la operación de carga.</returns>
        private async Task cargarProgressBarAsync()
        {
            Random random = new Random(); // Generador de números aleatorios para simular la carga.

            // Bucle para incrementar el valor de la barra de progreso.
            for (int i = 0; i <= 100; i++)
            {
                if (i < 80)
                {
                    // Incremento rápido de la barra de progreso.
                    i += random.Next(20); // Aumenta el valor de la barra de manera aleatoria.
                    progressBar1.Value = i; // Actualiza el valor de la barra de progreso.
                    await Task.Delay(random.Next(1000)); // Espera un tiempo aleatorio antes de continuar.
                }
                else
                {
                    if (i <= 100)
                    {
                        // Incremento lento de la barra de progreso al acercarse al 100%.
                        progressBar1.Value = progressBar1.Value + 1; // Aumenta el valor de la barra en 1.
                    }
                    else
                    {
                        break; // Sale del bucle cuando la barra alcanza el 100%.
                    }
                }
            }

            // Una vez completada la carga, redirige al formulario de inicio de sesión.
            InicioSesion form = new InicioSesion(); // Crea una instancia del formulario de inicio de sesión.
            MiForm metodos = new MiForm(); // Crea una instancia de la clase MiForm para gestionar formularios.

            // Carga y muestra el formulario de inicio de sesión dentro del formulario actual.
            metodos.cargarForm(form, this);
        }

        private void InicioBienvenida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string rutaejecutable = System.IO.Directory.GetCurrentDirectory();
                System.Diagnostics.Process.Start(rutaejecutable + "\\chm\\Manual de RestauranteTPV.html");

            }
        }
    }
}
