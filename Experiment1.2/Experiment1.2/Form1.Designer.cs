namespace Experiment1._2
{
    partial class Hello
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("苹方字体", 144F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 336);
            this.label1.TabIndex = 0;
            this.label1.Text = "n:";
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("苹方字体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNum.ForeColor = System.Drawing.Color.Gray;
            this.txtNum.Location = new System.Drawing.Point(33, 352);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(256, 35);
            this.txtNum.TabIndex = 1;
            this.txtNum.Text = "请输入n";
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCal
            // 
            this.btnCal.Font = new System.Drawing.Font("苹方字体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCal.ForeColor = System.Drawing.Color.Gray;
            this.btnCal.Location = new System.Drawing.Point(33, 409);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(256, 35);
            this.btnCal.TabIndex = 2;
            this.btnCal.Text = "求和";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.Font = new System.Drawing.Font("苹方字体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOutput.ForeColor = System.Drawing.Color.Gray;
            this.lblOutput.Location = new System.Drawing.Point(33, 468);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(256, 28);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Hello
            // 
            this.AcceptButton = this.btnCal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(324, 542);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("苹方字体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.Silver;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Hello";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label lblOutput;
    }
}

