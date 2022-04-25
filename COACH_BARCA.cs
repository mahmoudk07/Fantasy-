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
    public partial class COACH_BARCA : Form
    {
        Controller controllerObj = new Controller();
        public COACH_BARCA()
        {
            InitializeComponent();
            //INTIALIZE COMBOBOX OF PLAYERS 
            DataTable dt = controllerObj.SELECTPID();
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "ID";
        }

        private void VIEWPLAYER_Click(object sender, EventArgs e)
        {
            CLUBS f1 = new CLUBS();
            f1.Show();
        }

        private void TRANSFERBTN_Click(object sender, EventArgs e)
        {
            transfer f2 = new transfer();
            f2.Show();
        }

        private void SCHEDULEBTN_Click(object sender, EventArgs e)
        {
            SCHEDULE f3 = new SCHEDULE();
            f3.Show();
        }

        private void STANDINGSBTN_Click(object sender, EventArgs e)
        {
            STANDINGS f4 = new STANDINGS();
            f4.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
            LOGIN_COACH P = new LOGIN_COACH();
            P.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PLAYERINFO F5 = new PLAYERINFO();
            F5.Show();
        }

        private void UPDATEPLAYER_Click(object sender, EventArgs e)
        {
           
        }

        private void UPDATEPLAYER_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || comboBox3.SelectedItem == null || seas.SelectedItem == null)
            {
                MessageBox.Show("PLEASE, SELECT ALL DATA TO SHOW");
                return;
            }

            int result = controllerObj.UpdateP(this.comboBox1.GetItemText(this.comboBox1.SelectedItem), this.comboBox2.GetItemText(this.comboBox2.SelectedItem), Convert.ToInt32(this.comboBox3.GetItemText(this.comboBox3.SelectedItem)), Convert.ToInt32(this.seas.GetItemText(this.seas.SelectedItem)));

            if (result == 0)
            {
                MessageBox.Show("No rows are updated");
            }
            else
            {
                MessageBox.Show("The row is updated successfully");
            }
        }
    }
}
