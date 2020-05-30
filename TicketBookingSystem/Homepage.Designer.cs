namespace TicketBookingSystem
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Date = new System.Windows.Forms.Label();
            this.date_Select = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Destination = new System.Windows.Forms.ComboBox();
            this.label_Destination = new System.Windows.Forms.Label();
            this.comboBox_Source = new System.Windows.Forms.ComboBox();
            this.label_Source = new System.Windows.Forms.Label();
            this.Banner = new System.Windows.Forms.PictureBox();
            this.button_BUS = new System.Windows.Forms.Button();
            this.button_TRAIN = new System.Windows.Forms.Button();
            this.button_AIRPLANE = new System.Windows.Forms.Button();
            this.button_EMERGENCY = new System.Windows.Forms.Button();
            this.button_CANCEL = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.Goldenrod;
            this.button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Clear.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.Location = new System.Drawing.Point(563, 124);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(115, 37);
            this.button_Clear.TabIndex = 3;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Search.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.Location = new System.Drawing.Point(563, 182);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(115, 39);
            this.button_Search.TabIndex = 4;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::TicketBookingSystem.Properties.Resources.background;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.label_Date);
            this.groupBox1.Controls.Add(this.date_Select);
            this.groupBox1.Controls.Add(this.comboBox_Destination);
            this.groupBox1.Controls.Add(this.label_Destination);
            this.groupBox1.Controls.Add(this.comboBox_Source);
            this.groupBox1.Controls.Add(this.label_Source);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 208);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ticket Details";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.Location = new System.Drawing.Point(6, 160);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(86, 37);
            this.label_Date.TabIndex = 5;
            this.label_Date.Text = "Date";
            // 
            // date_Select
            // 
            this.date_Select.Cursor = System.Windows.Forms.Cursors.Hand;
            this.date_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_Select.Location = new System.Drawing.Point(224, 166);
            this.date_Select.Name = "date_Select";
            this.date_Select.Size = new System.Drawing.Size(242, 31);
            this.date_Select.TabIndex = 4;
            this.date_Select.ValueChanged += new System.EventHandler(this.date_Select_ValueChanged);
            // 
            // comboBox_Destination
            // 
            this.comboBox_Destination.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Destination.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Destination.FormattingEnabled = true;
            this.comboBox_Destination.Items.AddRange(new object[] {
            "Amritsar",
            "Barauni Jn",
            "Bareilly",
            "Begu Sarai",
            "Gorakh Pur",
            "Hapur",
            "Khagaria Jn",
            "Lucknow",
            "Moradabad",
            "New Delhi",
            "Patna",
            "Saharsa",
            "Samastipur Jn",
            "Simri Bhaktiyarpur"});
            this.comboBox_Destination.Location = new System.Drawing.Point(224, 104);
            this.comboBox_Destination.Name = "comboBox_Destination";
            this.comboBox_Destination.Size = new System.Drawing.Size(242, 37);
            this.comboBox_Destination.TabIndex = 3;
            // 
            // label_Destination
            // 
            this.label_Destination.AutoSize = true;
            this.label_Destination.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Destination.Location = new System.Drawing.Point(0, 100);
            this.label_Destination.Name = "label_Destination";
            this.label_Destination.Size = new System.Drawing.Size(207, 41);
            this.label_Destination.TabIndex = 2;
            this.label_Destination.Text = "Destination";
            // 
            // comboBox_Source
            // 
            this.comboBox_Source.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Source.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Source.FormattingEnabled = true;
            this.comboBox_Source.Items.AddRange(new object[] {
            "Amritsar",
            "Barauni Jn",
            "Bareilly",
            "Begu Sarai",
            "Gorakh Pur",
            "Hapur",
            "Khagaria Jn",
            "Lucknow",
            "Moradabad",
            "New Delhi",
            "Patna",
            "Saharsa",
            "Samastipur Jn",
            "Simri Bhaktiyarpur"});
            this.comboBox_Source.Location = new System.Drawing.Point(224, 47);
            this.comboBox_Source.Name = "comboBox_Source";
            this.comboBox_Source.Size = new System.Drawing.Size(242, 37);
            this.comboBox_Source.TabIndex = 1;
            // 
            // label_Source
            // 
            this.label_Source.AutoSize = true;
            this.label_Source.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Source.Location = new System.Drawing.Point(0, 43);
            this.label_Source.Name = "label_Source";
            this.label_Source.Size = new System.Drawing.Size(127, 41);
            this.label_Source.TabIndex = 0;
            this.label_Source.Text = "Source";
            // 
            // Banner
            // 
            this.Banner.Image = ((System.Drawing.Image)(resources.GetObject("Banner.Image")));
            this.Banner.Location = new System.Drawing.Point(0, 0);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(800, 70);
            this.Banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Banner.TabIndex = 1;
            this.Banner.TabStop = false;
            // 
            // button_BUS
            // 
            this.button_BUS.BackColor = System.Drawing.Color.DarkCyan;
            this.button_BUS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_BUS.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BUS.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_BUS.Location = new System.Drawing.Point(48, 331);
            this.button_BUS.Name = "button_BUS";
            this.button_BUS.Size = new System.Drawing.Size(161, 43);
            this.button_BUS.TabIndex = 5;
            this.button_BUS.Text = "BUS";
            this.button_BUS.UseVisualStyleBackColor = false;
            this.button_BUS.Click += new System.EventHandler(this.button_BUS_Click);
            // 
            // button_TRAIN
            // 
            this.button_TRAIN.BackColor = System.Drawing.Color.DarkCyan;
            this.button_TRAIN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_TRAIN.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TRAIN.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_TRAIN.Location = new System.Drawing.Point(317, 331);
            this.button_TRAIN.Name = "button_TRAIN";
            this.button_TRAIN.Size = new System.Drawing.Size(161, 43);
            this.button_TRAIN.TabIndex = 5;
            this.button_TRAIN.Text = "TRAIN";
            this.button_TRAIN.UseVisualStyleBackColor = false;
            this.button_TRAIN.Click += new System.EventHandler(this.button_TRAIN_Click);
            // 
            // button_AIRPLANE
            // 
            this.button_AIRPLANE.BackColor = System.Drawing.Color.DarkCyan;
            this.button_AIRPLANE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_AIRPLANE.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AIRPLANE.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_AIRPLANE.Location = new System.Drawing.Point(601, 331);
            this.button_AIRPLANE.Name = "button_AIRPLANE";
            this.button_AIRPLANE.Size = new System.Drawing.Size(161, 43);
            this.button_AIRPLANE.TabIndex = 5;
            this.button_AIRPLANE.Text = "AIRPLANE";
            this.button_AIRPLANE.UseVisualStyleBackColor = false;
            this.button_AIRPLANE.Click += new System.EventHandler(this.button_AIRPLANE_Click);
            // 
            // button_EMERGENCY
            // 
            this.button_EMERGENCY.BackColor = System.Drawing.Color.Brown;
            this.button_EMERGENCY.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_EMERGENCY.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_EMERGENCY.ForeColor = System.Drawing.Color.White;
            this.button_EMERGENCY.Location = new System.Drawing.Point(292, 399);
            this.button_EMERGENCY.Name = "button_EMERGENCY";
            this.button_EMERGENCY.Size = new System.Drawing.Size(207, 43);
            this.button_EMERGENCY.TabIndex = 5;
            this.button_EMERGENCY.Text = "EMERGENCY";
            this.button_EMERGENCY.UseVisualStyleBackColor = false;
            this.button_EMERGENCY.Click += new System.EventHandler(this.button_EMERGENCY_Click);
            // 
            // button_CANCEL
            // 
            this.button_CANCEL.BackColor = System.Drawing.Color.IndianRed;
            this.button_CANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_CANCEL.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CANCEL.ForeColor = System.Drawing.Color.Black;
            this.button_CANCEL.Location = new System.Drawing.Point(563, 238);
            this.button_CANCEL.Name = "button_CANCEL";
            this.button_CANCEL.Size = new System.Drawing.Size(115, 37);
            this.button_CANCEL.TabIndex = 8;
            this.button_CANCEL.Text = "Cancel";
            this.button_CANCEL.UseVisualStyleBackColor = false;
            this.button_CANCEL.Click += new System.EventHandler(this.button_CANCEL_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicketBookingSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.button_CANCEL);
            this.Controls.Add(this.button_EMERGENCY);
            this.Controls.Add(this.button_AIRPLANE);
            this.Controls.Add(this.button_TRAIN);
            this.Controls.Add(this.button_BUS);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Banner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket Booking System";
            this.Load += new System.EventHandler(this.TicketHomepage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_Destination;
        private System.Windows.Forms.Label label_Destination;
        private System.Windows.Forms.ComboBox comboBox_Source;
        private System.Windows.Forms.Label label_Source;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.DateTimePicker date_Select;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.PictureBox Banner;
        private System.Windows.Forms.Button button_BUS;
        private System.Windows.Forms.Button button_TRAIN;
        private System.Windows.Forms.Button button_AIRPLANE;
        private System.Windows.Forms.Button button_EMERGENCY;
        private System.Windows.Forms.Button button_CANCEL;
    }
}

