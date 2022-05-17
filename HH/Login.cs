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
    public partial class Login : Form
    {
        private string conStr = @"Data Source=LAPTOP-DI57MUOG;Initial Catalog=QLGB2;Integrated Security=True";
        private SqlConnection conn;
        private SqlDataAdapter myAdapter;
        private SqlCommand comm;
        private DataSet ds;
        private DataTable dt;
        public static string Username = "";
        public static string PassWord = "";
        public static string email = "";

        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SigninBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signin signInForm = new Signin();
            signInForm.Show();
        }


        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UserNameText.Text.ToString()!=""&&PasswordText.Text.ToString()!="") {
                conn = new SqlConnection(conStr);
                conn.Open();
                string sqlString = "select count(*) from ACCOUNT where USERNAME = N'" + UserNameText.Text.ToString() + "' and PASS =N'" + PasswordText.Text.ToString() + "' and TYPEA = 0";
                comm = new SqlCommand(sqlString, conn);
                Int32 count = (Int32)comm.ExecuteScalar();
                conn.Close();
                if (count == 1)
                {
                    conn = new SqlConnection(conStr);
                    conn.Open();
                    string sqlString1 = "select * from ACCOUNT where USERNAME = N'" + UserNameText.Text.ToString() + "' and PASS =N'" + PasswordText.Text.ToString() + "'";
                    myAdapter = new SqlDataAdapter(sqlString1, conn);
                    ds = new DataSet();
                    myAdapter.Fill(ds, "USERNAME");
                    dt = ds.Tables["USERNAME"];
                    Username = dt.Rows[0]["USERNAME"].ToString();
                    PassWord = dt.Rows[0]["PASS"].ToString();
                    email = dt.Rows[0]["email"].ToString();

                    HomePage f = new HomePage();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Username or Password is Valid", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Username or Password is NULL,", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CheckExist(string username, string password)
        {
            
        }
        

        private PictureBox CreateVolumeMute()
        {
            PictureBox volumeMute = new PictureBox();
            Bitmap bm = new Bitmap("C:\\Users\\USER\\Downloads\\1x\\outline_volume_mute_black_24dp.jpg");

            volumeMute.Size = new Size(32, 37);
            volumeMute.SizeMode = PictureBoxSizeMode.Zoom;
            volumeMute.Location = new Point(444, 524);
            volumeMute.Image = (Image)bm;

            return volumeMute;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
