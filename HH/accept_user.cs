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
    public partial class accept_user : Form
    {
        private string conStr = @"Data Source=LAPTOP-DI57MUOG;Initial Catalog=QLGB2;Integrated Security=True";
        private SqlConnection conn;
        private SqlDataAdapter myAdapter;
        private SqlCommand comm;
        private DataSet ds;
        private DataTable dt;
        public static int rrow = 0;
        public accept_user()
        {
            InitializeComponent();
        }

        private void accept_user_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            string sqlString = "select USERNAME, PASS,email from ACCEPT_ACCOUNT where TYPE_ACCEPT = 0";
            myAdapter = new SqlDataAdapter(sqlString, conn);
            ds = new DataSet();
            myAdapter.Fill(ds, "USERNAME");
            dt = ds.Tables["USERNAME"];

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["user"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["pass"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["email"].DefaultCellStyle.BackColor = Color.Aqua;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;

            conn.Close();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dt.Rows.Count >= 0)
            {
                int row = e.RowIndex;
                rrow = row;
                try
                {
                    searchText.Text = dt.Rows[row]["USERNAME"].ToString();
                }
                catch { }
            }
        }

        private void SigninBtn_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            string sqlString = "insert into ACCOUNT values (N'" + dt.Rows[rrow]["USERNAME"].ToString() +
                                "',N'" + dt.Rows[rrow]["PASS"].ToString()+"',1,1,N'"+dt.Rows[rrow]["email"].ToString()+"')";
            comm = new SqlCommand(sqlString, conn);
            try
            {
                object name = comm.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("USERNAME IS VALID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string sqlString1 = "update ACCEPT_ACCOUNT set TYPE_ACCEPT=1 where USERNAME = N'" + searchText.Text.ToString() + "'";
            comm = new SqlCommand(sqlString1, conn);
            comm.ExecuteNonQuery();
            string sqlString2 = "insert into play values (N'" + searchText.Text.ToString() + "',500000)";
            comm = new SqlCommand(sqlString2, conn);
            comm.ExecuteNonQuery();
            conn.Close();
            LoadData();
        }
    }
}
