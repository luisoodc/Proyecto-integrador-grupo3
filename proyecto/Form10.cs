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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			Form5 form5 = new Form5();
			form5.Show();
			this.Close(); // Cierra Form10
		}

        private void button3_Click(object sender, EventArgs e)
        {
			Form3 form3 = new Form3();
			form3.Show();
			this.Close(); // Cierra Form10
		}
    }
}
