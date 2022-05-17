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
    public partial class add_match : Form
    {
        private string conStr = @"Data Source=LAPTOP-DI57MUOG;Initial Catalog=QLGB2;Integrated Security=True";
        private SqlConnection conn;
        private SqlDataAdapter myAdapter;
        private SqlCommand comm;
        private DataSet ds;
        private DataTable dt;
        private SqlDataAdapter myAdapter1;
        private SqlCommand comm1;
        private DataSet ds1;
        private DataTable dt1;
        public static string sta1 = "";
        public static string sta2 = "";

        public add_match()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_match_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            conn = new SqlConnection(conStr);
            conn.Open();

            string sqlString = "select clb.* from CLUB as clb,ranking as r " +
                "where r.CLBID = clb.CLBID and r.matchPlay = (case  " +
                                                    "when (select count(*) from CLUB) = (select count(clb1.CLBID) from CLUB as clb1,ranking as ra1 where clb1.CLBID = ra1.CLBID and ra1.matchPlay = (select max(matchPlay) from ranking)) then (case when(select count(*)from MATCH1 where TYPE_MATCH = 0) = 0 then (select max(matchPlay) from ranking) else 1000	end ) " +
                                                    "else (select max(matchPlay) from ranking) -1 " +
                                                    "end )";
            myAdapter = new SqlDataAdapter(sqlString, conn);
            ds = new DataSet();
            myAdapter.Fill(ds, "CLBID");
            dt = ds.Tables["CLBID"];
            dt1 = ds.Tables["CLBID"];
            dataGridView1.DataSource = dt;
            myAdapter1 = new SqlDataAdapter(sqlString, conn);
            ds1 = new DataSet();
            myAdapter1.Fill(ds1, "CLBID");
            dt1 = ds1.Tables["CLBID"];
            dataGridView2.DataSource = dt1;

            dataGridView1.Columns["clbid1"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["name1"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["stadium1"].DefaultCellStyle.BackColor = Color.Aqua;


            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;

            dataGridView2.Columns["clbid2"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView2.Columns["name2"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView2.Columns["stadium2"].DefaultCellStyle.BackColor = Color.Aqua;


            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            dataGridView2.RowHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;

            conn.Close();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dt.Rows.Count > 0)
            {
                int row = e.RowIndex;
                clb1.Text = dt.Rows[row]["CLBID"].ToString();
                sta1 = dt.Rows[row]["STAYDIUM"].ToString();
            }
        }

        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dt.Rows.Count > 0)
            {
                int row = e.RowIndex;
                clb2.Text = dt1.Rows[row]["CLBID"].ToString();
                sta2 = dt1.Rows[row]["STAYDIUM"].ToString();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e) { stadium_string.Text = sta1; }
        private void guna2Button2_Click(object sender, EventArgs e) {stadium_string.Text = sta2;}

        private void add_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);
            conn.Open();

            if (stadium_string.Text.ToString() != "")
            {
                if(clb1.Text.ToString() != clb2.Text.ToString())
                {
                    string SqlStr = "select count(*) from MATCH1 where (CLB1 = N'" + clb1.Text.ToString() + "' and CLB2 = N'" + clb2.Text.ToString() + "')" +
                                     " or (CLB2=N'" + clb1.Text.ToString() + "' and CLB1 = N'" + clb2.Text.ToString() + "')";
                    comm = new SqlCommand(SqlStr, conn);
                    Int32 count = (Int32)comm.ExecuteScalar();
                    if (count == 0)
                    {
                        DialogResult re = MessageBox.Show("Do you want isert Match???", "QUestions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (re == DialogResult.Yes)
                        {
                            string sqlString = "exec insert_matchAutoID N'" + clb1.Text.ToString() + "',N'" + clb2.Text.ToString() + "',N'" + stadium_string.Text.ToString() + "','" + dateTimePicker1.Text.ToString() + "'";
                            comm = new SqlCommand(sqlString, conn);
                            comm.ExecuteNonQuery();
                            string sqlString1 = "update ranking set matchPlay = matchPlay + 1 where CLBID = N'" + clb1.Text.ToString() + "' or CLBID = N'" + clb2.Text.ToString() + "'";
                            comm = new SqlCommand(sqlString1, conn);
                            comm.ExecuteNonQuery();
                            stadium_string.Clear();
                            ref_toMatch f = new ref_toMatch();
                            f.ShowDialog();                           
                        }
                    }
                    else
                    {
                        MessageBox.Show("Matches already exist", "Error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("2 clb is same", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Stadium is NULL", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
            LoadData();
        }
    }
}
