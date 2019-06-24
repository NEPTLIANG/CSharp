namespace Experiment3._2Forms
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStuNum = new System.Windows.Forms.TextBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.txtStuClass = new System.Windows.Forms.TextBox();
            this.txtStuGrade = new System.Windows.Forms.TextBox();
            this.btnAddStu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddTea = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTeaDepartment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTeaTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTeaName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTeaNum = new System.Windows.Forms.TextBox();
            this.lblShow = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "编号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "班级：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "成绩：";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtStuNum
            // 
            this.txtStuNum.Location = new System.Drawing.Point(66, 24);
            this.txtStuNum.Name = "txtStuNum";
            this.txtStuNum.Size = new System.Drawing.Size(100, 25);
            this.txtStuNum.TabIndex = 5;
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(66, 56);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(100, 25);
            this.txtStuName.TabIndex = 6;
            // 
            // txtStuClass
            // 
            this.txtStuClass.Location = new System.Drawing.Point(66, 88);
            this.txtStuClass.Name = "txtStuClass";
            this.txtStuClass.Size = new System.Drawing.Size(100, 25);
            this.txtStuClass.TabIndex = 7;
            // 
            // txtStuGrade
            // 
            this.txtStuGrade.Location = new System.Drawing.Point(66, 120);
            this.txtStuGrade.Name = "txtStuGrade";
            this.txtStuGrade.Size = new System.Drawing.Size(100, 25);
            this.txtStuGrade.TabIndex = 8;
            // 
            // btnAddStu
            // 
            this.btnAddStu.Location = new System.Drawing.Point(6, 151);
            this.btnAddStu.Name = "btnAddStu";
            this.btnAddStu.Size = new System.Drawing.Size(160, 23);
            this.btnAddStu.TabIndex = 9;
            this.btnAddStu.Text = "添加学生";
            this.btnAddStu.UseVisualStyleBackColor = true;
            this.btnAddStu.Click += new System.EventHandler(this.btnAddStu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddStu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtStuGrade);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtStuClass);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtStuName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtStuNum);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 186);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "学生信息：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddTea);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTeaDepartment);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTeaTitle);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTeaName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtTeaNum);
            this.groupBox2.Location = new System.Drawing.Point(191, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 186);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "教师信息：";
            // 
            // btnAddTea
            // 
            this.btnAddTea.Location = new System.Drawing.Point(6, 151);
            this.btnAddTea.Name = "btnAddTea";
            this.btnAddTea.Size = new System.Drawing.Size(160, 23);
            this.btnAddTea.TabIndex = 9;
            this.btnAddTea.Text = "添加教师";
            this.btnAddTea.UseVisualStyleBackColor = true;
            this.btnAddTea.Click += new System.EventHandler(this.btnAddTea_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "编号：";
            // 
            // txtTeaDepartment
            // 
            this.txtTeaDepartment.Location = new System.Drawing.Point(66, 120);
            this.txtTeaDepartment.Name = "txtTeaDepartment";
            this.txtTeaDepartment.Size = new System.Drawing.Size(100, 25);
            this.txtTeaDepartment.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "姓名：";
            // 
            // txtTeaTitle
            // 
            this.txtTeaTitle.Location = new System.Drawing.Point(66, 88);
            this.txtTeaTitle.Name = "txtTeaTitle";
            this.txtTeaTitle.Size = new System.Drawing.Size(100, 25);
            this.txtTeaTitle.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "职称";
            // 
            // txtTeaName
            // 
            this.txtTeaName.Location = new System.Drawing.Point(66, 56);
            this.txtTeaName.Name = "txtTeaName";
            this.txtTeaName.Size = new System.Drawing.Size(100, 25);
            this.txtTeaName.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "部门";
            // 
            // txtTeaNum
            // 
            this.txtTeaNum.Location = new System.Drawing.Point(66, 24);
            this.txtTeaNum.Name = "txtTeaNum";
            this.txtTeaNum.Size = new System.Drawing.Size(100, 25);
            this.txtTeaNum.TabIndex = 5;
            // 
            // lblShow
            // 
            this.lblShow.BackColor = System.Drawing.SystemColors.Control;
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShow.Location = new System.Drawing.Point(13, 205);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(351, 128);
            this.lblShow.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 345);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStuNum;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.TextBox txtStuClass;
        private System.Windows.Forms.TextBox txtStuGrade;
        private System.Windows.Forms.Button btnAddStu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddTea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTeaDepartment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTeaTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTeaName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTeaNum;
        private System.Windows.Forms.Label lblShow;
    }
}

