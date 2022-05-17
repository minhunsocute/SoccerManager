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
    public partial class insert_player : Form
    {
        private string conStr = @"Data Source=LAPTOP-DI57MUOG;Initial Catalog=QLGB2;Integrated Security=True";
        private SqlConnection conn;
        private SqlDataAdapter myAdapter;
        private SqlCommand comm;
        private DataSet ds;
        private DataTable dt;

        public insert_player()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insertt_click(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);
            conn.Open();

            if(plid.Text.ToString()!= "" && name.Text.ToString() != "")
            {
                string sqlString = "insert into FOOTBALL_PLAYER values (" +
                                "N'" + plid.Text.ToString() + "',N'" + All_clb.clbIDString + "',N'" +
                                name.Text.ToString() + "',N'" + cou.Text.ToString() + "','" + dateTimePicker1.Text + "'," +
                                vitri.Text.ToString() + ",0,0,0)";
                comm = new SqlCommand(sqlString, conn);
                try
                {       
                    object name = comm.ExecuteNonQuery();
                    MessageBox.Show("PLAYER IS INSERTED");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR WHEN INSERT PLAYER", "ERROR", MessageBoxButtons.OK);
                }
                finally
                {
                    conn.Close();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("ID OR NAME IS EMPTY", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
