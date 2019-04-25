using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.White);
            //e.Graphics.DrawLine(pen, 0, 0, 100, 100);

            SolidBrush solidBrush = new SolidBrush(Color.Black);
            e.Graphics.FillRectangle(solidBrush, 0, 0, 1000, 600);

            SolidBrush solidBrush1 = new SolidBrush(Color.Blue);
            e.Graphics.FillRectangle(solidBrush1, 20, 20, 960, 560);

            e.Graphics.FillEllipse(pen.Brush, 50, 60, 30, 30);

        }
    }
}