using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    public partial class Formcultivo : Form
    {
        public Formcultivo()
        {
            InitializeComponent();
        }
        private void MostrarPanel_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show("¡Hiciste clic en una carta!");

            PictureBox imagenSeleccionada = sender as PictureBox;*/

            // 1. Identificar qué imagen recibió el clic
            PictureBox picSeleccionado = sender as PictureBox;
            string nombrePanel = picSeleccionado.Tag.ToString();

            // 2. Ocultar TODOS los paneles primero para que no se encimen
            panelproceso.Visible = false;
            panelcaracteristicas.Visible = false;
           


            // 3. Mostrar solo el panel que corresponde al Tag de la imagen
            if (nombrePanel == "panelproceso") panelproceso.Visible = true;
            else if (nombrePanel == "panelcaracteristicas") panelcaracteristicas.Visible = true;
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ((Button)sender).Parent.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((Button)sender).Parent.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11infor login = new Form11infor();
            login.Show();
            this.Close(); 
        }

        private void irjuego_Click(object sender, EventArgs e)
        {
            Form11juego1 login = new Form11juego1();
            login.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
