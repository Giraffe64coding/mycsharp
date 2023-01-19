using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyChart
{
    public partial class MySQLDatabase : Form
    {
        DataTable Table1;
        //SqlConnection Conn = null;
        public MySQLDatabase()
        {
            InitializeComponent();
        }


        private void MySQLDatabase_Load(object sender, EventArgs e)
        {
            Table1= new DataTable("Table1");
            DataColumn Col1=new DataColumn("Name",typeof(string));
            Table1.Columns.Add(Col1);
            Col1=new DataColumn("Age",typeof(int));
            Table1.Columns.Add(Col1);
            Col1=new DataColumn("Male",typeof(bool));
            Table1.Columns.Add(Col1);

            DataRow row=Table1.NewRow();
            row["Name"] = "철수";
            row["Age"] = 12;
            row["Male"] = true;
            Table1.Rows.Add(row);


            row=Table1.NewRow();
            row["Name"] = "다은";
            row["Age"] = 11;
            row["Male"] = false;
            Table1.Rows.Add(row);

            row = Table1.NewRow();
            row["Name"] = "은성";
            row["Age"] = 12;
            row["Male"] = true;
            Table1.Rows.Add(row);
            dataGridView1.DataSource = Table1;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 8);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "server=.\\SQLEXPRESS;database=school;uid=giraffe64coding;password=12345";
            Conn.Open();
            //string strSQL1 = "INSERT INTO tblStudent VALUES('이민우',25,1)";
            //string strSQL2 = "INSERT INTO tblStudent VALUES('김지우',41,0)";

            SqlCommand Command = new SqlCommand(textBox1.Text, Conn);
            Command.ExecuteNonQuery();


            Command.CommandText = "SELECT * FROM tblStudent";
            SqlDataReader Reader = Command.ExecuteReader();
            listView1.Clear();

            string strRecord;
            while (Reader.Read())
            {
                //Console.WriteLine("{0}{1}{2}", Reader["Name"], Reader[1], Reader["Male"]);
                strRecord = string.Format("이름:{0} 나이;{1} 성별:{2}", Reader["Name"], Reader["Age"], Reader["Male"]);
                listView1.Items.Add(strRecord);
                //INSERT INTO tblStudent VALUES('우차차',8,1)
            }
            Reader.Close();
            Conn.Close();
        }//IO SQL database //IO SQL database

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable table1 = new DataTable("table1");
            DataColumn Col1=new DataColumn("Name",typeof(string));
            table1.Columns.Add(Col1);
            Col1 = new DataColumn("Age", typeof(int));
            table1.Columns .Add(Col1);
            Col1 = new DataColumn("Male",typeof(bool));
            table1.Columns.Add (Col1);

            DataRow row=table1.NewRow();
            row["Name"] = "철수";
            row["Age"] = 12;
            row["Male"] = true;
            table1.Rows.Add(row);

            row = table1.NewRow();
            row["Name"] = "수지";
            row["Age"] = 11;
            row["Male"] = false;
            table1.Rows.Add(row);
            
            row = table1.NewRow();
            row["Name"] = "차돌";
            row["Age"] = 9;
            row["Male"] = true;
            table1.Rows.Add(row);
            table1.AcceptChanges();

            foreach(DataRow PrintRow in table1.Rows)
            {
                string str;
                if (PrintRow["Male"].ToString() == "True")
                    str = "남자";
                else
                    str = "여자";
                Console.WriteLine("이름:{0} 나이:{1} 성별:{2}", PrintRow["Name"],PrintRow["Age"],str);
            }


        }
        //입력
        private void button3_Click(object sender, EventArgs e)
        {
            DataRow row=Table1.NewRow();
            row["Name"] = textBox2.Text;
            row["Age"] = int.Parse(textBox3.Text);
            if (radioButton1.Checked)
            
                row["Male"] = true;
                else
                    row["Male"]=false;
            Table1.Rows.Add(row);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection Rows = dataGridView1.SelectedRows;
            int SelectedRowIndex = Rows[0].Index;
            DataRow Row = Table1.Rows[SelectedRowIndex];
            Row.Delete();
            Table1.AcceptChanges();

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection Rows = dataGridView1.SelectedRows;
            int SelectedRowIndex=Rows[0].Index;
            DataRow Row=Table1.Rows[SelectedRowIndex];
            Row["Name"] = textBox2.Text;
            Row["Age"] = int.Parse(textBox3.Text);
            if (radioButton1.Checked)
                Row["Male"] = true;
            else
                Row["Male"] = false;
        }
    }
}
