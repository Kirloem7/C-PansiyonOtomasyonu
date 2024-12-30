using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace LotusPansiyonVeDinlenmeTesisleri
{
    public partial class frmRadyoDinle : Form
    {
        public frmRadyoDinle()
        {
            InitializeComponent();
        }

        private void RadioChannel1LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://37.247.98.8/stream/166/";

        }

        private void RadioChannel2LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = " https://trkvz-radyolar.ercdn.net/asporradyo/playlist.m3u8";
        }

        private void RadioChannel3LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = " https://ssldyg.radyotvonline.com/smil/smil:kralfm.smil/playlist.m3u8";
        }
    }
}
