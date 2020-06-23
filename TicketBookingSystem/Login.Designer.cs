namespace TicketBookingSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.button_CANCEL = new System.Windows.Forms.Button();
            this.button_Login = new System.Windows.Forms.Button();
            this.Banner = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            this.SuspendLayout();
            // 
            // button_CANCEL
            // 
            this.button_CANCEL.BackColor = System.Drawing.Color.DarkCyan;
            this.button_CANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_CANCEL.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CANCEL.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_CANCEL.Location = new System.Drawing.Point(442, 366);
            this.button_CANCEL.Name = "button_CANCEL";
            this.button_CANCEL.Size = new System.Drawing.Size(161, 43);
            this.button_CANCEL.TabIndex = 48;
            this.button_CANCEL.Text = "CANCEL";
            this.button_CANCEL.UseVisualStyleBackColor = false;
            this.button_CANCEL.Click += new System.EventHandler(this.button_CANCEL_Click);
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.DarkCyan;
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Login.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_Login.Location = new System.Drawing.Point(208, 366);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(161, 43);
            this.button_Login.TabIndex = 47;
            this.button_Login.Text = "LOGIN";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // Banner
            // 
            this.Banner.Image = ((System.Drawing.Image)(resources.GetObject("Banner.Image")));
            this.Banner.Location = new System.Drawing.Point(0, 0);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(800, 70);
            this.Banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Banner.TabIndex = 46;
            this.Banner.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.textBox_Password);
            this.groupBox1.Controls.Add(this.textBox_Username);
            this.groupBox1.Controls.Add(this.label_Password);
            this.groupBox1.Controls.Add(this.label_Username);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(164, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 191);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(219, 104);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(242, 38);
            this.textBox_Password.TabIndex = 4;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(219, 47);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(242, 38);
            this.textBox_Username.TabIndex = 4;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(4, 100);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(172, 41);
            this.label_Password.TabIndex = 2;
            this.label_Password.Text = "Password";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.Location = new System.Drawing.Point(4, 43);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(183, 41);
            this.label_Username.TabIndex = 0;
            this.label_Username.Text = "Username";
            // 
            // BackButton
            // 
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(0, 70);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(44, 43);
            this.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackButton.TabIndex = 50;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicketBookingSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_CANCEL);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.Banner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket Booking System";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_CANCEL;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.PictureBox Banner;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.PictureBox BackButton;
    }
}