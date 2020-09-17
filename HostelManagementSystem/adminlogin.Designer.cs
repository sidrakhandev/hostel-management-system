namespace HostelManagementSystem
{
    partial class adminlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminlogin));
            this.pwdfield = new System.Windows.Forms.TextBox();
            this.adminfield = new System.Windows.Forms.TextBox();
            this.signinbutton = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.PictureBox();
            this.manappointlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.home)).BeginInit();
            this.SuspendLayout();
            // 
            // pwdfield
            // 
            this.pwdfield.Location = new System.Drawing.Point(426, 212);
            this.pwdfield.Name = "pwdfield";
            this.pwdfield.PasswordChar = '*';
            this.pwdfield.Size = new System.Drawing.Size(152, 20);
            this.pwdfield.TabIndex = 11;
            // 
            // adminfield
            // 
            this.adminfield.Location = new System.Drawing.Point(426, 138);
            this.adminfield.Name = "adminfield";
            this.adminfield.Size = new System.Drawing.Size(152, 20);
            this.adminfield.TabIndex = 10;
            // 
            // signinbutton
            // 
            this.signinbutton.BackColor = System.Drawing.Color.Black;
            this.signinbutton.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinbutton.ForeColor = System.Drawing.Color.White;
            this.signinbutton.Location = new System.Drawing.Point(360, 312);
            this.signinbutton.Name = "signinbutton";
            this.signinbutton.Size = new System.Drawing.Size(98, 45);
            this.signinbutton.TabIndex = 6;
            this.signinbutton.Text = "SIGN IN";
            this.signinbutton.UseVisualStyleBackColor = false;
            this.signinbutton.Click += new System.EventHandler(this.signinbutton_Click);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.SystemColors.ControlLight;
            this.home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            this.home.Location = new System.Drawing.Point(12, 12);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(50, 52);
            this.home.TabIndex = 13;
            this.home.TabStop = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // manappointlabel
            // 
            this.manappointlabel.AutoSize = true;
            this.manappointlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.manappointlabel.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manappointlabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.manappointlabel.Location = new System.Drawing.Point(378, 9);
            this.manappointlabel.Name = "manappointlabel";
            this.manappointlabel.Size = new System.Drawing.Size(157, 33);
            this.manappointlabel.TabIndex = 77;
            this.manappointlabel.Text = "ADMIN PROFILE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(280, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 33);
            this.label1.TabIndex = 78;
            this.label1.Text = "USERNAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(280, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 33);
            this.label4.TabIndex = 79;
            this.label4.Text = "PASSWORD";
            // 
            // adminlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(777, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.manappointlabel);
            this.Controls.Add(this.home);
            this.Controls.Add(this.pwdfield);
            this.Controls.Add(this.adminfield);
            this.Controls.Add(this.signinbutton);
            this.Name = "adminlogin";
            this.Text = "adminlogin";
            this.Load += new System.EventHandler(this.adminlogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pwdfield;
        private System.Windows.Forms.TextBox adminfield;
        private System.Windows.Forms.Button signinbutton;
        private System.Windows.Forms.PictureBox home;
        private System.Windows.Forms.Label manappointlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}