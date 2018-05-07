using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;


namespace MonteCarlo
{

    public partial class Form1 : System.Windows.Forms.Form
    {
        bool painted = false;
        Random rnd = new Random();
        List<KeyValuePair<float, float>> list = new List<KeyValuePair<float, float>>();
        Int32 iterations = 0;
        int marginLeft=100;
        int marginTop=100;
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.White;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
        }

        private void DrawWorld(Graphics g)
        {
            g.Clear(Color.White);
            Pen blackPen = new Pen(Color.Black, 2);
            double piApproximation = 0;
            int total = 0;
            int numInCircle = 0;
            float x, y; // Coordinates of the random point.
            int i = 0, side = 400;

            g.DrawRectangle(blackPen, new Rectangle(marginLeft, marginTop, side, side));
            g.DrawEllipse(blackPen, new Rectangle(marginLeft, marginTop, side, side));
            //Axies
            g.DrawLine(blackPen, new Point((side/2)+marginLeft, marginTop-50), new Point((side/2)+marginLeft, side+marginTop+50));
            g.DrawLine(blackPen, new Point((side / 2) + marginLeft, marginTop - 50), new Point((side / 2) + marginLeft-8, marginTop - 35));
            g.DrawLine(blackPen, new Point((side / 2) + marginLeft, marginTop - 50), new Point((side / 2) + marginLeft+8, marginTop - 35));
            g.DrawLine(blackPen, new Point(marginLeft-50, marginTop+(side/2)), new Point(side+marginLeft+50, (side/2)+marginTop));
            g.DrawLine(blackPen, new Point(side + marginLeft + 50, (side / 2) + marginTop), new Point(side+marginLeft+50-18, (side/2)+marginTop-8));
            g.DrawLine(blackPen, new Point(side + marginLeft + 50, (side / 2) + marginTop), new Point(side+marginLeft+50-18, (side/2)+marginTop+8));

            Brush brush;
            Stopwatch t = new Stopwatch();
            int pointX = (side / 2) + marginLeft;
            int pointY = marginTop + (side / 2);
            t.Start();
            while (i < iterations)
            {
                //Generate randon point
                do
                {
                    x = rnd.Next(marginLeft, side + marginLeft);
                    y = rnd.Next(marginTop, side + marginTop);
                } while (x == pointX || y == pointY);

                brush = Brushes.Red;
                if (Math.Sqrt(Math.Pow(((side/2)+marginLeft)-x,2)+Math.Pow(((side/2)+marginTop)-y,2))<side/2) // Is the point in the circle?
                {
                    brush = Brushes.Blue;
                    ++numInCircle;
                }
                g.FillRectangle(brush, x, y, 1, 1);     
                ++total;

                i++;
            }
            t.Stop();
            ElapseTime.Text = t.Elapsed.TotalSeconds+"/s";
            piApproximation = 4.0 * ((double)numInCircle / (double)total);
            iterations = 0;
            ApproximationBox.Text = piApproximation+"";
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            iterations = int.Parse(IterationBox.Text);
            DrawWorld(this.CreateGraphics());
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (!painted)
            {
                Graphics g = e.Graphics;
                g.Clear(Color.White);
                Pen blackPen = new Pen(Color.Black, 2);
                int side = 400;

                g.DrawRectangle(blackPen, new Rectangle(marginLeft, marginTop, side, side));
                g.DrawEllipse(blackPen, new Rectangle(marginLeft, marginTop, side, side));
                //Axies
                g.DrawLine(blackPen, new Point((side / 2) + marginLeft, marginTop - 50), new Point((side / 2) + marginLeft, side + marginTop + 50));
                g.DrawLine(blackPen, new Point((side / 2) + marginLeft, marginTop - 50), new Point((side / 2) + marginLeft - 8, marginTop - 35));
                g.DrawLine(blackPen, new Point((side / 2) + marginLeft, marginTop - 50), new Point((side / 2) + marginLeft + 8, marginTop - 35));
                g.DrawLine(blackPen, new Point(marginLeft - 50, marginTop + (side / 2)), new Point(side + marginLeft + 50, (side / 2) + marginTop));
                g.DrawLine(blackPen, new Point(side + marginLeft + 50, (side / 2) + marginTop), new Point(side + marginLeft + 50 - 18, (side / 2) + marginTop - 8));
                g.DrawLine(blackPen, new Point(side + marginLeft + 50, (side / 2) + marginTop), new Point(side + marginLeft + 50 - 18, (side / 2) + marginTop + 8));

            }
        }
    }
}
