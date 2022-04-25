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
    public partial class CLUBS : Form
    {
        Controller controllerObj = new Controller();
        public CLUBS()
        {
            InitializeComponent();

            DataTable dt = controllerObj.SELECTALLCLUB();
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "Club_Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("PLEASE, SELECT ALL DATA TO SHOW");
                return;
            }
            DataTable dt = controllerObj.SELECTCLUB(this.comboBox2.GetItemText(this.comboBox2.SelectedItem));
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SELECTALLCLUB();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
