namespace TicketBookingSystem
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.Banner = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_LOGIN = new System.Windows.Forms.Label();
            this.label_EXIT = new System.Windows.Forms.Label();
            this.label_SIGNUP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).BeginInit();
            this.SuspendLayout();
            // 
            // Banner
            // 
            this.Banner.Image = ((System.Drawing.Image)(resources.GetObject("Banner.Image")));
            this.Banner.Location = new System.Drawing.Point(0, 0);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(800, 70);
            this.Banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Banner.TabIndex = 22;
            this.Banner.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Angelface", 60F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(-11, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(830, 96);
            this.label1.TabIndex = 23;
            this.label1.Text = "Welcome to Ticket Booking System";
            // 
            // label_LOGIN
            // 
            this.label_LOGIN.AutoSize = true;
            this.label_LOGIN.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label_LOGIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_LOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LOGIN.Location = new System.Drawing.Point(238, 185);
            this.label_LOGIN.Name = "label_LOGIN";
            this.label_LOGIN.Padding = new System.Windows.Forms.Padding(67, 10, 68, 10);
            this.label_LOGIN.Size = new System.Drawing.Size(310, 77);
            this.label_LOGIN.TabIndex = 24;
            this.label_LOGIN.Text = "LOGIN";
            this.label_LOGIN.Click += new System.EventHandler(this.label_LOGIN_Click);
            // 
            // label_EXIT
            // 
            this.label_EXIT.AutoSize = true;
            this.label_EXIT.BackColor = System.Drawing.Color.Crimson;
            this.label_EXIT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_EXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EXIT.ForeColor = System.Drawing.Color.White;
            this.label_EXIT.Location = new System.Drawing.Point(347, 389);
            this.label_EXIT.Name = "label_EXIT";
            this.label_EXIT.Size = new System.Drawing.Size(95, 41);
            this.label_EXIT.TabIndex = 25;
            this.label_EXIT.Text = "EXIT";
            this.label_EXIT.Click += new System.EventHandler(this.label_EXIT_Click);
            // 
            // label_SIGNUP
            // 
            this.label_SIGNUP.AutoSize = true;
            this.label_SIGNUP.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label_SIGNUP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_SIGNUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SIGNUP.Location = new System.Drawing.Point(238, 289);
            this.label_SIGNUP.Name = "label_SIGNUP";
            this.label_SIGNUP.Padding = new System.Windows.Forms.Padding(50, 10, 50, 10);
            this.label_SIGNUP.Size = new System.Drawing.Size(310, 77);
            this.label_SIGNUP.TabIndex = 26;
            this.label_SIGNUP.Text = "SIGNUP";
            this.label_SIGNUP.Click += new System.EventHandler(this.label_SIGNUP_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicketBookingSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_EXIT);
            this.Controls.Add(this.label_SIGNUP);
            this.Controls.Add(this.label_LOGIN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Banner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket Booking System";
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Banner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_LOGIN;
        private System.Windows.Forms.Label label_EXIT;
        private System.Windows.Forms.Label label_SIGNUP;
    }
}