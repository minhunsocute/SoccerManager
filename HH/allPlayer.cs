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
    public partial class allPlayer : Form
    {
        private string conStr = @"Data Source=LAPTOP-DI57MUOG;Initial Catalog=QLGB2;Integrated Security=True";
        private SqlConnection conn;
        private SqlDataAdapter myAdapter;
        private SqlCommand comm;
        private DataSet ds;
        private DataTable dt;
        public static string namePlayer = "";
        public static string idPlayer = "";
        public allPlayer()
        {
            InitializeComponent();
        }

        private void allPlayer_Load(object sender, EventArgs e)
        {
            clbid.Text = All_clb.nameString;
            LoadData();
        }

        private void LoadData()
        {
            conn = new SqlConnection(conStr);
            conn.Open();

            string SqlString = "select * from FOOTBALL_PLAYER where CLBID = N'" + All_clb.clbIDString + "'";
            myAdapter = new SqlDataAdapter(SqlString, conn);

            ds = new DataSet();
            myAdapter.Fill(ds, "PLID");
            dt = ds.Tables["PLID"];
            dataGridView1.DataSource = dt;

            dataGridView1.Columns["plid"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["name"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["nation"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["day_born"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["vitri"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["score"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["Yellow"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["red"].DefaultCellStyle.BackColor = Color.Aqua;
            
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                if(dt.Rows[i]["VITRI"].ToString() == "1")
                {
                    dataGridView1.Rows[i].Cells["vitri"].Value = "Goalie";
                }
                else if(dt.Rows[i]["VITRI"].ToString() == "2")
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

            conn.Close();

        }

        private void searchPL(string valueSearch)
        {
            conn = new SqlConnection(conStr);
            conn.Open();

            string sqlString = "select * from FOOTBALL_PLAYER where PLNAME like N'%" + valueSearch + "%'";
            comm = new SqlCommand(sqlString, conn);
            myAdapter = new SqlDataAdapter(comm);
            dt = new DataTable();
            myAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();   
        }
        
        private void guna2Button5_Click(object sender, EventArgs e) {this.Close();}

        private void searchClick(object sender, EventArgs e)
        {
            string Value = searchString.Text;
            searchPL(Value);
        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                int row = e.RowIndex;
                searchString.Text = dt.Rows[row]["PLNAME"].ToString();
                idPlayer = dt.Rows[row]["PLID"].ToString();
            }
        }

        private void insertPlayer_Click(object sender, EventArgs e)
        {
            insert_player f = new insert_player();
            f.ShowDialog();
            LoadData();
        }

        private void delete_player_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("DO YOU WANT DELETE THIS PLAYER", "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(re == DialogResult.Yes)
            {
                conn = new SqlConnection(conStr);
                conn.Open();
                string sqlString = "delete from FOOTBALL_PLAYER where PLID = N'" + idPlayer + "'";
                comm = new SqlCommand(sqlString, conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
            LoadData();
            
        }
    }
}
