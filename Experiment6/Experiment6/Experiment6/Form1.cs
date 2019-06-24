using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Experiment6
{
    public partial class Form1 : Form
    {
        public static Form1 frm1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSprs_Click(object sender, EventArgs e)
        {
            ZJForm zj = new ZJForm();
            this.Hide();
            zj.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1.frm1 = this;
        }
    }
}
