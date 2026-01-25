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

        // Variables globales para el juego de líneas
        Point puntoInicio = Point.Empty;
        Point puntoFin = Point.Empty;
        Control controlOrigen = null;
        List<Tuple<Point, Point>> lineasCompletadas = new List<Tuple<Point, Point>>();

        private void FormJuegoLineas_Paint(object sender, PaintEventArgs e)
        {
            // Configuramos el estilo de la línea
            using (Pen lapizAcierto = new Pen(Color.Green, 4))
            using (Pen lapizGuia = new Pen(Color.Blue, 2))
            {
                // Dibujamos las que ya están bien
                foreach (var linea in lineasCompletadas)
                {
                    e.Graphics.DrawLine(lapizAcierto, linea.Item1, linea.Item2);
                }

                // Dibujamos la línea mientras el usuario arrastra
                if (puntoInicio != Point.Empty && puntoFin != Point.Empty)
                {
                    e.Graphics.DrawLine(lapizGuia, puntoInicio, puntoFin);
                }
            }
        }

        private void Elemento_MouseDown(object sender, MouseEventArgs e)
        {
            controlOrigen = sender as Control;
            // El punto de inicio es el centro del objeto que tocaste
            puntoInicio = new Point(controlOrigen.Left + controlOrigen.Width / 2,
                                    controlOrigen.Top + controlOrigen.Height / 2);
        }

        private void Elemento_MouseUp(object sender, MouseEventArgs e)
        {
            // Buscamos qué hay debajo de donde soltaste el mouse
            Control destino = this.GetChildAtPoint(this.PointToClient(Cursor.Position));

            if (destino != null && destino != controlOrigen && destino.Tag != null && controlOrigen.Tag != null)
            {
                // Si los Tags coinciden (ej. ambos dicen "Macho")
                if (controlOrigen.Tag.ToString() == destino.Tag.ToString())
                {
                    Point pFin = new Point(destino.Left + destino.Width / 2,
                                           destino.Top + destino.Height / 2);

                    lineasCompletadas.Add(new Tuple<Point, Point>(puntoInicio, pFin));
                    MessageBox.Show("¡Correcto!");
                }
            }

            // Limpiamos y redibujamos
            puntoInicio = Point.Empty;
            puntoFin = Point.Empty;
            this.Invalidate(); // ESTO LLAMA AL EVENTO PAINT AUTOMÁTICAMENTE
        }

        private void FormJuegoLineas_MouseMove(object sender, MouseEventArgs e)
        {
            if (puntoInicio != Point.Empty)
            {
                puntoFin = e.Location;
                this.Invalidate(); // Redibuja la línea en cada movimiento del mouse
            }
        }
        public Form6juego2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
