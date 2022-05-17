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
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-KBHC686\SQLEXPRESS;Initial Catalog=QLGB2;Integrated Security=True");

        private bool CheckExist(string username)
        {
            SqlDataAdapter da = new SqlDataAdapter("select Username from [INFO]",cnn);
            DataTable db = new DataTable();
            da.Fill(db);

            foreach(DataRow rows in db.Rows)
            {
                if(rows["Username"].ToString().Trim().Equals(username))
                {
                    return true;
                }
            }
            
            return false;
        }
        private void CreateUser(string username, string password, string email)
        {
            if (CheckExist(username))
            {
                MessageBox.Show("Username has been exist. Please try again.");
            }
            else
            {
                try
                {
                    cnn.Open();

                    string insertQuery = "insert into [INFO](Username, Password, Email) values (@username, @password, @email)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, cnn);

                    insertCommand.Parameters.AddWithValue("@Username", username);
                    insertCommand.Parameters.AddWithValue("@Password", password);
                    insertCommand.Parameters.AddWithValue("@Email", email);

                    int row = insertCommand.ExecuteNonQuery();

                    if (row != 0)
                    {
                        MessageBox.Show("Create account successfully");
                    }

                    insertCommand.Dispose();
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void SigninBtn_Click_1(object sender, EventArgs e)
        {
            string username = UserNameText.Text;
            string password = PasswordText.Text;
            string rePassword = RePasswordText.Text;
            string email = EmailText.Text;

            if (username == "")
            {
                MessageBox.Show("Username can't be empty");
            }
            else if (password == "")
            {
                MessageBox.Show("Password can't be empty");
            }
            else if (rePassword == "" || rePassword != password)
            {
                MessageBox.Show("Repassword can't be empty or invalid");
            }
            else if (email == "")
            {
                MessageBox.Show("Email can't be empty");
            }
            else
            {
                CreateUser(username, password, email);
            }
        }
    }
}
