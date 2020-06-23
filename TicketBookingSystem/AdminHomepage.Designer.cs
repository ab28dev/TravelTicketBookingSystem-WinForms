namespace TicketBookingSystem
{
    partial class AdminHomepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHomepage));
            this.HomeButton = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.PictureBox();
            this.button_CANCEL = new System.Windows.Forms.Button();
            this.button_BOOK = new System.Windows.Forms.Button();
            this.Banner = new System.Windows.Forms.PictureBox();
            this.ticket_history = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HomeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeButton
            // 
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.Location = new System.Drawing.Point(0, 113);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(44, 43);
            this.HomeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomeButton.TabIndex = 47;
            this.HomeButton.TabStop = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(0, 70);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(44, 43);
            this.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackButton.TabIndex = 46;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // button_CANCEL
            // 
            this.button_CANCEL.BackColor = System.Drawing.Color.DarkCyan;
            this.button_CANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_CANCEL.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CANCEL.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_CANCEL.Location = new System.Drawing.Point(459, 401);
            this.button_CANCEL.Name = "button_CANCEL";
            this.button_CANCEL.Size = new System.Drawing.Size(161, 43);
            this.button_CANCEL.TabIndex = 45;
            this.button_CANCEL.Text = "CANCEL";
            this.button_CANCEL.UseVisualStyleBackColor = false;
            this.button_CANCEL.Click += new System.EventHandler(this.button_CANCEL_Click);
            // 
            // button_BOOK
            // 
            this.button_BOOK.BackColor = System.Drawing.Color.DarkCyan;
            this.button_BOOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_BOOK.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BOOK.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_BOOK.Location = new System.Drawing.Point(199, 401);
            this.button_BOOK.Name = "button_BOOK";
            this.button_BOOK.Size = new System.Drawing.Size(161, 43);
            this.button_BOOK.TabIndex = 44;
            this.button_BOOK.Text = "Proceed";
            this.button_BOOK.UseVisualStyleBackColor = false;
            // 
            // Banner
            // 
            this.Banner.Image = ((System.Drawing.Image)(resources.GetObject("Banner.Image")));
            this.Banner.Location = new System.Drawing.Point(0, 0);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(800, 70);
            this.Banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Banner.TabIndex = 43;
            this.Banner.TabStop = false;
            // 
            // ticket_history
            // 
            this.ticket_history.AutoSize = true;
            this.ticket_history.BackColor = System.Drawing.Color.Teal;
            this.ticket_history.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticket_history.ForeColor = System.Drawing.Color.White;
            this.ticket_history.Location = new System.Drawing.Point(83, 89);
            this.ticket_history.Name = "ticket_history";
            this.ticket_history.Size = new System.Drawing.Size(194, 32);
            this.ticket_history.TabIndex = 48;
            this.ticket_history.Text = "Tickets History";
            this.ticket_history.Click += new System.EventHandler(this.ticket_history_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(725, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 27);
            this.label1.TabIndex = 49;
            this.label1.Text = "Log Out";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AdminHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicketBookingSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ticket_history);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.button_CANCEL);
            this.Controls.Add(this.button_BOOK);
            this.Controls.Add(this.Banner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminHomepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket Booking System";
            ((System.ComponentModel.ISupportInitialize)(this.HomeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox HomeButton;
        private System.Windows.Forms.PictureBox BackButton;
        private System.Windows.Forms.Button button_CANCEL;
        private System.Windows.Forms.Button button_BOOK;
        private System.Windows.Forms.PictureBox Banner;
        private System.Windows.Forms.Label ticket_history;
        private System.Windows.Forms.Label label1;
    }
}