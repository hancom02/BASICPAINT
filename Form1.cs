using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BASICPAINT
{
    public partial class Form1 : Form
    {
        private Point Start, End;
        private List<Triangle> trianglesList;
        Bitmap bm;
        Graphics g;
        bool isDrawing = false;
        Point px, py;
        Pen pen = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 10);
        int x, y, sX, sY, cX, cY;

        ColorDialog cd = new ColorDialog();
        Color new_color = Color.Black;
        //Point lastPoint;

        private Color defaultColor = Color.White; // Màu ban đầu của button
        private Color activeColor = Color.LightBlue; // Màu khi button được kích hoạt

        private bool isBoldActive = false;
        private bool isItalicActive = false;
        private bool isUnderlineActive = false;

        public enum TOOL
        {
            SELECT,
            PEN,
            ERASER,
            FILLCOLOR,
            TEXT,
            LINE,
            ELLIPSE,
            RECTANGLE,
            TRIANGLE
        }
        public TOOL curTool = TOOL.SELECT;

        public enum CREATE_TEXT
        {
            YES,
            NO,
        }
        public CREATE_TEXT curCreateText = CREATE_TEXT.YES;

        public Form1()
        {
            InitializeComponent();

            DoubleBuffered = true;
            g = pictureBox1.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pictureBox1.Image = bm;
            trianglesList = new List<Triangle>();
            //pen.Width = (float)pen_width.Value;
        }

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
            foreach (FontFamily font in FontFamily.Families)
            {
                cb_Font.Items.Add(font.Name.ToString());
            }
            cb_Font.SelectedItem = "Arial";

            
            cb_TextSize.SelectedItem = "11";
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
            curTool = TOOL.LINE;
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            curTool = TOOL.FILLCOLOR;
        }

        

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            curTool = TOOL.ERASER;
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
            curTool = TOOL.ELLIPSE;
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton1_Click_2(object sender, EventArgs e)
        {
            curTool = TOOL.RECTANGLE;
        }

        private void guna2ImageButton1_Click_3(object sender, EventArgs e)
        {

        }

        private void bt_size_plus_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            Start = End = e.Location;
            //lastPoint = e.Location;
            py = e.Location;

            cX = e.X;
            cY = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (isDrawing)
                {
                    if (curTool == TOOL.PEN)
                    {
                        px = e.Location;
                        g.DrawLine(pen, px, py);
                        py = px;
                    }
                    if (curTool == TOOL.ERASER)
                    {
                        px = e.Location;
                        g.DrawLine(erase, px, py);
                        py = px;
                    }
                }
                if (curTool == TOOL.TRIANGLE)
                {
                    End = e.Location;
                    this.Invalidate();
                }
                //if (curTool == TOOL.TRIANGLE)
                //{
                //    Point point1 = new Point() { X = startPointX, Y = startPointY + shapeHeight };
                //    Point point2 = new Point() { X = startPointX + (shapeWidth / 2), Y = startPointY };
                //    Point point3 = new Point() { X = startPointX + shapeWidth, Y = startPointY + shapeHeight };
                //    g.DrawPolygon(pen, new Point[] { point1, point2, point3 });
                //}
            }
            pictureBox1.Refresh();

            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;

            label1.Text =  e.X + "," + e.Y;
            
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;

            sX = x - cX;
            sY = y - cY;

            if (curTool == TOOL.ELLIPSE)
            {
                g.DrawEllipse(pen, cX, cY, sX, sY);
            }
            if (curTool == TOOL.RECTANGLE)
            {
                g.DrawRectangle(pen, cX, cY, sX, sY);
            }
            if (curTool == TOOL.LINE)
            {
                g.DrawLine(pen, cX, cY, x, y);
            }
            if (curTool == TOOL.TRIANGLE)
            {
                //Triangle triangle = new Triangle(Start, End);
                //trianglesList.Add(triangle);
                //Invalidate();
                End = e.Location;
                this.Invalidate();
                Point point1 = Start;
                Point point2 = new Point((Start.X + End.X) / 2, End.Y);
                Point point3 = End;
                g.DrawPolygon(pen, new Point[] { point1, point2, point3 });
            }
            if (curTool == TOOL.TEXT)
            {
                DrawText(x, y);
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            if (isDrawing)
            {
                if (curTool == TOOL.ELLIPSE)
                {
                    g.DrawEllipse(pen, cX, cY, sX, sY);

                }
                if (curTool == TOOL.RECTANGLE)
                {
                    g.DrawRectangle(pen, cX, cY, sX, sY);
                }
                if (curTool == TOOL.LINE)
                {
                    g.DrawLine(pen, cX, cY, x, y);
                }
                if (curTool == TOOL.TRIANGLE)
                {
                    //End = PointToClient(MousePosition);
                    //Triangle triangle = new Triangle(Start, End);
                    //triangle.Draw(g, pen);
                    Point point1 = Start;
                    Point point2 = new Point((Start.X + End.X) / 2, End.Y);
                    Point point3 = End;
                    g.DrawPolygon(pen, new Point[] { point1, point2, point3 });
                }
                if (curTool == TOOL.TEXT)
                {
                    DrawText(x, y);
                }
            }
            //foreach (var triangle in trianglesList)
            //{
            //    triangle.Draw(g, pen);
            //}
        }

        private void DrawText(int x, int y)
        {
           Font font = richTB_text.Font;
           Brush brush = new SolidBrush(new_color);

           g.DrawString(richTB_text.Text, font, brush, x, y);
        }

        private void guna2ImageButton2_Click_1(object sender, EventArgs e)
        {
            curTool = TOOL.TRIANGLE;
        }

        private void bt_pencil_Click(object sender, EventArgs e)
        {
            curTool = TOOL.PEN;
        }
        static Point set_point(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }
        private void pb_color_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_point(pb_color, e.Location);
            pic_color.FillColor = ((Bitmap)pb_color.Image).GetPixel(point.X, point.Y);
            new_color = pic_color.FillColor;
            pen.Color = pic_color.FillColor;
        }

        private void btn_color_dialog_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_color = cd.Color;
            pic_color.FillColor = cd.Color;
            pen.Color = cd.Color;
        }
        private void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color old_color, Color new_color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);
            }
        }

        public void Fill(Bitmap bm, int x, int y, Color new_clr)
        {
            Color old_color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_clr);
            if (old_color == new_clr) return;

            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0
                    && pt.X < bm.Width - 1
                    && pt.Y < bm.Height - 1)
                {
                    validate(bm, pixel, pt.X - 1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y - 1, old_color, new_clr);
                    validate(bm, pixel, pt.X + 1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y + 1, old_color, new_clr);

                }
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (curTool == TOOL.FILLCOLOR)
            {
                Point point = set_point(pictureBox1, e.Location);
                Fill(bm, point.X, point.Y, new_color);
            }
            if (curTool == TOOL.TEXT)
            {
                
               
            }
        }

        private void bt_text_Click(object sender, EventArgs e)
        {
            curTool = TOOL.TEXT;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_I_Click(object sender, EventArgs e)
        {
            isItalicActive = !isItalicActive; // Đảo ngược trạng thái

            // Cập nhật màu sắc của button
            btn_I.BackColor = isItalicActive ? activeColor : defaultColor;

            // Áp dụng font style
            ApplyFontStyle();
        }

        private void btn_Bold_Click(object sender, EventArgs e)
        {
            isBoldActive = !isBoldActive; // Đảo ngược trạng thái

            // Cập nhật màu sắc của button
            btn_Bold.BackColor = isBoldActive ? activeColor : defaultColor;

            // Áp dụng font style
            ApplyFontStyle();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            isUnderlineActive = !isUnderlineActive; // Đảo ngược trạng thái

            // Cập nhật màu sắc của button
            btn_underline.BackColor = isUnderlineActive ? activeColor : defaultColor;

            // Áp dụng font style
            ApplyFontStyle();
        }
        private void ApplyFontStyle()
        {
            // Lấy tên font từ ComboBox
            string fontName = cb_Font.SelectedItem.ToString();

            // Lấy kích thước font từ ComboBox
            float fontSize = float.Parse(cb_TextSize.SelectedItem.ToString());

            // Xác định kiểu chữ in đậm, nghiêng, gạch chân dựa trên trạng thái của các button
            FontStyle style = FontStyle.Regular;
            if (isBoldActive)
                style |= FontStyle.Bold;
            if (isItalicActive)
                style |= FontStyle.Italic;
            if (isUnderlineActive)
                style |= FontStyle.Underline;

            // Tạo đối tượng Font với các giá trị đã chọn và kiểu chữ
            Font font = new Font(fontName, fontSize, style);

            // Áp dụng font cho văn bản hoặc điều khiển khác
            richTB_text.Font = font;
        }

        private void panelZoom_Paint(object sender, PaintEventArgs e)
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
    }
}
