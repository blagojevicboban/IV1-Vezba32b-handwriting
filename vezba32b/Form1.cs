using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vezba32b
{
    public partial class Form1 : Form
    {
        bool crtaj=false;
        int xp, yp;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            crtaj=true;
            xp = e.X;
            yp = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            crtaj = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g=CreateGraphics();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (crtaj)
                g.DrawLine(new Pen(Color.Blue, 1),
                    xp, yp, e.X, e.Y);
            xp = e.X;
            yp = e.Y;

        }
    }
}
