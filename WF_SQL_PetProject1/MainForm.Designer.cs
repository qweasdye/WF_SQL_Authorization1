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
            this.AppMinimized = new System.Windows.Forms.Label();
            this.LabelCloseWindowLogin = new System.Windows.Forms.Label();
            this.SysTrayMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanelForm.SuspendLayout();
            this.contextMenuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanelForm
            // 
            this.MainPanelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(68)))), ((int)(((byte)(175)))));
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
            this.Controls.Add(this.MainPanelForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.MainPanelForm.ResumeLayout(false);
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
    }
}