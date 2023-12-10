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
            this.panelView = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelZoom = new Guna.UI2.WinForms.Guna2Panel();
            this.trackBarZoom = new System.Windows.Forms.TrackBar();
            this.bt_zoom_reduce = new System.Windows.Forms.Button();
            this.bt_zoom_plus = new System.Windows.Forms.Button();
            this.labelZoomPercent = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel_chung = new Guna.UI2.WinForms.Guna2Panel();
            this.panel_color_picker = new Guna.UI2.WinForms.Guna2Panel();
            this.panel_select = new Guna.UI2.WinForms.Guna2Panel();
            this.panel_tool = new Guna.UI2.WinForms.Guna2Panel();
            this.panel_brush = new Guna.UI2.WinForms.Guna2Panel();
            this.panel_shape = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel_size = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_pencil = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.menuStrip1.SuspendLayout();
            this.panelZoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.panel_chung.SuspendLayout();
            this.panel_tool.SuspendLayout();
            this.panel_shape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelView
            // 
            this.panelView.Location = new System.Drawing.Point(0, 0);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(200, 100);
            this.panelView.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1050, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // panelZoom
            // 
            this.panelZoom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelZoom.BorderColor = System.Drawing.Color.DarkGray;
            this.panelZoom.BorderRadius = 1;
            this.panelZoom.BorderThickness = 1;
            this.panelZoom.Controls.Add(this.labelZoomPercent);
            this.panelZoom.Controls.Add(this.bt_zoom_plus);
            this.panelZoom.Controls.Add(this.bt_zoom_reduce);
            this.panelZoom.Controls.Add(this.trackBarZoom);
            this.panelZoom.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelZoom.Location = new System.Drawing.Point(753, 532);
            this.panelZoom.Name = "panelZoom";
            this.panelZoom.Size = new System.Drawing.Size(298, 31);
            this.panelZoom.TabIndex = 1;
            // 
            // trackBarZoom
            // 
            this.trackBarZoom.Location = new System.Drawing.Point(104, 3);
            this.trackBarZoom.Name = "trackBarZoom";
            this.trackBarZoom.Size = new System.Drawing.Size(131, 56);
            this.trackBarZoom.TabIndex = 0;
            this.trackBarZoom.Value = 10;
            // 
            // bt_zoom_reduce
            // 
            this.bt_zoom_reduce.Location = new System.Drawing.Point(78, 8);
            this.bt_zoom_reduce.Name = "bt_zoom_reduce";
            this.bt_zoom_reduce.Size = new System.Drawing.Size(20, 20);
            this.bt_zoom_reduce.TabIndex = 1;
            this.bt_zoom_reduce.Text = "-";
            this.bt_zoom_reduce.UseVisualStyleBackColor = true;
            // 
            // bt_zoom_plus
            // 
            this.bt_zoom_plus.Location = new System.Drawing.Point(241, 8);
            this.bt_zoom_plus.Name = "bt_zoom_plus";
            this.bt_zoom_plus.Size = new System.Drawing.Size(20, 20);
            this.bt_zoom_plus.TabIndex = 2;
            this.bt_zoom_plus.Text = "+";
            this.bt_zoom_plus.UseVisualStyleBackColor = true;
            // 
            // labelZoomPercent
            // 
            this.labelZoomPercent.AutoSize = true;
            this.labelZoomPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZoomPercent.ForeColor = System.Drawing.Color.Black;
            this.labelZoomPercent.Location = new System.Drawing.Point(35, 8);
            this.labelZoomPercent.Name = "labelZoomPercent";
            this.labelZoomPercent.Size = new System.Drawing.Size(37, 18);
            this.labelZoomPercent.TabIndex = 3;
            this.labelZoomPercent.Text = "20%";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(3, 532);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 30);
            this.panel2.TabIndex = 3;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(30, 25);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "1222 x 1222";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Panel1.BorderRadius = 1;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.Location = new System.Drawing.Point(365, 532);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(388, 30);
            this.guna2Panel1.TabIndex = 5;
            // 
            // panel_chung
            // 
            this.panel_chung.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_chung.BorderColor = System.Drawing.Color.Gainsboro;
            this.panel_chung.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.panel_chung.BorderThickness = 1;
            this.panel_chung.Controls.Add(this.label5);
            this.panel_chung.Controls.Add(this.label4);
            this.panel_chung.Controls.Add(this.label3);
            this.panel_chung.Controls.Add(this.label2);
            this.panel_chung.Controls.Add(this.panel_size);
            this.panel_chung.Controls.Add(this.panel_shape);
            this.panel_chung.Controls.Add(this.panel_brush);
            this.panel_chung.Controls.Add(this.panel_tool);
            this.panel_chung.Controls.Add(this.panel_select);
            this.panel_chung.Controls.Add(this.panel_color_picker);
            this.panel_chung.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_chung.Location = new System.Drawing.Point(0, 28);
            this.panel_chung.Name = "panel_chung";
            this.panel_chung.Size = new System.Drawing.Size(1050, 107);
            this.panel_chung.TabIndex = 6;
            // 
            // panel_color_picker
            // 
            this.panel_color_picker.BorderColor = System.Drawing.Color.Gainsboro;
            this.panel_color_picker.BorderThickness = 1;
            this.panel_color_picker.Location = new System.Drawing.Point(669, 0);
            this.panel_color_picker.Name = "panel_color_picker";
            this.panel_color_picker.Size = new System.Drawing.Size(378, 82);
            this.panel_color_picker.TabIndex = 0;
            // 
            // panel_select
            // 
            this.panel_select.BorderColor = System.Drawing.Color.Gainsboro;
            this.panel_select.BorderThickness = 1;
            this.panel_select.Location = new System.Drawing.Point(2, 0);
            this.panel_select.Name = "panel_select";
            this.panel_select.Size = new System.Drawing.Size(130, 81);
            this.panel_select.TabIndex = 1;
            // 
            // panel_tool
            // 
            this.panel_tool.BorderColor = System.Drawing.Color.Gainsboro;
            this.panel_tool.BorderThickness = 1;
            this.panel_tool.Controls.Add(this.guna2ImageButton3);
            this.panel_tool.Controls.Add(this.guna2ImageButton2);
            this.panel_tool.Controls.Add(this.guna2ImageButton1);
            this.panel_tool.Controls.Add(this.guna2PictureBox3);
            this.panel_tool.Controls.Add(this.bt_pencil);
            this.panel_tool.Location = new System.Drawing.Point(130, 0);
            this.panel_tool.Name = "panel_tool";
            this.panel_tool.Size = new System.Drawing.Size(128, 82);
            this.panel_tool.TabIndex = 2;
            // 
            // panel_brush
            // 
            this.panel_brush.BorderColor = System.Drawing.Color.Gainsboro;
            this.panel_brush.BorderThickness = 1;
            this.panel_brush.Location = new System.Drawing.Point(255, 0);
            this.panel_brush.Name = "panel_brush";
            this.panel_brush.Size = new System.Drawing.Size(71, 82);
            this.panel_brush.TabIndex = 3;
            // 
            // panel_shape
            // 
            this.panel_shape.BorderColor = System.Drawing.Color.Gainsboro;
            this.panel_shape.BorderThickness = 1;
            this.panel_shape.Controls.Add(this.guna2Panel2);
            this.panel_shape.Location = new System.Drawing.Point(325, 0);
            this.panel_shape.Name = "panel_shape";
            this.panel_shape.Size = new System.Drawing.Size(202, 82);
            this.panel_shape.TabIndex = 4;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Location = new System.Drawing.Point(200, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(146, 78);
            this.guna2Panel2.TabIndex = 0;
            // 
            // panel_size
            // 
            this.panel_size.BorderColor = System.Drawing.Color.Gainsboro;
            this.panel_size.BorderThickness = 1;
            this.panel_size.Location = new System.Drawing.Point(525, 0);
            this.panel_size.Name = "panel_size";
            this.panel_size.Size = new System.Drawing.Size(147, 82);
            this.panel_size.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Image";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(168, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tools";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(394, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Shapes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(828, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Colors";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // bt_pencil
            // 
            this.bt_pencil.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.bt_pencil.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.bt_pencil.Image = ((System.Drawing.Image)(resources.GetObject("bt_pencil.Image")));
            this.bt_pencil.ImageOffset = new System.Drawing.Point(0, 0);
            this.bt_pencil.ImageRotate = 0F;
            this.bt_pencil.ImageSize = new System.Drawing.Size(22, 25);
            this.bt_pencil.Location = new System.Drawing.Point(8, 11);
            this.bt_pencil.Name = "bt_pencil";
            this.bt_pencil.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.bt_pencil.Size = new System.Drawing.Size(30, 30);
            this.bt_pencil.TabIndex = 0;
            this.bt_pencil.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(41, 21);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(20, 20);
            this.guna2PictureBox3.TabIndex = 2;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(22, 22);
            this.guna2ImageButton1.Location = new System.Drawing.Point(44, 11);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.TabIndex = 3;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click_1);
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton2.Location = new System.Drawing.Point(83, 11);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Size = new System.Drawing.Size(36, 30);
            this.guna2ImageButton2.TabIndex = 4;
            this.guna2ImageButton2.Click += new System.EventHandler(this.guna2ImageButton2_Click);
            // 
            // guna2ImageButton3
            // 
            this.guna2ImageButton3.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton3.Image")));
            this.guna2ImageButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton3.ImageRotate = 0F;
            this.guna2ImageButton3.ImageSize = new System.Drawing.Size(23, 23);
            this.guna2ImageButton3.Location = new System.Drawing.Point(5, 47);
            this.guna2ImageButton3.Name = "guna2ImageButton3";
            this.guna2ImageButton3.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton3.TabIndex = 5;
            this.guna2ImageButton3.Click += new System.EventHandler(this.guna2ImageButton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1050, 562);
            this.Controls.Add(this.panel_chung);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelZoom);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ArtEase";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelZoom.ResumeLayout(false);
            this.panelZoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panel_chung.ResumeLayout(false);
            this.panel_chung.PerformLayout();
            this.panel_tool.ResumeLayout(false);
            this.panel_shape.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Panel panelZoom;
        private System.Windows.Forms.TrackBar trackBarZoom;
        private System.Windows.Forms.Label labelZoomPercent;
        private System.Windows.Forms.Button bt_zoom_plus;
        private System.Windows.Forms.Button bt_zoom_reduce;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel panel_chung;
        private Guna.UI2.WinForms.Guna2Panel panel_color_picker;
        private Guna.UI2.WinForms.Guna2Panel panel_select;
        private Guna.UI2.WinForms.Guna2Panel panel_brush;
        private Guna.UI2.WinForms.Guna2Panel panel_tool;
        private Guna.UI2.WinForms.Guna2Panel panel_shape;
        private Guna.UI2.WinForms.Guna2Panel panel_size;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton bt_pencil;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
    }
}

