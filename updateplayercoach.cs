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
    public partial class updateplayercoach : Form
    {
        Controller controllerObj = new Controller();
        public updateplayercoach()
        {
            InitializeComponent();
            DataTable dt2 = controllerObj.SelectPlayerid();
            comboBox1.DataSource = dt2;
            comboBox1.DisplayMember = "ID";
            DataTable dt1 = controllerObj.SelectCoachid();
            comboBox2.DataSource = dt1;
            comboBox2.DisplayMember = "Coach_ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please insert Data");
                return;
            }
            int val, val1;
            if (!int.TryParse(textBox2.Text, out val) || !int.TryParse(textBox1.Text, out val1))
            {
                MessageBox.Show("invalid");
                return;
            }
            int result = controllerObj.Updateplayer(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(comboBox1.Text), textBox3.Text,2);
            if (result == 0)
            {
                MessageBox.Show("update failed ");

            }
            else
            {
                MessageBox.Show("update succeeded");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                MessageBox.Show("Please insert Data");
                return;
            }

            int result = controllerObj.UpdateCoach(Convert.ToInt32(comboBox2.Text), textBox4.Text, 2);
            if (result == 0)
            {
                MessageBox.Show("update failed ");

            }
            else
            {
                MessageBox.Show("update succeeded");
            }
        }
    }
}
