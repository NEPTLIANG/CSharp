using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Experiment3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //实验三第1题（课本P101 5.1.1实例5-1）：利用静态成员统计图书数量
        Book[] bookList = new Book[10000];  //书本列表

        private void btnAdd_Click(object sender, EventArgs e)  //添加书籍
        {
            Type type;
            //cbbType.SelectedIndex表示组合框中选择的项的索引，第一项的索引为0
            if (cbbType.SelectedIndex == 0)
            {
                type = Type.computerBook;
            }
            else //if (cbbType.SelectedIndex == 1)
            {
                type = Type.novel;
            }
            bookList[Book.Count] = new Book(txtTitle.Text, type, Convert.ToDouble(txtPrice.Text));
            lblShow.Text = string.Format("成功添加第{0}本书\n", Book.Count);
        }

        private void btnCount_Click(object sender, EventArgs e)  //统计书籍
        {
            lblShow.Text = string.Format("课本总数为：{0}\n", Book.Count);
            lblShow.Text += string.Format("其中计算机书籍{0}本，小说{1}本\n", Book.computerBookCount, Book.novelCount);
            foreach (Book i in bookList)
            {
                if (i != null)  //别忘了判空
                {
                    lblShow.Text += string.Format("{0} {1} {2}\n", i.title, i.type, i.price);
                }
            }
        }
    }

    enum Type { computerBook, novel };  //枚举类型
    class Book  //书籍类
    {
        private static int count;
        public static int Count                             //书籍总数
        {
            get { return count; }
        }
        static public int computerBookCount, novelCount;    //计算机书籍总数、小说总数
        public string title;                                //书籍名称
        public Type type;                                   //书籍类型
        public double price;                                //书籍价格

        public Book(string title, Type type, double price)  //构造书籍
        {
            this.title = title;
            this.type = type;
            this.price = price;
            Book.count++;
            if (type == Type.computerBook) { Book.computerBookCount++; }
            if (type == Type.novel) { Book.novelCount++; }
        }
    }
}
