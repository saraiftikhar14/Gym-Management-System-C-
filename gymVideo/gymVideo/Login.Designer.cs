namespace gymVideo
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            btnLogin = new Button();
            label4 = new Label();
            label3 = new Label();
            txtBoxPassword = new TextBox();
            txtBoxUserName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtBoxPassword);
            panel1.Controls.Add(txtBoxUserName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(153, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(492, 332);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(246, 282);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(127, 31);
            btnLogin.TabIndex = 22;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(101, 236);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 21;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(101, 173);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 20;
            label3.Text = "User Name";
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.BackColor = SystemColors.ScrollBar;
            txtBoxPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            txtBoxPassword.Location = new Point(211, 236);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PasswordChar = '*';
            txtBoxPassword.Size = new Size(210, 25);
            txtBoxPassword.TabIndex = 19;
            // 
            // txtBoxUserName
            // 
            txtBoxUserName.BackColor = SystemColors.ScrollBar;
            txtBoxUserName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            txtBoxUserName.Location = new Point(211, 173);
            txtBoxUserName.Name = "txtBoxUserName";
            txtBoxUserName.Size = new Size(210, 25);
            txtBoxUserName.TabIndex = 18;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(144, 101);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(204, 54);
            label2.TabIndex = 17;
            label2.Text = "FITNESS LOGIN";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(162, 10);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(151, 91);
            label1.TabIndex = 16;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button btnLogin;
        private Label label4;
        private Label label3;
        private TextBox txtBoxPassword;
        private TextBox txtBoxUserName;
    }
}