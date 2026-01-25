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
    public partial class Form6juego2 : Form
    {
        public Form6juego2()
        {
            InitializeComponent();
        }
        // Guardan el punto de inicio y fin de la línea
        Point puntoInicio = Point.Empty;
        Point puntoFin = Point.Empty;

        // Controlan qué objeto se seleccionó
        Control controlOrigen = null;

        // Lista para guardar las líneas correctas ya hechas y que no se borren
        List<Tuple<Point, Point>> lineasCompletadas = new List<Tuple<Point, Point>>();

        private void Form6juego2_Paint(object sender, PaintEventArgs e)
        {
            Pen lapiz = new Pen(Color.Green, 4); // Línea verde de 4px de grosor

            // Dibujar líneas de parejas ya acertadas
            foreach (var linea in lineasCompletadas)
            {
                e.Graphics.DrawLine(lapiz, linea.Item1, linea.Item2);
            }

            // Dibujar la línea que el usuario está trazando en el momento (si existe)
            if (puntoInicio != Point.Empty && puntoFin != Point.Empty)
            {
                e.Graphics.DrawLine(new Pen(Color.Blue, 3), puntoInicio, puntoFin);
            }
        }
        private void Elemento_MouseDown(object sender, MouseEventArgs e)
        {
            controlOrigen = sender as Control;
            // Tomamos el centro del control como inicio
            puntoInicio = new Point(controlOrigen.Left + controlOrigen.Width / 2,
                                    controlOrigen.Top + controlOrigen.Height / 2);
        }

        private void Elemento_MouseUp(object sender, MouseEventArgs e)
        {
            // Detectar qué hay bajo el mouse al soltar
            Control destino = this.GetChildAtPoint(this.PointToClient(Cursor.Position));

            if (destino != null && destino != controlOrigen)
            {
                // VALIDACIÓN: Aquí comparas si el Tag de origen coincide con el Tag de destino
                if (controlOrigen.Tag.ToString() == destino.Tag.ToString())
                {
                    puntoFin = new Point(destino.Left + destino.Width / 2,
                                         destino.Top + destino.Height / 2);

                    // Guardamos la línea para que quede permanente
                    lineasCompletadas.Add(new Tuple<Point, Point>(puntoInicio, puntoFin));
                    MessageBox.Show("¡Correcto!");
                }
            }

            // Limpiamos los puntos temporales y redibujamos
            puntoInicio = Point.Empty;
            puntoFin = Point.Empty;
            this.Invalidate(); // Fuerza al formulario a ejecutarel evento Paint
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
