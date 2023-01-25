namespace Paint
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.pic_color = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.btn_fill = new System.Windows.Forms.Button();
            this.btn_pen = new System.Windows.Forms.Button();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.btn_circle = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.color_pic = new System.Windows.Forms.PictureBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.color_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.color_pic);
            this.panel1.Controls.Add(this.btn_color);
            this.panel1.Controls.Add(this.pic_color);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 92);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 488);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(864, 23);
            this.panel2.TabIndex = 1;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(864, 511);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.SystemColors.Control;
            this.pic_color.Location = new System.Drawing.Point(520, 9);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(34, 31);
            this.pic_color.TabIndex = 0;
            this.pic_color.UseVisualStyleBackColor = false;
            // 
            // btn_color
            // 
            this.btn_color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_color.ForeColor = System.Drawing.Color.White;
            this.btn_color.Image = global::Paint.Properties.Resources.color;
            this.btn_color.Location = new System.Drawing.Point(20, 13);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(61, 53);
            this.btn_color.TabIndex = 1;
            this.btn_color.Text = "Color";
            this.btn_color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_fill
            // 
            this.btn_fill.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fill.ForeColor = System.Drawing.Color.White;
            this.btn_fill.Image = global::Paint.Properties.Resources.bucket;
            this.btn_fill.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_fill.Location = new System.Drawing.Point(75, 10);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(61, 53);
            this.btn_fill.TabIndex = 2;
            this.btn_fill.Text = "Fill";
            this.btn_fill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_fill.UseVisualStyleBackColor = false;
            this.btn_fill.Click += new System.EventHandler(this.btn_fill_Click);
            // 
            // btn_pen
            // 
            this.btn_pen.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_pen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_pen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_pen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pen.ForeColor = System.Drawing.Color.White;
            this.btn_pen.Image = global::Paint.Properties.Resources.pencil;
            this.btn_pen.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_pen.Location = new System.Drawing.Point(142, 10);
            this.btn_pen.Name = "btn_pen";
            this.btn_pen.Size = new System.Drawing.Size(63, 53);
            this.btn_pen.TabIndex = 3;
            this.btn_pen.Text = "Pencil";
            this.btn_pen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pen.UseVisualStyleBackColor = false;
            this.btn_pen.Click += new System.EventHandler(this.btn_pen_Click);
            // 
            // btn_eraser
            // 
            this.btn_eraser.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eraser.ForeColor = System.Drawing.Color.White;
            this.btn_eraser.Image = global::Paint.Properties.Resources.eraser;
            this.btn_eraser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eraser.Location = new System.Drawing.Point(211, 10);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(64, 53);
            this.btn_eraser.TabIndex = 4;
            this.btn_eraser.Text = "Eraser";
            this.btn_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eraser.UseVisualStyleBackColor = false;
            this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
            // 
            // btn_circle
            // 
            this.btn_circle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_circle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_circle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_circle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_circle.ForeColor = System.Drawing.Color.White;
            this.btn_circle.Image = global::Paint.Properties.Resources.circle;
            this.btn_circle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_circle.Location = new System.Drawing.Point(281, 10);
            this.btn_circle.Name = "btn_circle";
            this.btn_circle.Size = new System.Drawing.Size(64, 53);
            this.btn_circle.TabIndex = 5;
            this.btn_circle.Text = "Circle";
            this.btn_circle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_circle.UseVisualStyleBackColor = false;
            this.btn_circle.Click += new System.EventHandler(this.btn_circle_Click);
            // 
            // btn_rect
            // 
            this.btn_rect.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_rect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_rect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rect.ForeColor = System.Drawing.Color.White;
            this.btn_rect.Image = global::Paint.Properties.Resources.rectangle;
            this.btn_rect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rect.Location = new System.Drawing.Point(351, 10);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(70, 53);
            this.btn_rect.TabIndex = 6;
            this.btn_rect.Text = "Rectangle";
            this.btn_rect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rect.UseVisualStyleBackColor = false;
            this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
            // 
            // btn_line
            // 
            this.btn_line.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_line.ForeColor = System.Drawing.Color.White;
            this.btn_line.Image = global::Paint.Properties.Resources.line;
            this.btn_line.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_line.Location = new System.Drawing.Point(427, 10);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(64, 53);
            this.btn_line.TabIndex = 7;
            this.btn_line.Text = "Line";
            this.btn_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_line.UseVisualStyleBackColor = false;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.btn_fill);
            this.panel3.Controls.Add(this.btn_pen);
            this.panel3.Controls.Add(this.btn_line);
            this.panel3.Controls.Add(this.btn_eraser);
            this.panel3.Controls.Add(this.btn_rect);
            this.panel3.Controls.Add(this.btn_circle);
            this.panel3.Location = new System.Drawing.Point(12, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(502, 80);
            this.panel3.TabIndex = 8;
            // 
            // color_pic
            // 
            this.color_pic.BackColor = System.Drawing.Color.White;
            this.color_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_pic.Image = global::Paint.Properties.Resources.color_palette;
            this.color_pic.Location = new System.Drawing.Point(560, 3);
            this.color_pic.Name = "color_pic";
            this.color_pic.Size = new System.Drawing.Size(175, 80);
            this.color_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.color_pic.TabIndex = 9;
            this.color_pic.TabStop = false;
            this.color_pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.color_pic_MouseClick);
            // 
            // btn_clear
            // 
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_clear.Location = new System.Drawing.Point(741, 43);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(58, 23);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_save
            // 
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_save.Location = new System.Drawing.Point(741, 9);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(58, 23);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.color_pic)).EndInit();
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
        private System.Windows.Forms.PictureBox color_pic;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
    }
}

