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
    public partial class result : Form
    {
        private string conStr = @"Data Source=LAPTOP-DI57MUOG;Initial Catalog=QLGB2;Integrated Security=True";
        private SqlConnection conn;
        private SqlDataAdapter myAdapter;
        private SqlCommand comm;
        private DataSet ds;
        private DataTable dt;
        public static string clb1 = "";
        public static string clb2 = "";
        public static string sc1 = "";
        public static string sc2 = "";
        public static string maID = "";

        public result()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            insert_result f = new insert_result();
            f.ShowDialog();
            LoadData();
        }

        private void LoadData()
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            string sqlString = "select * from MATCH1 where TYPE_MATCH = 1";
            myAdapter = new SqlDataAdapter(sqlString, conn);

            ds = new DataSet();
            myAdapter.Fill(ds, "MATCHID");
            dt = ds.Tables["MATCHID"];
            dataGridView1.DataSource = dt;

            dataGridView1.Columns["matchid"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["club1"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["club2"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["score1"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["score2"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["stay"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["date"].DefaultCellStyle.BackColor = Color.Aqua;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;

            conn.Close();
        }
        private void result_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void show_Click(object sender, EventArgs e)
        {
            score f = new score();
            f.ShowDialog();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dt.Rows.Count > 0)
            {
                try
                {
                    int row = e.RowIndex;
                    mID.Text = dt.Rows[row]["MATCHID"].ToString();
                    clb1 = dt.Rows[row]["CLB1"].ToString();
                    clb2 = dt.Rows[row]["CLB2"].ToString();
                    sc1 = dt.Rows[row]["SCORED1"].ToString();
                    sc2 = dt.Rows[row]["SCORED2"].ToString();
                    maID = mID.Text;
                }
                catch
                {

                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
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
            if (count == 190)
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
                        HomePage.best_player = dt.Rows[0]["PLNAME"].ToString();
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
            this.Close();
        }
    }
}
