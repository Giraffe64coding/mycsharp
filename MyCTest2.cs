using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace MyCTest1
{    
    public partial class MyCTest2 : Form
    {        
        public MyCTest2()
        {
            InitializeComponent();
        }

        
        private void MyCTest2_Load(object sender, EventArgs e)
        {
            Thread thread=new Thread(new ThreadStart(ThreadTest));
            thread.Start();

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"메인스레드{1}");
                Thread.Sleep(500);
            }

            thread.Join();
            Console.WriteLine("스레드 종료");
            //Console.ReadLine();
        }
        
        static void ThreadTest()
        {
            for(int i = 0;i < 6; i++)
            {
                Console.WriteLine($"스레드추가{i}");
                Thread.Sleep(500);
            }   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
