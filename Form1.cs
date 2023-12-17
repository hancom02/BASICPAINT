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
<<<<<<< HEAD
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

=======

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Controls.Clear();
            //this.Controls.Add(panelHome);
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Controls.Clear();
            //this.Controls.Add(panelView);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel_shape_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton1_Click_2(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click_3(object sender, EventArgs e)
        {

        }

        private void bt_size_plus_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton3_Click_1(object sender, EventArgs e)
        {

        }

        private void lb_edit_colors_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
>>>>>>> main
    }
}
