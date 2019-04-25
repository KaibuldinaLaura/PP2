using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            pictureBox1.Paint += new PaintEventHandler(pictureBox_Paint);
            pictureBox1.MouseDown += new MouseEventHandler(pictureBox_MouseDown);
        }

        private int circleSize = 30;
        private Random R = new Random();
        private List<Color> NamedColors = new List<Color>();
        private List<Tuple<Point, Color>> Circles = new List<Tuple<Point, Color>>();

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Color C in System.ComponentModel.TypeDescriptor.GetConverter(typeof(Color)).GetStandardValues())
            {
                if (C.IsNamedColor)
                {
                    NamedColors.Add(C);
                }
            }
        }

        void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            Tuple<Point, Color> circle = new Tuple<Point, Color>(new Point(e.X, e.Y), NamedColors[R.Next(NamedColors.Count)]);
            Circles.Add(circle);
            pictureBox1.Invalidate();
        }

        void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (Tuple<Point, Color> circle in Circles)
            {
                Rectangle rc = new Rectangle(circle.Item1, new Size(1, 1));
                rc.Inflate(circleSize / 2, circleSize / 2);
                using (Pen pen = new Pen(circle.Item2, 3))
                {
                    e.Graphics.DrawEllipse(pen, rc);
                }
            }
        }

        void pictureBox1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
