using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class USERS : Form
    {
        public USERS()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void SUPPORTER_Click(object sender, EventArgs e)
        {
            LOGIN_SUPPORTER RE = new LOGIN_SUPPORTER();
            RE.Show();
            // this.Hide();
        }

        private void COACH_Click(object sender, EventArgs e)
        {
            LOGIN_COACH RC = new LOGIN_COACH();
            RC.Show();
           // this.Hide();
        }

        private void C_ADMIN_Click(object sender, EventArgs e)
        {
           LOGIN_CLUBADMIN RD = new LOGIN_CLUBADMIN();
            RD.Show();
            //this.Hide();
        }

        private void T_ADMIN_Click(object sender, EventArgs e)
        {
            LOGIN RF = new LOGIN();
            RF.Show();
            //this.Hide();
        }
    }
}
