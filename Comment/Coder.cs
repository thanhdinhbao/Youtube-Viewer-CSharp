using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Comment
{
    public partial class Coder : Form
    {
        public Coder()
        {
            InitializeComponent();
        }

        private void btnFb_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "https://www.facebook.com/thanhdinhbaoofficial");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "https://www.youtube.com/user/MrManhICT");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "https://www.instagram.com/thanh.gatrevlog");
        }
    }
}
