namespace BASICPAINT
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_all = new System.Windows.Forms.Panel();
            this.panel_shape = new System.Windows.Forms.Panel();
            this.button_triangle = new System.Windows.Forms.Button();
            this.button_rectangle = new System.Windows.Forms.Button();
            this.button_elip = new System.Windows.Forms.Button();
            this.button_line = new System.Windows.Forms.Button();
            this.panel_tools = new System.Windows.Forms.Panel();
            this.label_Tool = new System.Windows.Forms.Label();
            this.button_eraser = new System.Windows.Forms.Button();
            this.button_text = new System.Windows.Forms.Button();
            this.button_fill = new System.Windows.Forms.Button();
            this.button_pen = new System.Windows.Forms.Button();
            this.panel_image = new System.Windows.Forms.Panel();
            this.label_image = new System.Windows.Forms.Label();
            this.select_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_brushes = new System.Windows.Forms.Panel();
            this.button_brushes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_all.SuspendLayout();
            this.panel_shape.SuspendLayout();
            this.panel_tools.SuspendLayout();
            this.panel_image.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel_brushes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_all
            // 
            this.panel_all.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_all.Controls.Add(this.panel_shape);
            this.panel_all.Controls.Add(this.panel_tools);
            this.panel_all.Controls.Add(this.panel_image);
            this.panel_all.Location = new System.Drawing.Point(0, 36);
            this.panel_all.Name = "panel_all";
            this.panel_all.Size = new System.Drawing.Size(1034, 138);
            this.panel_all.TabIndex = 0;
            // 
            // panel_shape
            // 
            this.panel_shape.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_shape.Controls.Add(this.button_triangle);
            this.panel_shape.Controls.Add(this.button_rectangle);
            this.panel_shape.Controls.Add(this.button_elip);
            this.panel_shape.Controls.Add(this.button_line);
            this.panel_shape.Location = new System.Drawing.Point(355, -1);
            this.panel_shape.Name = "panel_shape";
            this.panel_shape.Size = new System.Drawing.Size(120, 138);
            this.panel_shape.TabIndex = 2;
            // 
            // button_triangle
            // 
            this.button_triangle.Image = ((System.Drawing.Image)(resources.GetObject("button_triangle.Image")));
            this.button_triangle.Location = new System.Drawing.Point(71, 53);
            this.button_triangle.Name = "button_triangle";
            this.button_triangle.Size = new System.Drawing.Size(44, 44);
            this.button_triangle.TabIndex = 3;
            this.button_triangle.UseVisualStyleBackColor = true;
            // 
            // button_rectangle
            // 
            this.button_rectangle.Image = ((System.Drawing.Image)(resources.GetObject("button_rectangle.Image")));
            this.button_rectangle.Location = new System.Drawing.Point(9, 53);
            this.button_rectangle.Name = "button_rectangle";
            this.button_rectangle.Size = new System.Drawing.Size(44, 44);
            this.button_rectangle.TabIndex = 2;
            this.button_rectangle.UseVisualStyleBackColor = true;
            this.button_rectangle.Click += new System.EventHandler(this.button_rectangle_Click);
            // 
            // button_elip
            // 
            this.button_elip.Image = ((System.Drawing.Image)(resources.GetObject("button_elip.Image")));
            this.button_elip.Location = new System.Drawing.Point(71, 3);
            this.button_elip.Name = "button_elip";
            this.button_elip.Size = new System.Drawing.Size(44, 44);
            this.button_elip.TabIndex = 1;
            this.button_elip.UseVisualStyleBackColor = true;
            this.button_elip.Click += new System.EventHandler(this.button_elip_Click);
            // 
            // button_line
            // 
            this.button_line.Image = ((System.Drawing.Image)(resources.GetObject("button_line.Image")));
            this.button_line.Location = new System.Drawing.Point(9, 3);
            this.button_line.Name = "button_line";
            this.button_line.Size = new System.Drawing.Size(44, 44);
            this.button_line.TabIndex = 0;
            this.button_line.UseVisualStyleBackColor = true;
            this.button_line.Click += new System.EventHandler(this.button_line_Click);
            // 
            // panel_tools
            // 
            this.panel_tools.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_tools.Controls.Add(this.label_Tool);
            this.panel_tools.Controls.Add(this.button_eraser);
            this.panel_tools.Controls.Add(this.button_text);
            this.panel_tools.Controls.Add(this.button_fill);
            this.panel_tools.Controls.Add(this.button_pen);
            this.panel_tools.Location = new System.Drawing.Point(141, -1);
            this.panel_tools.Name = "panel_tools";
            this.panel_tools.Size = new System.Drawing.Size(135, 138);
            this.panel_tools.TabIndex = 1;
            // 
            // label_Tool
            // 
            this.label_Tool.AutoSize = true;
            this.label_Tool.Location = new System.Drawing.Point(43, 108);
            this.label_Tool.Name = "label_Tool";
            this.label_Tool.Size = new System.Drawing.Size(47, 20);
            this.label_Tool.TabIndex = 4;
            this.label_Tool.Text = "Tools";
            // 
            // button_eraser
            // 
            this.button_eraser.Image = ((System.Drawing.Image)(resources.GetObject("button_eraser.Image")));
            this.button_eraser.Location = new System.Drawing.Point(76, 53);
            this.button_eraser.Name = "button_eraser";
            this.button_eraser.Size = new System.Drawing.Size(44, 44);
            this.button_eraser.TabIndex = 3;
            this.button_eraser.UseVisualStyleBackColor = true;
            // 
            // button_text
            // 
            this.button_text.Image = ((System.Drawing.Image)(resources.GetObject("button_text.Image")));
            this.button_text.Location = new System.Drawing.Point(10, 53);
            this.button_text.Name = "button_text";
            this.button_text.Size = new System.Drawing.Size(44, 44);
            this.button_text.TabIndex = 2;
            this.button_text.UseVisualStyleBackColor = true;
            // 
            // button_fill
            // 
            this.button_fill.Image = ((System.Drawing.Image)(resources.GetObject("button_fill.Image")));
            this.button_fill.Location = new System.Drawing.Point(76, 3);
            this.button_fill.Name = "button_fill";
            this.button_fill.Size = new System.Drawing.Size(44, 44);
            this.button_fill.TabIndex = 1;
            this.button_fill.UseVisualStyleBackColor = true;
            // 
            // button_pen
            // 
            this.button_pen.Image = ((System.Drawing.Image)(resources.GetObject("button_pen.Image")));
            this.button_pen.Location = new System.Drawing.Point(10, 3);
            this.button_pen.Name = "button_pen";
            this.button_pen.Size = new System.Drawing.Size(44, 44);
            this.button_pen.TabIndex = 0;
            this.button_pen.UseVisualStyleBackColor = true;
            this.button_pen.Click += new System.EventHandler(this.button_pen_Click);
            // 
            // panel_image
            // 
            this.panel_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_image.Controls.Add(this.label_image);
            this.panel_image.Controls.Add(this.select_button);
            this.panel_image.Location = new System.Drawing.Point(-1, -1);
            this.panel_image.Name = "panel_image";
            this.panel_image.Size = new System.Drawing.Size(147, 138);
            this.panel_image.TabIndex = 0;
            // 
            // label_image
            // 
            this.label_image.AutoSize = true;
            this.label_image.Location = new System.Drawing.Point(54, 108);
            this.label_image.Name = "label_image";
            this.label_image.Size = new System.Drawing.Size(52, 20);
            this.label_image.TabIndex = 1;
            this.label_image.Text = "image";
            // 
            // select_button
            // 
            this.select_button.Image = ((System.Drawing.Image)(resources.GetObject("select_button.Image")));
            this.select_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.select_button.Location = new System.Drawing.Point(-1, 0);
            this.select_button.Name = "select_button";
            this.select_button.Size = new System.Drawing.Size(86, 87);
            this.select_button.TabIndex = 0;
            this.select_button.Text = "select";
            this.select_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.select_button.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1034, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(62, 29);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // panel_brushes
            // 
            this.panel_brushes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_brushes.Controls.Add(this.button_brushes);
            this.panel_brushes.Location = new System.Drawing.Point(269, 36);
            this.panel_brushes.Name = "panel_brushes";
            this.panel_brushes.Size = new System.Drawing.Size(91, 138);
            this.panel_brushes.TabIndex = 2;
            // 
            // button_brushes
            // 
            this.button_brushes.Image = ((System.Drawing.Image)(resources.GetObject("button_brushes.Image")));
            this.button_brushes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_brushes.Location = new System.Drawing.Point(6, -1);
            this.button_brushes.Name = "button_brushes";
            this.button_brushes.Size = new System.Drawing.Size(80, 85);
            this.button_brushes.TabIndex = 0;
            this.button_brushes.Text = "Brushes";
            this.button_brushes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_brushes.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1034, 391);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 617);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_brushes);
            this.Controls.Add(this.panel_all);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_all.ResumeLayout(false);
            this.panel_shape.ResumeLayout(false);
            this.panel_tools.ResumeLayout(false);
            this.panel_tools.PerformLayout();
            this.panel_image.ResumeLayout(false);
            this.panel_image.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_brushes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_all;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel_image;
        private System.Windows.Forms.Button select_button;
        private System.Windows.Forms.Label label_image;
        private System.Windows.Forms.Panel panel_tools;
        private System.Windows.Forms.Button button_pen;
        private System.Windows.Forms.Button button_fill;
        private System.Windows.Forms.Button button_text;
        private System.Windows.Forms.Button button_eraser;
        private System.Windows.Forms.Label label_Tool;
        private System.Windows.Forms.Panel panel_brushes;
        private System.Windows.Forms.Button button_brushes;
        private System.Windows.Forms.Panel panel_shape;
        private System.Windows.Forms.Button button_line;
        private System.Windows.Forms.Button button_rectangle;
        private System.Windows.Forms.Button button_elip;
        private System.Windows.Forms.Button button_triangle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

