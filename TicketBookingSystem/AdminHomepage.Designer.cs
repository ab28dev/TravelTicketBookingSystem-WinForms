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
            this.BackButton = new System.Windows.Forms.PictureBox();
            this.Banner = new System.Windows.Forms.PictureBox();
            this.all_tickets = new System.Windows.Forms.Label();
            this.label_logout = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_T1 = new System.Windows.Forms.Label();
            this.label_T2 = new System.Windows.Forms.Label();
            this.label_T3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_T4 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.this_month = new System.Windows.Forms.Label();
            this.this_year = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.today = new System.Windows.Forms.Label();
            this.CustomRange = new System.Windows.Forms.Label();
            this.dateTime_from = new System.Windows.Forms.DateTimePicker();
            this.dateTime_to = new System.Windows.Forms.DateTimePicker();
            this.go = new System.Windows.Forms.Label();
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
            this.BackButton.TabIndex = 46;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
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
            // all_tickets
            // 
            this.all_tickets.AutoSize = true;
            this.all_tickets.BackColor = System.Drawing.Color.Teal;
            this.all_tickets.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all_tickets.ForeColor = System.Drawing.Color.White;
            this.all_tickets.Location = new System.Drawing.Point(528, 303);
            this.all_tickets.Name = "all_tickets";
            this.all_tickets.Size = new System.Drawing.Size(139, 32);
            this.all_tickets.TabIndex = 48;
            this.all_tickets.Text = "All Tickets";
            this.all_tickets.Click += new System.EventHandler(this.ticket_history_Click);
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
            this.label_logout.TabIndex = 49;
            this.label_logout.Text = "Log Out";
            this.label_logout.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "Tickets Booked Today - ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "Tickets Booked This Month - ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "Tickets Booked This Year - ";
            // 
            // label_T1
            // 
            this.label_T1.AutoSize = true;
            this.label_T1.BackColor = System.Drawing.Color.White;
            this.label_T1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_T1.Location = new System.Drawing.Point(313, 174);
            this.label_T1.Name = "label_T1";
            this.label_T1.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.label_T1.Size = new System.Drawing.Size(48, 25);
            this.label_T1.TabIndex = 53;
            this.label_T1.Text = "t";
            this.label_T1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_T2
            // 
            this.label_T2.AutoSize = true;
            this.label_T2.BackColor = System.Drawing.Color.White;
            this.label_T2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_T2.Location = new System.Drawing.Point(361, 218);
            this.label_T2.Name = "label_T2";
            this.label_T2.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.label_T2.Size = new System.Drawing.Size(48, 25);
            this.label_T2.TabIndex = 54;
            this.label_T2.Text = "t";
            this.label_T2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_T3
            // 
            this.label_T3.AutoSize = true;
            this.label_T3.BackColor = System.Drawing.Color.White;
            this.label_T3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_T3.Location = new System.Drawing.Point(346, 263);
            this.label_T3.Name = "label_T3";
            this.label_T3.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.label_T3.Size = new System.Drawing.Size(48, 25);
            this.label_T3.TabIndex = 55;
            this.label_T3.Text = "t";
            this.label_T3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(78, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 25);
            this.label7.TabIndex = 56;
            this.label7.Text = "Total Tickets Booked - ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label_T4
            // 
            this.label_T4.AutoSize = true;
            this.label_T4.BackColor = System.Drawing.Color.White;
            this.label_T4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_T4.Location = new System.Drawing.Point(300, 310);
            this.label_T4.Name = "label_T4";
            this.label_T4.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.label_T4.Size = new System.Drawing.Size(48, 25);
            this.label_T4.TabIndex = 57;
            this.label_T4.Text = "t";
            this.label_T4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(528, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 32);
            this.label4.TabIndex = 58;
            // 
            // this_month
            // 
            this.this_month.AutoSize = true;
            this.this_month.BackColor = System.Drawing.Color.Teal;
            this.this_month.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.this_month.ForeColor = System.Drawing.Color.White;
            this.this_month.Location = new System.Drawing.Point(528, 211);
            this.this_month.Name = "this_month";
            this.this_month.Size = new System.Drawing.Size(150, 32);
            this.this_month.TabIndex = 59;
            this.this_month.Text = "This Month";
            this.this_month.Click += new System.EventHandler(this.this_month_Click);
            // 
            // this_year
            // 
            this.this_year.AutoSize = true;
            this.this_year.BackColor = System.Drawing.Color.Teal;
            this.this_year.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.this_year.ForeColor = System.Drawing.Color.White;
            this.this_year.Location = new System.Drawing.Point(528, 256);
            this.this_year.Name = "this_year";
            this.this_year.Size = new System.Drawing.Size(129, 32);
            this.this_year.TabIndex = 60;
            this.this_year.Text = "This Year";
            this.this_year.Click += new System.EventHandler(this.this_year_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(528, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 32);
            this.label8.TabIndex = 61;
            this.label8.Text = "Tickets History";
            // 
            // today
            // 
            this.today.AutoSize = true;
            this.today.BackColor = System.Drawing.Color.Teal;
            this.today.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.today.ForeColor = System.Drawing.Color.White;
            this.today.Location = new System.Drawing.Point(528, 168);
            this.today.Name = "today";
            this.today.Size = new System.Drawing.Size(87, 32);
            this.today.TabIndex = 62;
            this.today.Text = "Today";
            this.today.Click += new System.EventHandler(this.today_Click);
            // 
            // CustomRange
            // 
            this.CustomRange.AutoSize = true;
            this.CustomRange.BackColor = System.Drawing.Color.Teal;
            this.CustomRange.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomRange.ForeColor = System.Drawing.Color.White;
            this.CustomRange.Location = new System.Drawing.Point(528, 354);
            this.CustomRange.Name = "CustomRange";
            this.CustomRange.Size = new System.Drawing.Size(197, 32);
            this.CustomRange.TabIndex = 63;
            this.CustomRange.Text = "Custom Range";
            this.CustomRange.Click += new System.EventHandler(this.CustomRange_Click);
            // 
            // dateTime_from
            // 
            this.dateTime_from.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_from.Location = new System.Drawing.Point(12, 356);
            this.dateTime_from.Name = "dateTime_from";
            this.dateTime_from.Size = new System.Drawing.Size(187, 26);
            this.dateTime_from.TabIndex = 64;
            this.dateTime_from.Value = new System.DateTime(2020, 7, 17, 0, 0, 0, 0);
            this.dateTime_from.ValueChanged += new System.EventHandler(this.dateTime_from_ValueChanged);
            // 
            // dateTime_to
            // 
            this.dateTime_to.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_to.Location = new System.Drawing.Point(229, 357);
            this.dateTime_to.Name = "dateTime_to";
            this.dateTime_to.Size = new System.Drawing.Size(180, 26);
            this.dateTime_to.TabIndex = 65;
            this.dateTime_to.Value = new System.DateTime(2020, 7, 17, 0, 0, 0, 0);
            // 
            // go
            // 
            this.go.AutoSize = true;
            this.go.BackColor = System.Drawing.Color.SteelBlue;
            this.go.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.go.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go.ForeColor = System.Drawing.Color.White;
            this.go.Location = new System.Drawing.Point(442, 358);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(46, 27);
            this.go.TabIndex = 66;
            this.go.Text = "GO";
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // AdminHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicketBookingSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.go);
            this.Controls.Add(this.dateTime_to);
            this.Controls.Add(this.dateTime_from);
            this.Controls.Add(this.CustomRange);
            this.Controls.Add(this.today);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.this_year);
            this.Controls.Add(this.this_month);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_T4);
            this.Controls.Add(this.label_T3);
            this.Controls.Add(this.label_T2);
            this.Controls.Add(this.label_T1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_logout);
            this.Controls.Add(this.all_tickets);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.Banner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminHomepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket Booking System";
            this.Load += new System.EventHandler(this.AdminHomepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox BackButton;
        private System.Windows.Forms.PictureBox Banner;
        private System.Windows.Forms.Label all_tickets;
        private System.Windows.Forms.Label label_logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_T1;
        private System.Windows.Forms.Label label_T2;
        private System.Windows.Forms.Label label_T3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_T4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label this_month;
        private System.Windows.Forms.Label this_year;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label today;
        private System.Windows.Forms.Label CustomRange;
        private System.Windows.Forms.DateTimePicker dateTime_from;
        private System.Windows.Forms.DateTimePicker dateTime_to;
        private System.Windows.Forms.Label go;
    }
}