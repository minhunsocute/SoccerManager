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
    public partial class sign_inUser : Form
    {
        private string conStr = @"Data Source=LAPTOP-DI57MUOG;Initial Catalog=QLGB2;Integrated Security=True";
        private SqlConnection conn;
        private SqlDataAdapter myAdapter;
        private SqlCommand comm;
        private DataSet ds;
        private DataTable dt;
        
        public sign_inUser()
        {
            InitializeComponent();
        }

        private void SigninBtn_Click(object sender, EventArgs e)
        {
            if (UserNameText.Text.ToString() != "" && PasswordText.Text.ToString() != "" && RePasswordText.Text.ToString() != "" && EmailText.Text.ToString() != "")
            {
                DialogResult re = MessageBox.Show("DO YOU WANT SIGN IN ?","QUESTIONS",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(re == DialogResult.Yes)
                {
                    if (PasswordText.Text.ToString() == RePasswordText.Text.ToString())
                    {
                        conn = new SqlConnection(conStr);
                        conn.Open();

                        string sqlString = "select count(*) from ACCOUNT where USERNAME = N'" + UserNameText.Text.ToString() + "'";
                        comm = new SqlCommand(sqlString, conn);
                        Int32 count = (Int32)comm.ExecuteScalar();
                        if(count == 0)
                        {
                            string sqlString1 ="insert into ACCEPT_ACCOUNT values (N'" + UserNameText.Text.ToString()+
                                            "',N'"+PasswordText.Text.ToString()+"',N'"+EmailText.Text.ToString()+"',0)";
                            comm = new SqlCommand(sqlString1, conn);
                            comm.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("WAIT FOR ACCEPT FROM ADMIN OF APP", "OK", MessageBoxButtons.OK);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Username available", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("PASS AND REPASS MUST BE SAME", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("USERNAME ,PASS OR EMAIL IS NULL", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
