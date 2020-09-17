namespace HostelManagementSystem
{
    partial class manlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manlogin));
            this.pwdfield = new System.Windows.Forms.TextBox();
            this.manfield = new System.Windows.Forms.TextBox();
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
            this.pwdfield.Location = new System.Drawing.Point(400, 225);
            this.pwdfield.Name = "pwdfield";
            this.pwdfield.PasswordChar = '*';
            this.pwdfield.Size = new System.Drawing.Size(135, 20);
            this.pwdfield.TabIndex = 17;
            // 
            // manfield
            // 
            this.manfield.Location = new System.Drawing.Point(400, 160);
            this.manfield.Name = "manfield";
            this.manfield.Size = new System.Drawing.Size(135, 20);
            this.manfield.TabIndex = 16;
            this.manfield.TextChanged += new System.EventHandler(this.adminfield_TextChanged);
            // 
            // signinbutton
            // 
            this.signinbutton.BackColor = System.Drawing.Color.Black;
            this.signinbutton.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinbutton.ForeColor = System.Drawing.Color.White;
            this.signinbutton.Location = new System.Drawing.Point(360, 309);
            this.signinbutton.Name = "signinbutton";
            this.signinbutton.Size = new System.Drawing.Size(120, 54);
            this.signinbutton.TabIndex = 12;
            this.signinbutton.Text = "SIGN IN";
            this.signinbutton.UseVisualStyleBackColor = false;
            this.signinbutton.Click += new System.EventHandler(this.signinbutton_Click_1);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.SystemColors.ControlLight;
            this.home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            this.home.Location = new System.Drawing.Point(12, 12);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(50, 52);
            this.home.TabIndex = 56;
            this.home.TabStop = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // manappointlabel
            // 
            this.manappointlabel.AutoSize = true;
            this.manappointlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.manappointlabel.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manappointlabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.manappointlabel.Location = new System.Drawing.Point(328, 9);
            this.manappointlabel.Name = "manappointlabel";
            this.manappointlabel.Size = new System.Drawing.Size(186, 33);
            this.manappointlabel.TabIndex = 78;
            this.manappointlabel.Text = "MANAGER PROFILE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(268, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 33);
            this.label1.TabIndex = 79;
            this.label1.Text = "USERNAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(268, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 33);
            this.label4.TabIndex = 80;
            this.label4.Text = "PASSWORD";
            // 
            // manlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.manappointlabel);
            this.Controls.Add(this.home);
            this.Controls.Add(this.pwdfield);
            this.Controls.Add(this.manfield);
            this.Controls.Add(this.signinbutton);
            this.Name = "manlogin";
            this.Text = "q";
            this.Load += new System.EventHandler(this.manlogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pwdfield;
        private System.Windows.Forms.TextBox manfield;
        private System.Windows.Forms.Button signinbutton;
        private System.Windows.Forms.PictureBox home;
        private System.Windows.Forms.Label manappointlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}