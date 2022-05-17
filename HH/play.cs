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
    public partial class play : Form
    {
        private string conStr = @"Data Source=LAPTOP-DI57MUOG;Initial Catalog=QLGB2;Integrated Security=True";
        private SqlConnection conn;
        private SqlDataAdapter myAdapter;
        private SqlCommand comm;
        private DataSet ds;
        private DataTable dt;
        public static string mID = "";

        public play()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            conn = new SqlConnection(conStr);
            conn.Open();

            userText.Text = user_login.user;
            string sqlString1 = "select POINT from play where USERNAME = N'" + user_login.user + "'";
            myAdapter = new SqlDataAdapter(sqlString1, conn);
            ds = new DataSet();
            myAdapter.Fill(ds, "USERNAME");
            dt = ds.Tables["USERNAME"];
            pointText.Text = dt.Rows[0]["POINT"].ToString();

            string sqlString = "select MATCHID,CLB1,CLB2,STAYDIUM,DATE_TIME from MATCH1 where TYPE_MATCH = 0 and MATCHID not in (select MATCHID from USER_PLAY where USERNAME =N'"+userText.Text.ToString()+"')";
            myAdapter = new SqlDataAdapter(sqlString, conn);

            ds = new DataSet();
            myAdapter.Fill(ds, "MATCHID");
            dt = ds.Tables["MATCHID"];
            dataGridView1.DataSource = dt;

            dataGridView1.Columns["matchid"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["club1"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["club2"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["stay"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["date"].DefaultCellStyle.BackColor = Color.Aqua;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;

            conn.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void play_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dt.Rows.Count > 0)
            {
                try
                {
                    int row = e.RowIndex;
                    clb1.Text = dt.Rows[row]["CLB1"].ToString();
                    clb2.Text = dt.Rows[row]["CLB2"].ToString();
                    mID = dt.Rows[row]["MATCHID"].ToString();
                }
                catch { }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            clbchoose.Text = clb1.Text;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            clbchoose.Text = clb2.Text;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (clbchoose.Text.ToString() != "" && point.Text.ToString() != "" && score.Text.ToString() != "")
            {
                if (clbchoose.Text.ToString() == clb1.Text.ToString() || clbchoose.Text.ToString() == clb2.Text.ToString())
                {
                    Int32 coint = Int32.Parse(point.Text.ToString());
                    if (coint >= 10000)
                    {
                        Int32 max_coint = Int32.Parse(pointText.Text.ToString());
                        if (coint <= max_coint)
                        {
                            conn = new SqlConnection(conStr);
                            conn.Open();
                            string sqlString = "insert into USER_PLAY values (N'" + userText.Text.ToString() + "',N'" + mID + "',N'" +
                                            clbchoose.Text.ToString() + "'," + score.Text.ToString() + "," + coint.ToString() + ")";
                            comm = new SqlCommand(sqlString, conn);
                            comm.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("The bet amount is bigger than the amount you have", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The amount must be at least 10000 or more", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("INPUT IS NULL", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }
    }
}
