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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
			if (txtuser.Text == "user" && txtclave.Text == "user")
			{
				Form3 form3 = new Form3();
				this.Hide();
				form3.ShowDialog();
				this.Close();
			}
			else
			{
				MessageBox.Show("Usuario o contraseña incorrectos");
			}
		}
    }
}
