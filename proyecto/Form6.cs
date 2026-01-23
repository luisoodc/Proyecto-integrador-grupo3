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
    public partial class Form6 : Form
    {
        public Form6()
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
            panelsuri.Visible = false;
            panelsigatoka.Visible = false;
            panelgorgojo.Visible = false;
           

            // 3. Mostrar solo el panel que corresponde al Tag de la imagen
            if (nombrePanel == "panelsuri") panelsuri.Visible = true;
            else if (nombrePanel == "panelsigatoka") panelsigatoka.Visible = true;
            else if (nombrePanel == "panelgorgojo") panelgorgojo.Visible = true;
       
        }
        private void button2_Click(object sender, EventArgs e)
        {
			Form5 form5 = new Form5();
			form5.Show();
			this.Close(); // Cierra Form6
		}

        private void button1_Click(object sender, EventArgs e)
        {
			Form3 form3 = new Form3();
			form3.Show();
			this.Close(); // Cierra Form6
		}

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelmacho_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Volver_Click(object sender, EventArgs e)
        {
            // Oculta el panel actual
            ((Button)sender).Parent.Visible = false;
        }
    }
}
