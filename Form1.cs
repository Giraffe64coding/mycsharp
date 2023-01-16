using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rdNum=new Random();
            Color[] colors = { Color.Red, Color.Blue, Color.Green, Color.Purple, Color.Orange, Color.Yellow };

            for (int i = 0; i < 6; i++)
            {
                chart1.Series[0].Points.Add(rdNum.Next(200));
                chart1.Series[0].Points[i].Color = colors[i];

                chart2.Series[0].Points.Add(rdNum.Next(500));
                chart2.Series[0].Points[i].Color = colors[i];

                chart2.Series[1].Points.Add(rdNum.Next(800));
                chart2.Series[1].Points[i].Color = colors[i];
            }

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
