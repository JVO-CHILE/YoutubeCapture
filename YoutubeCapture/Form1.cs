using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeCapture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            DownloadMp3(new Uri(txtURL.Text));
        }

        private void DownloadMp3(Uri URL)
        {
            WebClient w = new WebClient();
            var capHTML = w.DownloadString(URL);

            txtURL.Text = String.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtURL.Text = String.Empty;
        }
    }
}
