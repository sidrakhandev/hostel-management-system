namespace HostelManagementSystem
{
    partial class appman
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(appman));
            this.conbox = new System.Windows.Forms.TextBox();
            this.lnamebox = new System.Windows.Forms.TextBox();
            this.cpwdbox = new System.Windows.Forms.TextBox();
            this.pwdbox = new System.Windows.Forms.TextBox();
            this.fnamebox = new System.Windows.Forms.TextBox();
            this.unamebox = new System.Windows.Forms.TextBox();
            this.signupbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.updatebtn = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // conbox
            // 
            this.conbox.Location = new System.Drawing.Point(371, 147);
            this.conbox.Name = "conbox";
            this.conbox.Size = new System.Drawing.Size(125, 20);
            this.conbox.TabIndex = 54;
            // 
            // lnamebox
            // 
            this.lnamebox.Location = new System.Drawing.Point(375, 121);
            this.lnamebox.Name = "lnamebox";
            this.lnamebox.Size = new System.Drawing.Size(121, 20);
            this.lnamebox.TabIndex = 52;
            // 
            // cpwdbox
            // 
            this.cpwdbox.Location = new System.Drawing.Point(375, 231);
            this.cpwdbox.Name = "cpwdbox";
            this.cpwdbox.PasswordChar = '*';
            this.cpwdbox.Size = new System.Drawing.Size(121, 20);
            this.cpwdbox.TabIndex = 51;
            // 
            // pwdbox
            // 
            this.pwdbox.Location = new System.Drawing.Point(375, 200);
            this.pwdbox.Name = "pwdbox";
            this.pwdbox.PasswordChar = '*';
            this.pwdbox.Size = new System.Drawing.Size(121, 20);
            this.pwdbox.TabIndex = 50;
            // 
            // fnamebox
            // 
            this.fnamebox.Location = new System.Drawing.Point(375, 95);
            this.fnamebox.Name = "fnamebox";
            this.fnamebox.Size = new System.Drawing.Size(121, 20);
            this.fnamebox.TabIndex = 48;
            // 
            // unamebox
            // 
            this.unamebox.Location = new System.Drawing.Point(375, 68);
            this.unamebox.Name = "unamebox";
            this.unamebox.Size = new System.Drawing.Size(121, 20);
            this.unamebox.TabIndex = 47;
            this.unamebox.TextChanged += new System.EventHandler(this.unamebox_TextChanged);
            // 
            // signupbutton
            // 
            this.signupbutton.BackColor = System.Drawing.Color.Black;
            this.signupbutton.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupbutton.ForeColor = System.Drawing.Color.White;
            this.signupbutton.Location = new System.Drawing.Point(309, 272);
            this.signupbutton.Name = "signupbutton";
            this.signupbutton.Size = new System.Drawing.Size(105, 36);
            this.signupbutton.TabIndex = 46;
            this.signupbutton.Text = "APPOINT";
            this.signupbutton.UseVisualStyleBackColor = false;
            this.signupbutton.Click += new System.EventHandler(this.signupbutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 41;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.name,
            this.fname1,
            this.lname1,
            this.mob,
            this.hostel});
            this.dataGridView1.Location = new System.Drawing.Point(98, 314);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 150);
            this.dataGridView1.TabIndex = 56;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // username
            // 
            this.username.HeaderText = "HostelManId";
            this.username.Name = "username";
            // 
            // name
            // 
            this.name.HeaderText = "username";
            this.name.Name = "name";
            // 
            // fname1
            // 
            this.fname1.HeaderText = "Fname";
            this.fname1.Name = "fname1";
            // 
            // lname1
            // 
            this.lname1.HeaderText = "Lname";
            this.lname1.Name = "lname1";
            // 
            // mob
            // 
            this.mob.HeaderText = "Mobno";
            this.mob.Name = "mob";
            // 
            // hostel
            // 
            this.hostel.HeaderText = "Hostel";
            this.hostel.Name = "hostel";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(670, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 56);
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.Black;
            this.updatebtn.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.Color.White;
            this.updatebtn.Location = new System.Drawing.Point(670, 272);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(113, 36);
            this.updatebtn.TabIndex = 58;
            this.updatebtn.Text = "UPDATE";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.SystemColors.ControlLight;
            this.home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            this.home.Location = new System.Drawing.Point(3, 12);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(50, 52);
            this.home.TabIndex = 59;
            this.home.TabStop = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(738, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 56);
            this.pictureBox3.TabIndex = 60;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(543, 284);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(121, 20);
            this.idBox.TabIndex = 61;
            this.idBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(504, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 22);
            this.label1.TabIndex = 62;
            this.label1.Text = "Id";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(375, 173);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(266, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 33);
            this.label2.TabIndex = 82;
            this.label2.Text = "APPOINT HOSTEL MANAGER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(284, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 83;
            this.label3.Text = "USERNAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(310, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 22);
            this.label4.TabIndex = 84;
            this.label4.Text = "FNAME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(312, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 22);
            this.label6.TabIndex = 85;
            this.label6.Text = "LNAME";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(305, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 22);
            this.label7.TabIndex = 86;
            this.label7.Text = "MOBNO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(309, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 22);
            this.label8.TabIndex = 87;
            this.label8.Text = "HOSTEL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(286, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 22);
            this.label9.TabIndex = 88;
            this.label9.Text = "PASSWORD";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(219, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 22);
            this.label10.TabIndex = 89;
            this.label10.Text = "CONFIRM PASSWORD";
            // 
            // appman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.home);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.conbox);
            this.Controls.Add(this.lnamebox);
            this.Controls.Add(this.cpwdbox);
            this.Controls.Add(this.pwdbox);
            this.Controls.Add(this.fnamebox);
            this.Controls.Add(this.unamebox);
            this.Controls.Add(this.signupbutton);
            this.Controls.Add(this.label5);
            this.Name = "appman";
            this.Text = "appman";
            this.Load += new System.EventHandler(this.appman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox conbox;
        private System.Windows.Forms.TextBox lnamebox;
        private System.Windows.Forms.TextBox cpwdbox;
        private System.Windows.Forms.TextBox pwdbox;
        private System.Windows.Forms.TextBox fnamebox;
        private System.Windows.Forms.TextBox unamebox;
        private System.Windows.Forms.Button signupbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.PictureBox home;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mob;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}