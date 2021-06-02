using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ptnshki
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Form1.nh = 4;
            Form1.nw = 4;
            Mtds.newgame(Form1.nw, Form1.nh);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Form1.nh = 5;
            Form1.nw = 5;
            Mtds.newgame(Form1.nw, Form1.nh);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Form1.nh = 6;
            Form1.nw = 6;
            Mtds.newgame(Form1.nw, Form1.nh);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Form1.nh = 7;
            Form1.nw = 7;
            Mtds.newgame(Form1.nw, Form1.nh);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Form1.nh = 8;
            Form1.nw = 8;
            Mtds.newgame(Form1.nw, Form1.nh);
        }
    }
}
