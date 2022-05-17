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
    public partial class match_schedule : Form
    {
        private string conStr = @"Data Source=LAPTOP-DI57MUOG;Initial Catalog=QLGB2;Integrated Security=True";
        private SqlConnection conn;
        private SqlDataAdapter myAdapter;
        private SqlCommand comm;
        private DataSet ds;
        private DataTable dt;

        public match_schedule()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadData()
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            string sqlString = "select * from MATCH1 where TYPE_MATCH = 0";
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

        private void add_match1_Click(object sender, EventArgs e)
        {
            add_match f = new add_match();
            f.ShowDialog();
            LoadData();
        }

        private void match_schedule_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
