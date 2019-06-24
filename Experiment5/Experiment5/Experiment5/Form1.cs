using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Experiment5
{
    public partial class Form1 : Form
    {
        static IPlayer player;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMP3_Click(object sender, EventArgs e)
        {
            player = new MP3();
        }

        private void btnAVI_Click(object sender, EventArgs e)
        {
            player = new AVI();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            lblShow.Text = player.last();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            lblShow.Text = player.stop();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            lblShow.Text = player.play();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            lblShow.Text = player.pause();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            lblShow.Text = player.next();
        }
    }

    interface IPlayer  //接口名建议使用I打头;命名空间中定义的元素无法显式声明为 private、protected 或 protected internal
    {
        String play();
        String stop();
        String pause();
        String last();
        String next();
    }

    class MP3 : IPlayer  //访问修饰符包括public和internal，默认为public，可以省略，但不能使用protected和private等
    {
        String type = "MP3歌曲";
        public String play()
        {
            return "正在播放" + type;
        }
        public String stop() {
            return "停止播放" + type;
        }
        public String pause() {
            return "暂停播放" + type;
        }
        public String last() {
            return "播放上一首" + type;
        }
        public String next() {
            return "播放下一首" + type;
        }
    }

    public class AVI : IPlayer
    {
        String type = "AVI视频";
        public String play()
        {
            return "正在播放" + type;
        }
        public String stop()
        {
            return "停止播放" + type;
        }
        public String pause()
        {
            return "暂停播放" + type;
        }
        public String last()
        {
            return "播放上一首" + type;
        }
        public String next()
        {
            return "播放下一首" + type;
        }
    }
}
