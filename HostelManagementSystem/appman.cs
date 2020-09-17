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
    public partial class appman : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3T87TTE\\SQLEXPRESS;Initial Catalog=HOSTEL;Integrated Security=True");

        public appman()
        {
            InitializeComponent();
            populateData();
        }

        private void appman_Load(object sender, EventArgs e)
        {

        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            string username = unamebox.Text;
            string fname = fnamebox.Text;
            string lname = lnamebox.Text;
            string contact = conbox.Text;
            string hostel = comboBox1.Text;
            string pwd = pwdbox.Text;
            string cpwd = cpwdbox.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Hostel_Manager2(username,Fname,Lname, Mob_no,Hostel_id,Pwd) values(@un,@fname,@lname,@contact,@hostel,@pwd)", con);
            cmd.Parameters.AddWithValue("@un", username);
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@contact", contact);
            cmd.Parameters.AddWithValue("@hostel", hostel);
            cmd.Parameters.AddWithValue("@pwd", pwd);
            if (pwdbox.Text != cpwdbox.Text)
            {
                MessageBox.Show("Password do not match.");
            }
            else
            {
                MessageBox.Show("Your data is saved");

                cmd.ExecuteNonQuery();
                con.Close();
                populateData();
                //new stdlogin().Show();
                //this.Hide();
            }
        }
        private void populateData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Hostel_Manager2 ", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.Rows.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string username = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                string fname = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string lname = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                string contact = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                string hostel = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                string pwd= ds.Tables[0].Rows[i].ItemArray[5].ToString();
                DataGridViewRow koiNam = new DataGridViewRow();
                koiNam.CreateCells(dataGridView1);
                koiNam.Cells[0].Value = username;
                koiNam.Cells[1].Value = fname;
                koiNam.Cells[2].Value = lname;
                koiNam.Cells[3].Value = contact;
                koiNam.Cells[4].Value = hostel;
                koiNam.Cells[5].Value = pwd;
                dataGridView1.Rows.Add(koiNam);


            }
            con.Close();
        }
        private void delete_record_from_database()
        {
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-3T87TTE\\SQLEXPRESS;Initial Catalog=STUDENT;Integrated Security=True");
            con.Open();
            string pwd= pwdbox.Text;
            SqlCommand cmd = new SqlCommand("delete from Hostel_Manager2 where Pwd=@pwd", con);
            cmd.Parameters.AddWithValue("@pwd", pwd);
            //cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted");
            cmd.ExecuteNonQuery();
            con.Close();
            populateData();
            // cmd.ExecuteNonQuery();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new stdinfoform().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string id = idBox.Text;
            string username = unamebox.Text;
            string fname = fnamebox.Text;
            string lname = lnamebox.Text;
            string contact = conbox.Text;
            string hostel = comboBox1.Text;
            string pwd = pwdbox.Text;
            SqlCommand cmd = new SqlCommand("update Hostel_Manager2  set Username=@un, Fname=@f, Lname=@l, Mob_no=@no, Hostel_id=@hid, Pwd=@pd  where Hostel_man_id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@un", username);
            cmd.Parameters.AddWithValue("@f", fname);
            cmd.Parameters.AddWithValue("@l", lname);
            cmd.Parameters.AddWithValue("@no", contact);
            cmd.Parameters.AddWithValue("@hid", hostel);
            cmd.Parameters.AddWithValue("@pd", pwd);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Managers's record has been updated successfully");
            unamebox.Focus();
            con.Close();
            populateData();
        }

        private void unamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            new mainform().Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new adminlogin().Show();
            this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
