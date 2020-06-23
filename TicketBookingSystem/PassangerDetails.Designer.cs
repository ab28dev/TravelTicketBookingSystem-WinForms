namespace TicketBookingSystem
{
    partial class PassangerDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassangerDetails));
            this.Banner = new System.Windows.Forms.PictureBox();
            this.class_AIR = new System.Windows.Forms.ComboBox();
            this.label_Source = new System.Windows.Forms.Label();
            this.button_CANCEL = new System.Windows.Forms.Button();
            this.button_BOOK = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.PictureBox();
            this.textBox_tick = new System.Windows.Forms.TextBox();
            this.checkBox_p4 = new System.Windows.Forms.CheckBox();
            this.checkBox_p3 = new System.Windows.Forms.CheckBox();
            this.checkBox_p2 = new System.Windows.Forms.CheckBox();
            this.checkBox_p1 = new System.Windows.Forms.CheckBox();
            this.groupBox_Details = new System.Windows.Forms.GroupBox();
            this.comboBox_p4_food = new System.Windows.Forms.ComboBox();
            this.comboBox_p3_food = new System.Windows.Forms.ComboBox();
            this.comboBox_p2_food = new System.Windows.Forms.ComboBox();
            this.comboBox_p1_food = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_p4_gender = new System.Windows.Forms.ComboBox();
            this.comboBox_p3_gender = new System.Windows.Forms.ComboBox();
            this.comboBox_p2_gender = new System.Windows.Forms.ComboBox();
            this.comboBox_p1_gender = new System.Windows.Forms.ComboBox();
            this.textBox_p4_age = new System.Windows.Forms.TextBox();
            this.textBox_p3_age = new System.Windows.Forms.TextBox();
            this.textBox_p2_age = new System.Windows.Forms.TextBox();
            this.textBox_p1_age = new System.Windows.Forms.TextBox();
            this.textBox_p4_name = new System.Windows.Forms.TextBox();
            this.textBox_p3_name = new System.Windows.Forms.TextBox();
            this.textBox_p2_name = new System.Windows.Forms.TextBox();
            this.textBox_p1_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Depart = new System.Windows.Forms.Label();
            this.class_BUS = new System.Windows.Forms.ComboBox();
            this.class_TRAIN = new System.Windows.Forms.ComboBox();
            this.class_EMERGENCY = new System.Windows.Forms.ComboBox();
            this.label_logout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            this.groupBox_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // Banner
            // 
            this.Banner.Image = ((System.Drawing.Image)(resources.GetObject("Banner.Image")));
            this.Banner.Location = new System.Drawing.Point(-1, 0);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(800, 70);
            this.Banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Banner.TabIndex = 2;
            this.Banner.TabStop = false;
            // 
            // class_AIR
            // 
            this.class_AIR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.class_AIR.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.class_AIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_AIR.FormattingEnabled = true;
            this.class_AIR.Items.AddRange(new object[] {
            "Economy",
            "Business"});
            this.class_AIR.Location = new System.Drawing.Point(183, 80);
            this.class_AIR.Name = "class_AIR";
            this.class_AIR.Size = new System.Drawing.Size(144, 37);
            this.class_AIR.TabIndex = 4;
            // 
            // label_Source
            // 
            this.label_Source.AutoSize = true;
            this.label_Source.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Source.Location = new System.Drawing.Point(62, 76);
            this.label_Source.Name = "label_Source";
            this.label_Source.Size = new System.Drawing.Size(100, 41);
            this.label_Source.TabIndex = 3;
            this.label_Source.Text = "Class";
            // 
            // button_CANCEL
            // 
            this.button_CANCEL.BackColor = System.Drawing.Color.DarkCyan;
            this.button_CANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_CANCEL.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CANCEL.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_CANCEL.Location = new System.Drawing.Point(458, 401);
            this.button_CANCEL.Name = "button_CANCEL";
            this.button_CANCEL.Size = new System.Drawing.Size(161, 43);
            this.button_CANCEL.TabIndex = 29;
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
            this.button_BOOK.Location = new System.Drawing.Point(198, 401);
            this.button_BOOK.Name = "button_BOOK";
            this.button_BOOK.Size = new System.Drawing.Size(161, 43);
            this.button_BOOK.TabIndex = 28;
            this.button_BOOK.Text = "Proceed";
            this.button_BOOK.UseVisualStyleBackColor = false;
            this.button_BOOK.Click += new System.EventHandler(this.button_BOOK_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.Location = new System.Drawing.Point(-1, 113);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(44, 43);
            this.HomeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomeButton.TabIndex = 42;
            this.HomeButton.TabStop = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(-1, 70);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(44, 43);
            this.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackButton.TabIndex = 41;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // textBox_tick
            // 
            this.textBox_tick.Location = new System.Drawing.Point(1, 158);
            this.textBox_tick.Multiline = true;
            this.textBox_tick.Name = "textBox_tick";
            this.textBox_tick.Size = new System.Drawing.Size(67, 47);
            this.textBox_tick.TabIndex = 58;
            this.textBox_tick.Text = "Tick the Box\r\n     to add \r\n  Passanger";
            // 
            // checkBox_p4
            // 
            this.checkBox_p4.AutoSize = true;
            this.checkBox_p4.Location = new System.Drawing.Point(30, 368);
            this.checkBox_p4.Name = "checkBox_p4";
            this.checkBox_p4.Size = new System.Drawing.Size(15, 14);
            this.checkBox_p4.TabIndex = 57;
            this.checkBox_p4.UseVisualStyleBackColor = true;
            this.checkBox_p4.CheckedChanged += new System.EventHandler(this.checkBox_p4_CheckedChanged);
            // 
            // checkBox_p3
            // 
            this.checkBox_p3.AutoSize = true;
            this.checkBox_p3.Location = new System.Drawing.Point(30, 318);
            this.checkBox_p3.Name = "checkBox_p3";
            this.checkBox_p3.Size = new System.Drawing.Size(15, 14);
            this.checkBox_p3.TabIndex = 56;
            this.checkBox_p3.UseVisualStyleBackColor = true;
            this.checkBox_p3.CheckedChanged += new System.EventHandler(this.checkBox_p3_CheckedChanged);
            // 
            // checkBox_p2
            // 
            this.checkBox_p2.AutoSize = true;
            this.checkBox_p2.Location = new System.Drawing.Point(30, 266);
            this.checkBox_p2.Name = "checkBox_p2";
            this.checkBox_p2.Size = new System.Drawing.Size(15, 14);
            this.checkBox_p2.TabIndex = 55;
            this.checkBox_p2.UseVisualStyleBackColor = true;
            this.checkBox_p2.CheckedChanged += new System.EventHandler(this.checkBox_p2_CheckedChanged);
            // 
            // checkBox_p1
            // 
            this.checkBox_p1.AutoSize = true;
            this.checkBox_p1.Location = new System.Drawing.Point(30, 217);
            this.checkBox_p1.Name = "checkBox_p1";
            this.checkBox_p1.Size = new System.Drawing.Size(15, 14);
            this.checkBox_p1.TabIndex = 54;
            this.checkBox_p1.UseVisualStyleBackColor = true;
            this.checkBox_p1.CheckedChanged += new System.EventHandler(this.checkBox_p1_CheckedChanged);
            // 
            // groupBox_Details
            // 
            this.groupBox_Details.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Details.Controls.Add(this.comboBox_p4_food);
            this.groupBox_Details.Controls.Add(this.comboBox_p3_food);
            this.groupBox_Details.Controls.Add(this.comboBox_p2_food);
            this.groupBox_Details.Controls.Add(this.comboBox_p1_food);
            this.groupBox_Details.Controls.Add(this.label3);
            this.groupBox_Details.Controls.Add(this.comboBox_p4_gender);
            this.groupBox_Details.Controls.Add(this.comboBox_p3_gender);
            this.groupBox_Details.Controls.Add(this.comboBox_p2_gender);
            this.groupBox_Details.Controls.Add(this.comboBox_p1_gender);
            this.groupBox_Details.Controls.Add(this.textBox_p4_age);
            this.groupBox_Details.Controls.Add(this.textBox_p3_age);
            this.groupBox_Details.Controls.Add(this.textBox_p2_age);
            this.groupBox_Details.Controls.Add(this.textBox_p1_age);
            this.groupBox_Details.Controls.Add(this.textBox_p4_name);
            this.groupBox_Details.Controls.Add(this.textBox_p3_name);
            this.groupBox_Details.Controls.Add(this.textBox_p2_name);
            this.groupBox_Details.Controls.Add(this.textBox_p1_name);
            this.groupBox_Details.Controls.Add(this.label2);
            this.groupBox_Details.Controls.Add(this.label1);
            this.groupBox_Details.Controls.Add(this.lbl_Depart);
            this.groupBox_Details.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Details.Location = new System.Drawing.Point(66, 134);
            this.groupBox_Details.Name = "groupBox_Details";
            this.groupBox_Details.Size = new System.Drawing.Size(729, 262);
            this.groupBox_Details.TabIndex = 53;
            this.groupBox_Details.TabStop = false;
            this.groupBox_Details.Text = "Passanger Details";
            // 
            // comboBox_p4_food
            // 
            this.comboBox_p4_food.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_p4_food.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_p4_food.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_p4_food.FormattingEnabled = true;
            this.comboBox_p4_food.Items.AddRange(new object[] {
            "Veg",
            "Non-Veg"});
            this.comboBox_p4_food.Location = new System.Drawing.Point(612, 220);
            this.comboBox_p4_food.Name = "comboBox_p4_food";
            this.comboBox_p4_food.Size = new System.Drawing.Size(110, 33);
            this.comboBox_p4_food.TabIndex = 45;
            this.comboBox_p4_food.Text = "None";
            // 
            // comboBox_p3_food
            // 
            this.comboBox_p3_food.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_p3_food.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_p3_food.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_p3_food.FormattingEnabled = true;
            this.comboBox_p3_food.Items.AddRange(new object[] {
            "Veg",
            "Non-Veg"});
            this.comboBox_p3_food.Location = new System.Drawing.Point(612, 172);
            this.comboBox_p3_food.Name = "comboBox_p3_food";
            this.comboBox_p3_food.Size = new System.Drawing.Size(110, 33);
            this.comboBox_p3_food.TabIndex = 44;
            this.comboBox_p3_food.Text = "None";
            // 
            // comboBox_p2_food
            // 
            this.comboBox_p2_food.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_p2_food.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_p2_food.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_p2_food.FormattingEnabled = true;
            this.comboBox_p2_food.Items.AddRange(new object[] {
            "Veg",
            "Non-Veg"});
            this.comboBox_p2_food.Location = new System.Drawing.Point(612, 120);
            this.comboBox_p2_food.Name = "comboBox_p2_food";
            this.comboBox_p2_food.Size = new System.Drawing.Size(110, 33);
            this.comboBox_p2_food.TabIndex = 43;
            this.comboBox_p2_food.Text = "None";
            // 
            // comboBox_p1_food
            // 
            this.comboBox_p1_food.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_p1_food.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_p1_food.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_p1_food.FormattingEnabled = true;
            this.comboBox_p1_food.Items.AddRange(new object[] {
            "Veg",
            "Non-Veg"});
            this.comboBox_p1_food.Location = new System.Drawing.Point(612, 71);
            this.comboBox_p1_food.Name = "comboBox_p1_food";
            this.comboBox_p1_food.Size = new System.Drawing.Size(110, 33);
            this.comboBox_p1_food.TabIndex = 42;
            this.comboBox_p1_food.Text = "None";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(645, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Food";
            // 
            // comboBox_p4_gender
            // 
            this.comboBox_p4_gender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_p4_gender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_p4_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_p4_gender.FormattingEnabled = true;
            this.comboBox_p4_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.comboBox_p4_gender.Location = new System.Drawing.Point(471, 222);
            this.comboBox_p4_gender.Name = "comboBox_p4_gender";
            this.comboBox_p4_gender.Size = new System.Drawing.Size(93, 33);
            this.comboBox_p4_gender.TabIndex = 40;
            // 
            // comboBox_p3_gender
            // 
            this.comboBox_p3_gender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_p3_gender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_p3_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_p3_gender.FormattingEnabled = true;
            this.comboBox_p3_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.comboBox_p3_gender.Location = new System.Drawing.Point(471, 172);
            this.comboBox_p3_gender.Name = "comboBox_p3_gender";
            this.comboBox_p3_gender.Size = new System.Drawing.Size(93, 33);
            this.comboBox_p3_gender.TabIndex = 39;
            // 
            // comboBox_p2_gender
            // 
            this.comboBox_p2_gender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_p2_gender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_p2_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_p2_gender.FormattingEnabled = true;
            this.comboBox_p2_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.comboBox_p2_gender.Location = new System.Drawing.Point(471, 120);
            this.comboBox_p2_gender.Name = "comboBox_p2_gender";
            this.comboBox_p2_gender.Size = new System.Drawing.Size(93, 33);
            this.comboBox_p2_gender.TabIndex = 38;
            // 
            // comboBox_p1_gender
            // 
            this.comboBox_p1_gender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_p1_gender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_p1_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_p1_gender.FormattingEnabled = true;
            this.comboBox_p1_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.comboBox_p1_gender.Location = new System.Drawing.Point(471, 71);
            this.comboBox_p1_gender.Name = "comboBox_p1_gender";
            this.comboBox_p1_gender.Size = new System.Drawing.Size(93, 33);
            this.comboBox_p1_gender.TabIndex = 8;
            // 
            // textBox_p4_age
            // 
            this.textBox_p4_age.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_p4_age.Location = new System.Drawing.Point(308, 220);
            this.textBox_p4_age.Name = "textBox_p4_age";
            this.textBox_p4_age.Size = new System.Drawing.Size(78, 36);
            this.textBox_p4_age.TabIndex = 37;
            this.textBox_p4_age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_p4_age_KeyPress);
            // 
            // textBox_p3_age
            // 
            this.textBox_p3_age.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_p3_age.Location = new System.Drawing.Point(308, 170);
            this.textBox_p3_age.Name = "textBox_p3_age";
            this.textBox_p3_age.Size = new System.Drawing.Size(78, 36);
            this.textBox_p3_age.TabIndex = 36;
            this.textBox_p3_age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_p3_age_KeyPress);
            // 
            // textBox_p2_age
            // 
            this.textBox_p2_age.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_p2_age.Location = new System.Drawing.Point(308, 118);
            this.textBox_p2_age.Name = "textBox_p2_age";
            this.textBox_p2_age.Size = new System.Drawing.Size(78, 36);
            this.textBox_p2_age.TabIndex = 35;
            this.textBox_p2_age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_p2_age_KeyPress);
            // 
            // textBox_p1_age
            // 
            this.textBox_p1_age.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_p1_age.Location = new System.Drawing.Point(308, 69);
            this.textBox_p1_age.Name = "textBox_p1_age";
            this.textBox_p1_age.Size = new System.Drawing.Size(78, 36);
            this.textBox_p1_age.TabIndex = 34;
            this.textBox_p1_age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_p1_age_KeyPress);
            // 
            // textBox_p4_name
            // 
            this.textBox_p4_name.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_p4_name.Location = new System.Drawing.Point(6, 220);
            this.textBox_p4_name.Name = "textBox_p4_name";
            this.textBox_p4_name.Size = new System.Drawing.Size(255, 36);
            this.textBox_p4_name.TabIndex = 33;
            // 
            // textBox_p3_name
            // 
            this.textBox_p3_name.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_p3_name.Location = new System.Drawing.Point(6, 170);
            this.textBox_p3_name.Name = "textBox_p3_name";
            this.textBox_p3_name.Size = new System.Drawing.Size(255, 36);
            this.textBox_p3_name.TabIndex = 32;
            // 
            // textBox_p2_name
            // 
            this.textBox_p2_name.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_p2_name.Location = new System.Drawing.Point(6, 118);
            this.textBox_p2_name.Name = "textBox_p2_name";
            this.textBox_p2_name.Size = new System.Drawing.Size(255, 36);
            this.textBox_p2_name.TabIndex = 31;
            // 
            // textBox_p1_name
            // 
            this.textBox_p1_name.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_p1_name.Location = new System.Drawing.Point(6, 69);
            this.textBox_p1_name.Name = "textBox_p1_name";
            this.textBox_p1_name.Size = new System.Drawing.Size(255, 36);
            this.textBox_p1_name.TabIndex = 30;
            this.textBox_p1_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_p1_name_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(488, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Gender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(325, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Age";
            // 
            // lbl_Depart
            // 
            this.lbl_Depart.AutoSize = true;
            this.lbl_Depart.BackColor = System.Drawing.Color.White;
            this.lbl_Depart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Depart.ForeColor = System.Drawing.Color.Black;
            this.lbl_Depart.Location = new System.Drawing.Point(112, 40);
            this.lbl_Depart.Name = "lbl_Depart";
            this.lbl_Depart.Size = new System.Drawing.Size(49, 16);
            this.lbl_Depart.TabIndex = 27;
            this.lbl_Depart.Text = "Name";
            // 
            // class_BUS
            // 
            this.class_BUS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.class_BUS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.class_BUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_BUS.FormattingEnabled = true;
            this.class_BUS.Items.AddRange(new object[] {
            "AC",
            "NON-AC"});
            this.class_BUS.Location = new System.Drawing.Point(183, 80);
            this.class_BUS.Name = "class_BUS";
            this.class_BUS.Size = new System.Drawing.Size(109, 37);
            this.class_BUS.TabIndex = 59;
            // 
            // class_TRAIN
            // 
            this.class_TRAIN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.class_TRAIN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.class_TRAIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_TRAIN.FormattingEnabled = true;
            this.class_TRAIN.Items.AddRange(new object[] {
            "CC",
            "SL",
            "3A",
            "2A",
            "1A"});
            this.class_TRAIN.Location = new System.Drawing.Point(183, 80);
            this.class_TRAIN.Name = "class_TRAIN";
            this.class_TRAIN.Size = new System.Drawing.Size(66, 37);
            this.class_TRAIN.TabIndex = 60;
            // 
            // class_EMERGENCY
            // 
            this.class_EMERGENCY.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.class_EMERGENCY.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.class_EMERGENCY.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_EMERGENCY.FormattingEnabled = true;
            this.class_EMERGENCY.Items.AddRange(new object[] {
            "Economy",
            "Business"});
            this.class_EMERGENCY.Location = new System.Drawing.Point(183, 80);
            this.class_EMERGENCY.Name = "class_EMERGENCY";
            this.class_EMERGENCY.Size = new System.Drawing.Size(144, 37);
            this.class_EMERGENCY.TabIndex = 61;
            // 
            // label_logout
            // 
            this.label_logout.AutoSize = true;
            this.label_logout.BackColor = System.Drawing.Color.Firebrick;
            this.label_logout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_logout.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_logout.ForeColor = System.Drawing.SystemColors.Window;
            this.label_logout.Location = new System.Drawing.Point(724, 70);
            this.label_logout.Name = "label_logout";
            this.label_logout.Size = new System.Drawing.Size(77, 27);
            this.label_logout.TabIndex = 62;
            this.label_logout.Text = "Log Out";
            this.label_logout.Click += new System.EventHandler(this.label4_Click);
            // 
            // PassangerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicketBookingSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_logout);
            this.Controls.Add(this.class_EMERGENCY);
            this.Controls.Add(this.class_TRAIN);
            this.Controls.Add(this.class_BUS);
            this.Controls.Add(this.textBox_tick);
            this.Controls.Add(this.checkBox_p4);
            this.Controls.Add(this.checkBox_p3);
            this.Controls.Add(this.checkBox_p2);
            this.Controls.Add(this.checkBox_p1);
            this.Controls.Add(this.groupBox_Details);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.button_CANCEL);
            this.Controls.Add(this.button_BOOK);
            this.Controls.Add(this.class_AIR);
            this.Controls.Add(this.label_Source);
            this.Controls.Add(this.Banner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PassangerDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket Booking System";
            this.Load += new System.EventHandler(this.ReservationTypeAir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            this.groupBox_Details.ResumeLayout(false);
            this.groupBox_Details.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Banner;
        private System.Windows.Forms.ComboBox class_AIR;
        private System.Windows.Forms.Label label_Source;
        private System.Windows.Forms.Button button_CANCEL;
        private System.Windows.Forms.Button button_BOOK;
        private System.Windows.Forms.PictureBox HomeButton;
        private System.Windows.Forms.PictureBox BackButton;
        private System.Windows.Forms.TextBox textBox_tick;
        private System.Windows.Forms.CheckBox checkBox_p4;
        private System.Windows.Forms.CheckBox checkBox_p3;
        private System.Windows.Forms.CheckBox checkBox_p2;
        private System.Windows.Forms.CheckBox checkBox_p1;
        private System.Windows.Forms.GroupBox groupBox_Details;
        private System.Windows.Forms.ComboBox comboBox_p4_food;
        private System.Windows.Forms.ComboBox comboBox_p3_food;
        private System.Windows.Forms.ComboBox comboBox_p2_food;
        private System.Windows.Forms.ComboBox comboBox_p1_food;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_p4_gender;
        private System.Windows.Forms.ComboBox comboBox_p3_gender;
        private System.Windows.Forms.ComboBox comboBox_p2_gender;
        private System.Windows.Forms.ComboBox comboBox_p1_gender;
        private System.Windows.Forms.TextBox textBox_p4_age;
        private System.Windows.Forms.TextBox textBox_p3_age;
        private System.Windows.Forms.TextBox textBox_p2_age;
        private System.Windows.Forms.TextBox textBox_p1_age;
        private System.Windows.Forms.TextBox textBox_p4_name;
        private System.Windows.Forms.TextBox textBox_p3_name;
        private System.Windows.Forms.TextBox textBox_p2_name;
        private System.Windows.Forms.TextBox textBox_p1_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Depart;
        private System.Windows.Forms.ComboBox class_BUS;
        private System.Windows.Forms.ComboBox class_TRAIN;
        private System.Windows.Forms.ComboBox class_EMERGENCY;
        private System.Windows.Forms.Label label_logout;
    }
}