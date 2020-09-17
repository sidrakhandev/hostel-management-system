using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagementSystem
{
    public partial class manlogin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3T87TTE\\SQLEXPRESS;Initial Catalog=HOSTEL;Integrated Security=True");
        public manlogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new mainform().Show();
            this.Hide();
        }

        private void signinbutton_Click(object sender, EventArgs e)
        {
            con.Open();

            string userid = manfield.Text;
            string password = pwdfield.Text;
            SqlCommand cmd = new SqlCommand("select Username,Pwd from Hostel_Manager2 where Username='" + manfield.Text + "'and Pwd='" + pwdfield.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login sucess Welcome to HOSTEL MANAGEMENT SYSTEM");
                new apprecform().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The username or password is incorrect! Try again");
                manfield.Focus();
            }
            con.Close();
        }



        private void manlogin_Load(object sender, EventArgs e)
        {

        }

        private void adminfield_TextChanged(object sender, EventArgs e)
        {

        }

        private void signinbutton_Click_1(object sender, EventArgs e)
        {
            con.Open();

            string userid = manfield.Text;
            string password = pwdfield.Text;
            SqlCommand cmd = new SqlCommand("select Username,Pwd from Hostel_Manager2 where Username='" + manfield.Text + "'and Pwd='" + pwdfield.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login sucess Welcome to HOSTEL MANAGEMENT SYSTEM");
                new apprecform().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The username or password is incorrect! Try again");
                manfield.Focus();
            }
            con.Close();
        }

        private void home_Click(object sender, EventArgs e)
        {
            new mainform().Show();
            this.Hide();
        }
    }
}
