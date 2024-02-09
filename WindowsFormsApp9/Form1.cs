using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Win4 win4 = new Win4();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"ts3server://");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"steam://");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"https://www.instagram.com/");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Win3 win3 = new Win3();
            win3.Show();
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            Win3 win3 = new Win3();
            win3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
