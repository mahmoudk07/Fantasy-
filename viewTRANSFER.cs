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
    public partial class viewTRANSFER : Form
    {
        Controller controllerObj = new Controller();
        public viewTRANSFER()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAllTrans();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAllTrans1();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAllTrans2();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
