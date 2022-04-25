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
    public partial class SIGN_UP : Form
    {
        Controller controllerObj = new Controller();
        public SIGN_UP()
        {
            InitializeComponent();
        }

        private void LOGIIN_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || PASS.Text == "")
            {
                MessageBox.Show("Complete Data!");
            }
            else
            {
                int result = controllerObj.insertnewadmin1(textBox1.Text, Convert.ToInt32(PASS.Text));
                this.Close();
                LOGIN_SUPPORTER F1 = new LOGIN_SUPPORTER();
                F1.Show();
                if(result==0)
                {
                    MessageBox.Show("INSERTION FAILED");
                }
                else
                {
                    MessageBox.Show("INSERTION completed");
                }
            }
        }
    }
}
