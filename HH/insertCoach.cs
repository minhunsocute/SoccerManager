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
    public partial class insertCoach : Form
    {
        private string conStr = @"Data Source=LAPTOP-DI57MUOG;Initial Catalog=QLGB2;Integrated Security=True";
        private SqlConnection conn;
        private SqlDataAdapter myAdapter;
        private SqlCommand comm;
        private DataSet ds;
        private DataTable dt;

        public insertCoach()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            if (coachname.Text.ToString() != "" && country.Text.ToString() != "")
            {
                DialogResult re = MessageBox.Show("YES chọn huấn luyện viên trưởng No chọn trợ lý huấn luyện viên", "Questions", MessageBoxButtons.YesNo);
                if (re == DialogResult.Yes) 
                {
                    string sqlStr = "select count(*) from COACH where CLBID =N'" + All_clb.clbIDString + "' and TYPE_COACH=1";
                    comm = new SqlCommand(sqlStr, conn);
                    Int32 count = (Int32)comm.ExecuteScalar();
                    if (count == 0)
                    {
                        string sqlString = "exec inseer_Coach N'" + All_clb.clbIDString + "',N'" + coachname.Text.ToString() + "',N'" + country.Text.ToString() + "','" + dateTimePicker1.Text + "',1";
                        comm = new SqlCommand(sqlString, conn);
                        comm.ExecuteNonQuery();
                        conn.Close();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đã có huấn luyện viên trưởng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (re == DialogResult.No)
                {
                    string sqlString = "exec inseer_Coach N'" + All_clb.clbIDString + "',N'" + coachname.Text.ToString() + "',N'" + country.Text.ToString() + "','" + dateTimePicker1.Text + "',2" ;
                    comm = new SqlCommand(sqlString, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    this.Close();
                }
            }
        }

        private void insertCoach_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
