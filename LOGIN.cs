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
    public partial class LOGIN : Form
    {
        Controller controllerObj = new Controller();
        public LOGIN()
        {
            InitializeComponent();
        }

        private void LOGIIN_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || PASS.Text == "")
            {
                MessageBox.Show("INVALID");
            }
            else
            {
                DataTable dt = controllerObj.CHECK_USER_PASS2(textBox1.Text, Convert.ToInt32(PASS.Text));
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                if (dataGridView1.Rows.Count > 0)
                {
                    T_ADMIN F1 = new T_ADMIN();
                    F1.Show();
                }
                else
                {
                    MessageBox.Show("INVALID");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            CHANGEPASS f1 = new CHANGEPASS();
            f1.Show();
        }
    }
}
