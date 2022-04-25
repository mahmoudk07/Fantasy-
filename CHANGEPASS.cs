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
    public partial class CHANGEPASS : Form
    {
        Controller controllerObj = new Controller();
        public CHANGEPASS()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || PASS.Text == "")
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
                    int result = controllerObj.updatetiktsavail2(textBox1.Text, Convert.ToInt32(PASS.Text));
                    if (result == 0)
                    {
                        MessageBox.Show("INVALID");
                    }
                    this.Close();
                    LOGIN F1 = new LOGIN();
                    F1.Show();
                }
            }
        }
    }
}
