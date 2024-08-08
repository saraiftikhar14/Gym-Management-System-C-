namespace gymVideo
{
    partial class Equipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipment));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtEquipName = new TextBox();
            txtMusclesUsed = new TextBox();
            txtDescription = new RichTextBox();
            txtCost = new TextBox();
            dateTimePickerDeliveryDate = new DateTimePicker();
            btnReset = new Button();
            btnViewEq = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(323, -4);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(184, 130);
            label1.TabIndex = 13;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(172, 145);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 21);
            label2.TabIndex = 14;
            label2.Text = "Equipment Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(172, 200);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 15;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(172, 323);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(113, 21);
            label4.TabIndex = 16;
            label4.Text = "Muscles Used";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(170, 380);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(115, 21);
            label5.TabIndex = 17;
            label5.Text = "Delivery Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(172, 426);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(43, 21);
            label6.TabIndex = 18;
            label6.Text = "Cost";
            label6.Click += label6_Click;
            // 
            // txtEquipName
            // 
            txtEquipName.Location = new Point(349, 143);
            txtEquipName.Name = "txtEquipName";
            txtEquipName.Size = new Size(236, 27);
            txtEquipName.TabIndex = 19;
            // 
            // txtMusclesUsed
            // 
            txtMusclesUsed.Location = new Point(349, 323);
            txtMusclesUsed.Name = "txtMusclesUsed";
            txtMusclesUsed.Size = new Size(236, 27);
            txtMusclesUsed.TabIndex = 20;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(349, 198);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(299, 108);
            txtDescription.TabIndex = 21;
            txtDescription.Text = "";
            // 
            // txtCost
            // 
            txtCost.Location = new Point(349, 426);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(236, 27);
            txtCost.TabIndex = 22;
            // 
            // dateTimePickerDeliveryDate
            // 
            dateTimePickerDeliveryDate.Format = DateTimePickerFormat.Short;
            dateTimePickerDeliveryDate.Location = new Point(349, 380);
            dateTimePickerDeliveryDate.Name = "dateTimePickerDeliveryDate";
            dateTimePickerDeliveryDate.Size = new Size(236, 27);
            dateTimePickerDeliveryDate.TabIndex = 23;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(398, 505);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 32);
            btnReset.TabIndex = 25;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnViewEq
            // 
            btnViewEq.Location = new Point(495, 505);
            btnViewEq.Name = "btnViewEq";
            btnViewEq.Size = new Size(153, 32);
            btnViewEq.TabIndex = 26;
            btnViewEq.Text = "View Equipment";
            btnViewEq.UseVisualStyleBackColor = true;
            btnViewEq.Click += btnViewEq_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(298, 505);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 32);
            btnSave.TabIndex = 27;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Equipment
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(841, 549);
            Controls.Add(btnSave);
            Controls.Add(btnViewEq);
            Controls.Add(btnReset);
            Controls.Add(dateTimePickerDeliveryDate);
            Controls.Add(txtCost);
            Controls.Add(txtDescription);
            Controls.Add(txtMusclesUsed);
            Controls.Add(txtEquipName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Equipment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Equipment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtEquipName;
        private TextBox txtMusclesUsed;
        private RichTextBox txtDescription;
        private TextBox txtCost;
        private DateTimePicker dateTimePickerDeliveryDate;
        private Button btnReset;
        private Button btnViewEq;
        private Button btnSave;
    }
}