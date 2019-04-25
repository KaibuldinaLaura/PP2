using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        GraphicsPath gp = new GraphicsPath();
        SolidBrush brush = new SolidBrush(Color.Red);
        Random c = new Random();
        int r = 30;
        int a = 130;
        int b = 130;

        public Form1()
        {
            InitializeComponent();
            gp.AddEllipse(new Rectangle(a - r, b - r, 2 * r, 2 * r));
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillPath(brush, gp);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (gp.IsVisible(e.Location))
            //if ((e.X - a) * (e.X - a) + (e.Y - b) * (e.Y - b) <= r * r)
            {
                brush.Color = Color.FromArgb(c.Next(0, 256), c.Next(0, 256), c.Next(0, 256));
            }
            else
            {
                brush.Color = Color.Red;
            }
            Refresh();
        }
    }
}