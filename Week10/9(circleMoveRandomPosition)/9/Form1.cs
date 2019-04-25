using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }
        Graphics g;
        int dir;
        Pen pen;
        List<Rectangle> recs = new List<Rectangle>();
        List<int> directions = new List<int>();
        List<int> x = new List<int>();
        List<int> y = new List<int>();
        List<Color> colors = new List<Color>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Start();

            x.Add(e.Location.X);
            y.Add(e.Location.Y);

            Random randirec = new Random();
            dir = randirec.Next(1, 4);
            directions.Add(dir);

            Random randRGB = new Random();
            Color randomColor = Color.FromArgb(randRGB.Next(256), randRGB.Next(256), randRGB.Next(256));
            colors.Add(randomColor);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < x.Count; i++)
            {
                if (directions[i] == 1)
                    y[i] -= 10;
                else
                if (directions[i] == 2)
                    y[i] += 10;
                else
                if (directions[i] == 3)
                    x[i] -= 10;
                else
                if (directions[i] == 4)
                    x[i] += 10;

                Refresh();
            }

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < x.Count; i++)
            {
                pen = new Pen(colors[i]);
                e.Graphics.FillEllipse(pen.Brush, x[i], y[i], 27, 27);
            }

        }
    }
}
