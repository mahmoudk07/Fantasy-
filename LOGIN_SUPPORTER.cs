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
    public partial class LOGIN_SUPPORTER : Form
    {
        Controller controllerObj = new Controller();
        public LOGIN_SUPPORTER()
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
                DataTable dt = controllerObj.CHECK_USER_PASS(textBox1.Text, Convert.ToInt32(PASS.Text));
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                if (dataGridView1.Rows.Count > 0)
                {
                    SUPPORT_USER F1 = new SUPPORT_USER();
                    F1.Show();
                }
                else
                {
                    MessageBox.Show("YOUR USERNAME AND PASSWORD ARE NOT FOUND!");
                    this.Close();
                    LOGIN_SUPPORTER f1 = new LOGIN_SUPPORTER();
                    f1.Show();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SIGN_UP F1 = new SIGN_UP();
            F1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CHANGEPASS_SUPPORTER f1 = new CHANGEPASS_SUPPORTER();
            f1.Show();
        }
    }
}
