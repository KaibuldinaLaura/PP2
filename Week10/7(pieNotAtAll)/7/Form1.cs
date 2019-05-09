using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Paint(PaintEventArgs e)
        {

            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Create rectangle for ellipse.
            Rectangle rect = new Rectangle(0, 0, 200, 100);

            // Create start and sweep angles.
            float startAngle = 0.0F;
            float sweepAngle = 45.0F;

            // Draw pie to screen.
            e.Graphics.DrawPie(blackPen, rect, startAngle, sweepAngle);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}