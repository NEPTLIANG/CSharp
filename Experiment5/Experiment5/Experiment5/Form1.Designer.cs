namespace Experiment5
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
            this.btnMP3 = new System.Windows.Forms.Button();
            this.lblShow = new System.Windows.Forms.Label();
            this.btnAVI = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMP3
            // 
            this.btnMP3.Location = new System.Drawing.Point(12, 12);
            this.btnMP3.Name = "btnMP3";
            this.btnMP3.Size = new System.Drawing.Size(51, 23);
            this.btnMP3.TabIndex = 0;
            this.btnMP3.Text = "MP3";
            this.btnMP3.UseVisualStyleBackColor = true;
            this.btnMP3.Click += new System.EventHandler(this.btnMP3_Click);
            // 
            // lblShow
            // 
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblShow.Location = new System.Drawing.Point(69, 12);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(189, 23);
            this.lblShow.TabIndex = 1;
            this.lblShow.Text = "label1";
            this.lblShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAVI
            // 
            this.btnAVI.Location = new System.Drawing.Point(264, 12);
            this.btnAVI.Name = "btnAVI";
            this.btnAVI.Size = new System.Drawing.Size(51, 23);
            this.btnAVI.TabIndex = 2;
            this.btnAVI.Text = "AVI";
            this.btnAVI.UseVisualStyleBackColor = true;
            this.btnAVI.Click += new System.EventHandler(this.btnAVI_Click);
            // 
            // btnLast
            // 
            this.btnLast.AutoSize = true;
            this.btnLast.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLast.Location = new System.Drawing.Point(12, 41);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(51, 22);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = "上一首";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(207, 41);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(51, 22);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "暂停";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(126, 41);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 22);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "播放";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(69, 41);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(51, 22);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(264, 41);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(51, 22);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "下一首";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 73);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnAVI);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.btnMP3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMP3;
        private System.Windows.Forms.Label lblShow;
        public System.Windows.Forms.Label lblShow2
        {
            get { return lblShow; }
        }
        private System.Windows.Forms.Button btnAVI;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnNext;
    }
}

