using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buscaminas
{
    /// <summary>
    /// Formulario usado para obtener el número de casillas y la dificultad del formulario a instanciar.
    /// </summary>
    public partial class IniciarPartida : Form
    {
        /// <summary>
        /// Entero que representa el número de casillas que tendrá el buscaminas.
        /// </summary>
        int numero;
        /// <summary>
        /// Entero que codifica la dificultad elegida.
        /// </summary>
        int dificultad;

        /// <summary>
        /// Construye el formulario.
        /// </summary>
        public IniciarPartida()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Propiedad que permite el acceso al número de casillas.
        /// </summary>
        public int Numero
        {
            get
            {
                return this.numero;
            }
        }

        /// <summary>
        /// Propiedad que permite el acceso a la dificultad.
        /// </summary>
        public int Dificultad
        {
            get
            {
                return this.dificultad;
            }
        }

        /// <summary>
        /// Responde al evento de cambiar el texto del número de casillas.
        /// Si introduces un dato válido lo almacena y activa el botón de aceptar.
        /// </summary>
        /// <param name="sender">Objeto que desencadena el evento.</param>
        /// <param name="e">Información sobre el evento.</param>
        private void tbNumero_TextChanged(object sender, EventArgs e)
        {
            if(this.tbNumero.Text != "" && Int32.TryParse(this.tbNumero.Text, out this.numero))
            {
                this.bttAceptar.Enabled = true;
            }
            else
            {
                this.bttAceptar.Enabled = false;
            }
        }

        /// <summary>
        /// Responde al evento de pulsar el botón de afectar.
        /// Registramos la dificultad elegida, el número de casillas ya lo están.
        /// </summary>
        /// <param name="sender">Objeto que desencadena el evento.</param>
        /// <param name="e">Información sobre el evento.</param>
        private void bttAceptar_Click(object sender, EventArgs e)
        {
            if(rbFacil.Checked)
            {
                this.dificultad = 1;
            }
            if (rbIntermedio.Checked)
            {
                this.dificultad = 2;
            }
            if (rbDificil.Checked)
            {
                this.dificultad = 3;
            }

        }
    }
}
