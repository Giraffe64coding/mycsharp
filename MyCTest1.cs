using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
//using MySql.Data.MySqlClient;


namespace MyCTest1
{
    public partial class MyCTest1 : Form
    {
        public MyCTest1()
        {
            InitializeComponent();            
        }
        Random rdNum = new Random();

        private void MyCTest1_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Mask = "(999)000-0000";

            monthCalendar1.SelectionStart = DateTime.Now;
            monthCalendar1.SelectionEnd = DateTime.Now.AddDays(3);

            // MaxSelectionCount 디폴트 값은 7일            
            monthCalendar1.MaxSelectionCount = 31;

            //MonthCalender
            ContextMenu ctx = new ContextMenu();
            ctx.MenuItems.Add(new MenuItem("열기"));
            ctx.MenuItems.Add(new MenuItem("실행"));
            ctx.MenuItems.Add("-");
            ctx.MenuItems.Add(new MenuItem("종료", new EventHandler((s, ex) => this.Close())));
            notifyIcon1.ContextMenu = ctx;

            //NumericUpDown
            numericUpDown1.Value = 21.0M;

            //TreeView
            // TreeView에 사용할 ImageList 정의
            //ImageList imgList = new ImageList();
            //imgList.Images.Add(Bitmap.FromFile("server.jpg"));
            //imgList.Images.Add(Bitmap.FromFile("network.jpg"));
            //treeView1.ImageList = imgList;


            // 첫번째 TreeView 아이템 - 서버
            TreeNode svrNode = new TreeNode("서버", 0, 0);
            svrNode.Nodes.Add("SE", "서울 서버", 0, 0);
            svrNode.Nodes.Add("DJ", "대전 서버", 0, 0);
            svrNode.Nodes.Add("BS", "부산 서버", 0, 0);

            // 두번째 TreeView 아이템 - 네트웍
            TreeNode netNode = new TreeNode("네트웍", 1, 1);
            netNode.Nodes.Add("T1", "T1 케이블", 1, 1);
            netNode.Nodes.Add("56K", "56K 모뎀", 1, 1);
            netNode.Nodes.Add("3G", "3G 무선", 1, 1);

            // 2개의 노드를 TreeView에 추가
            treeView1.Nodes.Add(svrNode);
            treeView1.Nodes.Add(netNode);

            // 모든 트리 노드를 보여준다
            treeView1.ExpandAll();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            MessageBox.Show("내용", "제목",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);

            resultText.Text = String.Format("{0} {1}", "Button", "clicked");
        }//Button click
        
