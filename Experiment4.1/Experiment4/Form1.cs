using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Experiment4
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddressBook book = new AddressBook(txtName.Text, txtPhoneNum.Text, txtEmail.Text);
            txtShow.Text = book.show();
        }
    }

    class AddressBook
    {
        private string name;
        public string Name
        {
            get { return name; }
        }
        private string phoneNum;
        public string PhoneNum
        {
            get
            {
                if (phoneNum == "") { return "未输入"; }
                else { return phoneNum; }
            }
            set
            {
                phoneNum = value;
            }
        }
        private string email;
        public string Email
        {
            get
            {
                if (email == "") { return "未输入"; }
                else { return email; }
            }
            set { email = value; }
        }
        public string show()
        {
            return string.Format("姓名：{0}\r\n电话：{1}\r\nEmail：{2}", Name, PhoneNum, Email);  //这里使用字段而不是属性的话就没法利用属性对数据的正确性的验证
        }
        public AddressBook(string name, string phoneNum, string email)
        {
            this.name = name; this.phoneNum = phoneNum; this.email = email;
        }
    }

}
