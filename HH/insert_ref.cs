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
    public partial class insert_ref : Form
    {
        private string conStr = @"Data Source=LAPTOP-DI57MUOG;Initial Catalog=QLGB2;Integrated Security=True";
        private SqlConnection conn;
        private SqlDataAdapter myAdapter;
        private SqlCommand comm;
        private DataSet ds;
        private DataTable dt;

        public insert_ref()
        {
            InitializeComponent();
        }

        private void insert_ref_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            if (refname.Text.ToString() != "" && country.Text.ToString() != "")
            {
                DialogResult re = MessageBox.Show("YES chọn trọng tài chính No chọn trọng tài biên", "Questions", MessageBoxButtons.YesNo);
                if (re == DialogResult.Yes)
                {
                    string sqlString = "exec insert_refAutoID N'" + refname.Text.ToString() + "',N'" + country.Text.ToString() + "','" + dateTimePicker1.Text + "',1";
                    comm = new SqlCommand(sqlString, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    this.Close();
                }
                else if (re == DialogResult.No)
                {
                    string sqlString = "exec insert_refAutoID N'" + refname.Text.ToString() + "',N'" + country.Text.ToString() + "','" + dateTimePicker1.Text + "',2";
                    comm = new SqlCommand(sqlString, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();   
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Input is NULL", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
