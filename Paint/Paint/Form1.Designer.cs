﻿namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_color = new System.Windows.Forms.Button();
            this.pic_color = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_circle = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_fill = new System.Windows.Forms.Button();
            this.btn_pen = new System.Windows.Forms.Button();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.btn_solid = new System.Windows.Forms.Button();
            this.btn_dash = new System.Windows.Forms.Button();
            this.btn_1px = new System.Windows.Forms.Button();
            this.btn_5px = new System.Windows.Forms.Button();
            this.btn_10px = new System.Windows.Forms.Button();
            this.btn_15px = new System.Windows.Forms.Button();
            this.btn_marker = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_open);
            this.panel1.Controls.Add(this.btn_marker);
            this.panel1.Controls.Add(this.btn_15px);
            this.panel1.Controls.Add(this.btn_10px);
            this.panel1.Controls.Add(this.btn_5px);
            this.panel1.Controls.Add(this.btn_1px);
            this.panel1.Controls.Add(this.btn_dash);
            this.panel1.Controls.Add(this.btn_solid);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 90);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel5.Controls.Add(this.btn_color);
            this.panel5.Controls.Add(this.pic_color);
            this.panel5.Location = new System.Drawing.Point(8, 9);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(125, 72);
            this.panel5.TabIndex = 11;
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btn_color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_color.ForeColor = System.Drawing.Color.Black;
            this.btn_color.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_color.Location = new System.Drawing.Point(9, 7);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(61, 53);
            this.btn_color.TabIndex = 1;
            this.btn_color.Text = "цвет";
            this.btn_color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_color.UseVisualStyleBackColor = false;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.SystemColors.Control;
            this.pic_color.ForeColor = System.Drawing.Color.Black;
            this.pic_color.Location = new System.Drawing.Point(81, 19);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(34, 31);
            this.pic_color.TabIndex = 0;
            this.pic_color.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Paint.Properties.Resources.kit;
            this.pictureBox1.Location = new System.Drawing.Point(773, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 63);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel4.Controls.Add(this.btn_circle);
            this.panel4.Controls.Add(this.btn_line);
            this.panel4.Controls.Add(this.btn_rect);
            this.panel4.Location = new System.Drawing.Point(371, 10);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(219, 71);
            this.panel4.TabIndex = 5;
            // 
            // btn_circle
            // 
            this.btn_circle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_circle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btn_circle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_circle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_circle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_circle.Image = global::Paint.Properties.Resources.circle;
            this.btn_circle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_circle.Location = new System.Drawing.Point(148, 10);
            this.btn_circle.Name = "btn_circle";
            this.btn_circle.Size = new System.Drawing.Size(64, 53);
            this.btn_circle.TabIndex = 5;
            this.btn_circle.Text = "круг";
            this.btn_circle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_circle.UseVisualStyleBackColor = false;
            this.btn_circle.Click += new System.EventHandler(this.btn_circle_Click);
            // 
            // btn_line
            // 
            this.btn_line.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btn_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_line.ForeColor = System.Drawing.Color.Black;
            this.btn_line.Image = global::Paint.Properties.Resources.line;
            this.btn_line.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_line.Location = new System.Drawing.Point(79, 10);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(64, 53);
            this.btn_line.TabIndex = 7;
            this.btn_line.Text = "линия";
            this.btn_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_line.UseVisualStyleBackColor = false;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // btn_rect
            // 
            this.btn_rect.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_rect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btn_rect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_rect.Image = global::Paint.Properties.Resources.square;
            this.btn_rect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rect.Location = new System.Drawing.Point(9, 10);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(65, 53);
            this.btn_rect.TabIndex = 6;
            this.btn_rect.Text = "квадрат";
            this.btn_rect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rect.UseVisualStyleBackColor = false;
            this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
            // 
            // btn_save
            // 
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_save.Location = new System.Drawing.Point(857, 9);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(58, 23);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_clear.Location = new System.Drawing.Point(857, 58);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(58, 23);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Controls.Add(this.btn_fill);
            this.panel3.Controls.Add(this.btn_pen);
            this.panel3.Controls.Add(this.btn_eraser);
            this.panel3.Location = new System.Drawing.Point(144, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 72);
            this.panel3.TabIndex = 8;
            // 
            // btn_fill
            // 
            this.btn_fill.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btn_fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fill.ForeColor = System.Drawing.Color.Black;
            this.btn_fill.Image = global::Paint.Properties.Resources.fill;
            this.btn_fill.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_fill.Location = new System.Drawing.Point(9, 10);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(61, 53);
            this.btn_fill.TabIndex = 2;
            this.btn_fill.Text = "заливка";
            this.btn_fill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_fill.UseVisualStyleBackColor = false;
            this.btn_fill.Click += new System.EventHandler(this.btn_fill_Click);
            // 
            // btn_pen
            // 
            this.btn_pen.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_pen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btn_pen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_pen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pen.ForeColor = System.Drawing.Color.Black;
            this.btn_pen.Image = global::Paint.Properties.Resources.pencil;
            this.btn_pen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_pen.Location = new System.Drawing.Point(75, 10);
            this.btn_pen.Name = "btn_pen";
            this.btn_pen.Size = new System.Drawing.Size(63, 53);
            this.btn_pen.TabIndex = 3;
            this.btn_pen.Text = "кисть";
            this.btn_pen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pen.UseVisualStyleBackColor = false;
            this.btn_pen.Click += new System.EventHandler(this.btn_pen_Click);
            // 
            // btn_eraser
            // 
            this.btn_eraser.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btn_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eraser.ForeColor = System.Drawing.Color.Black;
            this.btn_eraser.Image = global::Paint.Properties.Resources.eraser;
            this.btn_eraser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_eraser.Location = new System.Drawing.Point(143, 10);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(64, 53);
            this.btn_eraser.TabIndex = 4;
            this.btn_eraser.Text = "ластик";
            this.btn_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eraser.UseVisualStyleBackColor = false;
            this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 488);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 23);
            this.panel2.TabIndex = 1;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(924, 511);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // btn_solid
            // 
            this.btn_solid.Location = new System.Drawing.Point(595, 12);
            this.btn_solid.Name = "btn_solid";
            this.btn_solid.Size = new System.Drawing.Size(75, 23);
            this.btn_solid.TabIndex = 3;
            this.btn_solid.Text = "Сплошная";
            this.btn_solid.UseVisualStyleBackColor = true;
            this.btn_solid.Click += new System.EventHandler(this.btn_solid_Click);
            // 
            // btn_dash
            // 
            this.btn_dash.Location = new System.Drawing.Point(595, 36);
            this.btn_dash.Name = "btn_dash";
            this.btn_dash.Size = new System.Drawing.Size(75, 23);
            this.btn_dash.TabIndex = 12;
            this.btn_dash.Text = "Прерывная";
            this.btn_dash.UseVisualStyleBackColor = true;
            this.btn_dash.Click += new System.EventHandler(this.btn_dash_Click);
            // 
            // btn_1px
            // 
            this.btn_1px.Location = new System.Drawing.Point(676, 12);
            this.btn_1px.Name = "btn_1px";
            this.btn_1px.Size = new System.Drawing.Size(75, 23);
            this.btn_1px.TabIndex = 13;
            this.btn_1px.Text = "Толщина 1";
            this.btn_1px.UseVisualStyleBackColor = true;
            this.btn_1px.Click += new System.EventHandler(this.btn_1px_Click);
            // 
            // btn_5px
            // 
            this.btn_5px.Location = new System.Drawing.Point(676, 36);
            this.btn_5px.Name = "btn_5px";
            this.btn_5px.Size = new System.Drawing.Size(75, 23);
            this.btn_5px.TabIndex = 14;
            this.btn_5px.Text = "Толщина 5";
            this.btn_5px.UseVisualStyleBackColor = true;
            this.btn_5px.Click += new System.EventHandler(this.btn_5px_Click);
            // 
            // btn_10px
            // 
            this.btn_10px.Location = new System.Drawing.Point(595, 64);
            this.btn_10px.Name = "btn_10px";
            this.btn_10px.Size = new System.Drawing.Size(92, 23);
            this.btn_10px.TabIndex = 15;
            this.btn_10px.Text = "Толщина 10";
            this.btn_10px.UseVisualStyleBackColor = true;
            this.btn_10px.Click += new System.EventHandler(this.btn_10px_Click);
            // 
            // btn_15px
            // 
            this.btn_15px.Location = new System.Drawing.Point(693, 65);
            this.btn_15px.Name = "btn_15px";
            this.btn_15px.Size = new System.Drawing.Size(86, 23);
            this.btn_15px.TabIndex = 16;
            this.btn_15px.Text = "Толщина 15";
            this.btn_15px.UseVisualStyleBackColor = true;
            this.btn_15px.Click += new System.EventHandler(this.btn_15px_Click);
            // 
            // btn_marker
            // 
            this.btn_marker.Location = new System.Drawing.Point(757, 12);
            this.btn_marker.Name = "btn_marker";
            this.btn_marker.Size = new System.Drawing.Size(75, 23);
            this.btn_marker.TabIndex = 17;
            this.btn_marker.Text = "marker";
            this.btn_marker.UseVisualStyleBackColor = true;
            this.btn_marker.Click += new System.EventHandler(this.btn_marker_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(333, 3);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 23);
            this.btn_open.TabIndex = 18;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            //this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Button btn_rect;
        private System.Windows.Forms.Button btn_circle;
        private System.Windows.Forms.Button btn_eraser;
        private System.Windows.Forms.Button btn_pen;
        private System.Windows.Forms.Button btn_fill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_dash;
        private System.Windows.Forms.Button btn_solid;
        private System.Windows.Forms.Button btn_marker;
        private System.Windows.Forms.Button btn_15px;
        private System.Windows.Forms.Button btn_10px;
        private System.Windows.Forms.Button btn_5px;
        private System.Windows.Forms.Button btn_1px;
        private System.Windows.Forms.Button btn_open;
    }
}

