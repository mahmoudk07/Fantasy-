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
    public partial class insertstandings : Form
    {
        Controller controllerObj = new Controller();
        public insertstandings()
        {
            InitializeComponent();
            DataTable dt = controllerObj.SelectClubname();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Club_Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all data");
                return;
            }
            int val, val1, val2, val3, val4, val5, val6, val7;
            if (!int.TryParse(textBox1.Text, out val) || !int.TryParse(textBox2.Text, out val1) || !int.TryParse(textBox3.Text, out val2) || !int.TryParse(textBox4.Text, out val3) || !int.TryParse(textBox6.Text, out val4) || !int.TryParse(textBox7.Text, out val5) || !int.TryParse(textBox8.Text, out val6))
            {
                MessageBox.Show("invalid please enter numbers");
                return;
            }
            int result = controllerObj.InsertStanding(comboBox1.Text, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text), 2);
            if (result == 0)
            {
                MessageBox.Show("unsucceed");
            }
            else
            {
                MessageBox.Show("succeed");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all data");
                return;
            }
            int val, val1, val2, val3, val4, val5, val6, val7;
            if (!int.TryParse(textBox1.Text, out val) || !int.TryParse(textBox2.Text, out val1) || !int.TryParse(textBox3.Text, out val2) || !int.TryParse(textBox4.Text, out val3) || !int.TryParse(textBox6.Text, out val4) || !int.TryParse(textBox7.Text, out val5) || !int.TryParse(textBox8.Text, out val6))
            {
                MessageBox.Show("invalid please enter numbers");
                return;
            }
            int result = controllerObj.UpdateStanding(comboBox1.Text, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text), 2);
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
