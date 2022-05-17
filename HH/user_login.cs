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
    public partial class user_login : Form
    {
        private string conStr = @"Data Source=LAPTOP-DI57MUOG;Initial Catalog=QLGB2;Integrated Security=True";
        private SqlConnection conn;
        private SqlDataAdapter myAdapter;
        private SqlCommand comm;
        private DataSet ds;
        private DataTable dt;
        public static int check_user = 0;
        public static string user = "";
        public static string pass = "";
        public user_login()
        {
            InitializeComponent();
        }

        private void signin_Click(object sender, EventArgs e)
        {
            sign_inUser f = new sign_inUser();
            f.ShowDialog();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UserNameText.Text.ToString() != "" && PasswordText.Text.ToString() != "")
            {
                conn = new SqlConnection(conStr);
                conn.Open();
                string sqlString = "select count(*) from ACCOUNT where USERNAME =N'" + UserNameText.Text.ToString() + "' and PASS = N'" + PasswordText.Text.ToString() + "'";
                comm = new SqlCommand(sqlString, conn);
                Int32 count = (Int32)comm.ExecuteScalar();
                if (count != 0)
                {
                    check_user = 1;
                    user = UserNameText.Text.ToString();
                    pass = PasswordText.Text.ToString();
                    user_home f = new user_home();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Username is invalid", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Username or Pass is Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
