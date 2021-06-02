using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ptnshki
{
    public partial class Form1 : Form
    {
        public static int nw = 3, nh = 3;
        System.Drawing.Graphics g;
        Bitmap picture;
        public static int cw, ch;
        Boolean showNumbers = false;

        public Form1()
        {
            InitializeComponent();

            try
            {
                picture = new Bitmap("puzzle.bmp");
            }
            catch (Exception)
            {
                MessageBox.Show("Файл 'puzzle.bmp' не найден.\n",
                    "Собери картинку",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
                return;
            }

            cw = (int)(picture.Width / nw);
            ch = (int)(picture.Height / nh);

            this.ClientSize =
                new System.Drawing.Size(cw * nw + 1, ch * nh + 1 + menuStrip1.Height);

            g = this.CreateGraphics();

            Mtds.newgame(nw, nh);
            drawField();
        }

        
        private void drawField()
        {
            int[] t = new int[Mtds.getFieldsize() * Mtds.getFieldsize2()];
            Mtds.getField(t);
            int[,] field = new int[nw, nh];
            int k = 0;
            for (int i = 0; i < nw; i++)
                for (int j = 0; j < nh; j++)
                {
                    field[i, j] = t[k++];
                }
            for (int i = 0; i < nw; i++)
                for (int j = 0; j < nh; j++)
                {




                    if (field[i, j] != 0)
                        g.DrawImage(picture,
                            new Rectangle(i * cw, j * ch + menuStrip1.Height, cw, ch),
                            new Rectangle(
                                ((field[i, j] - 1) % nw) * cw,
                                ((field[i, j] - 1) / nw) * ch,
                                cw, ch),
                            GraphicsUnit.Pixel);
                    else
                        g.FillRectangle(SystemBrushes.Control,
                            i * cw, j * ch + menuStrip1.Height, cw, ch);
                    
                    g.DrawRectangle(Pens.Black,
                        i * cw, j * ch + menuStrip1.Height, cw, ch);

                    if ((showNumbers) && field[i, j] != 0)
                        g.DrawString(Convert.ToString(field[i, j]),
                            new Font("Tahoma", 10, FontStyle.Bold),
                            Brushes.Black, i * cw + 5, j * ch + 5 + menuStrip1.Height);
                }
        }

        private void move(int cx, int cy)
        {
            Mtds.move(cx, cy);
            this.drawField();

            if (Mtds.wincheck(nw, nh) == 1)
            {
                this.drawField();
                if (MessageBox.Show("Поздравляю!\n" +
                         "Еще раз?", "Собери картинку",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question)
                          == System.Windows.Forms.DialogResult.No)
                    this.Close();
                else Mtds.newgame(nw, nh);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            drawField();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            move(e.X / cw, (e.Y - menuStrip1.Height) / ch);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mtds.newgame(nw, nh);
            this.drawField();
        }

        private void НастройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
            cw = (int)(picture.Width / nw);
            ch = (int)(picture.Height / nh);
            this.ClientSize =
               new System.Drawing.Size(cw * nw + 1, ch * nh + 1 + menuStrip1.Height);

            //g = this.CreateGraphics();
            Mtds.newgame(nw, nh);
            drawField();
        }
    }
}
