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
    public partial class apprecform : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3T87TTE\\SQLEXPRESS;Initial Catalog=HOSTEL;Integrated Security=True");
        

        public apprecform()
        {
            
            InitializeComponent();
            populateData1();
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            populateData1();
        }

        private void populateData1()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Application2", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView2.Rows.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string Appid = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                string stid = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string hostelid = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                string appStatus = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                string roomno = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                string msg1 = ds.Tables[0].Rows[i].ItemArray[5].ToString();

                DataGridViewRow koiNam = new DataGridViewRow();
                koiNam.CreateCells(dataGridView2);
                koiNam.Cells[0].Value = Appid;
                koiNam.Cells[1].Value =stid;
                koiNam.Cells[2].Value = hostelid;
                koiNam.Cells[3].Value = appStatus;
                koiNam.Cells[4].Value = roomno;
                koiNam.Cells[5].Value = msg1;
                dataGridView2.Rows.Add(koiNam);


            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void home_Click(object sender, EventArgs e)
        {
            new mainform().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                con.Open();
                string id = stidbox.Text;
                string app= comboBox2.Text;
                string room = comboBox1.Text;
                SqlCommand cmd = new SqlCommand("update Application2 set Application_status=@app,Room_No=@room,Student_id=@id  where Student_id=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@app", app);
                cmd.Parameters.AddWithValue("@room", room);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student's Application record has been updated successfully");
                stidbox.Focus();
                con.Close();
                populateData1();
            }

        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
     
            new vacateform().Show();
            this.Hide();
        }

        private void delete_record_from_database()
        {
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-3T87TTE\\SQLEXPRESS;Initial Catalog=STUDENT;Integrated Security=True");
            con.Open();
            string id = stidbox.Text;
            SqlCommand cmd = new SqlCommand("delete from Application2 where Student_id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            //cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted");
            cmd.ExecuteNonQuery();
            con.Close();
            // populateData();
            // cmd.ExecuteNonQuery();



        }
        private void removebutton_Click(object sender, EventArgs e)
        {
            delete_record_from_database();
            populateData1();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new manlogin().Show();
            this.Hide();
        }

        private void roomBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void apprecform_Load(object sender, EventArgs e)
        {

        }
        
    }
}
