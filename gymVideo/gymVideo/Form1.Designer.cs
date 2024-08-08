namespace gymVideo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            newMemberToolStripMenuItem = new ToolStripMenuItem();
            newStaffToolStripMenuItem = new ToolStripMenuItem();
            equipentToolStripMenuItem = new ToolStripMenuItem();
            searchMemberToolStripMenuItem = new ToolStripMenuItem();
            deleteMemberToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, newMemberToolStripMenuItem, newStaffToolStripMenuItem, equipentToolStripMenuItem, searchMemberToolStripMenuItem, deleteMemberToolStripMenuItem, logOutToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(877, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackColor = Color.Transparent;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(12, 25);
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // newMemberToolStripMenuItem
            // 
            newMemberToolStripMenuItem.BackColor = SystemColors.AppWorkspace;
            newMemberToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            newMemberToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            newMemberToolStripMenuItem.Image = (Image)resources.GetObject("newMemberToolStripMenuItem.Image");
            newMemberToolStripMenuItem.Name = "newMemberToolStripMenuItem";
            newMemberToolStripMenuItem.Size = new Size(141, 25);
            newMemberToolStripMenuItem.Text = "New Member";
            newMemberToolStripMenuItem.Click += newMemberToolStripMenuItem_Click;
            // 
            // newStaffToolStripMenuItem
            // 
            newStaffToolStripMenuItem.BackColor = SystemColors.ControlDarkDark;
            newStaffToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            newStaffToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            newStaffToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            newStaffToolStripMenuItem.Image = (Image)resources.GetObject("newStaffToolStripMenuItem.Image");
            newStaffToolStripMenuItem.Name = "newStaffToolStripMenuItem";
            newStaffToolStripMenuItem.Size = new Size(113, 25);
            newStaffToolStripMenuItem.Text = "New Staff";
            newStaffToolStripMenuItem.Click += newStaffToolStripMenuItem_Click;
            // 
            // equipentToolStripMenuItem
            // 
            equipentToolStripMenuItem.BackColor = SystemColors.AppWorkspace;
            equipentToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            equipentToolStripMenuItem.Image = (Image)resources.GetObject("equipentToolStripMenuItem.Image");
            equipentToolStripMenuItem.Name = "equipentToolStripMenuItem";
            equipentToolStripMenuItem.Size = new Size(122, 25);
            equipentToolStripMenuItem.Text = "Equipment";
            equipentToolStripMenuItem.Click += equipentToolStripMenuItem_Click;
            // 
            // searchMemberToolStripMenuItem
            // 
            searchMemberToolStripMenuItem.BackColor = SystemColors.ControlDarkDark;
            searchMemberToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            searchMemberToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            searchMemberToolStripMenuItem.Image = (Image)resources.GetObject("searchMemberToolStripMenuItem.Image");
            searchMemberToolStripMenuItem.Name = "searchMemberToolStripMenuItem";
            searchMemberToolStripMenuItem.Size = new Size(157, 25);
            searchMemberToolStripMenuItem.Text = "Search Member";
            searchMemberToolStripMenuItem.Click += searchMemberToolStripMenuItem_Click;
            // 
            // deleteMemberToolStripMenuItem
            // 
            deleteMemberToolStripMenuItem.BackColor = SystemColors.AppWorkspace;
            deleteMemberToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            deleteMemberToolStripMenuItem.Image = (Image)resources.GetObject("deleteMemberToolStripMenuItem.Image");
            deleteMemberToolStripMenuItem.Name = "deleteMemberToolStripMenuItem";
            deleteMemberToolStripMenuItem.Size = new Size(156, 25);
            deleteMemberToolStripMenuItem.Text = "Delete Member";
            deleteMemberToolStripMenuItem.Click += deleteMemberToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.BackColor = SystemColors.ControlDarkDark;
            logOutToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            logOutToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            logOutToolStripMenuItem.Image = (Image)resources.GetObject("logOutToolStripMenuItem.Image");
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(102, 25);
            logOutToolStripMenuItem.Text = "Log Out ";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = SystemColors.AppWorkspace;
            exitToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            exitToolStripMenuItem.Image = (Image)resources.GetObject("exitToolStripMenuItem.Image");
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(67, 25);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(877, 422);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Fitness";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem newMemberToolStripMenuItem;
        private ToolStripMenuItem newStaffToolStripMenuItem;
        private ToolStripMenuItem equipentToolStripMenuItem;
        private ToolStripMenuItem searchMemberToolStripMenuItem;
        private ToolStripMenuItem deleteMemberToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}
