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

namespace HH
{
    public partial class user_home : Form
    {
        private string conStr = @"Data Source=LAPTOP-DI57MUOG;Initial Catalog=QLGB2;Integrated Security=True";
        private SqlConnection conn;
        private SqlDataAdapter myAdapter;
        private SqlCommand comm;
        private DataSet ds;
        private DataTable dt;

        public user_home()
        {
            InitializeComponent();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void user_home_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadData1();
        }
        private void LoadData()
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            if (user_login.check_user == 1)
            {
                userText.Text = user_login.user;
                

                string sqlString = "select POINT from play where USERNAME = N'" + user_login.user + "'";
                myAdapter = new SqlDataAdapter(sqlString, conn);
                ds = new DataSet();
                myAdapter.Fill(ds, "USERNAME");
                dt = ds.Tables["USERNAME"];
                pointText.Text = dt.Rows[0]["POINT"].ToString();
            }

            string sqlString1 = "select top 20 *  from ranking order by POINT desc,gd desc,CLBNAME asc";
            myAdapter = new SqlDataAdapter(sqlString1, conn);

            ds = new DataSet();
            myAdapter.Fill(ds, "CLBID");
            dt = ds.Tables["CLBID"];
            dataGridView1.DataSource = dt;

            dataGridView1.Columns["clbname"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["win"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["draw"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["lose"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["PL"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["gd"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["point"].DefaultCellStyle.BackColor = Color.Aqua;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;
            conn.Close();
        }
        private void LoadData1()
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            string sqlString = "select top(10) * from champions order by CUPS_COUNT desc";
            ds = new DataSet();
            myAdapter = new SqlDataAdapter(sqlString, conn);
            myAdapter.Fill(ds, "CLBID");
            dt = ds.Tables["CLBID"];
            dataGridView2.DataSource = dt;

            dataGridView2.Columns["CLBID"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView2.Columns["CUPS_COUNT"].DefaultCellStyle.BackColor = Color.Aqua;

            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            dataGridView2.RowHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;

            conn.Close();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            top_goal f = new top_goal();
            f.ShowDialog();
        }

        private void result1_Click(object sender, EventArgs e)
        {
            result_user f = new result_user();
            f.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (user_login.check_user == 1)
            {
                play f = new play();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must be logged in to use this feature", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (user_login.check_user == 1)
            {
                message f = new message();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must be logged in to use this feature", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
