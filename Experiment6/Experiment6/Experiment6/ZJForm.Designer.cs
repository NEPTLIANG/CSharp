namespace Experiment6
{
    partial class ZJForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLook
            // 
            this.btnLook.Location = new System.Drawing.Point(12, 12);
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(177, 23);
            this.btnLook.TabIndex = 0;
            this.btnLook.Text = "点击查看";
            this.btnLook.UseVisualStyleBackColor = true;
            this.btnLook.Click += new System.EventHandler(this.btnLook_Click);
            // 
            // ZJForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 47);
            this.Controls.Add(this.btnLook);
            this.Name = "ZJForm";
            this.Text = "恭喜您中奖了";
            this.Load += new System.EventHandler(this.zj_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLook;
    }
}