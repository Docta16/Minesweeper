using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    /// <summary>
    /// Clase que representa la presentación del buscamians y su lógica.
    /// </summary>
    public partial class BotonesNumerados: UserControl
    {
        /// <summary>
        /// Matriz de botones que guarda las casillas del buscaminas.
        /// </summary>
        private Button[,] botones;
        /// <summary>
        /// Numero de filas y columnas.
        /// </summary>
        public int n;
        /// <summary>
        /// Número de minas que hay.
        /// </summary>
        private int minas;
        /// <summary>
        /// Imagelist con las imagenes necesarias.
        /// </summary>
        private ImageList casillas;
        /// <summary>
        /// Timer con el tiempo transcurrido desde el comienzo de la partida. Se parará al perder.
        /// </summary>
        private Timer t;
        /// <summary>
        /// Botón de iniciar partida, se le cambiará la imagen si se pierde.
        /// </summary>
        private Button b;

        /// <summary>
        /// Construye el buscaminas.
        /// </summary>
        /// <param name="n">Número de filas y de columnas.</param>
        /// <param name="dif">Dificultad del buscaminas.</param>
        /// <param name="img">Lista de imagenes.</param>
        /// <param name="t">Controlador del tiempo.</param>
        /// <param name="bb">Botón de iniciar partida.</param>
        public BotonesNumerados(int n, int dif, ImageList img, Timer t, Button bb)
        {
            this.t = t;
            this.b = bb;
            this.casillas = img;
            this.n = n;
            InitializeComponent();
            this.botones = new Button[this.n, this.n];
            for (int i = 0; i < this.n; i++)  //creamos los botones
            {
                for (int j = 0; j < this.n; j++)
                {
                    Button b = new Button();
                    b.Click += new System.EventHandler(this.btt_Click);   //asociamos el evento del click, para descubrir casillas.
                    b.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btt_MouseDown);  //Este para poner banderitas.
                    b.Name = i + "-" + j;
                    b.Size = new Size(30, 30);
                    b.BackgroundImage = casillas.Images[3];
                    b.BackgroundImageLayout = ImageLayout.Stretch;   
                    b.Location = new Point(i * b.Size.Width, j * b.Size.Height);
                    botones[i, j] = b;
                    this.Controls.Add(b);
                }
            }
            iniciarTablero(dif);
        }

        /// <summary>
        /// Propiedad que nos da acceso al número de minas.
        /// </summary>
        public int Minas
        {
            get
            {
                return this.minas;
            }
        }

        /// <summary>
        /// Comprueba si se han abierto todas las casillas que no son minas.
        /// </summary>
        /// <returns>Devuelve true si la partida ha acabado, false si no.</returns>
        private bool comprobarFinal()
        {
            foreach(Button b in this.botones)
            {
                if(b.Enabled && b.Tag == null)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Pone o quita una banderita de mina en la casilla pulsada.
        /// </summary>
        /// <param name="sender">Objeto que desencadena el evento.</param>
        /// <param name="e">Información sobre el evento.</param>
        private void btt_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            if (e.Button == MouseButtons.Right) //Comprobamos que es un click derecho.
            {
                if (b.BackgroundImage.Tag != null && b.BackgroundImage.Tag.ToString() == "Mina")
                {
                    b.BackgroundImage = this.casillas.Images[3];
                    b.BackgroundImage.Tag = "";
                }
                else
                {
                    b.BackgroundImage = this.casillas.Images[5];
                    b.BackgroundImage.Tag = "Mina";
                }               
            }
        }

        /// <summary>
        /// Inicia el tablero colocando el número de bombas convenientes a la dificultad.
        /// </summary>
        /// <param name="dif">Dificultad.</param>
        private void iniciarTablero(int dif)
        {
            float nb = 0;
            switch(dif)
            {
                case 1:
                    nb = 0.1f;
                    break;
                case 2:
                    nb = 0.15f;
                    break;
                case 3:
                    nb = 0.2f;
                    break;
            }
            int bombas = (int) (this.n * this.n * nb);
            this.minas = bombas;
            Random r = new Random();
            while(bombas > 0)    //Coloca las bombas en posiciones aleatorias.
            {
                Button b = this.botones[r.Next(this.n - 1), r.Next(this.n - 1)];
                if(b.Tag == null)   //Comprueba que no sea una mina ya.
                {
                    b.Tag = "Bomba";
                    bombas--;
                }
            }
        }

        /// <summary>
        /// Permite abrir las diferentes casillas.
        /// </summary>
        /// <param name="sender">Objeto que desencadena el evento.</param>
        /// <param name="e">Información sobre el evento.</param>
        private void btt_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            bool fin = false;
            b.Enabled = false;   //Lo desactivamos.
            if (b.Tag != null && b.Tag.ToString() == "Bomba")   //Si es una bomba ha perdido.
            {
                this.t.Stop();
                this.b.BackgroundImage = this.casillas.Images[1];   //Pone la carita triste
                MessageBox.Show("Perdiste");
                fin = true;
                abrirBombas();   //Abre las bombas.
                b.BackgroundImage = this.casillas.Images[6];   //Pone la imagen de la bomba explotando.
            }
            else
            {
                //Localiza su posición dentro de la matriz.
                int i = Int32.Parse(b.Name.Substring(0, b.Name.IndexOf("-")));
                int j = Int32.Parse(b.Name.Substring(b.Name.IndexOf("-") + 1));
                int bom = comprobarBombas(i, j);   //Comprueba el número de minas que le rodean.
                switch(bom)   //Pone la imagen correspondiente al número de minas.
                {
                    case 0:
                        b.BackgroundImage = this.casillas.Images[4];
                        break;
                    case 1:
                        b.BackgroundImage = this.casillas.Images[7];
                        break;
                    case 2:
                        b.BackgroundImage = this.casillas.Images[8];
                        break;
                    case 3:
                        b.BackgroundImage = this.casillas.Images[9];
                        break;
                    case 4:
                        b.BackgroundImage = this.casillas.Images[10];
                        break;
                    case 5:
                        b.BackgroundImage = this.casillas.Images[11];
                        break;
                    case 6:
                        b.BackgroundImage = this.casillas.Images[12];
                        break;
                    case 7:
                        b.BackgroundImage = this.casillas.Images[13];
                        break;
                    case 8:
                        b.BackgroundImage = this.casillas.Images[14];
                        break;
                    default:
                        b.Text = bom.ToString();
                        goto case 1;

                }
                if(bom == 0)   //Si no tenía minas alrededor desencadena la apertura de als casillas vecinas.
                {
                    desencadenarApertura(i, j);
                }
            } 
            if(comprobarFinal() && !fin)   //Comprueba si has ganado.
            {
                this.t.Stop();
                MessageBox.Show("Ganaste!");
                abrirBombas();
            }
        }

        /// <summary>
        /// Abre las bombas existentes colocando el icono de la boma en sus casillas.
        /// </summary>
        private void abrirBombas()
        {
            foreach(Button b in this.botones)
            {
                b.Enabled = false;
                if(b.Tag != null && b.Tag.ToString() == "Bomba")
                {
                    b.BackgroundImage = this.casillas.Images[2];
                }
                //Indica si alguna casilla no bomba tiene alguna banderita.
                if(b.Tag == null && b.BackgroundImage.Tag != null && b.BackgroundImage.Tag.ToString() == "Mina")
                {
                    b.BackgroundImage = this.casillas.Images[15];
                }
            }
        }

        /// <summary>
        /// Desencadena la apertura de las minas circundantes a una.
        /// </summary>
        /// <param name="i">Posición i del botón dentro de la matriz.</param>
        /// <param name="j">Posición j del botón dentro de la matriz.</param>
        private void desencadenarApertura(int i, int j)
        {
            for (int k = i - 1; k <= i + 1; k++)
            {
                for (int l = j - 1; l <= j + 1; l++)
                {
                    if (k >= 0 && l >= 0 && k <= this.n - 1 && l <= this.n - 1)  //Comprueba que no se sale.
                    {
                        Button b = this.botones[k, l];
                        b.PerformClick();  //Hace click para abrirla.
                    }
                }
            }
        }

        /// <summary>
        /// Comprueba cuantas minas rodean a una casilla.
        /// </summary>
        /// <param name="i">Posición i del botón dentro de la matriz.</param>
        /// <param name="j">Posición j del botón dentro de la matriz.</param>
        /// <returns>Devuelve el número de minas que rodean la casilla.</returns>
        private int comprobarBombas(int i, int j)
        {
            int n = 0;
            for(int k = i - 1; k <= i + 1; k++)
            {
                for(int l = j - 1; l <= j + 1; l++)
                {
                    if (k >= 0 && l >= 0 && k <= this.n - 1 && l <= this.n - 1)   //Comprueba que no se sale de la matriz.
                    {
                        Button b = this.botones[k, l];
                        if (b.Tag != null && b.Tag.ToString() == "Bomba")  //Si es una bomba suma una más.
                        {
                            n++;
                        }
                    }
                }
            }
            return n;
        }

    }
}
