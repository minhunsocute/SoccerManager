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
    public partial class coach : Form
    {
        private string conStr = @"Data Source=LAPTOP-DI57MUOG;Initial Catalog=QLGB2;Integrated Security=True";
        private SqlConnection conn;
        private SqlDataAdapter myAdapter;
        private SqlCommand comm;
        private DataSet ds;
        private DataTable dt;
        private static int a;
        public coach()
        {
            InitializeComponent();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void coach_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            conn = new SqlConnection(conStr);
            conn.Open();

            string sqlString = "select * from COACH where CLBID = N'" + All_clb.clbIDString +"'";
            ds = new DataSet();
            myAdapter = new SqlDataAdapter(sqlString, conn);
            myAdapter.Fill(ds, "COACHID");
            dt = ds.Tables["COACHID"];
            dataGridView1.DataSource = dt;

            dataGridView1.Columns["coachid"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["name"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["type"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["nation"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["day"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["CLBID"].DefaultCellStyle.BackColor = Color.Aqua;

            print_type();

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;
            conn.Close();
        }

        private void print_type()
        {
            for(int i=0;i<dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["TYPE_COACH"].ToString() == "1")
                {
                    dataGridView1.Rows[i].Cells["type"].Value = "Main Coach"; 
                }
                else if (dt.Rows[i]["TYPE_COACH"].ToString() == "2")
                {
                    dataGridView1.Rows[i].Cells["type"].Value = "Sp Coach";
                }
            }
        }
        private void insert_Click(object sender, EventArgs e)
        {
            insertCoach f = new insertCoach();
            f.ShowDialog();
            LoadData();
            print_type();

        }
        private void searchPL(string Value)
        {
            conn = new SqlConnection(conStr);
            conn.Open();

            string sqlString = "select * from COACH where COACHID like N'%" + Value + "%'";
            comm = new SqlCommand(sqlString, conn);
            myAdapter = new SqlDataAdapter(comm);
            dt = new DataTable();
            myAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void searchID_Click(object sender, EventArgs e)
        {
            string value = search_string.Text.ToString();
            searchPL(value);
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                int row = e.RowIndex;
                try
                {
                    ID.Text = dt.Rows[row]["COACHID"].ToString();
                }
                catch
                {

                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("DO YOU WANT DELETED THIS COACH", "QUESTIONS", MessageBoxButtons.YesNo);

            if (re == DialogResult.Yes)
            {
                
                    conn = new SqlConnection(conStr);
                    conn.Open();
                    string sqlString = "delete from COACH where COACHID = N'" + ID.Text.ToString() + "'";
                    comm = new SqlCommand(sqlString, conn);
                    comm.ExecuteNonQuery();
                    string sqlString1 = "exec update_coach";
                    comm = new SqlCommand(sqlString1, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
               
            }
            LoadData();
            print_type();

        }
    }
}
