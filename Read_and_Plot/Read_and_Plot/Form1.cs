using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Read_and_Plot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            int choice = TestList.SelectedIndex;
            string fileName = "";

            switch (choice)
            {
                case 0:
                    fileName = "C:\\Users\\кей\\Documents\\Visual Studio 2012\\Projects\\IntersectionSegments\\IntersectionSegments\\bin\\Debug\\Test 0.txt";
                    break;
                case 1:
                    fileName = "C:\\Users\\кей\\Documents\\Visual Studio 2012\\Projects\\IntersectionSegments\\IntersectionSegments\\bin\\Debug\\Test 1.txt";
                    break;
                case 2:
                    fileName = "C:\\Users\\кей\\Documents\\Visual Studio 2012\\Projects\\IntersectionSegments\\IntersectionSegments\\bin\\Debug\\Test 2.txt";
                    break;
                case 3:
                    fileName = "C:\\Users\\кей\\Documents\\Visual Studio 2012\\Projects\\IntersectionSegments\\IntersectionSegments\\bin\\Debug\\Test 3.txt";
                    break;
                case 4:
                    fileName = "C:\\Users\\кей\\Documents\\Visual Studio 2012\\Projects\\IntersectionSegments\\IntersectionSegments\\bin\\Debug\\Test 4.txt";
                    break;
            }

            int counter = 0;
            string line;
            string[] substrings;
            
            System.IO.StreamReader file = new System.IO.StreamReader(fileName);
            while ((line = file.ReadLine()) != null)
            {
                substrings = line.Split(' ');
                chart1.Series[0].Points.AddXY(double.Parse(substrings[0]), double.Parse(substrings[1]));
                chart1.Series[1].Points.AddXY(double.Parse(substrings[0]), double.Parse(substrings[2]));
                counter++;
            }

            file.Close();
            chart1.Series[0].LegendText = "Naiv";
            chart1.Series[1].LegendText = "Effectiv";
            chart1.DataBind();

        }
    }
}
