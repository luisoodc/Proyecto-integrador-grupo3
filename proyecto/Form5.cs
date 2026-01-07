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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
			Form6 form6 = new Form6();
			form6.Show();
			this.Hide(); // Oculta Form5
		}

        private void button3_Click(object sender, EventArgs e)
        {
			Form7 form7 = new Form7();
			form7.Show();
			this.Hide(); // Oculta Form5
		}

        private void ciclo_Click(object sender, EventArgs e)
        {
			Form10 form10 = new Form10();
			form10.Show();
			this.Close(); // Cierra Form5
		}

        private void button2_Click(object sender, EventArgs e)
        {
			Form3 form3 = new Form3();
			form3.Show();
			this.Close(); // Cierra Form5
		}

        private void button1_Click_1(object sender, EventArgs e)
        {
			Form3 form3 = new Form3();
			form3.Show();
			this.Close(); // Cierra Form5
		}

        private void produccion_Click(object sender, EventArgs e)
        {
			Form8 form8 = new Form8();
			form8.Show();
			this.Close(); // Cierra Form5
		}
    }
}
