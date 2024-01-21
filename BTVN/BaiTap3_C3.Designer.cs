namespace BTVN
{
    partial class BaiTap3_C3
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
            this.pl_color = new System.Windows.Forms.Panel();
            this.rdbtn_red = new System.Windows.Forms.RadioButton();
            this.rdbtn_green = new System.Windows.Forms.RadioButton();
            this.rdbtn_blue = new System.Windows.Forms.RadioButton();
            this.rdbtn_black = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pl_font = new System.Windows.Forms.Panel();
            this.cb_bold = new System.Windows.Forms.CheckBox();
            this.cb_italic = new System.Windows.Forms.CheckBox();
            this.cb_underline = new System.Windows.Forms.CheckBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_hoVaTen = new System.Windows.Forms.TextBox();
            this.pl_color.SuspendLayout();
            this.pl_font.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_color
            // 
            this.pl_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pl_color.Controls.Add(this.rdbtn_black);
            this.pl_color.Controls.Add(this.rdbtn_red);
            this.pl_color.Controls.Add(this.rdbtn_blue);
            this.pl_color.Controls.Add(this.rdbtn_green);
            this.pl_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pl_color.Location = new System.Drawing.Point(24, 99);
            this.pl_color.Name = "pl_color";
            this.pl_color.Size = new System.Drawing.Size(148, 157);
            this.pl_color.TabIndex = 0;
            // 
            // rdbtn_red
            // 
            this.rdbtn_red.AutoSize = true;
            this.rdbtn_red.ForeColor = System.Drawing.Color.Red;
            this.rdbtn_red.Location = new System.Drawing.Point(16, 23);
            this.rdbtn_red.Name = "rdbtn_red";
            this.rdbtn_red.Size = new System.Drawing.Size(63, 24);
            this.rdbtn_red.TabIndex = 1;
            this.rdbtn_red.TabStop = true;
            this.rdbtn_red.Text = "Red";
            this.rdbtn_red.UseVisualStyleBackColor = true;
            this.rdbtn_red.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbtn_green
            // 
            this.rdbtn_green.AutoSize = true;
            this.rdbtn_green.ForeColor = System.Drawing.Color.DarkGreen;
            this.rdbtn_green.Location = new System.Drawing.Point(16, 49);
            this.rdbtn_green.Name = "rdbtn_green";
            this.rdbtn_green.Size = new System.Drawing.Size(81, 24);
            this.rdbtn_green.TabIndex = 2;
            this.rdbtn_green.TabStop = true;
            this.rdbtn_green.Text = "Green";
            this.rdbtn_green.UseVisualStyleBackColor = true;
            this.rdbtn_green.CheckedChanged += new System.EventHandler(this.rdbtn_green_CheckedChanged);
            // 
            // rdbtn_blue
            // 
            this.rdbtn_blue.AutoSize = true;
            this.rdbtn_blue.ForeColor = System.Drawing.Color.Blue;
            this.rdbtn_blue.Location = new System.Drawing.Point(16, 75);
            this.rdbtn_blue.Name = "rdbtn_blue";
            this.rdbtn_blue.Size = new System.Drawing.Size(68, 24);
            this.rdbtn_blue.TabIndex = 3;
            this.rdbtn_blue.TabStop = true;
            this.rdbtn_blue.Text = "Blue";
            this.rdbtn_blue.UseVisualStyleBackColor = true;
            this.rdbtn_blue.CheckedChanged += new System.EventHandler(this.rdbtn_blue_CheckedChanged);
            // 
            // rdbtn_black
            // 
            this.rdbtn_black.AutoSize = true;
            this.rdbtn_black.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbtn_black.Location = new System.Drawing.Point(16, 101);
            this.rdbtn_black.Name = "rdbtn_black";
            this.rdbtn_black.Size = new System.Drawing.Size(77, 24);
            this.rdbtn_black.TabIndex = 4;
            this.rdbtn_black.TabStop = true;
            this.rdbtn_black.Text = "Black";
            this.rdbtn_black.UseVisualStyleBackColor = true;
            this.rdbtn_black.CheckedChanged += new System.EventHandler(this.rdbtn_black_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "font";
            // 
            // pl_font
            // 
            this.pl_font.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pl_font.Controls.Add(this.cb_underline);
            this.pl_font.Controls.Add(this.cb_italic);
            this.pl_font.Controls.Add(this.cb_bold);
            this.pl_font.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pl_font.Location = new System.Drawing.Point(260, 99);
            this.pl_font.Name = "pl_font";
            this.pl_font.Size = new System.Drawing.Size(169, 157);
            this.pl_font.TabIndex = 2;
            // 
            // cb_bold
            // 
            this.cb_bold.AutoSize = true;
            this.cb_bold.Location = new System.Drawing.Point(16, 23);
            this.cb_bold.Name = "cb_bold";
            this.cb_bold.Size = new System.Drawing.Size(69, 24);
            this.cb_bold.TabIndex = 4;
            this.cb_bold.Text = "Đậm";
            this.cb_bold.UseVisualStyleBackColor = true;
            this.cb_bold.CheckedChanged += new System.EventHandler(this.cb_bold_CheckedChanged);
            // 
            // cb_italic
            // 
            this.cb_italic.AutoSize = true;
            this.cb_italic.Location = new System.Drawing.Point(16, 62);
            this.cb_italic.Name = "cb_italic";
            this.cb_italic.Size = new System.Drawing.Size(99, 24);
            this.cb_italic.TabIndex = 5;
            this.cb_italic.Text = "Nghiêng";
            this.cb_italic.UseVisualStyleBackColor = true;
            this.cb_italic.CheckedChanged += new System.EventHandler(this.cb_italic_CheckedChanged);
            // 
            // cb_underline
            // 
            this.cb_underline.AutoSize = true;
            this.cb_underline.Location = new System.Drawing.Point(16, 101);
            this.cb_underline.Name = "cb_underline";
            this.cb_underline.Size = new System.Drawing.Size(121, 24);
            this.cb_underline.TabIndex = 6;
            this.cb_underline.Text = "Gạch chân";
            this.cb_underline.UseVisualStyleBackColor = true;
            this.cb_underline.CheckedChanged += new System.EventHandler(this.cb_underline_CheckedChanged);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(295, 358);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(134, 38);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lập trình bởi";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(157, 298);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(272, 30);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Nguyễn Phú - 31221024738";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(24, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(113, 30);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Nhập tên";
            // 
            // txt_hoVaTen
            // 
            this.txt_hoVaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hoVaTen.Location = new System.Drawing.Point(157, 38);
            this.txt_hoVaTen.Name = "txt_hoVaTen";
            this.txt_hoVaTen.Size = new System.Drawing.Size(272, 30);
            this.txt_hoVaTen.TabIndex = 8;
            // 
            // BaiTap3_C3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 414);
            this.Controls.Add(this.txt_hoVaTen);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pl_font);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pl_color);
            this.Name = "BaiTap3_C3";
            this.Text = "BaiTap3_C3";
            this.pl_color.ResumeLayout(false);
            this.pl_color.PerformLayout();
            this.pl_font.ResumeLayout(false);
            this.pl_font.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pl_color;
        private System.Windows.Forms.RadioButton rdbtn_red;
        private System.Windows.Forms.RadioButton rdbtn_black;
        private System.Windows.Forms.RadioButton rdbtn_blue;
        private System.Windows.Forms.RadioButton rdbtn_green;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pl_font;
        private System.Windows.Forms.CheckBox cb_underline;
        private System.Windows.Forms.CheckBox cb_italic;
        private System.Windows.Forms.CheckBox cb_bold;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txt_hoVaTen;
    }
}