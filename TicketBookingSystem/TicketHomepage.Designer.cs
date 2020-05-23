namespace TicketBookingSystem
{
    partial class TicketHomepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketHomepage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Date = new System.Windows.Forms.Label();
            this.date_Select = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Destination = new System.Windows.Forms.ComboBox();
            this.label_Destination = new System.Windows.Forms.Label();
            this.comboBox_Source = new System.Windows.Forms.ComboBox();
            this.label_Source = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 146);
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
            this.date_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_Select.Location = new System.Drawing.Point(224, 166);
            this.date_Select.Name = "date_Select";
            this.date_Select.Size = new System.Drawing.Size(242, 31);
            this.date_Select.TabIndex = 4;
            // 
            // comboBox_Destination
            // 
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
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.Goldenrod;
            this.button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Clear.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.Location = new System.Drawing.Point(566, 208);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(115, 44);
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
            this.button_Search.Location = new System.Drawing.Point(566, 272);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(115, 44);
            this.button_Search.TabIndex = 4;
            this.button_Search.Text = "Search]";
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 649);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // TicketHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TicketHomepage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TicketHomepage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

