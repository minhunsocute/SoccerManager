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
    public partial class my_account : Form
    {
        private string conStr = @"Data Source=LAPTOP-DI57MUOG;Initial Catalog=QLGB2;Integrated Security=True";
        private SqlConnection conn;
        private SqlDataAdapter myAdapter;
        private SqlCommand comm;
        private DataSet ds;
        private DataTable dt;

        public my_account()
        {
            InitializeComponent();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void my_account_Load(object sender, EventArgs e)
        {
            UserNameText.Text = Login.Username;
            passText.Text = Login.PassWord;
            emailText.Text = Login.email;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);
            conn.Open();

            string sqlString = "update ACCOUNT set PASS =N'" + passText.Text.ToString() + "',email=N'" + emailText.Text.ToString() + "' " +
                            "where USERNAME = N'" +Login.Username+"'";
            DialogResult re = MessageBox.Show("DO YOU WANT UPDATE YOUR ACCOUNT", "QUESTIONS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(re == DialogResult.Yes)
            {
                comm = new SqlCommand(sqlString, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("ACCOUNT IS UPDATED", "OK", MessageBoxButtons.OK);
                this.Close();
            }
            
        }
    }
}
