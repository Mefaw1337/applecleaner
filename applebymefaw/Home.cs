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


//this gui is maded in like 5 min lmao, add some cool shit lmao
namespace applebymefaw
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://applecheats.cc");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new Cleaner();
            this.Hide();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new Home();
            this.Hide();
            newForm.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
