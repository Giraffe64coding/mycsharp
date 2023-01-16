using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyCTest1
{
    public partial class MyCTest1 : Form
    {
        public MyCTest1()
        {
            InitializeComponent();            
        }
        Random rdNum = new Random();
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
            
        }
    }
}
