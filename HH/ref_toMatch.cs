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
    public partial class ref_toMatch : Form
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
        private SqlDataAdapter myAdapter2;
        private SqlCommand comm2;
        private DataSet ds2;
        private DataTable dt2;
        public static int re1 = 1;
        public static int re2 = 2;
        public ref_toMatch()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            string sqlString1 = "select REFID,REF_NAME,NATIONALITY,DAY_BORN from REFEREE where TYPE_REF = 1";
            myAdapter = new SqlDataAdapter(sqlString1, conn);
            ds = new DataSet();
            myAdapter.Fill(ds, "REFID");
            dt = ds.Tables["REFID"];
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["REFID"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["REF_NAME"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["NATIONALITY"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["DAY_BORN"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;

            string sqlString2 = "select REFID,REF_NAME,NATIONALITY,DAY_BORN from REFEREE where TYPE_REF = 2";
            myAdapter1 = new SqlDataAdapter(sqlString2, conn);
            ds1 = new DataSet();
            myAdapter1.Fill(ds1, "REFID");
            dt1 = ds1.Tables["REFID"];
            dataGridView2.DataSource = dt1;
            dataGridView2.Columns["REFID"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView2.Columns["REF_NAME"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView2.Columns["NATIONALITY"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView2.Columns["DAY_BORN"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            dataGridView2.RowHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;

            string sqlString3 = "declare @n int set @n = (select count(*) from MATCH1)" +
                            "select * from REF_TOMATCH where  MATCHID = dbo.b_string(@n)";
            myAdapter2 = new SqlDataAdapter(sqlString3, conn);
            ds2 = new DataSet();
            myAdapter2.Fill(ds2, "REFID");
            dt2 = ds2.Tables["REFID"];
            dataGridView3.DataSource = dt2;

            dataGridView3.Columns["refid"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView3.Columns["matchID"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            dataGridView3.RowHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;
            conn.Close();
        }
        
        private void ref_toMatch_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if(re2 == 0 && re1 == 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("INPUT REFEREE", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dt.Rows.Count > 0)
            {
                try
                {
                    int row = e.RowIndex;
                    ref1.Text = dt.Rows[row]["REFID"].ToString();
                }
                catch{}
            }
        }

        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dt1.Rows.Count > 0)
            {
                try
                {
                    int row = e.RowIndex;
                    ref2.Text = dt1.Rows[row]["REFID"].ToString();
                }
                catch {}
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if(re1 > 0)
            {
                conn = new SqlConnection(conStr);
                conn.Open();
                string sqlString = "declare @n int " +
                                   " set @n = (select count(*) from MATCH1)" +
                                   " insert into REF_TOMATCH values " +
                                   "(N'" + ref1.Text.ToString() +"',dbo.b_string(@n))";
                comm = new SqlCommand(sqlString, conn);
                try
                {
                    object name = comm.ExecuteNonQuery();
                    MessageBox.Show("REFEREE IS INSERTED", "OK", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("SAME ID REFEREE", "ERROR", MessageBoxButtons.OK);
                }
                finally
                {
                    conn.Close();
                }
                re1--;
            }
            LoadData();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(re2 > 0)
            {
                conn = new SqlConnection(conStr);
                conn.Open();
                string sqlString = "declare @n int " +
                                   " set @n = (select count(*) from MATCH1)" +
                                   " insert into REF_TOMATCH values " +
                                   "(N'" + ref2.Text.ToString() + "',dbo.b_string(@n))";
                comm = new SqlCommand(sqlString, conn);
                try
                {
                    object name = comm.ExecuteNonQuery();
                    MessageBox.Show("REFEREE IS INSERTED", "OK", MessageBoxButtons.OK);
                    re2--;
                }
                catch
                {
                    MessageBox.Show("SAME ID REFEREE", "ERROR", MessageBoxButtons.OK);
                }
                finally
                {
                    conn.Close();
                }
            }
            LoadData();
        }
    }
}
