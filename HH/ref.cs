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
    public partial class @ref : Form
    {
        private string conStr = @"Data Source=LAPTOP-DI57MUOG;Initial Catalog=QLGB2;Integrated Security=True";
        private SqlConnection conn;
        private SqlDataAdapter myAdapter;
        private SqlCommand comm;
        private DataSet ds;
        private DataTable dt;

        public @ref()
        {
            InitializeComponent();
        }

        private void guna2Button4_Click(object sender, EventArgs e) 
        {
            insert_ref f = new insert_ref();
            f.ShowDialog();
            LoadData();
        }
        private void LoadData()
        {
            conn = new SqlConnection(conStr);
            conn.Open();

            string sqlString = "select * from REFEREE";
            myAdapter = new SqlDataAdapter(sqlString, conn);
            ds = new DataSet();
            myAdapter.Fill(ds, "REFID");
            dt = ds.Tables["REFID"];
            dataGridView1.DataSource = dt;
            print_type();
            //search_string.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            dataGridView1.Columns["refID"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["name"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["day"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["nation"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["type"].DefaultCellStyle.BackColor = Color.Aqua;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;

            conn.Close();
        }
        private void print_type()
        {
            int n = dt.Rows.Count;
            for (int i = 0; i < n; i++)
            {
                if (dt.Rows[i]["TYPE_REF"].ToString() == "1")
                {
                    dataGridView1.Rows[i].Cells["type"].Value = "Trọng tài chính";
                }
                else if (dt.Rows[i]["TYPE_REF"].ToString() == "2")
                {
                    dataGridView1.Rows[i].Cells["type"].Value = "Trọng tài biên";
                }
            }
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ref_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        /*
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
         */
        private void searchPL(string Value)
        {
            conn = new SqlConnection(conStr);
            conn.Open();

            string sqlString = "select * from REFEREE where REFID like N'%" + Value + "%'";
            comm = new SqlCommand(sqlString, conn);
            myAdapter = new SqlDataAdapter(comm);
            dt = new DataTable();
            myAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            print_type();
            conn.Close();   
        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dt.Rows.Count > 0)
            {
                int row = e.RowIndex;
                ID.Text = dt.Rows[row]["REFID"].ToString();
            }
        }

        private void searchID_Click(object sender, EventArgs e)
        {
            string value = search_string.Text.ToString();
            searchPL(value);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("DO YOU WANT DELETED THIS REFEREE", "QUESTIONS", MessageBoxButtons.YesNo);

            if(re == DialogResult.Yes)
            {
                conn = new SqlConnection(conStr);
                conn.Open();
                string sqlStr = "select count(*) from REF_TOMATCH where REFID = N'" + ID.Text.ToString() +"'";
                comm = new SqlCommand(sqlStr, conn);
                Int32 count = (Int32)comm.ExecuteScalar();
                conn.Close();
                if (count == 0)
                {
                    conn = new SqlConnection(conStr);
                    conn.Open();
                    string sqlString = "delete from REFEREE where REFID = N'" + ID.Text.ToString() + "'";
                    comm = new SqlCommand(sqlString, conn);
                    comm.ExecuteNonQuery();
                    string sqlString1 = "exec update_Ref";
                    comm = new SqlCommand(sqlString1, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("The referee is in charge of the match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadData();
        }
    }
}
