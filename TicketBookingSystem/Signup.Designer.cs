namespace TicketBookingSystem
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.BackButton = new System.Windows.Forms.PictureBox();
            this.button_CANCEL = new System.Windows.Forms.Button();
            this.button_Login = new System.Windows.Forms.Button();
            this.Banner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(0, 70);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(44, 43);
            this.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackButton.TabIndex = 54;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // button_CANCEL
            // 
            this.button_CANCEL.BackColor = System.Drawing.Color.DarkCyan;
            this.button_CANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_CANCEL.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CANCEL.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_CANCEL.Location = new System.Drawing.Point(442, 399);
            this.button_CANCEL.Name = "button_CANCEL";
            this.button_CANCEL.Size = new System.Drawing.Size(161, 43);
            this.button_CANCEL.TabIndex = 53;
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
            this.button_Login.Location = new System.Drawing.Point(208, 399);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(161, 43);
            this.button_Login.TabIndex = 52;
            this.button_Login.Text = "SIGNUP";
            this.button_Login.UseVisualStyleBackColor = false;
            // 
            // Banner
            // 
            this.Banner.Image = ((System.Drawing.Image)(resources.GetObject("Banner.Image")));
            this.Banner.Location = new System.Drawing.Point(0, 0);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(800, 70);
            this.Banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Banner.TabIndex = 51;
            this.Banner.TabStop = false;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicketBookingSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.button_CANCEL);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.Banner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket Booking System";
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BackButton;
        private System.Windows.Forms.Button button_CANCEL;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.PictureBox Banner;
    }
}