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
    public partial class SUPPORT_USER : Form
    {
        Controller controllerObj = new Controller();
        public SUPPORT_USER()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            S_TOUR F1 = new S_TOUR();
            F1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SCLUBS F2 = new SCLUBS();
            F2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SCHEDULE F3 = new SCHEDULE();
            F3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            STANDINGS F4 = new STANDINGS();
            F4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            transfer F5 = new transfer();
            F5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""&&textBox2.Text=="")
            {
                MessageBox.Show("PLEASE COMPLETE DATA TO BE RETREIVED!");
            }
            else
            {
                DataTable dt = controllerObj.SelectTicket_Status(textBox2.Text, textBox1.Text);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                textBox3.Text = Convert.ToString(dataGridView1.Rows[0].Cells[0].Value);
            }
        }
    }
}
