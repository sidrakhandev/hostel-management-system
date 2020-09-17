namespace HostelManagementSystem
{
    partial class mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.mainlabel = new System.Windows.Forms.Label();
            this.adminbutton = new System.Windows.Forms.Button();
            this.stdbutton = new System.Windows.Forms.Button();
            this.managerbutton = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.home)).BeginInit();
            this.SuspendLayout();
            // 
            // mainlabel
            // 
            this.mainlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.mainlabel.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainlabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.mainlabel.Location = new System.Drawing.Point(238, 9);
            this.mainlabel.Name = "mainlabel";
            this.mainlabel.Size = new System.Drawing.Size(308, 37);
            this.mainlabel.TabIndex = 0;
            this.mainlabel.Text = "HOSTEL MANAGEMENT SYSTEM";
            this.mainlabel.Click += new System.EventHandler(this.mainlabel_Click);
            // 
            // adminbutton
            // 
            this.adminbutton.BackColor = System.Drawing.Color.Black;
            this.adminbutton.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminbutton.ForeColor = System.Drawing.Color.White;
            this.adminbutton.Location = new System.Drawing.Point(323, 136);
            this.adminbutton.Name = "adminbutton";
            this.adminbutton.Size = new System.Drawing.Size(200, 56);
            this.adminbutton.TabIndex = 1;
            this.adminbutton.Text = "ADMIN";
            this.adminbutton.UseVisualStyleBackColor = false;
            this.adminbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // stdbutton
            // 
            this.stdbutton.BackColor = System.Drawing.Color.Black;
            this.stdbutton.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdbutton.ForeColor = System.Drawing.Color.White;
            this.stdbutton.Location = new System.Drawing.Point(323, 198);
            this.stdbutton.Name = "stdbutton";
            this.stdbutton.Size = new System.Drawing.Size(200, 58);
            this.stdbutton.TabIndex = 2;
            this.stdbutton.Text = "STUDENT";
            this.stdbutton.UseVisualStyleBackColor = false;
            this.stdbutton.Click += new System.EventHandler(this.stdbutton_Click);
            // 
            // managerbutton
            // 
            this.managerbutton.BackColor = System.Drawing.Color.Black;
            this.managerbutton.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerbutton.ForeColor = System.Drawing.Color.White;
            this.managerbutton.Location = new System.Drawing.Point(323, 262);
            this.managerbutton.Name = "managerbutton";
            this.managerbutton.Size = new System.Drawing.Size(200, 60);
            this.managerbutton.TabIndex = 3;
            this.managerbutton.Text = " MANAGER";
            this.managerbutton.UseVisualStyleBackColor = false;
            this.managerbutton.Click += new System.EventHandler(this.managerbutton_Click);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.SystemColors.ControlLight;
            this.home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            this.home.Location = new System.Drawing.Point(2, 3);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(50, 52);
            this.home.TabIndex = 4;
            this.home.TabStop = false;
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(791, 424);
            this.Controls.Add(this.home);
            this.Controls.Add(this.managerbutton);
            this.Controls.Add(this.stdbutton);
            this.Controls.Add(this.adminbutton);
            this.Controls.Add(this.mainlabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.DarkMagenta;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "mainform";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "mainform";
            this.Load += new System.EventHandler(this.mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.home)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label mainlabel;
        private System.Windows.Forms.Button adminbutton;
        private System.Windows.Forms.Button stdbutton;
        private System.Windows.Forms.Button managerbutton;
        private System.Windows.Forms.PictureBox home;
    }
}

