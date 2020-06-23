namespace TicketBookingSystem
{
    partial class TicketPageEmergency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketPageEmergency));
            this.Banner = new System.Windows.Forms.PictureBox();
            this.pictureBox_Ticket = new System.Windows.Forms.PictureBox();
            this.button_BOOK = new System.Windows.Forms.Button();
            this.button_CANCEL = new System.Windows.Forms.Button();
            this.label_PREVIEW = new System.Windows.Forms.Label();
            this.lbl_Depart = new System.Windows.Forms.Label();
            this.lbl_Arrive = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Route = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_TicketNo = new System.Windows.Forms.Label();
            this.label_Source = new System.Windows.Forms.Label();
            this.label_Destination = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Route = new System.Windows.Forms.Label();
            this.label_Price = new System.Windows.Forms.Label();
            this.label_TicketNo = new System.Windows.Forms.Label();
            this.label_TICKET = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.PictureBox();
            this.HomeButton = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Distance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_logout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ticket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // Banner
            // 
            this.Banner.Image = ((System.Drawing.Image)(resources.GetObject("Banner.Image")));
            this.Banner.Location = new System.Drawing.Point(0, 0);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(800, 70);
            this.Banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Banner.TabIndex = 2;
            this.Banner.TabStop = false;
            // 
            // pictureBox_Ticket
            // 
            this.pictureBox_Ticket.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Ticket.Image")));
            this.pictureBox_Ticket.Location = new System.Drawing.Point(86, 112);
            this.pictureBox_Ticket.Name = "pictureBox_Ticket";
            this.pictureBox_Ticket.Size = new System.Drawing.Size(637, 282);
            this.pictureBox_Ticket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Ticket.TabIndex = 3;
            this.pictureBox_Ticket.TabStop = false;
            this.pictureBox_Ticket.Click += new System.EventHandler(this.pictureBox_Ticket_Click);
            // 
            // button_BOOK
            // 
            this.button_BOOK.BackColor = System.Drawing.Color.DarkCyan;
            this.button_BOOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_BOOK.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BOOK.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_BOOK.Location = new System.Drawing.Point(195, 403);
            this.button_BOOK.Name = "button_BOOK";
            this.button_BOOK.Size = new System.Drawing.Size(161, 43);
            this.button_BOOK.TabIndex = 6;
            this.button_BOOK.Text = "BOOK";
            this.button_BOOK.UseVisualStyleBackColor = false;
            this.button_BOOK.Click += new System.EventHandler(this.button_BOOK_Click);
            // 
            // button_CANCEL
            // 
            this.button_CANCEL.BackColor = System.Drawing.Color.DarkCyan;
            this.button_CANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_CANCEL.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CANCEL.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_CANCEL.Location = new System.Drawing.Point(455, 403);
            this.button_CANCEL.Name = "button_CANCEL";
            this.button_CANCEL.Size = new System.Drawing.Size(161, 43);
            this.button_CANCEL.TabIndex = 7;
            this.button_CANCEL.Text = "CANCEL";
            this.button_CANCEL.UseVisualStyleBackColor = false;
            this.button_CANCEL.Click += new System.EventHandler(this.button_CANCEL_Click);
            // 
            // label_PREVIEW
            // 
            this.label_PREVIEW.AutoSize = true;
            this.label_PREVIEW.BackColor = System.Drawing.Color.Transparent;
            this.label_PREVIEW.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PREVIEW.ForeColor = System.Drawing.Color.Navy;
            this.label_PREVIEW.Location = new System.Drawing.Point(259, 71);
            this.label_PREVIEW.Name = "label_PREVIEW";
            this.label_PREVIEW.Size = new System.Drawing.Size(299, 43);
            this.label_PREVIEW.TabIndex = 8;
            this.label_PREVIEW.Text = "TICKET PREVIEW";
            // 
            // lbl_Depart
            // 
            this.lbl_Depart.AutoSize = true;
            this.lbl_Depart.BackColor = System.Drawing.Color.White;
            this.lbl_Depart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Depart.ForeColor = System.Drawing.Color.Black;
            this.lbl_Depart.Location = new System.Drawing.Point(143, 206);
            this.lbl_Depart.Name = "lbl_Depart";
            this.lbl_Depart.Size = new System.Drawing.Size(64, 16);
            this.lbl_Depart.TabIndex = 9;
            this.lbl_Depart.Text = "Depart -";
            // 
            // lbl_Arrive
            // 
            this.lbl_Arrive.AutoSize = true;
            this.lbl_Arrive.BackColor = System.Drawing.Color.White;
            this.lbl_Arrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Arrive.ForeColor = System.Drawing.Color.Black;
            this.lbl_Arrive.Location = new System.Drawing.Point(144, 240);
            this.lbl_Arrive.Name = "lbl_Arrive";
            this.lbl_Arrive.Size = new System.Drawing.Size(58, 16);
            this.lbl_Arrive.TabIndex = 9;
            this.lbl_Arrive.Text = "Arrive -";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.White;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.Black;
            this.lbl_Date.Location = new System.Drawing.Point(501, 206);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(50, 16);
            this.lbl_Date.TabIndex = 10;
            this.lbl_Date.Text = "Date -";
            // 
            // lbl_Route
            // 
            this.lbl_Route.AutoSize = true;
            this.lbl_Route.BackColor = System.Drawing.Color.White;
            this.lbl_Route.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Route.ForeColor = System.Drawing.Color.Black;
            this.lbl_Route.Location = new System.Drawing.Point(501, 240);
            this.lbl_Route.Name = "lbl_Route";
            this.lbl_Route.Size = new System.Drawing.Size(58, 16);
            this.lbl_Route.TabIndex = 11;
            this.lbl_Route.Text = "Route -";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.BackColor = System.Drawing.Color.White;
            this.lbl_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.ForeColor = System.Drawing.Color.Black;
            this.lbl_Price.Location = new System.Drawing.Point(616, 285);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(44, 16);
            this.lbl_Price.TabIndex = 12;
            this.lbl_Price.Text = "Price";
            this.lbl_Price.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_TicketNo
            // 
            this.lbl_TicketNo.AutoSize = true;
            this.lbl_TicketNo.BackColor = System.Drawing.Color.White;
            this.lbl_TicketNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TicketNo.ForeColor = System.Drawing.Color.Black;
            this.lbl_TicketNo.Location = new System.Drawing.Point(192, 285);
            this.lbl_TicketNo.Name = "lbl_TicketNo";
            this.lbl_TicketNo.Size = new System.Drawing.Size(109, 16);
            this.lbl_TicketNo.TabIndex = 13;
            this.lbl_TicketNo.Text = "Ticket Number";
            // 
            // label_Source
            // 
            this.label_Source.AutoSize = true;
            this.label_Source.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Source.Location = new System.Drawing.Point(207, 201);
            this.label_Source.Name = "label_Source";
            this.label_Source.Size = new System.Drawing.Size(136, 27);
            this.label_Source.TabIndex = 14;
            this.label_Source.Text = "DEFAULT";
            // 
            // label_Destination
            // 
            this.label_Destination.AutoSize = true;
            this.label_Destination.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Destination.Location = new System.Drawing.Point(207, 235);
            this.label_Destination.Name = "label_Destination";
            this.label_Destination.Size = new System.Drawing.Size(136, 27);
            this.label_Destination.TabIndex = 14;
            this.label_Destination.Text = "DEFAULT";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.Location = new System.Drawing.Point(575, 201);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(136, 27);
            this.label_Date.TabIndex = 15;
            this.label_Date.Text = "DEFAULT";
            // 
            // label_Route
            // 
            this.label_Route.AutoSize = true;
            this.label_Route.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Route.Location = new System.Drawing.Point(575, 235);
            this.label_Route.Name = "label_Route";
            this.label_Route.Size = new System.Drawing.Size(71, 27);
            this.label_Route.TabIndex = 16;
            this.label_Route.Text = "ANY";
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Price.Location = new System.Drawing.Point(622, 306);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(54, 27);
            this.label_Price.TabIndex = 16;
            this.label_Price.Text = "000";
            this.label_Price.Click += new System.EventHandler(this.label9_Click);
            // 
            // label_TicketNo
            // 
            this.label_TicketNo.AutoSize = true;
            this.label_TicketNo.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TicketNo.Location = new System.Drawing.Point(203, 306);
            this.label_TicketNo.Name = "label_TicketNo";
            this.label_TicketNo.Size = new System.Drawing.Size(88, 27);
            this.label_TicketNo.TabIndex = 17;
            this.label_TicketNo.Text = "XXXX";
            // 
            // label_TICKET
            // 
            this.label_TICKET.AutoSize = true;
            this.label_TICKET.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(91)))), ((int)(((byte)(5)))));
            this.label_TICKET.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TICKET.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_TICKET.Location = new System.Drawing.Point(322, 124);
            this.label_TICKET.Name = "label_TICKET";
            this.label_TICKET.Size = new System.Drawing.Size(178, 27);
            this.label_TICKET.TabIndex = 19;
            this.label_TICKET.Text = "EMERGENCY";
            // 
            // BackButton
            // 
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(0, 70);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(44, 43);
            this.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackButton.TabIndex = 18;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.Exit_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.Location = new System.Drawing.Point(0, 113);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(44, 43);
            this.HomeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomeButton.TabIndex = 20;
            this.HomeButton.TabStop = false;
            this.HomeButton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(470, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 27);
            this.label4.TabIndex = 39;
            this.label4.Text = "KM";
            // 
            // label_Distance
            // 
            this.label_Distance.AutoSize = true;
            this.label_Distance.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Distance.Location = new System.Drawing.Point(408, 306);
            this.label_Distance.Name = "label_Distance";
            this.label_Distance.Size = new System.Drawing.Size(54, 27);
            this.label_Distance.TabIndex = 38;
            this.label_Distance.Text = "000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(431, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Distance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(603, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 27);
            this.label3.TabIndex = 40;
            this.label3.Text = "₹";
            // 
            // label_logout
            // 
            this.label_logout.AutoSize = true;
            this.label_logout.BackColor = System.Drawing.Color.Firebrick;
            this.label_logout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_logout.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_logout.ForeColor = System.Drawing.SystemColors.Window;
            this.label_logout.Location = new System.Drawing.Point(725, 70);
            this.label_logout.Name = "label_logout";
            this.label_logout.Size = new System.Drawing.Size(77, 27);
            this.label_logout.TabIndex = 50;
            this.label_logout.Text = "Log Out";
            this.label_logout.Click += new System.EventHandler(this.label2_Click);
            // 
            // TicketPageEmergency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicketBookingSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.label_logout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_Distance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.label_TICKET);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label_TicketNo);
            this.Controls.Add(this.label_Price);
            this.Controls.Add(this.label_Route);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.label_Destination);
            this.Controls.Add(this.label_Source);
            this.Controls.Add(this.lbl_TicketNo);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Route);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Arrive);
            this.Controls.Add(this.lbl_Depart);
            this.Controls.Add(this.button_CANCEL);
            this.Controls.Add(this.button_BOOK);
            this.Controls.Add(this.pictureBox_Ticket);
            this.Controls.Add(this.Banner);
            this.Controls.Add(this.label_PREVIEW);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TicketPageEmergency";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket Booking System";
            this.Load += new System.EventHandler(this.TicketPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ticket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Banner;
        private System.Windows.Forms.PictureBox pictureBox_Ticket;
        private System.Windows.Forms.Button button_BOOK;
        private System.Windows.Forms.Button button_CANCEL;
        private System.Windows.Forms.Label label_PREVIEW;
        private System.Windows.Forms.Label lbl_Depart;
        private System.Windows.Forms.Label lbl_Arrive;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Route;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_TicketNo;
        private System.Windows.Forms.Label label_Source;
        private System.Windows.Forms.Label label_Destination;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_Route;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Label label_TicketNo;
        private System.Windows.Forms.Label label_TICKET;
        private System.Windows.Forms.PictureBox BackButton;
        private System.Windows.Forms.PictureBox HomeButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Distance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_logout;
    }
}