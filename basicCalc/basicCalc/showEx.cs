using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basicCalc
{
    public partial class showEx : Form
    {
        private string[] arr = new string[10];
        private bool correct;
        private int index;
        public showEx(string[] arr,bool correct,int index)
        {
            this.arr = arr;
            this.correct = correct;
            this.index = index;
            InitializeComponent();
        }

        private void showEx_Load(object sender, EventArgs e){
            lb_headLine.Text = correct ? "תרגילים נכונים" : "תרגילים לא נכונים";
            for (int i = 0; i < index; i++)
            {
                lBox.Items.Add(arr[i]);
            }
        }
    }
}
