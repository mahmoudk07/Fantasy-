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
    public partial class PLAYERINFO : Form
    {

        Controller controllerObj = new Controller();
        public PLAYERINFO()
        {
            InitializeComponent();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check not empty
            if (playername.Text == "")
            {
                MessageBox.Show("Please, insert a player name");
                return;    //momken ashelha 
            }
            if (SEAS.SelectedItem == null)
            {
                MessageBox.Show("PLEASE, INSERT THE SEASON ");
                return;    //momken ashelha 
            }

            DataTable dt = controllerObj.SELECTP(playername.Text, Convert.ToInt32(this.SEAS.GetItemText(this.SEAS.SelectedItem)));
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (SEAS.SelectedItem == null)
            {
                MessageBox.Show("PLEASE, INSERT THE SEASON ");
                return;    //momken ashelha 
            }

            DataTable dt = controllerObj.SELECTOLDESTPLAYER(Convert.ToInt32(this.SEAS.GetItemText(this.SEAS.SelectedItem)));
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            return;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (SEAS.SelectedItem == null)
            {
                MessageBox.Show("PLEASE, INSERT THE SEASON ");
                return;    //momken ashelha 
            }
            DataTable dt = controllerObj.SELECTALLP(Convert.ToInt32(this.SEAS.GetItemText(this.SEAS.SelectedItem)));
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (SEAS.SelectedItem == null)
            {
                MessageBox.Show("PLEASE, INSERT THE SEASON ");
                return;    //momken ashelha 
            }

            DataTable dt = controllerObj.SELECTBESTPLAYER(Convert.ToInt32(this.SEAS.GetItemText(this.SEAS.SelectedItem)));
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            return;
        }
    }
}
