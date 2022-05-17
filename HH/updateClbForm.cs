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
    public partial class updateClbForm : Form
    {
        private string conStr = @"Data Source=LAPTOP-DI57MUOG;Initial Catalog=QLGB2;Integrated Security=True";
        private SqlConnection conn;
        private SqlDataAdapter myAdapter;
        private SqlCommand comm;
        private DataSet ds;
        private DataTable dt;
        private string _message;

        public updateClbForm()
        {
            InitializeComponent();
        }

        private void updateClbForm_Load(object sender, EventArgs e)
        {
            clbID.Text = All_clb.clbIDString;
            nameclb.Text = All_clb.nameString;
            staydium.Text = All_clb.staydiumString;
            ad.Text = All_clb.addressString;
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void update_click(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            string sqlString = "update CLUB " +
                            "set CLBNAME = N'" + nameclb.Text + "', " +
                            "STAYDIUM = N'" + staydium.Text + "',ADDRES = N'" + ad.Text + "'" +
                            "where CLBID = N'" + clbID.Text + "'";
            if(nameclb.Text.ToString()==""||staydium.Text.ToString()==""||ad.Text.ToString()==""){
                MessageBox.Show("DATA YOU INPUT IS NULL", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                DialogResult re = MessageBox.Show("DO YOU WANT CHANGR INFORMATION THIS CLUB", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    comm = new SqlCommand(sqlString, conn);
                    comm.ExecuteNonQuery();
                    this.Close();
                }
            }
            conn.Close();
        }
    }
}
