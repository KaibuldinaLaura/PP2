using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics graphics;
        //Rectangle rectangle, rectangle2;
        List<Rectangle> rectangles;
        List<Brush> brushes;
        Point point1;
        Point point2;
        int cnt = 0;
        Brush b = Brushes.Red;
        public Form1()
        {
            rectangles = new List<Rectangle>();
            brushes = new List<Brush>();
            InitializeComponent();
            //rectangle = new Rectangle(50, 50, 50, 50);
            //rectangle2 = new Rectangle(200, 200, 50, 50);
            bitmap = new Bitmap(Picture.Width, Picture.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            Picture.Image = bitmap;
        }

        private void Picture_Click(object sender, EventArgs e)
        {
            //graphics.FillRectangle(Brushes.Red, rectangle);
            // graphics.FillRectangle(Brushes.Blue, rectangle2);
            Picture.Refresh();
            timer1.Start();
        }

        private void Picture_MouseDown(object sender, MouseEventArgs e)
        {
            point1 = e.Location;
        }

        private void Picture_MouseUp(object sender, MouseEventArgs e)
        {
            point2 = e.Location;
            int width = Math.Abs(point1.X - point2.X);
            int height = Math.Abs(point1.Y - point2.Y);
            Point p = new Point(Math.Min(point1.X, point2.X), Math.Min(point2.Y, point1.Y));
            graphics.FillRectangle(b, new Rectangle(p, new Size(width, height)));
            brushes.Add(b);
            rectangles.Add(new Rectangle(p, new Size(width, height)));
            //MessageBox.Show("I am here");
            Picture.Refresh();
            cnt++;
            if (cnt % 3 == 0)
            {
                if (b == Brushes.Red)
                    b = Brushes.Black;
                else
                    b = Brushes.Red;
            }
        }
        private PointF[] StarPoints(int num_points, Rectangle bounds)
        {
            // Make room for the points.
            PointF[] pts = new PointF[num_points];

            double rx = bounds.Width / 2;
            double ry = bounds.Height / 2;
            double cx = bounds.X + rx;
            double cy = bounds.Y + ry;

            // Start at the top.
            double theta = -Math.PI / 2;
            double dtheta = 4 * Math.PI / num_points;
            for (int i = 0; i < num_points; i++)
            {
                pts[i] = new PointF(
                    (float)(cx + rx * Math.Cos(theta)),
                    (float)(cy + ry * Math.Sin(theta)));
                theta += dtheta;
            }

            return pts;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            PointF[] pts = StarPoints(6, this.ClientRectangle);
            graphics.FillPolygon(b, pts);
            //graphics.FillRectangle(Brushes.White, rectangle);
            //graphics.FillRectangle(Brushes.White, rectangle2);
            //rectangle.X = rectangle.X + 20;
            //rectangle2.Y = rectangle2.Y - 20;
            for (int i = 0; i < rectangles.Count; i++)
            {
                Rectangle rectangle = rectangles[i];
                graphics.FillRectangle(brushes[i], rectangle);
                rectangle.Y = rectangle.Y + 20;
                rectangles[i] = rectangle;
                //graphics.FillRectangle(Brushes.Blue, rectangle2);
            }
            Picture.Refresh();
        }

    }
}
