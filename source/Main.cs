using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;

namespace EmojiCord
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ThotLabel_Click(object sender, EventArgs e)
        {
            Process.Start("https://thot.cf");
        }

        private void DownloadBtn_Click(object sender, EventArgs e)
        {
            if (PNGSelect.Checked) { DownloadEmoji("png", IDBox.Text); }
            else if (GIFSelect.Checked) { DownloadEmoji("gif", IDBox.Text); }
            else if (WEBPSelect.Checked) { DownloadEmoji("webp", IDBox.Text); }
            else
            {
                MessageBox.Show("Please Choose a File Type");
            }


        }

        private void DownloadEmoji(string filetype, string id)
        {
            //688126860621512796
            using (WebClient sheesh = new WebClient())
            {
                try
                {
                    sheesh.DownloadFile($"https://cdn.discordapp.com/emojis/{id}.{filetype}?size=128&quality=lossless", Environment.CurrentDirectory + $"//{id}.{filetype}");
                }
                catch (System.Net.WebException)
                {
                    MessageBox.Show("Emoji not found");
                }
            }
        }
    }
}
