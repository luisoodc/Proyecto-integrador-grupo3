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
    public partial class Form11juego1 : Form
    {
        // --- VARIABLES DEL JUEGO ---
        // Guarda la primera carta que el usuario voltea
        PictureBox primeraCarta = null;
        // Guarda la segunda carta que el usuario voltea
        PictureBox segundaCarta = null;
        // Controla el tiempo que las cartas quedan visibles si fallas
        Timer timerEspera = new Timer();
        // Lista para manejar las imágenes lógicamente
        List<Image> listaImagenes = new List<Image>();
        // Generador de números aleatorios para mezclar
        Random rnd = new Random();
        int intentos = 0;
        public Form11juego1()
        {
            InitializeComponent();
           
            Image imgMacho = Properties.Resources.Macho;
            Image imgBarraganete = Properties.Resources.Barraganete;
            Image imgDominico = Properties.Resources.Dominico;
            Image imgHarton = Properties.Resources.Harton; 
            Image imgMaqueño = Properties.Resources.Maqueño;
            // Configuración del Timer (750 milisegundos de espera)
            timerEspera.Interval = 750;
            timerEspera.Tick += TimerEspera_Tick;

           
            // ponemos cada imagen 2 veces para formar la pareja
            listaImagenes.Add(imgMacho); listaImagenes.Add(imgMacho);
            listaImagenes.Add(imgMaqueño); listaImagenes.Add(imgMaqueño);
            listaImagenes.Add(imgBarraganete); listaImagenes.Add(imgBarraganete);
            listaImagenes.Add(imgHarton); listaImagenes.Add(imgHarton);
            listaImagenes.Add(imgDominico); listaImagenes.Add(imgDominico);

            // Mezclamos las imágenes aleatoriamente
            listaImagenes = listaImagenes.OrderBy(x => rnd.Next()).ToList();

            // Asignamos las imágenes a los cuadros del TableLayoutPanel
            int i = 0;
            // --- CAMBIA 'tableLayoutPanel1' por el nombre de tu tabla ---
            foreach (Control c in tablajuego1.Controls)
            {
                if (c is PictureBox pic)
                {
                    pic.Tag = listaImagenes[i]; // Guardamos la imagen real "escondida" en el Tag
                                                // --- CAMBIA 'Dorso' por tu imagen de la parte de atrás de la carta ---
                    pic.Image = Properties.Resources.platano_piesna;
                    pic.SizeMode = PictureBoxSizeMode.Zoom;
                    pic.Cursor = Cursors.Hand;

                    // Conectamos el evento Clic (Asegúrate de que el método Carta_Click exista abajo)
                    pic.Click += img1_Click;
                    i++;
                }
            }
        }
        private void IniciarJuego()
        {
            // 1. Resetear variables y textos
            intentos = 0;
            labintentos.Text = "Incorrectos: 0";
            primeraCarta = null;
            segundaCarta = null;
            timerEspera.Stop();

            // 2. Limpiar y volver a llenar la lista de imágenes para mezclar de nuevo
            listaImagenes.Clear();

            // Usamos variables para asegurar que la referencia sea la misma 
            Image imgMacho = Properties.Resources.Macho;
            Image imgMaqueno = Properties.Resources.Maqueño;
            Image imgBarraganete = Properties.Resources.Barraganete;
            Image imgHarton = Properties.Resources.Harton;
            Image imgDominico = Properties.Resources.Dominico;

            listaImagenes.Add(imgMacho); listaImagenes.Add(imgMacho);
            listaImagenes.Add(imgMaqueno); listaImagenes.Add(imgMaqueno);
            listaImagenes.Add(imgBarraganete); listaImagenes.Add(imgBarraganete);
            listaImagenes.Add(imgHarton); listaImagenes.Add(imgHarton);
            listaImagenes.Add(imgDominico); listaImagenes.Add(imgDominico);

           // 3. Mezclar aleatoriamente 
            listaImagenes = listaImagenes.OrderBy(x => rnd.Next()).ToList();

            // 4. Asignar a los PictureBox y taparlos
            int i = 0;
            foreach (Control c in tablajuego1.Controls)
            {
                if (c is PictureBox pic)
                {
                    if (i < listaImagenes.Count)
                    {
                        pic.Visible = true;
                        pic.Tag = listaImagenes[i];
                        pic.Image = Properties.Resources.platano_piesna;// El dorso [cite: 1]
                        i++;
                    }
                    else
                    {
                        pic.Visible = false; // Ocultar si sobran cuadros
                    }
                }
            }
        }



        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void imgfondojuego1_Click(object sender, EventArgs e)
        {

        }

        private void img1_Click(object sender, EventArgs e)

        {
           
            // AÑADE ESTA LÍNEA TEMPORALMENTE:
            /* MessageBox.Show("¡Hiciste clic en una carta!");

             PictureBox imagenSeleccionada = sender as PictureBox;*/

            PictureBox cartaActual = sender as PictureBox;

            if (timerEspera.Enabled) return;

            // Si ya está volteada, no hacer nada
            if (cartaActual.Image == (Image)cartaActual.Tag) return;

            // Voltear
            cartaActual.Image = (Image)cartaActual.Tag;

            if (primeraCarta == null)
            {
                primeraCarta = cartaActual;
            }
            else
            {
                if (primeraCarta == cartaActual) return;
                segundaCarta = cartaActual;

             

                // --- SOLUCIÓN AQUÍ ---
                // Comparamos el objeto de imagen directamente. 
                // Si esto falla, una opción es usar el nombre de la imagen si los guardaste como string.
                if (primeraCarta.Tag.Equals(segundaCarta.Tag))
                {
                    // ¡Es un acierto!
                    primeraCarta = null;
                    segundaCarta = null;
                    VerificarVictoria();
                }
                else
                {
                    // Error, activar timer
                    timerEspera.Start();
                    intentos++;
                    labintentos.Text = "Intentos: " + intentos;
                }
            }
        }







        private void TimerEspera_Tick(object sender, EventArgs e)
        {
            // Detenemos el reloj
            timerEspera.Stop();

            // Volvemos a poner la imagen de "atrás" a las dos cartas
            // --- CAMBIA 'Dorso' por tu imagen de fondo de carta ---
            primeraCarta.Image = Properties.Resources.platano_piesna;
            segundaCarta.Image = Properties.Resources.platano_piesna;

            // Limpiamos las variables para volver a jugar
            primeraCarta = null;
            segundaCarta = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
        private void VerificarVictoria()
        {
            // Si todos los PictureBox muestran algo que NO es el dorso, el juego terminó
            int cartasVolteadas = 0;
            int totalCartas = 0;

            foreach (Control c in tablajuego1.Controls)
            {
                if (c is PictureBox pic && pic.Visible)
                {
                    totalCartas++;
                    // Si la imagen actual es igual a la del Tag, la carta está descubierta
                    if (pic.Image == (Image)pic.Tag)
                    {
                        cartasVolteadas++;
                    }
                }
            }

            // Solo si el número de cartas abiertas es igual al total, hay victoria
            if (cartasVolteadas == totalCartas && totalCartas > 0)
            {
                MessageBox.Show("¡Felicidades! Completaste el juego con solo  " + intentos + " incorrectos.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {   
            
            
                IniciarJuego();
            
        }

        private void panelJUEGO1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
        



