namespace MyCTest1
{
    partial class MyCTest1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyCTest1));
            this.btnDown = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.allResult = new System.Windows.Forms.Label();
            this.resultText = new System.Windows.Forms.Label();
            this.cbRaffe = new System.Windows.Forms.CheckBox();
            this.cbLion = new System.Windows.Forms.CheckBox();
            this.cbRabbit = new System.Windows.Forms.CheckBox();
            this.cbButton = new System.Windows.Forms.Button();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tbTest = new System.Windows.Forms.TextBox();
            this.rbNeutral = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.genderButton = new System.Windows.Forms.Button();
            this.cbFavorChoose = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFavorInfo = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFavor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimeChange = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.gbGender.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDown.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnDown.ImageIndex = 0;
            this.btnDown.ImageList = this.imageList1;
            this.btnDown.Location = new System.Drawing.Point(166, 459);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(70, 43);
            this.btnDown.TabIndex = 0;
            this.btnDown.Text = "Down";
            this.btnDown.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Down0.jpg");
            this.imageList1.Images.SetKeyName(1, "Down1.jpg");
            // 
            // allResult
            // 
            this.allResult.AutoSize = true;
            this.allResult.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.allResult.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.allResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.allResult.Location = new System.Drawing.Point(460, 481);
            this.allResult.Name = "allResult";
            this.allResult.Size = new System.Drawing.Size(65, 22);
            this.allResult.TabIndex = 2;
            this.allResult.Text = "Result";
            // 
            // resultText
            // 
            this.resultText.AutoSize = true;
            this.resultText.Location = new System.Drawing.Point(542, 490);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(0, 12);
            this.resultText.TabIndex = 3;
            // 
            // cbRaffe
            // 
            this.cbRaffe.AutoSize = true;
            this.cbRaffe.Location = new System.Drawing.Point(12, 443);
            this.cbRaffe.Name = "cbRaffe";
            this.cbRaffe.Size = new System.Drawing.Size(48, 16);
            this.cbRaffe.TabIndex = 4;
            this.cbRaffe.Text = "기린";
            this.cbRaffe.UseVisualStyleBackColor = true;
            // 
            // cbLion
            // 
            this.cbLion.AutoSize = true;
            this.cbLion.Location = new System.Drawing.Point(12, 466);
            this.cbLion.Name = "cbLion";
            this.cbLion.Size = new System.Drawing.Size(48, 16);
            this.cbLion.TabIndex = 5;
            this.cbLion.Text = "사자";
            this.cbLion.UseVisualStyleBackColor = true;
            // 
            // cbRabbit
            // 
            this.cbRabbit.AutoSize = true;
            this.cbRabbit.Location = new System.Drawing.Point(12, 489);
            this.cbRabbit.Name = "cbRabbit";
            this.cbRabbit.Size = new System.Drawing.Size(48, 16);
            this.cbRabbit.TabIndex = 6;
            this.cbRabbit.Text = "토끼";
            this.cbRabbit.UseVisualStyleBackColor = true;
            // 
            // cbButton
            // 
            this.cbButton.Location = new System.Drawing.Point(66, 482);
            this.cbButton.Name = "cbButton";
            this.cbButton.Size = new System.Drawing.Size(75, 23);
            this.cbButton.TabIndex = 7;
            this.cbButton.Text = "확인";
            this.cbButton.UseVisualStyleBackColor = true;
            this.cbButton.Click += new System.EventHandler(this.cbButton_Click);
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.btnConfirm);
            this.gbGender.Controls.Add(this.tbTest);
            this.gbGender.Controls.Add(this.rbNeutral);
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Controls.Add(this.genderButton);
            this.gbGender.Location = new System.Drawing.Point(12, 305);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(200, 132);
            this.gbGender.TabIndex = 10;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "당신 성별은?";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(125, 87);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(69, 38);
            this.btnConfirm.TabIndex = 12;
            this.btnConfirm.Text = "확인";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tbTest
            // 
            this.tbTest.Location = new System.Drawing.Point(6, 87);
            this.tbTest.Multiline = true;
            this.tbTest.Name = "tbTest";
            this.tbTest.Size = new System.Drawing.Size(115, 38);
            this.tbTest.TabIndex = 11;
            // 
            // rbNeutral
            // 
            this.rbNeutral.AutoSize = true;
            this.rbNeutral.Location = new System.Drawing.Point(7, 65);
            this.rbNeutral.Name = "rbNeutral";
            this.rbNeutral.Size = new System.Drawing.Size(47, 16);
            this.rbNeutral.TabIndex = 3;
            this.rbNeutral.TabStop = true;
            this.rbNeutral.Text = "중성";
            this.rbNeutral.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(7, 42);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(47, 16);
            this.rbFemale.TabIndex = 2;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "여자";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(7, 19);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(47, 16);
            this.rbMale.TabIndex = 1;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "남자";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // genderButton
            // 
            this.genderButton.Location = new System.Drawing.Point(120, 19);
            this.genderButton.Name = "genderButton";
            this.genderButton.Size = new System.Drawing.Size(75, 59);
            this.genderButton.TabIndex = 0;
            this.genderButton.Text = "선택";
            this.genderButton.UseVisualStyleBackColor = true;
            this.genderButton.Click += new System.EventHandler(this.genderButton_Click);
            // 
            // cbFavorChoose
            // 
            this.cbFavorChoose.FormattingEnabled = true;
            this.cbFavorChoose.Items.AddRange(new object[] {
            "선택해 주세요",
            "생물",
            "인문학",
            "스포츠",
            "전자기기"});
            this.cbFavorChoose.Location = new System.Drawing.Point(6, 32);
            this.cbFavorChoose.Name = "cbFavorChoose";
            this.cbFavorChoose.Size = new System.Drawing.Size(121, 20);
            this.cbFavorChoose.TabIndex = 11;
            this.cbFavorChoose.Text = "선택해 주세요";
            this.cbFavorChoose.SelectedIndexChanged += new System.EventHandler(this.cbFavorChoose_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "종류선택";
            // 
            // lbFavorInfo
            // 
            this.lbFavorInfo.FormattingEnabled = true;
            this.lbFavorInfo.ItemHeight = 12;
            this.lbFavorInfo.Items.AddRange(new object[] {
            "상세내역 선택"});
            this.lbFavorInfo.Location = new System.Drawing.Point(143, 32);
            this.lbFavorInfo.Name = "lbFavorInfo";
            this.lbFavorInfo.Size = new System.Drawing.Size(120, 88);
            this.lbFavorInfo.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "상세정보";
            // 
            // btnFavor
            // 
            this.btnFavor.Location = new System.Drawing.Point(84, 126);
            this.btnFavor.Name = "btnFavor";
            this.btnFavor.Size = new System.Drawing.Size(111, 33);
            this.btnFavor.TabIndex = 14;
            this.btnFavor.Text = "확인";
            this.btnFavor.UseVisualStyleBackColor = true;
            this.btnFavor.Click += new System.EventHandler(this.btnFavor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFavor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbFavorInfo);
            this.groupBox1.Controls.Add(this.cbFavorChoose);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 165);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "취미";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.Black;
            this.lblDateTime.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDateTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDateTime.Location = new System.Drawing.Point(6, 13);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(0, 19);
            this.lblDateTime.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnTimeChange);
            this.groupBox2.Controls.Add(this.lblDateTime);
            this.groupBox2.Location = new System.Drawing.Point(393, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 41);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // btnTimeChange
            // 
            this.btnTimeChange.BackColor = System.Drawing.Color.DarkBlue;
            this.btnTimeChange.ForeColor = System.Drawing.Color.White;
            this.btnTimeChange.Location = new System.Drawing.Point(206, 11);
            this.btnTimeChange.Name = "btnTimeChange";
            this.btnTimeChange.Size = new System.Drawing.Size(67, 25);
            this.btnTimeChange.TabIndex = 18;
            this.btnTimeChange.Text = "서울";
            this.btnTimeChange.UseVisualStyleBackColor = false;
            this.btnTimeChange.Click += new System.EventHandler(this.btnTimeChange_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(218, 321);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 19;
            this.btnOpen.Text = "열기";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // MyCTest1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 515);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbButton);
            this.Controls.Add(this.cbRabbit);
            this.Controls.Add(this.cbLion);
            this.Controls.Add(this.cbRaffe);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.allResult);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.groupBox1);
            this.Name = "MyCTest1";
            this.Text = "MyCTest";
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label allResult;
        private System.Windows.Forms.Label resultText;
        private System.Windows.Forms.CheckBox cbRaffe;
        private System.Windows.Forms.CheckBox cbLion;
        private System.Windows.Forms.CheckBox cbRabbit;
        private System.Windows.Forms.Button cbButton;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbNeutral;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Button genderButton;
        private System.Windows.Forms.TextBox tbTest;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ComboBox cbFavorChoose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbFavorInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFavor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimeChange;
        private System.Windows.Forms.Button btnOpen;
    }
}

