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
    public partial class message : Form
    {
        private string conStr = @"Data Source=LAPTOP-DI57MUOG;Initial Catalog=QLGB2;Integrated Security=True";
        private SqlConnection conn;
        private SqlDataAdapter myAdapter;
        private SqlCommand comm;
        private DataSet ds;
        private DataTable dt;

        public message()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            string sqlString = "select mess from MESSAG where USERNAME = N'" + user_login.user + "'";
            myAdapter = new SqlDataAdapter(sqlString, conn);
            ds = new DataSet();
            myAdapter.Fill(ds, "mess");
            dt = ds.Tables["mess"];
            guna2DataGridView1.DataSource = dt;
            conn.Close();
        }
        private void message_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
