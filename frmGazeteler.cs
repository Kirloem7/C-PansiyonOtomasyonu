using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotusPansiyonVeDinlenmeTesisleri
{
    public partial class frmGazeteler : Form
    {
        public frmGazeteler()
        {
            InitializeComponent();
        }

        private void NewspaperButton1_Click(object sender, EventArgs e)
        {
            NewspaperWebView.Source = new Uri("https://www.hurriyet.com.tr");
        }

        private void Newspaper2Button_Click(object sender, EventArgs e)
        {
            NewspaperWebView.Source = new Uri("https://www.sozcu.com.tr");
        }

        private void NewspaperButton3_Click(object sender, EventArgs e)
        {
            NewspaperWebView.Source = new Uri("https://www.cumhuriyet.com.tr");
        }

        private void NewspaperButton4_Click(object sender, EventArgs e)
        {
            NewspaperWebView.Source = new Uri("https://www.fanatik.com.tr");
        }
    }
}
