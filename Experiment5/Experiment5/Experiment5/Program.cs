﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Experiment5
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 frm1 = new Form1();
            Application.Run(frm1);
        }
    }
}
