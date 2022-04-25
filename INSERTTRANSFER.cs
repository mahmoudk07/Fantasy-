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
    public partial class INSERTTRANSFER : Form
    {
        Controller controllerObj = new Controller();
        public INSERTTRANSFER()
        {
            InitializeComponent();
            DataTable dt = controllerObj.SelectClubname();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Club_Name";
            DataTable dt3 = controllerObj.SelectClubname();
            comboBox2.DataSource = dt3;
            comboBox2.DisplayMember = "Club_Name";
            DataTable dt2 = controllerObj.SelectPlayerid();
            comboBox3.DataSource = dt2;
            comboBox3.DisplayMember = "ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please insert Data");
                return;
            }
            int val;
            if (!int.TryParse(textBox2.Text, out val))
            {
                MessageBox.Show("invalid");
                return;
            }
            if (!int.TryParse(textBox1.Text, out val))
            {
                MessageBox.Show("invalid");
                return;
            }
            if (comboBox1.Text == comboBox2.Text)
            {
                MessageBox.Show("invalid");
                return;
            }

            int result = controllerObj.Inserttrans(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToDateTime(dateTimePicker1.Value), comboBox1.Text, comboBox2.Text, Convert.ToInt32(comboBox3.Text), 2);
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
