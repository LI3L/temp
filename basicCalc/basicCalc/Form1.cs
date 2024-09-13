using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basicCalc
{
    public partial class Form1 : Form
    {
        private string[] correct = new string[10];
        private string[] wrong = new string[10];
        int correctIndex = 0, wrongIndex = 0;
        public Form1(){
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {}

        private void btn_ass_Click(object sender, EventArgs e){
            if(tb_name.Text=="" || tb_age.Text == "")
                MessageBox.Show("must fill the name and the age", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!int.TryParse(tb_age.Text, out _))
                MessageBox.Show("the age must be int", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(int.Parse(tb_age.Text) < 6 || int.Parse(tb_age.Text) > 8)
                MessageBox.Show("the age must be in range 6-8", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                gb_ex.Visible = true;
        }
        private void newEx(){
            Random r = new Random();
            lb_sign.Text = $"{(r.Next(2)==1?"+":"-")}";
            int num1 = r.Next(0, 11),num2 = r.Next(0, 11);
            if(lb_sign.Text == "-" && num1 < num2){
                lb_num1.Text = $"{num2}";
                lb_num2.Text = $"{num1}";
            }
            else{
                lb_num1.Text = $"{num1}";
                lb_num2.Text = $"{num2}";
            }
            lb_num1.TextAlign = ContentAlignment.MiddleCenter;
            lb_num2.TextAlign = ContentAlignment.MiddleCenter;
            lb_sign.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void btn_newEx_Click(object sender, EventArgs e){
            newEx();
            btn_check.Enabled = true;
            btn_newEx.Enabled = false;
            cb_r.Enabled = true;
        }

        private void cb_r_SelectedIndexChanged(object sender, EventArgs e){}

        private void btn_show_ex_Click(object sender, EventArgs e){
            Form ex;

            if (rb_show.Checked)
            {
                ex = new showEx(correct, true, correctIndex);
            }
            else
            {
                ex = new showEx(wrong, false, wrongIndex);
            }
            ex.ShowDialog();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            if(cb_r.SelectedIndex==-1)
                MessageBox.Show("must choose result", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int num1 = int.Parse(lb_num1.Text),num2 = int.Parse(lb_num2.Text);
                if(lb_sign.Text == "+")
                {
                    if(num1+num2 == int.Parse(cb_r.SelectedItem.ToString()))
                    {
                        MessageBox.Show("תשובה נכונה", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        correct[correctIndex++] = $"{num1}+{num2}={int.Parse(cb_r.SelectedItem.ToString())}";
                    }
                    else
                    {
                        MessageBox.Show("תשובה לא נכונה", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        wrong[wrongIndex++] = $"{num1}+{num2}={int.Parse(cb_r.SelectedItem.ToString())}";
                    }
                }
                else
                {
                    if(num1-num2 == int.Parse(cb_r.SelectedItem.ToString()))
                    {
                        MessageBox.Show("תשובה נכונה", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        correct[correctIndex++] = $"{num1}-{num2}={int.Parse(cb_r.SelectedItem.ToString())}";
                    }
                    else
                    {
                        MessageBox.Show("תשובה לא נכונה", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        wrong[wrongIndex++] = $"{num1}-{num2}={int.Parse(cb_r.SelectedItem.ToString())}";
                    }
                }
                btn_newEx.Enabled = true;
                btn_check.Enabled = false;
                btn_show_ex.Enabled = true;
                rb_show.Enabled = true;
                rb_show2.Enabled = true;
                string s = $"{(correctIndex / (correctIndex+wrongIndex))*100}% : תרגילים נכונים";
                MessageBox.Show($"{s}", "score", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