        private void cbButton_Click(object sender, EventArgs e)
        {
            
            resultText.Text = "선택한 동물은 ";
            if (cbRaffe.Checked)
            {
                resultText.Text += cbRaffe.Text+" ";                
            }
            if (cbLion.Checked)
            {
                resultText.Text += cbLion.Text+" ";                
            }
            if (cbRabbit.Checked)
            {
                resultText.Text += cbRabbit.Text+" ";                
            }
            resultText.Text +=" 입니다";
            if (!cbRaffe.Checked &&!cbRabbit.Checked&&!cbLion.Checked)
            {                
                resultText.Text = "선택해 주세요";
                MessageBox.Show("하나라도 선택해야 합니다", "선택오류", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }//Check box

        private void genderButton_Click(object sender, EventArgs e)
        {
            if (rbMale.Checked)
            {
                MessageBox.Show("남자군요","성별선택",MessageBoxButtons.OK);
                
            }else if (rbFemale.Checked)
            {
                MessageBox.Show("여자군요", "성별선택", MessageBoxButtons.OK);
                
            }
            else if(rbNeutral.Checked)
            {
                MessageBox.Show("중성이군요", "성별선택", MessageBoxButtons.OK);
                
            }
            if (!rbMale.Checked && !rbFemale.Checked && !rbNeutral.Checked)
            {
                MessageBox.Show("성별을 선택하세요","안내",MessageBoxButtons.OK,MessageBoxIcon.Question);
            }
        }//Radio Box

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            tbTest.Clear();
            
            if (rbMale.Checked)
            {
                
                tbTest.Text = "저는 " + rbMale.Text + "입니다" ;
                
            }        
            if (rbFemale.Checked)
            {
                
                tbTest.Text = "저는 " + rbFemale.Text + "입니다" ;
            }
            if (rbNeutral.Checked)
            {
                
                tbTest.Text = "저는 " + rbNeutral.Text + "입니다" ;
            }
            

        }//Radio Box Choose

        private void btnFavor_Click(object sender, EventArgs e)
        {              
            if (lbFavorInfo.SelectedItems.Count <= 0 && lbFavorInfo.SelectedIndex < 1 || lbFavorInfo.SelectedItem.ToString() == "상세내역 선택")
            {
                MessageBox.Show("종류와 상세내역 선택해 주세요","안내",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                string strText = "당신의 취미는 " + cbFavorChoose.Text + "-" + lbFavorInfo.Text + " 입니다";
                MessageBox.Show(strText, "취미선택", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }        
        }//Combo Box
          
        private void cbFavorChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbFavorInfo.Items.Clear();
            if(cbFavorChoose.SelectedIndex == 0)
            {
                lbFavorInfo.Items.Add("상세내역 선택");
            }
            else if (cbFavorChoose.SelectedIndex == 1)
            {
                lbFavorInfo.Items.Add("동물");
                lbFavorInfo.Items.Add("식물");
                lbFavorInfo.Items.Add("파충류");
            }
            else if (cbFavorChoose.SelectedIndex == 2)
            {
                lbFavorInfo.Items.Add("교육");
                lbFavorInfo.Items.Add("예술");
                lbFavorInfo.Items.Add("철학");
                lbFavorInfo.Items.Add("경제");                
            }
            else if (cbFavorChoose.SelectedIndex == 3)
            {
                lbFavorInfo.Items.Add("축구");
                lbFavorInfo.Items.Add("농구");
                lbFavorInfo.Items.Add("볼링");
            }
            else if (cbFavorChoose.SelectedIndex == 4)
            {
                lbFavorInfo.Items.Add("컴퓨터");
                lbFavorInfo.Items.Add("모바일");
                lbFavorInfo.Items.Add("게임기");
                lbFavorInfo.Items.Add("헤드폰");
            }
        }//List Box

        private void timer1_Tick(object sender, EventArgs e)
        {            
            if (btnTimeChange.Text=="서울")
            {
                lblDateTime.Text = DateTime.Now.ToString();
            }else if (btnTimeChange.Text=="유럽")
            {
                lblDateTime.Text=DateTime.UtcNow.ToString();
            }            
        }//Timer

        private void btnTimeChange_Click(object sender, EventArgs e)
        {
            
            if(btnTimeChange.Text == "유럽")
            {
                btnTimeChange.Text = "서울";
                btnTimeChange.ForeColor= Color.White;
                btnTimeChange.BackColor = Color.DarkBlue;
            }
            else
            {
                btnTimeChange.Text = "유럽";
                btnTimeChange.ForeColor = Color.White;
                btnTimeChange.BackColor = Color.Fuchsia;
            }
            
        }//Timer Changer

        private void btnOpen_Click(object sender, EventArgs e)
        {
            MyCTest2 myCT=new MyCTest2();
            myCT.ShowDialog();
            
        }//Show MyCTest2 Form

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.google.com/");
        }//linklabel

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.naver.com/");
           
        }//linklabel

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (e.Position < 5) // (999)인 경우
            {
                toolTip1.Show("숫자나 공란만 입력 가능", this);
                resultText.Text = "mask1";
            }
            else // 000-0000 인 경우
            {
                toolTip1.Show("숫자만 입력 가능", this);
                resultText.Text = "mask2";
            }
        }//maskedtextbox

        private void button1_Click(object sender, EventArgs e)
        {
            string val = maskedTextBox1.Text;
            MessageBox.Show(val);
        }//maskedtextbox

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
            textBox1.Text = monthCalendar1.SelectionStart.ToShortDateString();
            textBox2.Text = monthCalendar1.SelectionEnd.ToShortDateString();
        }//MonthCalender

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
                this.Activate();
        }//NotifyIcon

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // 섭씨를 화씨로 변경
            decimal C = numericUpDown1.Value;
            decimal F = C * (9.0M / 5.0M) + 32.0M;

            // 화씨 출력
            this.textBox3.Text = F.ToString();
        }//NumericUpDown

        private void button2_Click(object sender, EventArgs e)
        {
            string filepath = textBox4.Text;
            if (string.IsNullOrEmpty(filepath) ||
                  !File.Exists(filepath))
            {
                MessageBox.Show("Invalid file name");
                return;
            }

            // Load .RTF or Text File
            richTextBox1.LoadFile(filepath);
        }//RichTextBox

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectionLength = richTextBox1.Text.Length;
            richTextBox1.SelectionFont = new Font(SystemFonts.DefaultFont, FontStyle.Italic);
        }//RichTextBoxChange

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string nodeKey = e.Node.Name;
            if (!string.IsNullOrEmpty(nodeKey))
            {
                MessageBox.Show("선택된 노드 키 : " + nodeKey);
            }
        }//TreeView

        private void button4_Click(object sender, EventArgs e)
        {
            string url = textBox5.Text;
            webBrowser1.Navigate(url);
        }//WebBrowser

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string msg = e.Url + " 로딩 완료!";
            MessageBox.Show(msg);
        }//WebBrowser

        private void button5_Click(object sender, EventArgs e)
        {
            MyBackGroundWorker worker = new MyBackGroundWorker();
            worker.Show();
        }
    }
}
