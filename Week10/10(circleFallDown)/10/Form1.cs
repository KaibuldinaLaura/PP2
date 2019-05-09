using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }
        Graphics g;
        int x, y;
        List<Rectangle> recs = new List<Rectangle>();


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.Location.X;
            y = e.Location.Y;
            recs.Add(new Rectangle(x, y, 30, 30));

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
            Brush pen = Brushes.Black;

            for (int i = 0; i < recs.Count; i++)
            {
                Rectangle rec = new Rectangle();
                rec = recs[i];
                rec.Y += 20;
                recs[i] = rec;

                g.FillEllipse(pen, rec);
            }

        }
    }
}