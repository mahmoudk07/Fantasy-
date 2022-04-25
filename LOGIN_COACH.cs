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
    public partial class LOGIN_COACH : Form
    {
        Controller controllerObj = new Controller();
        public LOGIN_COACH()
        {
            InitializeComponent();
        }

        private void LOGIIN_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || PASS.Text == "")
            {
                MessageBox.Show("PLEASE COMPLETE DATA!");
            }
            else
            {
                DataTable dt = controllerObj.CHECK_USER_PASS(textBox1.Text, Convert.ToInt32(PASS.Text));
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                if (dataGridView1.Rows.Count > 0)
                {
                    if(textBox1.Text=="Pitso")
                    {
                        COACH_AHLY F7 = new COACH_AHLY();
                        F7.Show();
                    }
                    else if(textBox1.Text== "klopp")
                    {
                        COACH_LIVER f8 = new COACH_LIVER();
                        f8.Show();
                    }
                    else if(textBox1.Text== "pochettino")
                    {
                        CAOCH_PARIS F10 = new CAOCH_PARIS();
                        F10.Show();
                    }
                    else if(textBox1.Text== "Julian")
                    {
                        COACH_BAYERN F11 = new COACH_BAYERN();
                        F11.Show();
                    }
                    else if(textBox1.Text== "Xavi")
                    {
                        COACH_BARCA F12 = new COACH_BARCA();
                        F12.Show();
                    }
                    else
                    {
                        COACH F13 = new COACH();
                        F13.Show();
                    }
                }
                else
                {
                    MessageBox.Show("YOUR USERNAME AND PASSWORD ARE NOT FOUND!");
                    this.Close();
                    LOGIN_COACH f1 = new LOGIN_COACH();
                    f1.Show();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CHANGEPASS_COACH f1 = new CHANGEPASS_COACH();
            f1.Show();
        }
    }
}
