using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breakpoint
{
    public partial class Form1 : Form
    {
        int count = 198;
        int a2;
        int a1;
        int a0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            a2 = count / 100;
            a1 = (count - a2 * 100) / 10;
            a0 = (count - a2 * 100 - a1 * 10);

            pictureBox4.Image = NumberPicture(a0);
            pictureBox3.Image = NumberPicture(a1);
            pictureBox2.Image = NumberPicture(a2);

            if (count == 200)
                timer1.Enabled = false;
        }

        private Bitmap NumberPicture(int n)
        {
            Bitmap tmp = new Bitmap(230,260);
            switch (n)
            {
                case 0:
                    tmp = Properties.Resources._0;
                    break;
                case 1:
                    tmp = Properties.Resources._1;
                    break;
                case 2:
                    tmp = Properties.Resources._2;
                    break;
                case 3:
                    tmp = Properties.Resources._3;
                    break;
                case 4:
                    tmp = Properties.Resources._4;
                    break;
                case 5:
                    tmp = Properties.Resources._5;
                    break;
                case 6:
                    tmp = Properties.Resources._6;
                    break;
                case 7:
                    tmp = Properties.Resources._7;
                    break;
                case 8:
                    tmp = Properties.Resources._8;
                    break;
                case 9:
                    tmp = Properties.Resources._9;
                    break;
            }
            return tmp;
        }
    }
}
