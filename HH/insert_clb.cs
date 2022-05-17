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
    public partial class insert_clb : Form
    {

        private string conStr = @"Data Source=LAPTOP-DI57MUOG;Initial Catalog=QLGB2;Integrated Security=True";
        private SqlConnection conn;
        //private SqlDataAdapter myAdapter;
        private SqlCommand comm;

        public insert_clb()
        {
            InitializeComponent();
        }

        private void insert_clb_Load(object sender, EventArgs e) {}
        private void exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insert_clb1(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);
            conn.Open();

            if (clbid1.Text.ToString() != "" && nameid1.Text.ToString() != "")
            {
                string sqlString = "INSERT INTO CLUB VALUES " +
                "(N'" + clbid1.Text.ToString() + "',N'" + nameid1.Text.ToString() + "',N'" + staydium1.Text.ToString() +
                "',N'" + adres1.Text.ToString() + "','" + dateTimePicker1.Text + "',0,0,0,0)";
                string sqlString2 = "insert into ranking values" +
                                    "(N'" + clbid1.Text.ToString() + "',N'" + nameid1.Text.ToString() + "',0,0,0,0,0,0,0)";
                comm = new SqlCommand(sqlString, conn);
                try
                {
                    object name = comm.ExecuteNonQuery();
                    comm = new SqlCommand(sqlString2, conn);
                    object name1 = comm.ExecuteNonQuery();
                    MessageBox.Show("CLUB WAS INSERTED");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error when you insert", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    conn.Close();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("CLB OR NAMR IS NULL", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
