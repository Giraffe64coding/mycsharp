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
    public partial class MyMainChart : Form
    {
        public MyMainChart()
        {
            InitializeComponent();
        }
        
        private void MyChart_Load(object sender, EventArgs e)
        {
            Random rdNum=new Random();
            ////Color[] colors = { Color.Red, Color.Blue, Color.Green, Color.Purple, Color.Orange, Color.Yellow };

            for (int i = 0; i < 6; i++)
            {
            //    chart1.Series[0].Points.Add(rdNum.Next(200));
            //    chart1.Series[1].Points.Add(rdNum.Next(200));
            //    //chart1.Series[0].Points[i].Color = colors[i];

                chart2.Series[0].Points.Add(rdNum.Next(500));
                chart2.Series[0].Points.Add(rdNum.Next(500));
            //    //chart2.Series[0].Points[i].Color = colors[i];

                chart2.Series[1].Points.Add(rdNum.Next(800));
                chart2.Series[1].Points.Add(rdNum.Next(800));
            //    //chart2.Series[1].Points[i].Color = colors[i];
            }
            chart1.Series[0].Points.DataBindXY(
                new[] { "1월", "2월", "3월", "4월", "5월" },
                new[] { 100, 50, 250, 100, 50 }
                );

        }//Open MainChart & Change Color

        private void chart1_Click(object sender, EventArgs e)
        {

        }//Empty

        private void button1_Click(object sender, EventArgs e)
        {
            MyLineChart myLineChart=new MyLineChart();
            myLineChart.Show();

        }//Open Line Chart

        private void button2_Click(object sender, EventArgs e)
        {
            MyPieChart myPieChart=new MyPieChart();
            myPieChart.Show();
        }//Open Pie Chart

        private void button3_Click(object sender, EventArgs e)
        {
            MySQLDatabase mySQLDatabase = new MySQLDatabase();
            mySQLDatabase.Show();
        }//Open SQL Database Form

    }
}
