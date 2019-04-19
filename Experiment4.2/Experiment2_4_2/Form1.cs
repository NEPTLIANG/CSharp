using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Experiment2_4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Time time = new Time(int.Parse(txtHour.Text), int.Parse(txtMin.Text), int.Parse(txtSec.Text));
            time.add1s();
            txtSec.Text = time.Sec.ToString();
            txtMin.Text = time.Min.ToString();
            txtHour.Text = time.Hour.ToString();
        }
    }

    class Time
    {
        private int hour;
        public int Hour
        {
            get { return hour; }
        }
        private int min;
        public int Min
        {
            get { return min; }
        }
        private int sec;
        public int Sec
        {
            get { return sec; }
        }

        public void add1s()
        {
            sec++;
            if ( sec>=60 )
            {
                sec = 0;
                min++;
            }
            if ( min>=60 )
            {
                min = 0;
                hour++;
            }
            if ( hour>=24 )
            {
                hour = 0;
            }
        }

        public Time()
        {
            hour = System.DateTime.Now.Hour;
            min = System.DateTime.Now.Minute;
            sec = System.DateTime.Now.Second;
        }

        public Time(int hour, int min, int sec)
        {
            this.hour = hour;
            this.min = min;
            this.sec = sec;
        }
    }

}