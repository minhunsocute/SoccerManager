using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HH
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Left += 2;
            if(panel2.Left > 399)
            {
                panel2.Left = 0;
            }
            if(panel2.Left < 0)
            {
                panel2.Left = 399;
            }
        }

        private void loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
