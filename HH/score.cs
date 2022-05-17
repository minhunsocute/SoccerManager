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
    public partial class score : Form
    {
        private string conStr = @"Data Source=LAPTOP-DI57MUOG;Initial Catalog=QLGB2;Integrated Security=True";
        private SqlConnection conn;
        private SqlDataAdapter myAdapter;
       // private SqlCommand comm;
        private DataSet ds;
        private DataTable dt;
        private SqlDataAdapter myAdapter1;
        private DataSet ds1;
        private DataTable dt1;
        private string _message;

        public score()
        {
            InitializeComponent();
        }

        private void score_Load(object sender, EventArgs e)
        {
            if (result.clb1 != "")
            {
                clb1.Text = result.clb1;
                clb2.Text = result.clb2;
                sc1.Text = result.sc1;
                sc2.Text = result.sc2;
            }
            else
            {
                clb1.Text = result_user.clb1;
                clb2.Text = result_user.clb2;
                sc1.Text = result_user.sc1;
                    sc2.Text = result_user.sc2;
                }
            LoadData();
        }

        private void LoadData()
        {
            conn = new SqlConnection(conStr);
            conn.Open();

            if (result.clb1 != "")
            {
                string sqlString = "select PLID,CLBID,TIME_GOAL,NAMEGOAL from GOAL where MATCHID  = N'" + result.maID + "'";
                ds = new DataSet();
                myAdapter = new SqlDataAdapter(sqlString, conn);
                myAdapter.Fill(ds, "MATCHID");
                dt = ds.Tables["MATCHID"];
                string SqlString1 = "select r.REF_NAME,r.TYPE_REF from REFEREE as r inner join REF_TOMATCH as rt on rt.REFID = r.REFID " +
                                    "and rt.MATCHID = N'" + result.maID.ToString() + "'";
                ds1 = new DataSet();
                myAdapter1 = new SqlDataAdapter(SqlString1, conn);
                myAdapter1.Fill(ds1, "REFNAME");
                dt1 = ds1.Tables["REFNAME"];
            }
            else
            {
                string sqlString = "select PLID,CLBID,TIME_GOAL,NAMEGOAL from GOAL where MATCHID  = N'" + result_user.maID + "'";
                ds = new DataSet();
                myAdapter = new SqlDataAdapter(sqlString, conn);
                myAdapter.Fill(ds, "MATCHID");
                dt = ds.Tables["MATCHID"];
                string SqlString1 = "select r.REF_NAME,r.TYPE_REF from REFEREE as r inner join REF_TOMATCH as rt on rt.REFID = r.REFID " +
                                    "and rt.MATCHID = N'" + result_user.maID.ToString() + "'";
                ds1 = new DataSet();
                myAdapter1 = new SqlDataAdapter(SqlString1, conn);
                myAdapter1.Fill(ds1, "REFNAME");
                dt1 = ds1.Tables["REFNAME"];
            }
            if (dt1.Rows.Count > 0)
            {
                ref1.Text = dt1.Rows[0]["REF_NAME"].ToString();
                ref2.Text = dt1.Rows[1]["REF_NAME"].ToString();
                ref3.Text = dt1.Rows[2]["REF_NAME"].ToString();

            }
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["playID"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["clbid"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["name"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["time"].DefaultCellStyle.BackColor = Color.Aqua;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;

            conn.Close();

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
