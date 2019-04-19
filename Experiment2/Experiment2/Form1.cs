using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Experiment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTransition_Click(object sender, EventArgs e)
        {
            int a = 32 + int.Parse(txtDegreeCentigrade.Text) * 9 / 5;
            txtFahrenheitDegree.Text = a.ToString();
        }
    }
}
