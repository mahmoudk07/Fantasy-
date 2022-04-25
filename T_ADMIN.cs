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
    public partial class T_ADMIN : Form
    {
        Controller controllerObj = new Controller();
        public T_ADMIN()
        {
            InitializeComponent();
            DataTable dt = controllerObj.SelectMatchID();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Match_ID";
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            INSERTOSPONSOR F1 = new INSERTOSPONSOR();
            F1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            INSERTTRANSFER F2 = new INSERTTRANSFER();
            F2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            viewTRANSFER f3 = new viewTRANSFER();
            f3.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            updateschedule f4 = new updateschedule();
            f4.Show();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            this.Close();
            insertmatch f5 = new insertmatch();
            f5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            insertstandings f1 = new insertstandings();
            f1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            updateplayercoach f1 = new updateplayercoach();
            f1.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Please insert Data");
                return;
            }
            int val;
            if (!int.TryParse(textBox5.Text, out val))
            {
                MessageBox.Show("invalid");
                return;
            }

            int result = controllerObj.insertnewadmin(Convert.ToInt32(textBox5.Text), textBox2.Text);
            if (result == 0)
            {
                MessageBox.Show("insertion failed ");

            }
            else
            {
                MessageBox.Show("insertion Done");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please insert Data");
                return;
            }
            int result = controllerObj.Updateprize(textBox1.Text, textBox3.Text);
            if (result == 0)
            {
                MessageBox.Show("update failed check ");

            }
            else
            {
                MessageBox.Show("update Done");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                MessageBox.Show("Please insert Data");
                return;
            }
            int result = controllerObj.inserttiktsavail(Convert.ToInt32(comboBox1.Text), textBox4.Text);
            if (result == 0)
            {
                MessageBox.Show("insert failed check ");

            }
            else
            {
                MessageBox.Show("insert Done");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                MessageBox.Show("Please insert Data");
                return;
            }
            int result = controllerObj.updatetiktsavail(Convert.ToInt32(comboBox1.Text), textBox4.Text);
            if (result == 0)
            {
                MessageBox.Show("update failed  ");

            }
            else
            {
                MessageBox.Show("update Done");
            }
        }
    }
}
