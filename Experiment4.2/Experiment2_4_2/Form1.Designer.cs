namespace Experiment2_4_2
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
            this.txtHour = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSec = new System.Windows.Forms.TextBox();
            this.btnAdd1s = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(13, 13);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(40, 25);
            this.txtHour.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = ":";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(80, 13);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(40, 25);
            this.txtMin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = ":";
            // 
            // txtSec
            // 
            this.txtSec.Location = new System.Drawing.Point(147, 13);
            this.txtSec.Name = "txtSec";
            this.txtSec.Size = new System.Drawing.Size(40, 25);
            this.txtSec.TabIndex = 4;
            // 
            // btnAdd1s
            // 
            this.btnAdd1s.Location = new System.Drawing.Point(193, 13);
            this.btnAdd1s.Name = "btnAdd1s";
            this.btnAdd1s.Size = new System.Drawing.Size(51, 25);
            this.btnAdd1s.TabIndex = 5;
            this.btnAdd1s.Text = "+1s";
            this.btnAdd1s.UseVisualStyleBackColor = true;
            this.btnAdd1s.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 51);
            this.Controls.Add(this.btnAdd1s);
            this.Controls.Add(this.txtSec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHour);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSec;
        private System.Windows.Forms.Button btnAdd1s;
    }
}

