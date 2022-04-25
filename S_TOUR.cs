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
    public partial class S_TOUR : Form
    {
        Controller controllerObj;
        public S_TOUR()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem=="Players")
            {
                controllerObj = new Controller();
                DataTable dt = controllerObj.ViewAllplayers();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            else if (comboBox1.SelectedItem=="Referees")
            {
                controllerObj = new Controller();
                DataTable dt = controllerObj.ViewAllReferees();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            else if(comboBox1.SelectedItem=="Coaches")
            {
                controllerObj = new Controller();
                DataTable dt = controllerObj.ViewAllCoaches();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Please Select any Category to Retreive!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox2.SelectedItem=="All Clubs")
            {
                controllerObj = new Controller();
                DataTable dt = controllerObj.ViewAllClubs();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            else if (comboBox2.SelectedItem==null)
            {
                MessageBox.Show("Please Select any Team to Show information!");
            }
            else
            {
                controllerObj = new Controller();
                DataTable dt = controllerObj.ViewClub(comboBox2.Text);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem == null)
            {
                MessageBox.Show("Please Select the season to Show Data!");
            }
            else
            {

                if (comboBox1.SelectedItem == "Players")
                {
                    controllerObj = new Controller();
                    DataTable dt = controllerObj.ViewPlayer(textBox1.Text, Convert.ToInt32(comboBox3.Text));
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                }
                else if (comboBox1.SelectedItem == "Coaches")
                {
                    controllerObj = new Controller();
                    DataTable dt = controllerObj.ViewCoach(textBox1.Text, Convert.ToInt32(comboBox3.Text));
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                }
                else if (comboBox1.SelectedItem == "Referees")
                {
                    controllerObj = new Controller();
                    DataTable dt = controllerObj.ViewReferee(textBox1.Text, Convert.ToInt32(comboBox3.Text));
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                }
                else if (comboBox1.SelectedItem == null && textBox1.Text == "")
                {
                    MessageBox.Show("Please Enter Complete Information to Retreive!");
                }
            }
        }

        private void S_TOUR_Load(object sender, EventArgs e)
        {

        }
    }
}
