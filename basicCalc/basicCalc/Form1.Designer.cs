namespace basicCalc
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
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_age = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.btn_ass = new System.Windows.Forms.Button();
            this.gb_ex = new System.Windows.Forms.GroupBox();
            this.cb_r = new System.Windows.Forms.ComboBox();
            this.btn_newEx = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            this.lb_num1 = new System.Windows.Forms.Label();
            this.lb_eq = new System.Windows.Forms.Label();
            this.lb_num2 = new System.Windows.Forms.Label();
            this.lb_sign = new System.Windows.Forms.Label();
            this.btn_show_ex = new System.Windows.Forms.Button();
            this.rb_show = new System.Windows.Forms.RadioButton();
            this.rb_show2 = new System.Windows.Forms.RadioButton();
            this.gb_ex.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lb_name.Location = new System.Drawing.Point(861, 82);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(61, 37);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = ":שם";
            this.lb_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_age
            // 
            this.lb_age.AutoSize = true;
            this.lb_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lb_age.Location = new System.Drawing.Point(526, 82);
            this.lb_age.Name = "lb_age";
            this.lb_age.Size = new System.Drawing.Size(60, 37);
            this.lb_age.TabIndex = 1;
            this.lb_age.Text = ":גיל";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tb_name.Location = new System.Drawing.Point(640, 79);
            this.tb_name.Name = "tb_name";
            this.tb_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_name.Size = new System.Drawing.Size(215, 44);
            this.tb_name.TabIndex = 2;
            // 
            // tb_age
            // 
            this.tb_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tb_age.Location = new System.Drawing.Point(305, 79);
            this.tb_age.Name = "tb_age";
            this.tb_age.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_age.Size = new System.Drawing.Size(215, 44);
            this.tb_age.TabIndex = 3;
            // 
            // btn_ass
            // 
            this.btn_ass.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_ass.Location = new System.Drawing.Point(152, 82);
            this.btn_ass.Name = "btn_ass";
            this.btn_ass.Size = new System.Drawing.Size(109, 45);
            this.btn_ass.TabIndex = 4;
            this.btn_ass.Text = "הרשמה";
            this.btn_ass.UseVisualStyleBackColor = true;
            this.btn_ass.Click += new System.EventHandler(this.btn_ass_Click);
            // 
            // gb_ex
            // 
            this.gb_ex.Controls.Add(this.cb_r);
            this.gb_ex.Controls.Add(this.btn_newEx);
            this.gb_ex.Controls.Add(this.btn_check);
            this.gb_ex.Controls.Add(this.lb_num1);
            this.gb_ex.Controls.Add(this.lb_eq);
            this.gb_ex.Controls.Add(this.lb_num2);
            this.gb_ex.Controls.Add(this.lb_sign);
            this.gb_ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.gb_ex.Location = new System.Drawing.Point(152, 210);
            this.gb_ex.Name = "gb_ex";
            this.gb_ex.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gb_ex.Size = new System.Drawing.Size(770, 293);
            this.gb_ex.TabIndex = 5;
            this.gb_ex.TabStop = false;
            this.gb_ex.Text = "תרגילים";
            this.gb_ex.Visible = false;
            // 
            // cb_r
            // 
            this.cb_r.Enabled = false;
            this.cb_r.FormattingEnabled = true;
            this.cb_r.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cb_r.Location = new System.Drawing.Point(547, 74);
            this.cb_r.Name = "cb_r";
            this.cb_r.Size = new System.Drawing.Size(121, 37);
            this.cb_r.TabIndex = 12;
            this.cb_r.SelectedIndexChanged += new System.EventHandler(this.cb_r_SelectedIndexChanged);
            // 
            // btn_newEx
            // 
            this.btn_newEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_newEx.Location = new System.Drawing.Point(138, 215);
            this.btn_newEx.Name = "btn_newEx";
            this.btn_newEx.Size = new System.Drawing.Size(203, 45);
            this.btn_newEx.TabIndex = 11;
            this.btn_newEx.Text = "תרגיל חדש";
            this.btn_newEx.UseVisualStyleBackColor = true;
            this.btn_newEx.Click += new System.EventHandler(this.btn_newEx_Click);
            // 
            // btn_check
            // 
            this.btn_check.Enabled = false;
            this.btn_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_check.Location = new System.Drawing.Point(381, 215);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(203, 45);
            this.btn_check.TabIndex = 6;
            this.btn_check.Text = "בדיקה";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // lb_num1
            // 
            this.lb_num1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lb_num1.Location = new System.Drawing.Point(88, 48);
            this.lb_num1.Name = "lb_num1";
            this.lb_num1.Size = new System.Drawing.Size(82, 63);
            this.lb_num1.TabIndex = 10;
            // 
            // lb_eq
            // 
            this.lb_eq.AutoSize = true;
            this.lb_eq.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lb_eq.Location = new System.Drawing.Point(475, 74);
            this.lb_eq.Name = "lb_eq";
            this.lb_eq.Size = new System.Drawing.Size(36, 37);
            this.lb_eq.TabIndex = 9;
            this.lb_eq.Text = "=";
            // 
            // lb_num2
            // 
            this.lb_num2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lb_num2.Location = new System.Drawing.Point(315, 48);
            this.lb_num2.Name = "lb_num2";
            this.lb_num2.Size = new System.Drawing.Size(82, 63);
            this.lb_num2.TabIndex = 8;
            // 
            // lb_sign
            // 
            this.lb_sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lb_sign.Location = new System.Drawing.Point(176, 48);
            this.lb_sign.Name = "lb_sign";
            this.lb_sign.Size = new System.Drawing.Size(133, 63);
            this.lb_sign.TabIndex = 7;
            // 
            // btn_show_ex
            // 
            this.btn_show_ex.Enabled = false;
            this.btn_show_ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_show_ex.Location = new System.Drawing.Point(682, 641);
            this.btn_show_ex.Name = "btn_show_ex";
            this.btn_show_ex.Size = new System.Drawing.Size(138, 87);
            this.btn_show_ex.TabIndex = 13;
            this.btn_show_ex.Text = "הצג תרגילים";
            this.btn_show_ex.UseVisualStyleBackColor = true;
            this.btn_show_ex.Click += new System.EventHandler(this.btn_show_ex_Click);
            // 
            // rb_show
            // 
            this.rb_show.AutoSize = true;
            this.rb_show.Checked = true;
            this.rb_show.Enabled = false;
            this.rb_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rb_show.Location = new System.Drawing.Point(467, 641);
            this.rb_show.Name = "rb_show";
            this.rb_show.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rb_show.Size = new System.Drawing.Size(202, 41);
            this.rb_show.TabIndex = 14;
            this.rb_show.TabStop = true;
            this.rb_show.Text = "תרגילים נכונים";
            this.rb_show.UseVisualStyleBackColor = true;
            // 
            // rb_show2
            // 
            this.rb_show2.AutoSize = true;
            this.rb_show2.Enabled = false;
            this.rb_show2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rb_show2.Location = new System.Drawing.Point(427, 687);
            this.rb_show2.Name = "rb_show2";
            this.rb_show2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rb_show2.Size = new System.Drawing.Size(242, 41);
            this.rb_show2.TabIndex = 15;
            this.rb_show2.Text = "תרגילים לא נכונים";
            this.rb_show2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 766);
            this.Controls.Add(this.rb_show2);
            this.Controls.Add(this.rb_show);
            this.Controls.Add(this.btn_show_ex);
            this.Controls.Add(this.gb_ex);
            this.Controls.Add(this.btn_ass);
            this.Controls.Add(this.tb_age);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lb_age);
            this.Controls.Add(this.lb_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_ex.ResumeLayout(false);
            this.gb_ex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_age;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.Button btn_ass;
        private System.Windows.Forms.GroupBox gb_ex;
        private System.Windows.Forms.Label lb_eq;
        private System.Windows.Forms.Label lb_num2;
        private System.Windows.Forms.Label lb_sign;
        private System.Windows.Forms.Label lb_num1;
        private System.Windows.Forms.Button btn_newEx;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.ComboBox cb_r;
        private System.Windows.Forms.Button btn_show_ex;
        private System.Windows.Forms.RadioButton rb_show;
        private System.Windows.Forms.RadioButton rb_show2;
    }
}

