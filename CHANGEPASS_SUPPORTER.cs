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
    public partial class CHANGEPASS_SUPPORTER : Form
    {
        public CHANGEPASS_SUPPORTER()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            SUPPORT_USER f1 = new SUPPORT_USER();
            f1.Show();
        }
    }
}
