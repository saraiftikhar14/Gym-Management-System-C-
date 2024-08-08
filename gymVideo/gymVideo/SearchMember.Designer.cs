namespace gymVideo
{
    partial class SearchMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchMember));
            label1 = new Label();
            label2 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(292, -8);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(210, 147);
            label1.TabIndex = 15;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(248, 146);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 16;
            label2.Text = "Enter ID";
            label2.Click += label2_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(325, 142);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(308, 25);
            txtSearch.TabIndex = 17;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(427, 183);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(87, 29);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 218);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(654, 283);
            dataGridView1.TabIndex = 19;
            // 
            // SearchMember
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(680, 513);
            Controls.Add(dataGridView1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SearchMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchMember";
            Load += SearchMember_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dataGridView1;
    }
}