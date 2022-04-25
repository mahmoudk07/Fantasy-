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
    public partial class LOGIN_CLUBADMIN : Form
    {
        Controller controllerObj = new Controller();
        public LOGIN_CLUBADMIN()
        {
            InitializeComponent();
        }

        private void LOGIIN_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || PASS.Text == "")
            {
                MessageBox.Show("PLEASE COMPLETE DATA!");
            }
            else
            {
                DataTable dt = controllerObj.CHECK_USER_PASS1(textBox1.Text, Convert.ToInt32(PASS.Text));
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                if (dataGridView1.Rows.Count > 0)
                {
                    if (textBox1.Text == "ELKHATEEB")
                    {
                        AHLY_ADMIN F7 = new AHLY_ADMIN();
                        F7.Show();
                    }
                    else if (textBox1.Text == "WERNER")
                    {
                        LIVER_ADMIN f8 = new LIVER_ADMIN();
                        f8.Show();
                    }
                    else if (textBox1.Text == "ALKHALIFIE")
                    {
                        PARIS_ADMIN F10 = new PARIS_ADMIN();
                        F10.Show();
                    }
                    else if (textBox1.Text == "HAINER")
                    {
                        BAYERN_ADMIN F11 = new BAYERN_ADMIN();
                        F11.Show();
                    }
                    else if (textBox1.Text == "LAPORTE")
                    {
                        BARCELONA_ADMIN F12 = new BARCELONA_ADMIN();
                        F12.Show();
                    }
                    else
                    {
                        REAL_ADMIN F13 = new REAL_ADMIN();
                        F13.Show();
                    }
                }
                else
                {
                    MessageBox.Show("YOUR USERNAME AND PASSWORD ARE NOT FOUND!");
                    this.Close();
                    LOGIN_COACH f1 = new LOGIN_COACH();
                    f1.Show();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CHANGEPASS_CLUBADMIN f1 = new CHANGEPASS_CLUBADMIN();
            f1.Show();
        }
    }
}
