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
    public partial class MyLineChart : Form
    {
        public MyLineChart()
        {
            InitializeComponent();
        }
        private void MyChart2_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 100;

            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 300;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rdNum= new Random();
            if (chart1.Series[0].Points.Count==100)
            {
                chart1.Series[0].Points.Clear();
            }
            chart1.Series[0].Points.AddY(rdNum.Next(300));
        }

        
    }
}
