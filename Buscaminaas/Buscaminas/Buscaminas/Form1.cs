using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_1;
using System.Windows.Forms;

namespace Buscaminas
{
    /// <summary>
    /// Formulario principal en el que se instanciará el buscaminas.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Almacenamos el control que representa al buscaminas.
        /// </summary>
        private BotonesNumerados bn;

        /// <summary>
        /// Construye el formulario principal.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.tbTiempo.Text = "0";   //Ponemos el tiempo a cero
            iniciarPartida();
            this.tbMinas.Text = bn.Minas.ToString();   //Mostramos el número de minas a encontrar. 
        }

        /// <summary>
        /// Responde al evento de pulsar al botón iniciar.
        /// Eliminará el buscaminas anterior si existía y creará otro.
        /// </summary>
        /// <param name="sender">Objeto que desencadena el evento.</param>
        /// <param name="e">Información sobre el evento.</param>
        private void bttIniciar_Click(object sender, EventArgs e)
        {
            if (this.Controls["bn"] != null)
            {
                this.Controls["bn"].Dispose();
            }
            iniciarPartida();
        }

        /// <summary>
        /// Inicializa el buscaminas en el formulario.
        /// </summary>
        private void iniciarPartida()
        {
            IniciarPartida ip = new IniciarPartida();   //Pedimos la información sobre las casillas y la dificultad.
            DialogResult dr = ip.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                ip.Dispose();
            }
            else
            {
                this.bttIniciar.BackgroundImage = global::Buscaminas.Properties.Resources.carasonrienteminas;
                //creamos el buscaminas.
                BotonesNumerados bn = new BotonesNumerados(ip.Numero, ip.Dificultad, this.imageList1, this.timer, this.bttIniciar);
                this.bn = bn;
                bn.Name = "bn";             
                ip.Dispose();
                this.Controls.Add(bn);
                //El código que sigue se asegura que todos los elementos del formulario se situen en la posición correcta.
                if (bn.Size.Width + 70 < 420)
                {
                    this.Size = new Size(420, 170 + bn.Size.Height);
                    bn.Location = new Point(this.Size.Width/2 - bn.Size.Width/2, 130);
                    this.bttIniciar.Location = new Point(180, 55);
                    this.lbMinas.Location = new Point(35, 58);
                    this.tbMinas.Location = new Point(this.lbMinas.Location.X - 1, 60 + this.lbMinas.Size.Height);
                    this.lbTiempo.Location = new Point(285, 58);
                    this.tbTiempo.Location = new Point(this.lbTiempo.Location.X - 1, 60 + this.lbTiempo.Size.Height);
                }
                else
                {
                    bn.Location = new Point(35, 130);
                    this.Size = new Size(70 + bn.Size.Width, 170 + bn.Size.Height);
                    this.bttIniciar.Location = new Point(35 + bn.Size.Width/2 - this.bttIniciar.Size.Width/2, 55);
                    this.lbMinas.Location = new Point(35 + bn.Size.Width/4 - this.lbMinas.Size.Width/2, 58);
                    this.tbMinas.Location = new Point(this.lbMinas.Location.X - 1, 60 + this.lbMinas.Size.Height);
                    this.lbTiempo.Location = new Point(35 + 3*bn.Size.Width / 4 - this.lbTiempo.Size.Width / 2, 58);
                    this.tbTiempo.Location = new Point(this.lbTiempo.Location.X - 1, 60 + this.lbTiempo.Size.Height);
                }
                
                this.tbTiempo.Text = "0";   //Colocamos el tiempo a cero y hacemos que empiece a contar.
                this.timer.Start();
            }
        }

        /// <summary>
        /// Actualiza el texto del tiempo en función del tiempo transcurrido.
        /// </summary>
        /// <param name="sender">Objeto que desencadena el evento.</param>
        /// <param name="e">Información sobre el evento.</param>
        private void timer_Tick(object sender, EventArgs e)
        {
            this.tbTiempo.Text = (Int32.Parse(this.tbTiempo.Text) + 1).ToString();
        }

        /// <summary>
        /// Responde al evento de clicar en jugar del menú.
        /// Realiza un click en el botón de iniciar partida.
        /// </summary>
        /// <param name="sender">Objeto que desencadena el evento.</param>
        /// <param name="e">Información sobre el evento.</param>
        private void jugarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.bttIniciar.PerformClick();
        }

        /// <summary>
        /// Responde al evento de clicar en salir del menú.
        /// Cierra la aplicación.
        /// </summary>
        /// <param name="sender">Objeto que desencadena el evento.</param>
        /// <param name="e">Información sobre el evento.</param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
