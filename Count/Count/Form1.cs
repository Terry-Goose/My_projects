using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Count
{
    public partial class Form1 : Form
    {
        int count = Properties.Settings.Default.n;
        int a2;
        int a1;
        int a0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            a2 = count / 100;
            a1 = (count - a2 * 100) / 10;
            a0 = (count - a2 * 100 - a1 * 10);
            Properties.Settings.Default.n = count;
            //однозначное
            #region
            switch (a0)
            {
                case 0:
                    pictureBox4.Image = Properties.Resources.цифра0;
                    break;
                case 1:
                    pictureBox4.Image = Properties.Resources.цифра1;
                    break;
                case 2:
                    pictureBox4.Image = Properties.Resources.цифра2;
                    break;
                case 3:
                    pictureBox4.Image = Properties.Resources.цифра3;          
                    break;
                case 4:
                    pictureBox4.Image = Properties.Resources.цифра4;
                    break;
                case 5:
                    pictureBox4.Image = Properties.Resources.цифра5;
                    break;
                case 6:
                    pictureBox4.Image = Properties.Resources.цифра6;
                    break;
                case 7:
                    pictureBox4.Image = Properties.Resources.цифра7;
                    break;
                case 8:
                    pictureBox4.Image = Properties.Resources.цифра8;
                    break;
                case 9:
                    pictureBox4.Image = Properties.Resources.цифра9;
                    break;
            }
            #endregion

            //двузначное
            #region
            switch (a1)
            {
                case 0:
                    if(a2==0)
                    pictureBox3.Visible = false;
                    else
                    {
                        pictureBox3.Visible = true;
                        pictureBox3.Image = Properties.Resources.цифра0;
                    }
                    break;
                case 1:
                    pictureBox3.Visible = true;
                    pictureBox3.Image = Properties.Resources.цифра1;
                    break;
                case 2:
                    pictureBox3.Image = Properties.Resources.цифра2;
                    break;
                case 3:
                    pictureBox3.Image = Properties.Resources.цифра3;
                    break;
                case 4:
                    pictureBox3.Image = Properties.Resources.цифра4;
                    break;
                case 5:
                    pictureBox3.Image = Properties.Resources.цифра5;
                    break;
                case 6:
                    pictureBox3.Image = Properties.Resources.цифра6;
                    break;
                case 7:
                    pictureBox3.Image = Properties.Resources.цифра7;
                    break;
                case 8:
                    pictureBox3.Image = Properties.Resources.цифра8;
                    break;
                case 9:
                    pictureBox3.Image = Properties.Resources.цифра9;
                    break;
            }
            #endregion

            //трехзначное
            #region
            switch (a2)
            {
                case 0:
                    pictureBox2.Visible = false;
                    //pictureBox4.Image = Properties.Resources.;
                    break;
                case 1:
                    pictureBox2.Visible = true;
                    pictureBox2.Image = Properties.Resources.цифра1;
                    break;
                case 2:
                    pictureBox2.Image = Properties.Resources.цифра2;
                    break;
                case 3:
                    pictureBox2.Image = Properties.Resources.цифра3;
                    break;
                case 4:
                    pictureBox2.Image = Properties.Resources.цифра4;
                    break;
                case 5:
                    pictureBox2.Image = Properties.Resources.цифра5;
                    break;
                case 6:
                    pictureBox2.Image = Properties.Resources.цифра6;
                    break;
                case 7:
                    pictureBox2.Image = Properties.Resources.цифра7;
                    break;
                case 8:
                    pictureBox2.Image = Properties.Resources.цифра8;
                    break;
                case 9:
                    pictureBox2.Image = Properties.Resources.цифра9;
                    break;
            }
            #endregion

            Properties.Settings.Default.Save();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            count--;
            a2 = count / 100;
            a1 = (count - a2 * 100) / 10;
            a0 = (count - a2 * 100 - a1 * 10);
            Properties.Settings.Default.n = count;

            //однозначное
            #region
            switch (a0)
            {
                case 0:
                    pictureBox4.Image = Properties.Resources.цифра0;
                    break;
                case 1:
                    pictureBox4.Image = Properties.Resources.цифра1;
                    break;
                case 2:
                    pictureBox4.Image = Properties.Resources.цифра2;
                    break;
                case 3:
                    pictureBox4.Image = Properties.Resources.цифра3;
                    break;
                case 4:
                    pictureBox4.Image = Properties.Resources.цифра4;
                    break;
                case 5:
                    pictureBox4.Image = Properties.Resources.цифра5;
                    break;
                case 6:
                    pictureBox4.Image = Properties.Resources.цифра6;
                    break;
                case 7:
                    pictureBox4.Image = Properties.Resources.цифра7;
                    break;
                case 8:
                    pictureBox4.Image = Properties.Resources.цифра8;
                    break;
                case 9:
                    pictureBox4.Image = Properties.Resources.цифра9;
                    break;
            }
            #endregion

            //двузначное
            #region
            switch (a1)
            {
                case 0:
                    if (a2==0)
                        pictureBox3.Visible = false;
                    else
                    {
                        pictureBox3.Visible = true;
                        pictureBox3.Image = Properties.Resources.цифра0;
                    }
                    break;
                case 1:
                    pictureBox3.Image = Properties.Resources.цифра1;
                    break;
                case 2:
                    pictureBox3.Image = Properties.Resources.цифра2;
                    break;
                case 3:
                    pictureBox3.Image = Properties.Resources.цифра3;
                    break;
                case 4:
                    pictureBox3.Image = Properties.Resources.цифра4;
                    break;
                case 5:
                    pictureBox3.Image = Properties.Resources.цифра5;
                    break;
                case 6:
                    pictureBox3.Image = Properties.Resources.цифра6;
                    break;
                case 7:
                    pictureBox3.Image = Properties.Resources.цифра7;
                    break;
                case 8:
                    pictureBox3.Image = Properties.Resources.цифра8;
                    break;
                case 9:
                    pictureBox3.Visible = true;
                    pictureBox3.Image = Properties.Resources.цифра9;
                    break;
            }
            #endregion

            //трёхзначное
            #region
            switch (a2)
            {
                case 0:
                    pictureBox2.Visible = false;
                    //pictureBox4.Image = Properties.Resources.;
                    break;
                case 1:
                    pictureBox2.Image = Properties.Resources.цифра1;
                    break;
                case 2:
                    pictureBox2.Image = Properties.Resources.цифра2;
                    break;
                case 3:
                    pictureBox2.Image = Properties.Resources.цифра3;
                    break;
                case 4:
                    pictureBox2.Image = Properties.Resources.цифра4;
                    break;
                case 5:
                    pictureBox2.Image = Properties.Resources.цифра5;
                    break;
                case 6:
                    pictureBox2.Image = Properties.Resources.цифра6;
                    break;
                case 7:
                    pictureBox2.Image = Properties.Resources.цифра7;
                    break;
                case 8:
                    pictureBox2.Image = Properties.Resources.цифра8;
                    break;
                case 9:
                    pictureBox2.Visible = true;
                    pictureBox2.Image = Properties.Resources.цифра9;
                    break;
            }
            #endregion

            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            a2 = count / 100;
            a1 = (count - a2 * 100) / 10;
            a0 = (count - a2 * 100 - a1 * 10);
            Properties.Settings.Default.n = count;
            //однозначное
            #region
            switch (a0)
            {
                case 0:
                    pictureBox4.Image = Properties.Resources.цифра0;
                    break;
                case 1:
                    pictureBox4.Image = Properties.Resources.цифра1;
                    break;
                case 2:
                    pictureBox4.Image = Properties.Resources.цифра2;
                    break;
                case 3:
                    pictureBox4.Image = Properties.Resources.цифра3;
                    break;
                case 4:
                    pictureBox4.Image = Properties.Resources.цифра4;
                    break;
                case 5:
                    pictureBox4.Image = Properties.Resources.цифра5;
                    break;
                case 6:
                    pictureBox4.Image = Properties.Resources.цифра6;
                    break;
                case 7:
                    pictureBox4.Image = Properties.Resources.цифра7;
                    break;
                case 8:
                    pictureBox4.Image = Properties.Resources.цифра8;
                    break;
                case 9:
                    pictureBox4.Image = Properties.Resources.цифра9;
                    break;
            }
            #endregion

            //двузначное
            #region
            switch (a1)
            {
                case 0:
                    if (a2 == 0)
                        pictureBox3.Visible = false;
                    else
                        pictureBox3.Image = Properties.Resources.цифра0;
                    break;
                case 1:
                    pictureBox3.Image = Properties.Resources.цифра1;
                    break;
                case 2:
                    pictureBox3.Image = Properties.Resources.цифра2;
                    break;
                case 3:
                    pictureBox3.Image = Properties.Resources.цифра3;
                    break;
                case 4:
                    pictureBox3.Image = Properties.Resources.цифра4;
                    break;
                case 5:
                    pictureBox3.Image = Properties.Resources.цифра5;
                    break;
                case 6:
                    pictureBox3.Image = Properties.Resources.цифра6;
                    break;
                case 7:
                    pictureBox3.Image = Properties.Resources.цифра7;
                    break;
                case 8:
                    pictureBox3.Image = Properties.Resources.цифра8;
                    break;
                case 9:
                    pictureBox3.Image = Properties.Resources.цифра9;
                    break;
            }
            #endregion

            //трехзначное
            #region
            switch (a2)
            {
                case 0:
                    pictureBox2.Visible = false;
                    break;
                case 1:
                    pictureBox2.Image = Properties.Resources.цифра1;
                    break;
                case 2:
                    pictureBox2.Image = Properties.Resources.цифра2;
                    break;
                case 3:
                    pictureBox2.Image = Properties.Resources.цифра3;
                    break;
                case 4:
                    pictureBox2.Image = Properties.Resources.цифра4;
                    break;
                case 5:
                    pictureBox2.Image = Properties.Resources.цифра5;
                    break;
                case 6:
                    pictureBox2.Image = Properties.Resources.цифра6;
                    break;
                case 7:
                    pictureBox2.Image = Properties.Resources.цифра7;
                    break;
                case 8:
                    pictureBox2.Image = Properties.Resources.цифра8;
                    break;
                case 9:
                    pictureBox2.Image = Properties.Resources.цифра9;
                    break;
            }
            #endregion
        }
    }
}
