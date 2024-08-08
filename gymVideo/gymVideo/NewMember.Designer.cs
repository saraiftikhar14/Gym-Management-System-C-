namespace gymVideo
{
    partial class NewMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMember));
            txtFirstName = new TextBox();
            txtEmail = new TextBox();
            txtMobile = new TextBox();
            txtLastName = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            dateTimePickerDOB = new DateTimePicker();
            dateTimePickerJoinDate = new DateTimePicker();
            txtAddress = new RichTextBox();
            comboBoxGymTime = new ComboBox();
            comboBoxMembership = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnSave = new Button();
            btnReset = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(151, 124);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(149, 23);
            txtFirstName.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(607, 132);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(145, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(151, 349);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(149, 23);
            txtMobile.TabIndex = 2;
            txtMobile.TextChanged += textBox3_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(151, 176);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(149, 23);
            txtLastName.TabIndex = 3;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioButton1.ForeColor = SystemColors.ButtonHighlight;
            radioButton1.Location = new Point(151, 233);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(52, 19);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioButton2.ForeColor = SystemColors.ButtonHighlight;
            radioButton2.Location = new Point(237, 232);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(65, 19);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Format = DateTimePickerFormat.Short;
            dateTimePickerDOB.Location = new Point(151, 289);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(149, 23);
            dateTimePickerDOB.TabIndex = 6;
            // 
            // dateTimePickerJoinDate
            // 
            dateTimePickerJoinDate.Format = DateTimePickerFormat.Short;
            dateTimePickerJoinDate.Location = new Point(607, 176);
            dateTimePickerJoinDate.Name = "dateTimePickerJoinDate";
            dateTimePickerJoinDate.Size = new Size(145, 23);
            dateTimePickerJoinDate.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(607, 276);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(145, 96);
            txtAddress.TabIndex = 9;
            txtAddress.Text = "";
            // 
            // comboBoxGymTime
            // 
            comboBoxGymTime.FormattingEnabled = true;
            comboBoxGymTime.Items.AddRange(new object[] { "04:00 AM-05:00 AM", "05:00 AM-06:00 AM", "06:00 AM-07:00 AM", "07:00 AM-08:00 AM", "08:00 AM-09:00 AM", "09:00 AM-10:00 AM", "10:00 AM-11:00 AM" });
            comboBoxGymTime.Location = new Point(607, 224);
            comboBoxGymTime.Name = "comboBoxGymTime";
            comboBoxGymTime.Size = new Size(145, 23);
            comboBoxGymTime.TabIndex = 10;
            // 
            // comboBoxMembership
            // 
            comboBoxMembership.FormattingEnabled = true;
            comboBoxMembership.Items.AddRange(new object[] { "01 Month", "02 Month", "03 Month", "04 Month", "05 Month", "06 Month", "07 Month", "08 Month", "09 Month", "10 Month", "11 Month", "12 Month", "" });
            comboBoxMembership.Location = new Point(472, 405);
            comboBoxMembership.Name = "comboBoxMembership";
            comboBoxMembership.Size = new Size(121, 23);
            comboBoxMembership.TabIndex = 11;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(328, 9);
            label1.Name = "label1";
            label1.Size = new Size(143, 97);
            label1.TabIndex = 12;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.Transparent;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(23, 122);
            label2.Name = "label2";
            label2.Size = new Size(112, 23);
            label2.TabIndex = 13;
            label2.Text = "First Name";
            label2.TextAlign = ContentAlignment.MiddleRight;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.Transparent;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(23, 171);
            label3.Name = "label3";
            label3.Size = new Size(112, 35);
            label3.TabIndex = 14;
            label3.Text = "Last Name";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.Transparent;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(23, 224);
            label4.Name = "label4";
            label4.Size = new Size(99, 35);
            label4.TabIndex = 15;
            label4.Text = "Gender";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label5.ForeColor = Color.Transparent;
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(14, 284);
            label5.Name = "label5";
            label5.Size = new Size(130, 35);
            label5.TabIndex = 16;
            label5.Text = "Date Of Birth";
            label5.TextAlign = ContentAlignment.MiddleRight;
            label5.Click += label5_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(343, 456);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(83, 35);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReset.Image = (Image)resources.GetObject("btnReset.Image");
            btnReset.ImageAlign = ContentAlignment.MiddleLeft;
            btnReset.Location = new Point(472, 456);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(88, 35);
            btnReset.TabIndex = 18;
            btnReset.Text = "Reset";
            btnReset.TextAlign = ContentAlignment.MiddleRight;
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label6.ForeColor = Color.Transparent;
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(14, 341);
            label6.Name = "label6";
            label6.Size = new Size(138, 35);
            label6.TabIndex = 19;
            label6.Text = "Contact No.";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label7.ForeColor = Color.Transparent;
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.ImageAlign = ContentAlignment.MiddleLeft;
            label7.Location = new Point(497, 124);
            label7.Name = "label7";
            label7.Size = new Size(101, 35);
            label7.TabIndex = 20;
            label7.Text = "Email ID";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label8.ForeColor = Color.Transparent;
            label8.Image = (Image)resources.GetObject("label8.Image");
            label8.ImageAlign = ContentAlignment.MiddleLeft;
            label8.Location = new Point(497, 176);
            label8.Name = "label8";
            label8.Size = new Size(101, 35);
            label8.TabIndex = 21;
            label8.Text = "Join Date";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label9.ForeColor = Color.Transparent;
            label9.Image = (Image)resources.GetObject("label9.Image");
            label9.ImageAlign = ContentAlignment.MiddleLeft;
            label9.Location = new Point(497, 224);
            label9.Name = "label9";
            label9.Size = new Size(101, 35);
            label9.TabIndex = 22;
            label9.Text = "Gym Time";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label10.ForeColor = Color.Transparent;
            label10.Image = (Image)resources.GetObject("label10.Image");
            label10.ImageAlign = ContentAlignment.MiddleLeft;
            label10.Location = new Point(489, 276);
            label10.Name = "label10";
            label10.Size = new Size(109, 35);
            label10.TabIndex = 23;
            label10.Text = "Address";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label11.ForeColor = Color.Transparent;
            label11.Image = (Image)resources.GetObject("label11.Image");
            label11.ImageAlign = ContentAlignment.MiddleLeft;
            label11.Location = new Point(296, 397);
            label11.Name = "label11";
            label11.Size = new Size(162, 35);
            label11.TabIndex = 24;
            label11.Text = "Membership Time";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NewMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(821, 503);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnReset);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxMembership);
            Controls.Add(comboBoxGymTime);
            Controls.Add(txtAddress);
            Controls.Add(dateTimePickerJoinDate);
            Controls.Add(dateTimePickerDOB);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(txtLastName);
            Controls.Add(txtMobile);
            Controls.Add(txtEmail);
            Controls.Add(txtFirstName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NewMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewMember";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtEmail;
        private TextBox txtMobile;
        private TextBox txtLastName;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private DateTimePicker dateTimePickerDOB;
        private DateTimePicker dateTimePickerJoinDate;
        private RichTextBox txtAddress;
        private ComboBox comboBoxGymTime;
        private ComboBox comboBoxMembership;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnSave;
        private Button btnReset;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}