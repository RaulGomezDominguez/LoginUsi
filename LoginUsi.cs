using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginUnisur
{
    public partial class Form1 : Form
    {
        static int intentos = 3;
        static int totales = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbContrasena_TextChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        { 
            string usurio = TbUser.Text;
            string passsword = TbContrasena.Text;
            if (this.TbUser.Text == "raul" && this.TbContrasena.Text == "123")
            {
                intentos = 0;
                pictureBox1.Image = new Bitmap(@"D:\trabajos de visual studio\US.png");
                MessageBox.Show("Bienvenido!");
            }
            else if (intentos > 0 && intentos <=3)
            {
                intentos--;
               
                Aviso.Text = "tienes " + Convert.ToString(intentos) + " intentos";
                MessageBox.Show("datos incorrectos ");
                if (intentos == 0)
                {
                    btnLogin.Enabled = false;    
                }
            }
        } 
    }
}
