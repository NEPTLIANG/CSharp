﻿namespace Experiment2
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDegreeCentigrade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFahrenheitDegree = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTransition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDegreeCentigrade
            // 
            this.txtDegreeCentigrade.Location = new System.Drawing.Point(12, 12);
            this.txtDegreeCentigrade.Name = "txtDegreeCentigrade";
            this.txtDegreeCentigrade.Size = new System.Drawing.Size(34, 21);
            this.txtDegreeCentigrade.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "摄氏度";
            // 
            // txtFahrenheitDegree
            // 
            this.txtFahrenheitDegree.Location = new System.Drawing.Point(190, 12);
            this.txtFahrenheitDegree.Name = "txtFahrenheitDegree";
            this.txtFahrenheitDegree.Size = new System.Drawing.Size(34, 21);
            this.txtFahrenheitDegree.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "华氏度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "<==>";
            // 
            // btnTransition
            // 
            this.btnTransition.Location = new System.Drawing.Point(12, 40);
            this.btnTransition.Name = "btnTransition";
            this.btnTransition.Size = new System.Drawing.Size(260, 23);
            this.btnTransition.TabIndex = 5;
            this.btnTransition.Text = "转换";
            this.btnTransition.UseVisualStyleBackColor = true;
            this.btnTransition.Click += new System.EventHandler(this.btnTransition_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 72);
            this.Controls.Add(this.btnTransition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFahrenheitDegree);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDegreeCentigrade);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDegreeCentigrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFahrenheitDegree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTransition;
    }
}

