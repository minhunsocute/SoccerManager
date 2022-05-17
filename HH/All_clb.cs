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
    public partial class All_clb : Form
    {
        private string conStr = @"Data Source=LAPTOP-DI57MUOG;Initial Catalog=QLGB2;Integrated Security=True";
        private SqlConnection conn;
        private SqlDataAdapter myAdapter;
        private SqlCommand comm;
        private DataSet ds;
        private DataTable dt;
        public static string nameString = "";
        public static string clbIDString = "";
        public static string staydiumString = "";
        public static string addressString = "";

        public All_clb()
        {
            InitializeComponent();
        }

        
        private void LoadData()
        {
            conn = new SqlConnection(conStr);
            conn.Open();

            string sqlString1 = "update CLUB " +
                                "set NUMBERPLAYER = (select count(*) " +
                                                        "from FOOTBALL_PLAYER as fp,CLUB as clb " +
                                                        "where fp.CLBID = clb.CLBID  and clb.CLBID = CLUB.CLBID)";
            comm = new SqlCommand(sqlString1, conn);
            comm.ExecuteNonQuery();

            string sqlString = "select*from CLUB";
            myAdapter = new SqlDataAdapter(sqlString, conn);


            ds = new DataSet();
            myAdapter.Fill(ds, "CLBID");
            dt = ds.Tables["CLBID"];
            dataGridView1.DataSource = dt;

            string sqlString2 = "select count(*) from CLUB";
            comm = new SqlCommand(sqlString2, conn);
            Int32 count = (Int32)comm.ExecuteScalar();
            label2.Text =count.ToString();


            dataGridView1.Columns["clbid"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["nameclb"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["staydium"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["addres"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["date"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["goal"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["lose"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["point"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["numberplayer"].DefaultCellStyle.BackColor = Color.Aqua;


            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;

            conn.Close();
        }
        private void All_clb_Load(object sender, EventArgs e)
        {
            LoadData();
            string Value = searchText.Text.ToString();
            searchData(Value);
        }
        
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            idclub.Text = dt.Rows[row]["CLBID"].ToString();
            nameString = dt.Rows[row]["CLBNAME"].ToString();
            clbIDString = dt.Rows[row]["CLBID"].ToString();
            staydiumString = dt.Rows[row]["STAYDIUM"].ToString();
            addressString = dt.Rows[row]["ADDRES"].ToString();
            
        }

        private void insert_clbForm(object sender, EventArgs e)
        {
            insert_clb f = new insert_clb();
            f.ShowDialog();
            LoadData();
        }

        private void deleteCLick(object sender, EventArgs e)    
        {
            DialogResult re = MessageBox.Show("Do you want deleted this clb", "client", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(re == DialogResult.Yes)
            {
                conn = new SqlConnection(conStr);
                conn.Open();
                string sqlString1 = "delete from CLUB where CLBID = N'" + idclub.Text.ToString() + "'";
                comm = new SqlCommand(sqlString1, conn);
                comm.ExecuteNonQuery();


                conn.Close();
                LoadData();
            }

        }
        public void searchData(string ValueToSearch)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            string query = "select * from CLUB where CLBID like N'%" + ValueToSearch + "%'";
            comm = new SqlCommand(query, conn);
            myAdapter = new SqlDataAdapter(comm);
            dt = new DataTable();
            myAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void searchClick(object sender, EventArgs e)
        {
            string Value = searchText.Text.ToString();
            searchData(Value);
        }

        private void closeClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void watch_player(object sender, EventArgs e)
        {
            allPlayer f = new allPlayer();
            f.ShowDialog();
        }

        private void update_click(object sender, EventArgs e)
        {
            updateClbForm f = new updateClbForm();
            f.ShowDialog();
            LoadData();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            coach f = new coach();
            f.ShowDialog();
        }
    }
}
