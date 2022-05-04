using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgramingProject.Forms
{
    public partial class Paint_Form : Form
    {
        public Paint_Form()
        {
            InitializeComponent();
        }
        bool drw;
        int beginX;
        int beginY;
        private void Paint_Form_MouseUp(object sender, MouseEventArgs e)
        {
            drw = false;
        }
        private void Paint_Form_MouseDown(object sender, MouseEventArgs e)
        {
            drw = true;
            beginX = e.X;
            beginY = e.Y;
        }

        private void Paint_Form_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 4);
            if (this.BackColor==Color.White)
            {
                 p = new Pen(Color.Black, 4);
            }
            else
            {
                p = new Pen(Color.White, 4);
            }
                

            Point point1 = new Point(beginX, beginY);
            Point point2 = new Point(e.X, e.Y);
            if(drw==true)
            {
                g.DrawLine(p, point1, point2);
                beginX = e.X;
                beginY = e.Y;
            }
        }

        private void Paint_Form_Load(object sender, EventArgs e)
        {
            this.Text = "Paint";
            this.BackColor = Color.Black;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;
            
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
        }
    }
}
