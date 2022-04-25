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
    public partial class insertmatch : Form
    {
        Controller controllerObj = new Controller();
        public insertmatch()
        {
            InitializeComponent();
            DataTable dt = controllerObj.Selectreferee();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Referee_ID";
            DataTable dt3 = controllerObj.Selectstadium();
            comboBox2.DataSource = dt3;
            comboBox2.DisplayMember = "Stadium_Name";
            /////////////////////////////////////////////////////
            DataTable dt22 = controllerObj.SelectClubname();
            comboBox3.DataSource = dt22;
            comboBox3.DisplayMember = "Club_Name";
            DataTable dt221 = controllerObj.SelectClubname();
            comboBox4.DataSource = dt221;
            comboBox4.DisplayMember = "Club_Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all data of Match ");
                return;
            }
            int val = 0;
            if (!int.TryParse(textBox1.Text, out val))
            {
                MessageBox.Show("invalid please enter numbers");
                return;
            }
            if (comboBox3.Text == comboBox4.Text)
            {
                MessageBox.Show("Please, insert all data of Match ");
                return;
            }
            int result = controllerObj.InsertMatch(Convert.ToInt32(textBox1.Text), dateTimePicker1.Value, Convert.ToInt32(comboBox1.Text), comboBox2.Text, comboBox3.Text, comboBox4.Text, 2);
            if (result == 0)
            {
                MessageBox.Show("unsucceed");
            }
            else
            {
                MessageBox.Show("succeed");
            }
        }
    }
}
