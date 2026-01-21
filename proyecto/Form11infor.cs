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
    public partial class Form11infor : Form
    {

        public Form11infor()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 login = new Form5();
            login.Show();
            this.Close(); // Cierra Form3
        }

        private void irjuego_Click(object sender, EventArgs e)
        {
            Form11juego1 login = new Form11juego1();
            login.Show();
            this.Close(); // Cierra Form3
        }

        private void panelmaqueño_Paint(object sender, PaintEventArgs e)
        {

        }
        private void MostrarPanel_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show("¡Hiciste clic en una carta!");

            PictureBox imagenSeleccionada = sender as PictureBox;*/

            // 1. Identificar qué imagen recibió el clic
            PictureBox picSeleccionado = sender as PictureBox;
            string nombrePanel = picSeleccionado.Tag.ToString();

            // 2. Ocultar TODOS los paneles primero para que no se encimen
            panelmacho.Visible = false;
            panelmaqueño.Visible = false;
            panelbarraganete.Visible = false;
            panelharton.Visible = false;
            paneldominico.Visible = false;

            // 3. Mostrar solo el panel que corresponde al Tag de la imagen
            if (nombrePanel == "panelmacho") panelmacho.Visible = true;
            else if (nombrePanel == "panelmaqueno") panelmaqueño.Visible = true;
            else if (nombrePanel == "panelbarraganete") panelbarraganete.Visible = true;
            else if (nombrePanel == "panelharton") panelharton.Visible = true;
            else if (nombrePanel == "paneldominico") paneldominico.Visible = true;
        }
       private void Volver_Click(object sender, EventArgs e)
        {
            // Oculta el panel actual
            ((Button)sender).Parent.Visible = false;
        }

       /* private void btnVolver(object sender, EventArgs e)
        {
            // Oculta el panel actual
            ((Button)sender).Parent.Visible = false;
        }*/
    }
}
