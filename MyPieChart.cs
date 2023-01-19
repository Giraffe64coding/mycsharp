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
    public partial class MyPieChart : Form
    {
        public MyPieChart()
        {
            InitializeComponent();
        }

        private void MyPieChart_Load(object sender, EventArgs e)
        {
            Random rdNum=new Random();
            chart1.Series[0].Label = "#PERCENT{P1}";

            for(int i = 0; i < 5; i++)
            {
                chart1.Series[0].Points.Add(rdNum.Next(100)); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points[0].SetValueY(textBox1.Text);
            chart1.Invalidate();
        }
    }
}
