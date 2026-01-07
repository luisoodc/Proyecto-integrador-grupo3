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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			Form5 form5 = new Form5();
			form5.Show();
			this.Hide(); // Oculta Form5
		}

        private void btnjugar_Click(object sender, EventArgs e)
        {
			Form4 form4 = new Form4();
			form4.Show();
			this.Hide(); // Oculta Form5
		}

        private void button1_Click_1(object sender, EventArgs e)
        {
			Form2 login = new Form2();
			login.Show();
			this.Close(); // Cierra Form3
		}

        private void button2_Click(object sender, EventArgs e)
        {
			Form3 form3 = new Form3();
			form3.Show();
			this.Close(); // Cierra Form3
		}
    }
}
