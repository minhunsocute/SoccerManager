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
    public partial class result_user : Form
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

        public result_user()
        {
            InitializeComponent();
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

        private void result_user_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        

        private void dataGridView1_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                try
                {
                    int row = e.RowIndex;
                    guna2TextBox1.Text = dt.Rows[row]["MATCHID"].ToString();
                    clb1 = dt.Rows[row]["CLB1"].ToString();
                    clb2 = dt.Rows[row]["CLB2"].ToString();
                    sc1 = dt.Rows[row]["SCORED1"].ToString();
                    sc2 = dt.Rows[row]["SCORED2"].ToString();
                    maID = guna2TextBox1.Text;
                }
                catch
                {

                }
            }
        }

        private void show_Click_1(object sender, EventArgs e)
        {
            score f = new score();
            f.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
