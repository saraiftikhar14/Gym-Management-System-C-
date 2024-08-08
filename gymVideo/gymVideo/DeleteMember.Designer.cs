namespace gymVideo
{
    partial class DeleteMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteMember));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(105, 122);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter ID";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(233, -9);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(184, 130);
            label2.TabIndex = 15;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(204, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(288, 23);
            textBox1.TabIndex = 16;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDelete.Location = new Point(284, 162);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(101, 37);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 219);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(656, 291);
            dataGridView1.TabIndex = 18;
            // 
            // DeleteMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(680, 513);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DeleteMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeleteMember";
            Load += DeleteMember_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button btnDelete;
        private DataGridView dataGridView1;
    }
}