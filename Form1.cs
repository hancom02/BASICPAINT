using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BASICPAINT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            bm = new Bitmap(this.Width, this.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pictureBox1.Image = bm;
        }
        private Point Start, End;
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black,1);
        int x, y, sX, sY, cX, cY;


        public enum TOOL
        {
            SELECT,
            PEN,
            ERASER,
            FILLCOLOR,
            LINE,
            ELLIPSE,
            RECTANGLE,
            TRIANGLE
        }
        public TOOL curTool = TOOL.SELECT;

        private void button_rectangle_Click(object sender, EventArgs e)
        {
            curTool = TOOL.RECTANGLE;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            Start = End = e.Location;
            py = e.Location;
            cX = e.X;
            cY = e.Y;
        }

        
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(paint)
            {
                if(curTool ==TOOL.PEN )
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }    
                
            }
            pictureBox1.Refresh();
            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;

        }


        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            sX = x - cX;
            sY = y - cY;

            if (curTool == TOOL.ELLIPSE)
            {
                g.DrawEllipse(p, cX, cY, sX, sY);
            }
            if (curTool == TOOL.RECTANGLE)
            {
                g.DrawRectangle(p, cX, cY, sX, sY);
            }
            if (curTool == TOOL.LINE)
            {
                g.DrawLine(p, cX, cY, x, y);
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            if (paint)
            {
                if (curTool == TOOL.ELLIPSE)
                {
                    g.DrawEllipse(p, cX, cY, sX, sY);

                }
                if (curTool == TOOL.RECTANGLE)
                {
                    g.DrawRectangle(p, cX, cY, sX, sY);
                }
                if (curTool == TOOL.LINE)
                {
                    g.DrawLine(p, cX, cY, x, y);
                }
            }
        }

        private void button_line_Click(object sender, EventArgs e)
        {
            curTool = TOOL.LINE;
        }

        private void button_pen_Click(object sender, EventArgs e)
        {
            curTool= TOOL.PEN;
        }

        private void button_elip_Click(object sender, EventArgs e)
        {
            curTool = TOOL.ELLIPSE;
        }

    }
}
