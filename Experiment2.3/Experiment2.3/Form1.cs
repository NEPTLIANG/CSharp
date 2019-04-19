using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Experiment2._3
{
    public partial class Form1 : Form
    {
        int[] list = new int[5];
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int j = i + 2;
            lblInput.Text = "请输入第" + j + "个元素";
            int a = int.Parse(txtInput.Text);
            list[i] = a;
            txtOriginList.Text += list[i].ToString() + " ";
            i++;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
