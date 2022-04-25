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
    public partial class INSERTOSPONSOR : Form
    {
        Controller controllerObj = new Controller();
        public INSERTOSPONSOR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all data of Sponsor ");
            }
            int val = 0;
            if (!int.TryParse(textBox2.Text, out val))
            {
                MessageBox.Show("invalid please enter numbers");
                return;
            }

            int result = controllerObj.InsertSponsor(textBox1.Text, Convert.ToInt32(textBox2.Text), 2);
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
