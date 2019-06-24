using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Experiment3._2Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        Student[] stuList = new Student[10000];
        private void btnAddStu_Click(object sender, EventArgs e)
        {
            stuList[Student.Count] = new Student(txtStuNum.Text, txtStuName.Text, txtStuClass.Text, Convert.ToDouble(txtStuGrade.Text));
        }

        private void btnAddTea_Click(object sender, EventArgs e)
        {

        }
    }

    class Person
    {
        private static int count;
        public static int Count
        {
            get { return count; }
        }
        private string num;
        private string name;

        public Person(string num, string name)
        {
            this.num = num;
            this.name = name;
        }

        public void printInfo()
        {
            Console.Write(num + name);
        }
    }

    class Student : Person
    {
        private string classAndGrade;
        private double grade;

        public Student(string num, string name, string classAndGrade, double grade) : base(num, name) { }
    }

    class Teacher : Person
    {
        private string title;
        private string department;

        Teacher(string num, string name) : base(num, name) { }
    }
}
