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
    public partial class all_user : Form
    {
        private string conStr = @"Data Source=LAPTOP-DI57MUOG;Initial Catalog=QLGB2;Integrated Security=True";
        private SqlConnection conn;
        private SqlDataAdapter myAdapter;
        private SqlCommand comm;
        private DataSet ds;
        private DataTable dt;
        public static int rrow = 0;

        public all_user()
        {
            InitializeComponent();
        }

        private void SigninBtn_Click(object sender, EventArgs e)
        {
            accept_user f = new accept_user();
            f.ShowDialog();
        }

        private void all_user_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            conn = new SqlConnection(conStr);
            conn.Open();

            string SqlString = "select USERNAME, PASS,email from ACCOUNT where TYPEA = 1";
            myAdapter = new SqlDataAdapter(SqlString, conn);
            ds = new DataSet();
            myAdapter.Fill(ds, "USERNAME");

            dt = ds.Tables["USERNAME"];
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["user"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["pass"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["email"].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridView1.Columns["point"].DefaultCellStyle.BackColor = Color.Aqua;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;


            conn.Close();

        }
    }
}
