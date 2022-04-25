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
    public partial class CHANGEPASS_CLUBADMIN : Form
    {
        public CHANGEPASS_CLUBADMIN()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            LOGIN_CLUBADMIN f1 = new LOGIN_CLUBADMIN();
            f1.Show();
        }
    }
}
