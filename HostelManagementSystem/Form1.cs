using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagementSystem
{
    
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new adminlogin().Show();
            this.Hide();
        }

        private void stdbutton_Click(object sender, EventArgs e)
        {
            new stdlogin().Show();
            this.Hide();
        }

        private void managerbutton_Click(object sender, EventArgs e)
        {
            new manlogin().Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new apprecform().Show();
            this.Hide();
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void mainlabel_Click(object sender, EventArgs e)
        {

        }

        private void mainform_Load(object sender, EventArgs e)
        {

        }
    }
}
