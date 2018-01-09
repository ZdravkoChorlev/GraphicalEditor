using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicalEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = drawPanel.CreateGraphics();
        }

        Graphics g;
        bool drawRectangle = false;
        bool drawElipse = false;
        bool drawLine = false;

        private void panel_Draw_MouseDown(object sender, MouseEventArgs e)
        {
            if (drawLine)
            {

                //Drawing Line
                Pen p = new Pen(Color.Black, float.Parse(textBox1.Text));
                Point point1 = new Point(100, 50);
                Point point2 = new Point(150, 350);
                g.DrawLine(p, point1, point2);
               //startPaint = false;
                drawLine = false;
            }

            if(drawRectangle)
            {
                //Drawing Rectangle
                Pen p = new Pen(Color.Black, float.Parse(textBox1.Text));
                g.DrawRectangle(p, 100, 300,50, 70);
                //startPaint = false;
                drawRectangle = false;
            }

            if(drawElipse)
            {
                //Drawing Elipse
                Pen p = new Pen(Color.Black, float.Parse(textBox1.Text));
                g.DrawEllipse(p, 100, 200, 60, 70);
                //startPaint = false;
                drawElipse = false;
            }
        }


        private void button_Rectangle_Click(object sender, EventArgs e)
        {
            drawRectangle = true;
        }

        private void button_Elipse_Click(object sender, EventArgs e)
        {
            drawElipse = true;
        }   

        private void button3_Click(object sender, EventArgs e)
        {
            drawLine = true;
        }
        //Menu for clear
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            g.Clear(drawPanel.BackColor);
        }
        //Menu for exit
        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
