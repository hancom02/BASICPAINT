﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BASICPAINT
{
    public partial class Form1 : Form
    {
        private Point Start, End ,Startp,Endp;
        private List<Triangle> trianglesList;
        Bitmap bm;
        Graphics g;
        bool isDrawing = false;
        Point px, py;

        Pen pen = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 10);
        Pen oilBrush = new Pen(new HatchBrush(HatchStyle.Trellis, Color.Red), 15);
        Pen waterBrush = new Pen(Color.FromArgb(128, Color.Blue), 20);

        int x, y, sX, sY, cX, cY;
        int xp,yp, sXp, sYp, cXp, cYp;

        ColorDialog cd = new ColorDialog();
        Color new_color = Color.Black;
        //Point lastPoint;

        private Color defaultColor = Color.White; // Màu ban đầu của button
        private Color activeColor = Color.LightBlue; // Màu khi button được kích hoạt
        private Color brushes_DefaultColor = Color.WhiteSmoke;

        private bool isBoldActive = false;
        private bool isItalicActive = false;
        private bool isUnderlineActive = false;

        private bool isBrushesActive = false;

        public enum TOOL
        {
            SELECT,
            PEN,
            ERASER,
            FILLCOLOR,
            BRUSH,
            TEXT,
            LINE,
            ELLIPSE,
            RECTANGLE,
            TRIANGLE
        }
        public TOOL curTool = TOOL.SELECT;

        //public enum CREATE_TEXT
        //{
        //    YES,
        //    NO,
        //}
        //public CREATE_TEXT curCreateText = CREATE_TEXT.YES;

        public Form1()
        {
            InitializeComponent();

            DoubleBuffered = true;
            g = pictureBox1.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            //erase.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            erase.SetLineCap(LineCap.Square, LineCap.Square, DashCap.Round);
            waterBrush.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pictureBox1.Image = bm;
            trianglesList = new List<Triangle>();
            //pen.Width = (float)pen_width.Value;
            tb_size.Text = pen.Width.ToString();
            
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

            this.DoubleBuffered = true;
            org = new PictureBox();
            org.Image = pictureBox1.Image;

            cb_brush.SelectedItem = "Hatch brush";
            pic_color.FillColor = Color.Black;
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

            panel_brush.BackColor = brushes_DefaultColor;
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            curTool = TOOL.FILLCOLOR;

            panel_brush.BackColor = brushes_DefaultColor;
        }

        

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            curTool = TOOL.ERASER;

            panel_brush.BackColor = brushes_DefaultColor;
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

            panel_brush.BackColor = brushes_DefaultColor;
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton1_Click_2(object sender, EventArgs e)
        {
            curTool = TOOL.RECTANGLE;

            panel_brush.BackColor = brushes_DefaultColor;
        }

        private void guna2ImageButton1_Click_3(object sender, EventArgs e)
        {

        }

        private void bt_size_plus_Click(object sender, EventArgs e)
        {
            pen.Width = pen.Width + 1;
            oilBrush.Width = oilBrush.Width + 1;
            waterBrush.Width = waterBrush.Width + 1;
            erase.Width++;

            tb_size.Text = pen.Width.ToString();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //org = new PictureBox();
            //org.Image = pictureBox1.Image;
            pictureBox1.Image = ZoomPicture(bm ,org.Image, new Size(trackBarZoom.Value, trackBarZoom.Value));
            isDrawing = true;
            Startp = Endp = e.Location;
            Point a = new Point((int)(1.0 * e.Location.X / (1.0 * trackBarZoom.Value / 100)), (int)(1.0 * e.Location.Y / (1.0 * trackBarZoom.Value / 100)));
            //lastPoint = e.Location;
            Start = End = a;
            py = a;
            cX = a.X;
            cY = a.Y;
            cXp = e.X;
            cYp = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Point a = new Point((int)(1.0 * e.Location.X / (1.0 * trackBarZoom.Value / 100)), (int)(1.0 * e.Location.Y / (1.0 * trackBarZoom.Value / 100)));
            
            if (e.Button == MouseButtons.Left)
            {
                if (isDrawing)
                {
                    pictureBox1.Image = ZoomPicture(bm, org.Image, new Size(trackBarZoom.Value, trackBarZoom.Value));
                    if (curTool == TOOL.PEN)
                    {
                        px = a;
                        g.DrawLine(pen, px, py);
                        py = px;
                    }
                    if (curTool == TOOL.ERASER)
                    {
                        px = a;
                        g.DrawLine(erase, px, py);
                        py = px;
                    }
                    if (curTool == TOOL.BRUSH)
                    {
                        px = a;

                        if (cb_brush.SelectedItem.ToString() == "Hatch brush")
                        {
                            //Brush oilBrush = new HatchBrush(HatchStyle.LargeCheckerBoard, new_color);
                            //brushPoints.Add(e.Location);
                            //pictureBox1.Invalidate();

                            g.SmoothingMode = SmoothingMode.AntiAlias;
                            oilBrush.Color = new_color;
                            g.DrawLine(oilBrush, px, py);
                            py = px;

                        }
                        else if (cb_brush.SelectedItem.ToString() == "Water color")
                        {
                            //Brush oilBrush = new HatchBrush(HatchStyle.LargeCheckerBoard, new_color);

                            g.SmoothingMode = SmoothingMode.AntiAlias;
                            waterBrush.Color = Color.FromArgb(128, new_color);
                            g.DrawLine(waterBrush, px, py);
                            py = px;
                        }

                    }
                }
                if (curTool == TOOL.TRIANGLE)
                {
                    End = a;
                    Endp = e.Location;
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
            
            x = a.X;
            y = a.Y;
            xp = e.X;
            yp = e.Y;
            sX = a.X - cX;
            sY = a.Y - cY;
            sXp = e.X - cXp;
            sYp = e.Y - cYp;

            label1.Text =  e.X + "," + e.Y;
            pictureBox1.Image = ZoomPicture(bm, org.Image, new Size(trackBarZoom.Value, trackBarZoom.Value));
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //org = new PictureBox();
            //org.Image = pictureBox1.Image;
            Point a = new Point((int)(1.0* e.Location.X / (1.0*trackBarZoom.Value / 100)), (int)(1.0 * e.Location.Y / (1.0 * trackBarZoom.Value / 100)));
            pictureBox1.Image = ZoomPicture(bm, org.Image, new Size(trackBarZoom.Value, trackBarZoom.Value));
            isDrawing = false;

            sX = x - cX;
            sY = y - cY;
            sXp = xp - cXp;
            sYp = yp - cYp;

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
                End = a;
                Endp = e.Location;
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
                    g.DrawEllipse(pen, cXp, cYp, sXp, sYp);

                }
                if (curTool == TOOL.RECTANGLE)
                {
                    g.DrawRectangle(pen, cXp, cYp, sXp, sYp);
                }
                if (curTool == TOOL.LINE)
                {
                    g.DrawLine(pen, cXp, cYp, xp, yp);
                }
                if (curTool == TOOL.TRIANGLE)
                {
                    //End = PointToClient(MousePosition);
                    //Triangle triangle = new Triangle(Start, End);
                    //triangle.Draw(g, pen);
                    Point point1 = Startp;
                    Point point2 = new Point((Startp.X + Endp.X) / 2, Endp.Y);
                    Point point3 = Endp;
                    g.DrawPolygon(pen, new Point[] { point1, point2, point3 });
                }
                //if (curTool == TOOL.TEXT)
                //{
                //    DrawText(x, y);
                //}
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

            panel_brush.BackColor = brushes_DefaultColor;
        }

        private void bt_pencil_Click(object sender, EventArgs e)
        {
            curTool = TOOL.PEN;

            panel_brush.BackColor = brushes_DefaultColor;
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

            panel_brush.BackColor = brushes_DefaultColor;

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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                var sdf = new SaveFileDialog();
                sdf.Filter = "Image(*.jpeg)|*.jpeg";
                if (sdf.ShowDialog() == DialogResult.OK)
                {
                    Bitmap btm = bm.Clone(new Rectangle(0, 0,pictureBox1.Width, pictureBox1.Height), bm.PixelFormat);
                    btm.Save(sdf.FileName, ImageFormat.Jpeg);
                    MessageBox.Show("Image Saved Sucessully");
                }
                else if (pictureBox1.Image == null)
                {
                    MessageBox.Show("Draw Something First");
                }
            }

        }

        private void tb_size_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bt_size_reduce_Click(object sender, EventArgs e)
        {
            pen.Width = pen.Width - 1;
            oilBrush.Width = oilBrush.Width - 1;
            waterBrush.Width = waterBrush.Width - 1;
            erase.Width--;

            tb_size.Text = pen.Width.ToString();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Do you want to save currrent drawing?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                saveToolStripMenuItem.PerformClick();
            }
           
                g.Clear(Color.White);
            pictureBox1.Image = bm;
            org = new PictureBox();
            org.Image = pictureBox1.Image;
            curTool = TOOL.SELECT;
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";

            if (ofd.ShowDialog() == DialogResult.OK)
            { 
                org = new PictureBox();
                org.Load(ofd.FileName);
                pictureBox1.Load(ofd.FileName);
                
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            string message = "Do you want to save currrent drawing?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                saveToolStripMenuItem.PerformClick();
            }
            Application.Exit();
        }

        private void pb_brush_Click(object sender, EventArgs e)
        {
            isBrushesActive = !isBrushesActive;

            panel_brush.BackColor = isBrushesActive ? activeColor : brushes_DefaultColor;

            if (isBrushesActive)
            {
                curTool = TOOL.BRUSH;
                panel_brush.BackColor = activeColor;
            }
            else panel_brush.BackColor = brushes_DefaultColor;
        }

        private void panel_brush_Click(object sender, EventArgs e)
        {
            isBrushesActive = !isBrushesActive;

            panel_brush.BackColor = isBrushesActive ? activeColor : brushes_DefaultColor;

            if (isBrushesActive)
            {
                curTool = TOOL.BRUSH;
            }
        }

        private void cb_Font_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font newFont = new Font(cb_Font.SelectedItem.ToString(), richTB_text.Font.Size);

            richTB_text.Font = newFont;
        }

        private void cb_TextSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font newFont = new Font(cb_Font.SelectedItem.ToString(), float.Parse(cb_TextSize.SelectedItem.ToString()));

            richTB_text.Font = newFont;
        }

        private void cb_brush_SelectedIndexChanged(object sender, EventArgs e)
        {
            curTool = TOOL.BRUSH;
        }

        private void cb_brush_Click(object sender, EventArgs e)
        {
            panel_brush.BackColor = activeColor;
        }

        static Point set_Point(PictureBox pb, Point pt)
        {
            float px = 1f * pb.Width / pb.Width;
            float py = 1f * pb.Height / pb.Height;
            return new Point((int)(pt.X * px), (int)(pt.Y * py));
        }
        private void Validate(Bitmap bm, Stack<Point> sp, int x, int y, Color Old_Color, Color New_Color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == Old_Color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, New_Color);
            }
        }

        //public void Fill(Bitmap bm, int x, int y, Color New_Clr)
        //{
        //    Color Old_Color = bm.GetPixel(x, y);
        //    Stack<Point> pixel = new Stack<Point>();
        //    pixel.Push(new Point(x, y));
        //    bm.SetPixel(x, y, New_Clr);
        //    if (Old_Color == New_Clr) { return; }

        //    while (pixel.Count > 0)
        //    {
        //        Point pt = (Point)pixel.Pop();
        //        if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
        //        {
        //            Validate(bm, pixel, pt.X - 1, pt.Y, Old_Color, New_Clr);
        //            Validate(bm, pixel, pt.X, pt.Y - 1, Old_Color, New_Clr);
        //            Validate(bm, pixel, pt.X + 1, pt.Y, Old_Color, New_Clr);
        //            Validate(bm, pixel, pt.X, pt.Y + 1, Old_Color, New_Clr);
        //        }
        //    }
        //}

        //private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        //{
        //    if (curTool == TOOL.FILLCOLOR)
        //    {
        //        Point point = set_Point(pictureBox1, e.Location);
        //        Fill(bm, point.X, point.Y, new_color);
        //    }
        //}
        PictureBox org;
        System.Drawing.Image ZoomPicture(Bitmap bm, System.Drawing.Image img, Size size)
        {
             bm = new Bitmap(img, Convert.ToInt32(img.Width * size.Width)/100,
                Convert.ToInt32(img.Height * size.Height)/100);
            Graphics gpu = Graphics.FromImage(bm);
            gpu.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bm;
            
        }
        private void trackBarZoom_Scroll(object sender, EventArgs e)
        {
            labelZoomPercent.Text = trackBarZoom.Value.ToString() + "%";
            if (trackBarZoom.Value != 0)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = ZoomPicture(bm,org.Image, new Size(trackBarZoom.Value, trackBarZoom.Value));
            }
           
            
        }

        private void bt_zoom_plus_Click(object sender, EventArgs e)
        {
            if (trackBarZoom.Value < 195)
            {
                trackBarZoom.Value = trackBarZoom.Value + 5;
            }
            else
            {
                trackBarZoom.Value = 200;
            }
            labelZoomPercent.Text = trackBarZoom.Value.ToString() + "%";
            pictureBox1.Image = ZoomPicture(bm, org.Image, new Size(trackBarZoom.Value, trackBarZoom.Value));
        }

        private void bt_zoom_reduce_Click(object sender, EventArgs e)
        {
            if (trackBarZoom.Value > 105)
            {
                trackBarZoom.Value = trackBarZoom.Value - 5;
            }
            else
            {
                trackBarZoom.Value = 100;
            }    
            labelZoomPercent.Text = trackBarZoom.Value.ToString() + "%";
            pictureBox1.Image = ZoomPicture(bm, org.Image, new Size(trackBarZoom.Value, trackBarZoom.Value));
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
