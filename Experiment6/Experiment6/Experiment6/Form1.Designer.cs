namespace Experiment6
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
            this.btnSprs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSprs
            // 
            this.btnSprs.Location = new System.Drawing.Point(12, 12);
            this.btnSprs.Name = "btnSprs";
            this.btnSprs.Size = new System.Drawing.Size(92, 23);
            this.btnSprs.TabIndex = 0;
            this.btnSprs.Text = "点击有惊喜";
            this.btnSprs.UseVisualStyleBackColor = true;
            this.btnSprs.Click += new System.EventHandler(this.btnSprs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(116, 49);
            this.Controls.Add(this.btnSprs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSprs;
    }
}

