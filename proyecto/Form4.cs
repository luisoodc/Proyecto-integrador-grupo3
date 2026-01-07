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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
			Form3 form3 = new Form3();
			form3.Show();
			this.Close(); // Cierra Form4
		}

        private void button1_Click(object sender, EventArgs e)
        {
			Form3 form3 = new Form3();
			form3.Show();
			this.Close(); // Cierra Form4
		}

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
