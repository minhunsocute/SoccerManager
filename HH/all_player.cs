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
    public partial class all_player : Form
    {
        private string conStr = @"Data Source=LAPTOP-DI57MUOG;Initial Catalog=QLGB2;Integrated Security=True";
        private SqlConnection conn;
        private SqlDataAdapter myAdapter;
        private SqlCommand comm;
        private DataSet ds;
        private DataTable dt;
        private string _message;

        public all_player()
        {
            InitializeComponent();
        }

        private void all_player_Load(object sender, EventArgs e)
        {
            label1.Text = All_clb.nameString;
            LoadData();
        }
        private void LoadData()
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            string sqlString = "select * from FOOTBALL_PLAYER where CLBID = N'" + All_clb.clbIDString+"'";
            myAdapter = new SqlDataAdapter(sqlString, conn);
            ds = new DataSet();
            myAdapter.Fill(ds,"PLID");
            dt = ds.Tables["PLID"];
            dataGridView1.DataSource = dt;
            
            dataGridView1.Columns["plid"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["plname"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["nation"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["day_born"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["location"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["score"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["yellowCard"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["redCard"].DefaultCellStyle.BackColor = Color.Aqua;
            
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;

        }

        private void search_player(string ValueSearch)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            string sqlString = "select * from FOOTBALL_PLAYER where PLNAME like N'%" + ValueSearch + "%' " +
                "and CLBID = N'" + All_clb.clbIDString + "'";
            myAdapter = new SqlDataAdapter(sqlString, conn);
            dt = new DataTable();
            myAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void search_Click(object sender, EventArgs e)
        {
            string valuSearch = searchText.Text.ToString();
            search_player(valuSearch);
        }
    }
}
