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
using System.IO;


namespace MyCTest1
{
    
    public partial class MyBackGroundWorker : Form
    {
        BackgroundWorker worker=new BackgroundWorker();
        public MyBackGroundWorker()
        {
            InitializeComponent();
            
            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            worker.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);

        }

        private void MyBackGroundWorker_Load(object sender, EventArgs e)
        {
            
        }    
        private void startButton_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = 10;
            //backgroundWorker1.RunWorkerAsync();
            //MessageBox.Show("Started");
            startButton.Enabled = false;
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
                

            }
            
            

            // 비동기(Async)로 실행 
            //worker.RunWorkerAsync();
            
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            for (int i = 1; i < 11; i++)
            {
                Thread.Sleep(1000);
                backgroundWorker1.ReportProgress(i);
                label1.Text = "로딩중...";
                
                if (backgroundWorker1.CancellationPending)
                {
                    label1.Text = "중단됨";
                    break;
                }
                    

            }

            //string srcDir = @"C:\Users\cuido\Desktop\_Src";
            //string destDir = @"C:\Users\cuido\Desktop\_Dest";

            //DirectoryInfo di = new DirectoryInfo(srcDir);
            //FileInfo[] fileInfos = di.GetFiles();
            //int totalFiles = fileInfos.Length;
            //int counter = 0;
            //int pct = 0;
            //foreach (var fi in fileInfos)
            //{
            //    string destFile = Path.Combine(destDir, fi.Name);
            //    File.Copy(fi.FullName, destFile);

            //    pct = ((++counter * 100) / totalFiles);
            //    worker.ReportProgress(pct);
            //}


        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            Console.WriteLine(e.ProgressPercentage.ToString());
            if (backgroundWorker1.CancellationPending)
            {
                return;
            }


        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //MessageBox.Show("Task Compeleted");
            // 에러가 있는지 체크
            if (e.Error != null)
            {
                label1.Text = e.Error.Message;
                MessageBox.Show(e.Error.Message, "Error");
                return;
            }
            if (backgroundWorker1.CancellationPending)
            {
                label1.Text = "성공적으로 완료되었습니다";
            }
            
            startButton.Enabled = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
                
                MessageBox.Show("clicked");
                
            }            
            
        }
        
    }
}
