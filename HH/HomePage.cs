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
    public partial class HomePage : Form
    {

        private string conStr = @"Data Source=LAPTOP-DI57MUOG;Initial Catalog=QLGB2;Integrated Security=True";
        private SqlConnection conn;
        private SqlDataAdapter myAdapter;
        private SqlCommand comm;
        private DataSet ds;
        private SqlDataAdapter myAdapter1;
        private SqlCommand comm1;
        private DataSet ds1;
        private DataTable dt1;
        private DataTable dt;
        private string _message;
        public static string ID_Champion = "";
        public static string best_player = "";  
        public HomePage()
        {
            InitializeComponent();
        }
        private void Header_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            All_clb allClub = new All_clb();
            allClub.Show();
            LoadData();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadData1();
        }
        private  void LoadData()
        {
            conn = new SqlConnection(conStr);
            conn.Open();

            /*string sqlString2 = "update ra"+
                                " set ra.gd = cl.SCORE - cl.LOSE"+
                                " from ranking as ra"+
                                " inner join CLUB as cl"+
                                " on cl.CLBID = ra.CLBID";

            myAdapter = new SqlDataAdapter(sqlString2, conn);
            comm = new SqlCommand(sqlString2,conn);
            comm.ExecuteNonQuery();*/

            string sqlString = "select top 20 *  from ranking order by POINT desc,gd desc,CLBNAME asc";
            myAdapter = new SqlDataAdapter(sqlString, conn);

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

            ID_Champion = dt.Rows[0]["CLBID"].ToString();
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
        private void setRowNumber(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = row.Index + 1;
            }

            dgv.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

        }

        private void result_Click(object sender, EventArgs e)
        {
            result f = new result();
            f.ShowDialog();
            LoadData();
            LoadData1();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void match_sch_Click(object sender, EventArgs e)
        {
            match_schedule f = new match_schedule();
            f.ShowDialog();
            LoadData();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            @ref f = new @ref();
            f.ShowDialog();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            top_goal f = new top_goal();
            f.ShowDialog();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("DO YOU WANT END OF SESSION", "QUESTIONS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(re == DialogResult.Yes)
            {
                conn = new SqlConnection(conStr);
                conn.Open();
                string sqlString = "select count(*) from MATCH1 where TYPE_MATCH = 1";
                string sqlString1 = "select count(*) from MATCH1 where TYPE_MATCH = 0";
                comm = new SqlCommand(sqlString, conn);
                Int32 count = (Int32)comm.ExecuteScalar();
                comm = new SqlCommand(sqlString1, conn);
                Int32 count1 = (Int32)comm.ExecuteScalar();
                //MessageBox.Show(count1.ToString() + count.ToString(),"q", MessageBoxButtons.OK);
                conn.Close();
                if(count % 10 ==10&& count1 == 0)
                {
                    if (count >= 30)
                    {
                        conn = new SqlConnection(conStr);
                        conn.Open();
                        string sqlString8 = "select top(10) PLID, CLBID,PLNAME,NATIONALITY,DAY_BORN,VITRI,SCORE from FOOTBALL_PLAYER" +
                        " where SCORE != 0  order by SCORE desc";

                        myAdapter = new SqlDataAdapter(sqlString8, conn);
                        ds = new DataSet();
                        myAdapter.Fill(ds, "PLID");
                        dt = ds.Tables["PLID"];
                        if (dt.Rows.Count > 0)
                        {
                            best_player = dt.Rows[0]["PLNAME"].ToString();
                        }
                        string sqlString2 = "update champions set CUPS_COUNT =CUPS_COUNT + 1" +
                                            "where CLBID = (select top 1 r.CLBID from ranking as r order by POINT desc,gd desc,CLBNAME asc)";
                        comm = new SqlCommand(sqlString2, conn);
                        comm.ExecuteNonQuery();
                        string sqlString3 = "DELETE FROM GOAL";
                        comm = new SqlCommand(sqlString3, conn);
                        comm.ExecuteNonQuery();

                        string sqlString4 = "DELETE FROM REF_TOMATCH";
                        comm = new SqlCommand(sqlString4, conn);
                        comm.ExecuteNonQuery();

                        string sqlString5 = "DELETE FROM MATCH1";
                        comm = new SqlCommand(sqlString5, conn);
                        comm.ExecuteNonQuery();

                        string sqlString6 = "UPDATE FOOTBALL_PLAYER set SCORE = 0";
                        comm = new SqlCommand(sqlString6, conn);
                        comm.ExecuteNonQuery();

                        string sqlString7 = "UPDATE ranking set win = 0,draw = 0,lose = 0,matchPlay = 0,gd = 0,POINT = 0";
                        comm = new SqlCommand(sqlString7, conn);
                        comm.ExecuteNonQuery();

                        champion f = new champion();
                        f.ShowDialog();

                    }
                }
            }
            LoadData();
            LoadData1();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            my_account f = new my_account();
            f.ShowDialog();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            all_user f = new all_user();
            f.ShowDialog();
        }
    }
}
