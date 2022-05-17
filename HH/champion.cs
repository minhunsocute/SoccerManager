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
    public partial class champion : Form
    {
        private string conStr = @"Data Source=LAPTOP-DI57MUOG;Initial Catalog=QLGB2;Integrated Security=True";
        private SqlConnection conn;
        private SqlDataAdapter myAdapter;
        private SqlCommand comm;
        private DataSet ds;
        private DataTable dt;

        public champion()
        {
            InitializeComponent();
        }

        private void champion_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            string sqlString = "select * from CLUB where CLBID = N'" + HomePage.ID_Champion +"'";
            ds = new DataSet();
            myAdapter = new SqlDataAdapter(sqlString, conn);
            myAdapter.Fill(ds, "CLBID");
            dt = ds.Tables["CLBID"];
            clb.Text = dt.Rows[0]["CLBNAME"].ToString();
            string sqlString1 = "select top(1) PLID, CLBID,PLNAME,NATIONALITY,DAY_BORN,VITRI,SCORE from FOOTBALL_PLAYER" +
                " where SCORE != 0  order by SCORE desc";
            ds = new DataSet();
            myAdapter = new SqlDataAdapter(sqlString1, conn);
            myAdapter.Fill(ds, "PLID");
            dt = ds.Tables["PLID"];
            pl.Text = HomePage.best_player;
            conn.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
