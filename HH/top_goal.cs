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
    public partial class top_goal : Form
    {
        private string conStr = @"Data Source=LAPTOP-DI57MUOG;Initial Catalog=QLGB2;Integrated Security=True";
        private SqlConnection conn;
        private SqlDataAdapter myAdapter;
        private SqlCommand comm;
        private DataSet ds;
        private DataTable dt;
        public static string best_player = "";
        public top_goal()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            conn = new SqlConnection(conStr);
            conn.Open();

            string sqlString = "select top(10) PLID, CLBID,PLNAME,NATIONALITY,DAY_BORN,VITRI,SCORE from FOOTBALL_PLAYER" +
                " where SCORE != 0  order by SCORE desc";

            myAdapter = new SqlDataAdapter(sqlString, conn);
            ds = new DataSet();
            myAdapter.Fill(ds, "PLID");
            dt = ds.Tables["PLID"];
            dataGridView1.DataSource = dt;


            dataGridView1.Columns["plid"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["clbid"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["plname"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["day"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["score"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["vitri"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["nation"].DefaultCellStyle.BackColor = Color.Aqua;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["VITRI"].ToString() == "1")
                {
                    dataGridView1.Rows[i].Cells["vitri"].Value = "Goalie";
                }
                else if (dt.Rows[i]["VITRI"].ToString() == "2")
                {
                    dataGridView1.Rows[i].Cells["vitri"].Value = "defender";
                }
                else if (dt.Rows[i]["VITRI"].ToString() == "3")
                {
                    dataGridView1.Rows[i].Cells["vitri"].Value = "midfielder";
                }
                else if (dt.Rows[i]["VITRI"].ToString() == "4")
                {
                    dataGridView1.Rows[i].Cells["vitri"].Value = "striker";
                }
            }

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;

            if(dt.Rows.Count > 0)
            {
                topPl.Text = dt.Rows[0]["PLNAME"].ToString();
            }
            conn.Close();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void top_goal_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
