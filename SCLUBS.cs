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
    public partial class SCLUBS : Form
    {
        Controller controllerObj;
        public SCLUBS()
        {
            InitializeComponent();
        }

        private void SCLUBS_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.ViewAllClubs();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void REALPIC_Click(object sender, EventArgs e)
        {
            string list1 =Convert.ToString(dataGridView1.Rows[0].Cells[3].Value);
            textBox1.Text = list1;
            string list2 = Convert.ToString(dataGridView1.Rows[0].Cells[0].Value);
            textBox3.Text = list2;
            string list3 = Convert.ToString(dataGridView1.Rows[0].Cells[2].Value);
            textBox2.Text = list3;
            string list4 = Convert.ToString(dataGridView1.Rows[0].Cells[4].Value);
            textBox4.Text = list4;
        }

        private void BARCAPIC_Click(object sender, EventArgs e)
        {
            string list1 = Convert.ToString(dataGridView1.Rows[1].Cells[3].Value);
            textBox1.Text = list1;
            string list2 = Convert.ToString(dataGridView1.Rows[1].Cells[0].Value);
            textBox3.Text = list2;
            string list3 = Convert.ToString(dataGridView1.Rows[1].Cells[2].Value);
            textBox2.Text = list3;
            string list4 = Convert.ToString(dataGridView1.Rows[1].Cells[4].Value);
            textBox4.Text = list4;
        }

        private void LIVERPIC_Click(object sender, EventArgs e)
        {
            string list1 = Convert.ToString(dataGridView1.Rows[3].Cells[3].Value);
            textBox1.Text = list1;
            string list2 = Convert.ToString(dataGridView1.Rows[3].Cells[0].Value);
            textBox3.Text = list2;
            string list3 = Convert.ToString(dataGridView1.Rows[3].Cells[2].Value);
            textBox2.Text = list3;
            string list4 = Convert.ToString(dataGridView1.Rows[3].Cells[4].Value);
            textBox4.Text = list4;
        }

        private void PARISPIC_Click(object sender, EventArgs e)
        {
            string list1 = Convert.ToString(dataGridView1.Rows[5].Cells[3].Value);
            textBox1.Text = list1;
            string list2 = Convert.ToString(dataGridView1.Rows[5].Cells[0].Value);
            textBox3.Text = list2;
            string list3 = Convert.ToString(dataGridView1.Rows[5].Cells[2].Value);
            textBox2.Text = list3;
            string list4 = Convert.ToString(dataGridView1.Rows[5].Cells[4].Value);
            textBox4.Text = list4;
        }

        private void BAYERNPIC_Click(object sender, EventArgs e)
        {
            string list1 = Convert.ToString(dataGridView1.Rows[2].Cells[3].Value);
            textBox1.Text = list1;
            string list2 = Convert.ToString(dataGridView1.Rows[2].Cells[0].Value);
            textBox3.Text = list2;
            string list3 = Convert.ToString(dataGridView1.Rows[2].Cells[2].Value);
            textBox2.Text = list3;
            string list4 = Convert.ToString(dataGridView1.Rows[2].Cells[4].Value);
            textBox4.Text = list4;
        }

        private void AHLYPIC_Click(object sender, EventArgs e)
        {
            string list1 = Convert.ToString(dataGridView1.Rows[4].Cells[3].Value);
            textBox1.Text = list1;
            string list2 = Convert.ToString(dataGridView1.Rows[4].Cells[0].Value);
            textBox3.Text = list2;
            string list3 = Convert.ToString(dataGridView1.Rows[4].Cells[2].Value);
            textBox2.Text = list3;
            string list4 = Convert.ToString(dataGridView1.Rows[4].Cells[4].Value);
            textBox4.Text = list4;
        }
    }
}
