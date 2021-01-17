using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;


//why trying to paste a shit maded in 5 min lmao

namespace applebymefaw
{
    public partial class Cleaner : Form
    {
        public Cleaner()
        {
            InitializeComponent();
        }


        private void Cleaner_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            wb.DownloadFile("https://cdn.discordapp.com/attachments/747385387697045556/800435305584263248/cleanerBETAS5.exe", @"C:\cleanerBETAS5.exe");  //downloading the cleaner
            Process.Start(@"C:\cleanerBETAS5.exe");  //execute it
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new Home();
            this.Hide();
            newForm.Show();
        }
    }
}
