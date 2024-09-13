namespace basicCalc
{
    partial class showEx
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
            this.lBox = new System.Windows.Forms.ListBox();
            this.lb_headLine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lBox
            // 
            this.lBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lBox.FormattingEnabled = true;
            this.lBox.ItemHeight = 31;
            this.lBox.Location = new System.Drawing.Point(380, 108);
            this.lBox.Name = "lBox";
            this.lBox.Size = new System.Drawing.Size(367, 283);
            this.lBox.TabIndex = 1;
            // 
            // lb_headLine
            // 
            this.lb_headLine.AutoSize = true;
            this.lb_headLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lb_headLine.Location = new System.Drawing.Point(380, 55);
            this.lb_headLine.Name = "lb_headLine";
            this.lb_headLine.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_headLine.Size = new System.Drawing.Size(108, 37);
            this.lb_headLine.TabIndex = 2;
            this.lb_headLine.Text = "תרגילים";
            // 
            // showEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_headLine);
            this.Controls.Add(this.lBox);
            this.Name = "showEx";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "רשימת תרגילים";
            this.Load += new System.EventHandler(this.showEx_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBox;
        private System.Windows.Forms.Label lb_headLine;
    }
}