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
    public partial class ZJForm : Form
    {
        public ZJForm()
        {
            InitializeComponent();
        }

        private void zj_Load(object sender, EventArgs e)
        {

        }

        private void btnLook_Click(object sender, EventArgs e)
        {
            LQForm lq = new LQForm();
            lq.Show();
            this.Hide();
        }
    }
}
