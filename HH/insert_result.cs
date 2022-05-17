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
    public partial class insert_result : Form
    {
        private string conStr = @"Data Source=LAPTOP-DI57MUOG;Initial Catalog=QLGB2;Integrated Security=True";
        private SqlConnection conn;
        private SqlDataAdapter myAdapter;
        private SqlCommand comm;
        private DataSet ds;
        private DataTable dt;
        public static string maID = "";
        public static string clb1ID = "";
        public static string clb2ID = "";
        public static int scor1;
        public static int scor2;


        public insert_result()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void insert_result_LocationChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            string sqlString = "select * from MATCH1 where TYPE_MATCH = 0";
            myAdapter = new SqlDataAdapter(sqlString, conn);

            ds = new DataSet();
            myAdapter.Fill(ds, "MATCHID");
            dt = ds.Tables["MATCHID"];
            datagridview11.DataSource = dt;

            datagridview11.Columns["matchid"].DefaultCellStyle.BackColor = Color.Aqua;
            datagridview11.Columns["club1"].DefaultCellStyle.BackColor = Color.Aqua;
            datagridview11.Columns["club2"].DefaultCellStyle.BackColor = Color.Aqua;
            datagridview11.Columns["score1"].DefaultCellStyle.BackColor = Color.Aqua;
            datagridview11.Columns["score2"].DefaultCellStyle.BackColor = Color.Aqua;
            datagridview11.Columns["stay"].DefaultCellStyle.BackColor = Color.Aqua;
            datagridview11.Columns["date"].DefaultCellStyle.BackColor = Color.Aqua;
            
            datagridview11.EnableHeadersVisualStyles = false;
            datagridview11.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            datagridview11.RowHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;

            conn.Close();
        }

        private void searchString(string Value)
        {
            conn = new SqlConnection(conStr);
            conn.Open();

            string sqlString = "select* from MATCH1 where TYPE_MATCH = 0 and MATCHID like N'%" + Value.ToString() + "%'";
            comm = new SqlCommand(sqlString, conn);
            myAdapter = new SqlDataAdapter(comm);
            dt = new DataTable();
            myAdapter.Fill(dt);
            datagridview11.DataSource = dt;
            conn.Close();

        }
        private void datagridview11_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                int row = e.RowIndex;
                matID.Text = dt.Rows[row]["MATCHID"].ToString();
                clb1.Text = dt.Rows[row]["CLB1"].ToString();
                clb2.Text = dt.Rows[row]["CLB2"].ToString();
                sc1.Text = dt.Rows[row]["SCORED1"].ToString();
                sc2.Text = dt.Rows[row]["SCORED2"].ToString();
                staydum.Text = dt.Rows[row]["STAYDIUM"].ToString();
                datetine.Text = dt.Rows[row]["DATE_TIME"].ToString();

                clb1ID = clb1.Text.ToString();
                clb2ID = clb2.Text.ToString();
                maID = matID.Text.ToString();
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Searchh_Click(object sender, EventArgs e)
        {
            string value = searchhString.Text.ToString();
            searchString(value);
        }

        private void add_score_Click(object sender, EventArgs e)
        {
            if (int.Parse(sc1.Text.ToString()) != 250 && int.Parse(sc2.Text.ToString())!=250) {
                DialogResult re = MessageBox.Show("DO YOU WANT INSERT RESULT MATCH ??", "QUESTIONS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(re == DialogResult.Yes)
                {
                    conn = new SqlConnection(conStr);
                    conn.Open();

                    string sqlString = "update  MATCH1 set TYPE_MATCH = 1," +
                                       "SCORED1 = " + sc1.Text.ToString() + " ,SCORED2 = " + sc2.Text.ToString() +
                                        " where MATCHID = N'" + matID.Text.ToString() + "'";

                    comm = new SqlCommand(sqlString, conn);
                    comm.ExecuteNonQuery();
                    scor1 = int.Parse(sc1.Text.ToString());
                    scor2 = int.Parse(sc2.Text.ToString());

                    if (scor1 < scor2)
                    {
                        string sqlStrresult = "update play " +
                                              "set POINT = (case " +
                                                                    "when N'" + clb1.Text.ToString() + "' in (select UP.CLB_CHOOSE " +
                                                                                                        "from USER_PLAY as UP " +
                                                                                                        "where UP.USERNAME = USERNAME) then (POINT - (select max(U.POINT*U.NO_POINT) " +
                                                                                                                                        "from USER_PLAY as U " +
                                                                                                                                        " where U.USERNAME = USERNAME and U.MATCHID = N'"+ matID.Text.ToString()+"')) " +
                                                                    "else (POINT + (select max(U.POINT*U.NO_POINT) " +
                                                                          "from USER_PLAY as U " +
                                                                          " where U.USERNAME = USERNAME and U.MATCHID = N'" + matID.Text.ToString() + "')) " +
                                                                " end)" +
                                               " where USERNAME in (select USERNAME " +
                                                                "from USER_PLAY " +
                                                                "where MATCHID = N'" + matID.Text.ToString() + "')";
                        comm = new SqlCommand(sqlStrresult, conn);
                        comm.ExecuteNonQuery();

                        string sqlResult1 = "insert into MESSAG " +
                                            " select DISTINCT USERNAME , (case " +
                                                                " when N'"+clb1.Text.ToString()+"' in (select UP.CLB_CHOOSE " +
                                                                                                      " from USER_PLAY AS UP " +
                                                                                                      " where UP.USERNAME = USERNAME) then (N'YOU LOSE BET SO YOU MUST BE DEPOSITED') " +
                                                                  "else N'YOU WIN YOUR BET YOU GET MONEY' " +
                                                                  "end ) " +
                                              "from USER_PLAY where MATCHID = N'" +matID.Text.ToString()+"'";
                        comm = new SqlCommand(sqlResult1, conn);
                        comm.ExecuteNonQuery();
                    }
                    else
                    {
                        string sqlStrresult = "update play " +
                                              "set POINT = (case " +
                                                                    "when N'" + clb1.Text.ToString() + "' in (select UP.CLB_CHOOSE " +
                                                                                                        "from USER_PLAY as UP " +
                                                                                                        "where UP.USERNAME = USERNAME) then (POINT + (select max(U.POINT*U.NO_POINT) " +
                                                                                                                                        "from USER_PLAY as U " +
                                                                                                                                        " where U.USERNAME = USERNAME and U.MATCHID = N'" + matID.Text.ToString() + "')) " +
                                                                    "else (POINT - (select max(U.POINT*U.NO_POINT) " +
                                                                          "from USER_PLAY as U " +
                                                                          " where U.USERNAME = USERNAME and U.MATCHID = N'" + matID.Text.ToString() + "')) " +
                                                                " end)" +
                                               " where USERNAME in (select USERNAME " +
                                                                "from USER_PLAY " +
                                                                "where MATCHID = N'" + matID.Text.ToString() + "')";
                        comm = new SqlCommand(sqlStrresult, conn);
                        comm.ExecuteNonQuery();

                        string sqlResult1 = "insert into MESSAG " +
                                            " select DISTINCT USERNAME , (case " +
                                                                " when N'" + clb1.Text.ToString() + "' in (select UP.CLB_CHOOSE " +
                                                                                                      " from USER_PLAY AS UP " +
                                                                                                      " where UP.USERNAME = USERNAME) then (N'YOU WIN YOUR BET YOU GET MONEY') " +
                                                                  "else N'YOU LOSE BET SO YOU MUST BE DEPOSITED' " +
                                                                  "end ) " +
                                              "from USER_PLAY where MATCHID = N'" + matID.Text.ToString() + "'";
                        comm = new SqlCommand(sqlResult1, conn);
                        comm.ExecuteNonQuery();

                    }
                    if(scor1 != 0 || scor2 != 0)    
                    {
                        if(scor1 < scor2)
                        {
                            string sqlString1 = "update ranking set win = win + 1, POINT = POINT + 3, " +
                                            "gd = gd + " + sc2.Text.ToString()+" - "+ sc1.Text.ToString()+"    where CLBID = N'" + clb2ID.ToString() + "'";
                            comm = new SqlCommand(sqlString1, conn);
                            comm.ExecuteNonQuery();
                            string sqlString2 = "update ranking set lose = lose + 1, " +
                                            "gd = gd + " + sc1.Text.ToString() + " - " + sc2.Text.ToString() + "    where CLBID = N'" + clb1ID.ToString() + "'";
                            comm = new SqlCommand(sqlString2, conn);
                            comm.ExecuteNonQuery();

                           /* string sqlString3 = "update CLUB set SCORE = SCORE +" + sc1.Text.ToString() + ", LOSE = LOSE + " + sc2.Text.ToString() + "" +
                                                "where CLBID = N'" +clb1.ToString()+"'";
                            comm = new SqlCommand(sqlString3, conn);
                            comm.ExecuteNonQuery();
                            string sqlString4 = "update CLUB set SCORE = SCORE +" + sc2.Text.ToString() + ", LOSE = LOSE + " + sc1.Text.ToString() + "" +
                                                ",POINT = POINT + 3 where CLBID = N'" + clb2.ToString() + "'";
                            comm = new SqlCommand(sqlString4, conn);
                            comm.ExecuteNonQuery();*/

                        }
                        else if(scor1 > scor2)
                        {
                            string sqlString1 = "update ranking set win = win + 1, POINT = POINT + 3, " +
                                            "gd = gd + " + sc1.Text.ToString() + " - " + sc2.Text.ToString() + "    where CLBID = N'" + clb1ID.ToString() + "'";
                            comm = new SqlCommand(sqlString1, conn);
                            comm.ExecuteNonQuery();
                            string sqlString2 = "update ranking set lose = lose + 1, " +
                                            "gd = gd + " + sc2.Text.ToString() + " - " + sc1.Text.ToString() + "    where CLBID = N'" + clb2ID.ToString() + "'";
                            comm = new SqlCommand(sqlString2, conn);
                            comm.ExecuteNonQuery();
                            /*string sqlString3 = "update CLUB set SCORE = SCORE +" + sc2.Text.ToString() + ", LOSE = LOSE + " + sc1.Text.ToString() + "" +
                                                "where CLBID = N'" + clb2.ToString() + "'";
                            comm = new SqlCommand(sqlString3, conn);
                            comm.ExecuteNonQuery();
                            string sqlString4 = "update CLUB set SCORE = SCORE +" + sc1.Text.ToString() + ", LOSE = LOSE + " + sc2.Text.ToString() + "" +
                                                ",POINT = POINT + 3 where CLBID = N'" + clb1.ToString() + "'";
                            comm = new SqlCommand(sqlString4, conn);
                            comm.ExecuteNonQuery();*/

                        }
                        else if(scor1 == scor2)
                        {
                            string sqlString1 = "update ranking set draw = draw + 1, POINT = POINT + 1, " +
                                            "gd = gd + " + sc1.Text.ToString() + " - " + sc2.Text.ToString() + "    where CLBID = N'" + clb1ID.ToString() + "'";
                            comm = new SqlCommand(sqlString1, conn);
                            comm.ExecuteNonQuery();
                            string sqlString2 = "update ranking set draw = draw + 1,POINT = POINT + 1, " +
                                            "gd = gd + " + sc2.Text.ToString() + " - " + sc1.Text.ToString() + "    where CLBID = N'" + clb2ID.ToString() + "'";
                            comm = new SqlCommand(sqlString2, conn);
                            comm.ExecuteNonQuery();
                        }
                        insertScore f = new insertScore();
                        f.ShowDialog();
                    }
                    else
                    {
                        string sqlString1 = "update ranking set draw = draw + 1, POINT = POINT + 1 " +
                                             "where CLBID = N'" + clb2ID.ToString() + "'";
                        comm = new SqlCommand(sqlString1, conn);
                        comm.ExecuteNonQuery();
                        string sqlString2 = "update ranking set draw = draw + 1,POINT = POINT + 1 " +
                                            "where CLBID = N'" + clb1ID.ToString() + "'";
                        comm = new SqlCommand(sqlString2, conn);
                        comm.ExecuteNonQuery();
                        /*string sqlString3 = "update CLUB set SCORE = SCORE +" + sc1.Text.ToString() + ", LOSE = LOSE + " + sc2.Text.ToString() + "" +
                                                "POINT = POINT + 1 where CLBID = N'" + clb1.ToString() + "'";
                        comm = new SqlCommand(sqlString3, conn);
                        comm.ExecuteNonQuery();
                        string sqlString4 = "update CLUB set SCORE = SCORE +" + sc2.Text.ToString() + ", LOSE = LOSE + " + sc1.Text.ToString() + "" +
                                            ",POINT = POINT + 1 where CLBID = N'" + clb2.ToString() + "'";
                        comm = new SqlCommand(sqlString4, conn);
                        comm.ExecuteNonQuery();*/

                    }
                    conn.Close();
                   
                }
            }
            else
            {
                MessageBox.Show("PLEASE INPUT SCORE FOR 2 CLUB", "WARNING", MessageBoxButtons.OK);
            }
            LoadData();
        }
    }
}
