using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form6 : Form
    {
        private TextBox cT;

        public Form6()
        
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            button19.Name = "SPACE";

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
            panel1.Show();
            panel2.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }


        private void textSpace(object sender, EventArgs e)
        {
            textBox1.Text += " ";
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            cT = textBox2;
            panel1.Hide();
            panel2.Show();
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            panel1.Hide();
            panel2.Show();
        }

        private void textBox3_MouseClick_1(object sender, MouseEventArgs e)
        {
            cT = textBox3;
            panel1.Hide();
            panel2.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            cT.Text += ((Button)sender).Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            cT.Text = cT.Text.Substring(0, cT.TextLength - 1);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.TextLength - 1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();
        }
    }
}
