using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Assignment2_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRanNum_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            int num = ran.Next(1, 100);
            lblRanNum.Text = "Rnadom Num" + num;
            Console.WriteLine("Random number generated" + num);
        }

        private void btnchngimg_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            int num = ran.Next(1, 10);
            if (num % 2 == 0)
            {
                Pbimage.Image = global::Assignment2_Practice.Properties.Resources.image2;
            }
            else
            {
                Pbimage.Image = global::Assignment2_Practice.Properties.Resources.image;
            }

        }

        private void btnsound_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Assignment2_Practice.Properties.Resources.ie_shot_gun_luminalace_770179786);
            player.Load();
            player.Play();

        }
    }
}
