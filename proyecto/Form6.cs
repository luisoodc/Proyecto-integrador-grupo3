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
    }
}
