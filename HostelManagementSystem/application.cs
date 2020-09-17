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
    public partial class application : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3T87TTE\\SQLEXPRESS;Initial Catalog=HOSTEL;Integrated Security=True");

        public application()
        {
            InitializeComponent();
        }

        private void application_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userid = stidbox.Text;
            string hostel = comboBox1.Text;
            string msg = msgbox.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Application2(Student_id,Hostel_id,Message1) values(@unid,@hostel,@msg)", con);
            cmd.Parameters.AddWithValue("@unid", userid);
            cmd.Parameters.AddWithValue("@hostel", hostel);
            cmd.Parameters.AddWithValue("@msg", msg);
            MessageBox.Show("Application has been submitted successfully.");
            cmd.ExecuteNonQuery();
            con.Close();
                
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new stdlogin().Show();
            this.Hide();
        }

        private void home_Click(object sender, EventArgs e)
        {
            new mainform().Show();
            this.Hide();
        }
    }
}
