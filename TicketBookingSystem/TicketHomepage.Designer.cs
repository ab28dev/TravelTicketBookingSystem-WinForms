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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Source = new System.Windows.Forms.Label();
            this.label_destination = new System.Windows.Forms.Label();
            this.comboBox_Source = new System.Windows.Forms.ComboBox();
            this.comboBox_Destination = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_Source
            // 
            this.label_Source.AutoSize = true;
            this.label_Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Source.Location = new System.Drawing.Point(41, 110);
            this.label_Source.Name = "label_Source";
            this.label_Source.Size = new System.Drawing.Size(80, 25);
            this.label_Source.TabIndex = 1;
            this.label_Source.Text = "Source";
            // 
            // label_destination
            // 
            this.label_destination.AutoSize = true;
            this.label_destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_destination.Location = new System.Drawing.Point(423, 110);
            this.label_destination.Name = "label_destination";
            this.label_destination.Size = new System.Drawing.Size(120, 25);
            this.label_destination.TabIndex = 1;
            this.label_destination.Text = "Destination";
            this.label_destination.Click += new System.EventHandler(this.label_destination_Click);
            // 
            // comboBox_Source
            // 
            this.comboBox_Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.comboBox_Source.Location = new System.Drawing.Point(151, 107);
            this.comboBox_Source.Name = "comboBox_Source";
            this.comboBox_Source.Size = new System.Drawing.Size(180, 28);
            this.comboBox_Source.TabIndex = 2;
            // 
            // comboBox_Destination
            // 
            this.comboBox_Destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.comboBox_Destination.Location = new System.Drawing.Point(581, 107);
            this.comboBox_Destination.Name = "comboBox_Destination";
            this.comboBox_Destination.Size = new System.Drawing.Size(180, 28);
            this.comboBox_Destination.TabIndex = 2;
            // 
            // datePicker
            // 
            this.datePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Location = new System.Drawing.Point(151, 161);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(179, 24);
            this.datePicker.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            this.label1.Click += new System.EventHandler(this.label_destination_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(431, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Proceed";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(629, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // TicketHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.comboBox_Destination);
            this.Controls.Add(this.comboBox_Source);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_destination);
            this.Controls.Add(this.label_Source);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TicketHomepage";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Source;
        private System.Windows.Forms.ComboBox comboBox_Source;
        private System.Windows.Forms.ComboBox comboBox_Destination;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_destination;
    }
}

