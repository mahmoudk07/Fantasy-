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
    public partial class STANDINGS : Form
    {
        Controller controllerObj = new Controller();
        public STANDINGS()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem==null)
            {
                MessageBox.Show("PLEASE SELECT SEASON TO SHOW DATA!");
            }
            else
            {
                DataTable dt = controllerObj.SELECTSTAND(Convert.ToInt32(this.comboBox1.GetItemText(this.comboBox1.SelectedItem)));
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
        }
    }
}
