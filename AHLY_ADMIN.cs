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
    public partial class AHLY_ADMIN : Form
    {
        Controller controllerObj = new Controller();
        public AHLY_ADMIN()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            LOGIN_CLUBADMIN F = new LOGIN_CLUBADMIN();
            F.Show();
        }

        private void VIEWL_Click(object sender, EventArgs e)
        {
            DataFor_ClubAdmin F = new DataFor_ClubAdmin();
            F.Show();
        }

        private void UPBUDGET_Click(object sender, EventArgs e)
        {
            if (TEXTBUDGET.Text == "")
            {
                MessageBox.Show("Please Enter New Budget to Update!");
            }
            else
            {
                int result = controllerObj.UPDATE_BUDGET(TEXTBUDGET.Text, Convert.ToInt32(500));
                if (result == 0)
                {
                    MessageBox.Show("No rows are updated");
                }
                else
                {
                    MessageBox.Show("The row is updated successfully");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int outt = 0;
            if (textBox2.Text == "" && textBox3.Text == "")
            {
                MessageBox.Show("Please Fill all Data to Insert Sponsor");
            }
            else if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("SELECT SEASON TO INSERT SPONSOR!");
            }
            else if (!int.TryParse(textBox2.Text, out outt))
            {
                MessageBox.Show("PLEASE INTER ID AS INTEGER NUMBER!");
            }
            else
            {
                int result = controllerObj.INSERT_SPONSOR(textBox3.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(comboBox1.Text));
                if (result == 0)
                {
                    MessageBox.Show("No rows are inserted");
                }
                else
                {
                    MessageBox.Show("The row is inserted successfully");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter new Value to Update!");
            }
            else
            {
                int result = controllerObj.UPDATE_STADIUM(Convert.ToInt32(textBox1.Text), 500);
                if (result == 0)
                {
                    MessageBox.Show("No rows are updated");
                }
                else
                {
                    MessageBox.Show("The row is updated successfully");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("PLEASE, SELECT ALL DATA TO TERMINATE CONTRACT");
                return;
            }

            int result = controllerObj.DELETES(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox2.Text), 500);

            if (result == 0)
            {
                MessageBox.Show("FAILED ENTER VALID DATA");
            }
            else
            {
                MessageBox.Show("CONTRACT TERMINATED");
            }
        }
    }
}
