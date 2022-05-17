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
    public partial class insertScore : Form
    {
        private string conStr = @"Data Source=LAPTOP-DI57MUOG;Initial Catalog=QLGB2;Integrated Security=True";
        private SqlConnection conn;
        private SqlDataAdapter myAdapter;
        private SqlCommand comm;
        private DataSet ds;
        private DataTable dt;
        private SqlDataAdapter myAdapter1;
        private SqlCommand comm1;
        private DataSet ds1;
        private DataTable dt1;
        private SqlDataAdapter myAdapter2;
        private SqlCommand comm2;
        private DataSet ds2;
        private DataTable dt2;
        public static int sc1;
        public static int sc2;
        public insertScore()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            GoalID.Text = "";
            nameGoal.Text = "";
            timeGoal.Text = "";
            conn = new SqlConnection(conStr);
            conn.Open();

            string sqlString = "select * from FOOTBALL_PLAYER where CLBID = N'" + insert_result.clb1ID  + "'";
            string sqlString1 = "select * from FOOTBALL_PLAYER where CLBID = N'" + insert_result.clb2ID + "'";
            myAdapter = new SqlDataAdapter(sqlString, conn);
            ds = new DataSet();
            myAdapter.Fill(ds, "PLID");
            dt = ds.Tables["PLID"];
            dataGridView1.DataSource = dt;
            
            myAdapter1 = new SqlDataAdapter(sqlString1, conn);
            ds1 = new DataSet();
            myAdapter1.Fill(ds1, "PLID");
            dt1 = ds1.Tables["PLID"];
            dataGridView2.DataSource = dt1;
            sc.Text = insert_result.scor1.ToString();
            score1.Text = insert_result.scor2.ToString();
            conn.Close();
        }

        private void insertScore_Load(object sender, EventArgs e)
        {
            sc1 = insert_result.scor1;
            sc2 = insert_result.scor2;
            clb.Text = insert_result.clb1ID;
            clb1.Text = insert_result.clb2ID;
            LoadData();
            LoadData1();

        }

        private void LoadData1()
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            string sqlString = "select PLID, CLBID,TIME_GOAL,NAMEGOAL from GOAL where MATCHID = N'" + insert_result.maID.ToString() + "'";

            myAdapter2 = new SqlDataAdapter(sqlString, conn);
            ds2 = new DataSet();
            myAdapter2.Fill(ds2, "PLID");
            dt2 = ds2.Tables["PLID"];
            dataGridView3.DataSource = dt2;
            conn.Close();
            
        }
        /*private void insert_button_Click(object sender, EventArgs e)
        {
            if (sc1 <= 0)
            {
                LoadData(insert_result.clb2ID);
                if (timeGoal.Text.ToString() != "" && GoalID.Text.ToString()!= "" && nameGoal.Text.ToString()!= "")
                {
                    if(int.Parse(timeGoal.Text.ToString()) >= 0 && int.Parse(timeGoal.Text.ToString()) <= 120)
                    {

                        conn = new SqlConnection(conStr);
                        conn.Open();
                        string sqlString = "insert into GOAL values(" +
                            "N'" + playerID.Text.ToString() + "',N'" + insert_result.clb2ID.ToString() + "',N'" +
                            GoalID.Text.ToString() + "',N'" + insert_result.maID.ToString() + "'," + timeGoal.Text.ToString() +
                            ",N'" + nameGoal.Text.ToString() + "')";
                        comm = new SqlCommand(sqlString, conn);
                        comm.ExecuteNonQuery();

                        string sqlstring2 = "update FOOTBALL_PLAYER set SCORE = SCORE + 1 where PLID = N'" + playerID.Text.ToString() + "' and CLBID = N'" + insert_result.clb2ID + "'";
                        comm = new SqlCommand(sqlstring2, conn);
                        comm.ExecuteNonQuery();
                        conn.Close();
                        sc2--;
                        if(sc1 <= 0 && sc2 <= 0)
                        {
                            this.Close();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("TIME GOAL IS  WRONG", "ERROR", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("INPUT HAVE NULL", "ERROR", MessageBoxButtons.OK);
                }
            }
            else
            {
                if (timeGoal.Text.ToString() != "" && GoalID.Text.ToString() != "" && nameGoal.Text.ToString() != "")
                {
                    if (int.Parse(timeGoal.Text.ToString()) >= 0 && int.Parse(timeGoal.Text.ToString()) <= 120)
                    {

                        conn = new SqlConnection(conStr);
                        conn.Open();
                        string sqlString = "insert into GOAL values(" +
                            "N'" + playerID.Text.ToString() + "',N'" + insert_result.clb1ID.ToString() + "',N'" +
                            GoalID.Text.ToString() + "',N'" + insert_result.maID.ToString() + "'," + timeGoal.Text.ToString() +
                            ",N'" + nameGoal.Text.ToString() + "')";
                        comm = new SqlCommand(sqlString, conn);
                        comm.ExecuteNonQuery();
                        string sqlstring2 = "update FOOTBALL_PLAYER set SCORE = SCORE + 1 where PLID = N'" + playerID.Text.ToString() + "' and CLBID = N'" + insert_result.clb1ID + "'";
                        comm = new SqlCommand(sqlstring2, conn);
                        comm.ExecuteNonQuery();
                        conn.Close();
                        sc1--;
                        if (sc1 <= 0 && sc2 <= 0) this.Close();
                        else
                        {
                            if (sc1 == 0)
                            {
                                LoadData(insert_result.clb2ID);
                            }
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("TIME GOAL IS  WRONG", "ERROR", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("INPUT HAVE NULL", "ERROR", MessageBoxButtons.OK);
                }
            }
        }*/

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dt.Rows.Count > 0)
            {
                int row = e.RowIndex;
                playerID.Text = dt.Rows[row]["PLID"].ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dt1.Rows.Count > 0)
            {
                int row = e.RowIndex;
                plid1.Text = dt1.Rows[row]["PLID"].ToString();
            }
        }

        private void insert_button_Click(object sender, EventArgs e)
        {
            if (sc1 > 0)
            {
                if (timeGoal.Text.ToString() != "" && GoalID.Text.ToString() != "" && nameGoal.Text.ToString() != "")
                {
                    if (int.Parse(timeGoal.Text.ToString()) >= 0 && int.Parse(timeGoal.Text.ToString()) <= 120)
                    {
                        conn = new SqlConnection(conStr);
                        conn.Open();
                        string sqlString = "insert into GOAL values(" +
                                "N'" + playerID.Text.ToString() + "',N'" + insert_result.clb1ID.ToString() + "',N'" +
                                GoalID.Text.ToString() + "',N'" + insert_result.maID.ToString() + "'," + timeGoal.Text.ToString() +
                                ",N'" + nameGoal.Text.ToString() + "')";
                        comm = new SqlCommand(sqlString, conn);
                        comm.ExecuteNonQuery();
                        string sqlstring2 = "update FOOTBALL_PLAYER set SCORE = SCORE + 1 where PLID = N'" + playerID.Text.ToString() + "' and CLBID = N'" + insert_result.clb1ID + "'";
                        comm = new SqlCommand(sqlstring2, conn);
                        comm.ExecuteNonQuery();
                        conn.Close();
                        sc1--;
                        if (sc1 <= 0 && sc2 <= 0) this.Close();
                    }
                    else
                    {
                        MessageBox.Show("TIME GOAL IS  WRONG", "ERROR", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("INPUT HAVE NULL", "ERROR", MessageBoxButtons.OK);
                }
            }
            timeGoal.Clear();
            nameGoal.Clear();
            GoalID.Clear();
            LoadData1();
        }

        private void insert_button2_Click(object sender, EventArgs e)
        {
            if (sc2 > 0)
            {
                if (time1.Text.ToString() != "" && goalid1.Text.ToString() != "" && name1.Text.ToString() != "")
                {
                    if (int.Parse(time1.Text.ToString()) >= 0 && int.Parse(time1.Text.ToString()) <= 120)
                    {
                        conn = new SqlConnection(conStr);
                        conn.Open();
                        string sqlString = "insert into GOAL values(" +
                                "N'" + plid1.Text.ToString() + "',N'" + insert_result.clb2ID.ToString() + "',N'" +
                                goalid1.Text.ToString() + "',N'" + insert_result.maID.ToString() + "'," + time1.Text.ToString() +
                                ",N'" + name1.Text.ToString() + "')";
                        comm = new SqlCommand(sqlString, conn);
                        comm.ExecuteNonQuery();
                        string sqlString1 = "update FOOTBALL_PLAYER set SCORE = SCORE + 1 where PLID = N'" + plid1.Text.ToString() + "' and CLBID = N'" + insert_result.clb2ID + "'";
                        comm = new SqlCommand(sqlString1, conn);
                        comm.ExecuteNonQuery();
                        conn.Close();
                        sc2--;
                        if (sc1 <= 0 && sc2 <= 0) this.Close();
                    }
                    else
                    {
                        MessageBox.Show("TIME GOAL IS  WRONG", "ERROR", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("INPUT HAVE NULL", "ERROR", MessageBoxButtons.OK);
                }
            }
            time1.Clear();
            name1.Clear();
            goalid1.Clear();
            LoadData1();
        }

        private void dataGridView3_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dt2.Rows.Count > 0)
            {

            }
        }
    }
}
