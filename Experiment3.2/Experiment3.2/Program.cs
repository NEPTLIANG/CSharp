using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment3._2
{
    class Person
    {
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

        Student(string num, string name) : base(num, name) { }
    }

    class Teacher : Person
    {
        private string title;
        private string department;

        Teacher(string num,string name) : base(num, name) { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }
}
