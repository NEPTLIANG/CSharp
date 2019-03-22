using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//(2)	创建一个Windows应用程序，输入n，求1+2+3+…+n。

namespace Experiment1._2
{
    public partial class Hello : Form
    {
        public Hello()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)  //要注意是双击按钮
        {
            int n = Convert.ToInt32(txtNum.Text);  //记得把输入的字符串转化为需要的类型
            lblOutput.Text = "1+2+...+" + (n - 1) + "+" + n + "=" + (1 + n) * n / 2;  //别忘了.Text
        }
    }
}