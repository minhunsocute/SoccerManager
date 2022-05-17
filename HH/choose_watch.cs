using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace HH
{
    public partial class choose_watch : Form
    {
        public choose_watch()
        {
            Thread trd = new Thread(new ThreadStart(formRun));
            trd.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            trd.Abort();
        }

        private void formRun()
        {
            Application.Run(new loading());
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.ShowDialog();            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            user_login f = new user_login();
            f.ShowDialog();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            user_home f = new user_home();
            f.ShowDialog();
        }
    }
}
