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
    public partial class LQForm : Form
    {
        public LQForm()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("逗你玩！");
            Form1.frm1.Close();
        }
    }
}
