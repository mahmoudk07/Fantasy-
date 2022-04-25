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
    public partial class updateschedule : Form
    {
        Controller controllerObj = new Controller();
        public updateschedule()
        {
            InitializeComponent();
            DataTable dt = controllerObj.Selectreferee();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Referee_ID";
            DataTable dt3 = controllerObj.Selectstadium();
            comboBox2.DataSource = dt3;
            comboBox2.DisplayMember = "Stadium_Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("invalid");
                return;
            }
            int val = 0;
            if (!int.TryParse(textBox1.Text, out val))
            {
                MessageBox.Show("invalid please enter numbers");
                return;
            }
            int result = controllerObj.Updatematchshedule(Convert.ToInt32(textBox1.Text), dateTimePicker1.Value, Convert.ToInt32(comboBox1.Text), comboBox2.Text);
            if (result == 0)
            {
                MessageBox.Show("update failed check match id");

            }
            else
            {
                MessageBox.Show("update succeeded");
            }
        }
    }
}
