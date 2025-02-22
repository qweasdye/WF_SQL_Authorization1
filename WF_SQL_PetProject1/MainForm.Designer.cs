namespace WF_SQL_PetProject1
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainPanelForm = new System.Windows.Forms.Panel();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelSurname = new System.Windows.Forms.Label();
            this.LabelNameOfProfile = new System.Windows.Forms.Label();
            this.LabelSurnameOfProfile = new System.Windows.Forms.Label();
            this.AppMinimized = new System.Windows.Forms.Label();
            this.LabelCloseWindowLogin = new System.Windows.Forms.Label();
            this.LeftPanelMainForm = new System.Windows.Forms.Panel();
            this.LabelMyProfile = new System.Windows.Forms.Label();
            this.SysTrayMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanelForm.SuspendLayout();
            this.LeftPanelMainForm.SuspendLayout();
            this.contextMenuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanelForm
            // 
            this.MainPanelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(68)))), ((int)(((byte)(175)))));
            this.MainPanelForm.Controls.Add(this.LabelName);
            this.MainPanelForm.Controls.Add(this.LabelSurname);
            this.MainPanelForm.Controls.Add(this.LabelNameOfProfile);
            this.MainPanelForm.Controls.Add(this.LabelSurnameOfProfile);
            this.MainPanelForm.Controls.Add(this.AppMinimized);
            this.MainPanelForm.Controls.Add(this.LabelCloseWindowLogin);
            this.MainPanelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanelForm.Location = new System.Drawing.Point(0, 0);
            this.MainPanelForm.Name = "MainPanelForm";
            this.MainPanelForm.Size = new System.Drawing.Size(1030, 477);
            this.MainPanelForm.TabIndex = 0;
            this.MainPanelForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanelForm_MouseDown);
            this.MainPanelForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanelForm_MouseMove);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelName.Location = new System.Drawing.Point(210, 23);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(21, 23);
            this.LabelName.TabIndex = 10;
            this.LabelName.Text = "_";
            // 
            // LabelSurname
            // 
            this.LabelSurname.AutoSize = true;
            this.LabelSurname.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSurname.Location = new System.Drawing.Point(234, 61);
            this.LabelSurname.Name = "LabelSurname";
            this.LabelSurname.Size = new System.Drawing.Size(21, 23);
            this.LabelSurname.TabIndex = 9;
            this.LabelSurname.Text = "_";
            // 
            // LabelNameOfProfile
            // 
            this.LabelNameOfProfile.AutoSize = true;
            this.LabelNameOfProfile.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNameOfProfile.Location = new System.Drawing.Point(139, 23);
            this.LabelNameOfProfile.Name = "LabelNameOfProfile";
            this.LabelNameOfProfile.Size = new System.Drawing.Size(65, 23);
            this.LabelNameOfProfile.TabIndex = 7;
            this.LabelNameOfProfile.Text = "Name:";
            // 
            // LabelSurnameOfProfile
            // 
            this.LabelSurnameOfProfile.AutoSize = true;
            this.LabelSurnameOfProfile.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSurnameOfProfile.Location = new System.Drawing.Point(139, 61);
            this.LabelSurnameOfProfile.Name = "LabelSurnameOfProfile";
            this.LabelSurnameOfProfile.Size = new System.Drawing.Size(89, 23);
            this.LabelSurnameOfProfile.TabIndex = 8;
            this.LabelSurnameOfProfile.Text = "Surname:";
            // 
            // AppMinimized
            // 
            this.AppMinimized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(68)))), ((int)(((byte)(175)))));
            this.AppMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AppMinimized.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AppMinimized.ForeColor = System.Drawing.Color.Indigo;
            this.AppMinimized.Location = new System.Drawing.Point(958, 9);
            this.AppMinimized.Name = "AppMinimized";
            this.AppMinimized.Size = new System.Drawing.Size(27, 26);
            this.AppMinimized.TabIndex = 5;
            this.AppMinimized.Text = "_";
            this.AppMinimized.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.AppMinimized.Click += new System.EventHandler(this.AppMinimized_Click);
            // 
            // LabelCloseWindowLogin
            // 
            this.LabelCloseWindowLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(68)))), ((int)(((byte)(175)))));
            this.LabelCloseWindowLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelCloseWindowLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCloseWindowLogin.ForeColor = System.Drawing.Color.Indigo;
            this.LabelCloseWindowLogin.Location = new System.Drawing.Point(991, 9);
            this.LabelCloseWindowLogin.Name = "LabelCloseWindowLogin";
            this.LabelCloseWindowLogin.Size = new System.Drawing.Size(27, 26);
            this.LabelCloseWindowLogin.TabIndex = 4;
            this.LabelCloseWindowLogin.Text = "X";
            this.LabelCloseWindowLogin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.LabelCloseWindowLogin.Click += new System.EventHandler(this.LabelCloseWindowLogin_Click);
            // 
            // LeftPanelMainForm
            // 
            this.LeftPanelMainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(133)))), ((int)(((byte)(212)))));
            this.LeftPanelMainForm.Controls.Add(this.LabelMyProfile);
            this.LeftPanelMainForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanelMainForm.Location = new System.Drawing.Point(0, 0);
            this.LeftPanelMainForm.Name = "LeftPanelMainForm";
            this.LeftPanelMainForm.Size = new System.Drawing.Size(123, 477);
            this.LeftPanelMainForm.TabIndex = 7;
            // 
            // LabelMyProfile
            // 
            this.LabelMyProfile.AutoSize = true;
            this.LabelMyProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelMyProfile.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMyProfile.Location = new System.Drawing.Point(3, 9);
            this.LabelMyProfile.Name = "LabelMyProfile";
            this.LabelMyProfile.Size = new System.Drawing.Size(117, 40);
            this.LabelMyProfile.TabIndex = 6;
            this.LabelMyProfile.Text = "Profile";
            // 
            // SysTrayMain
            // 
            this.SysTrayMain.ContextMenuStrip = this.contextMenuStripMain;
            this.SysTrayMain.Icon = ((System.Drawing.Icon)(resources.GetObject("SysTrayMain.Icon")));
            this.SysTrayMain.Text = "notifyIcon1";
            this.SysTrayMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SysTrayMain_MouseDoubleClick);
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(104, 26);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 477);
            this.Controls.Add(this.LeftPanelMainForm);
            this.Controls.Add(this.MainPanelForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.MainPanelForm.ResumeLayout(false);
            this.MainPanelForm.PerformLayout();
            this.LeftPanelMainForm.ResumeLayout(false);
            this.LeftPanelMainForm.PerformLayout();
            this.contextMenuStripMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanelForm;
        private System.Windows.Forms.Label AppMinimized;
        private System.Windows.Forms.Label LabelCloseWindowLogin;
        private System.Windows.Forms.NotifyIcon SysTrayMain;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label LabelMyProfile;
        private System.Windows.Forms.Panel LeftPanelMainForm;
        public System.Windows.Forms.Label LabelName;
        public System.Windows.Forms.Label LabelSurname;
        private System.Windows.Forms.Label LabelNameOfProfile;
        private System.Windows.Forms.Label LabelSurnameOfProfile;
    }
}