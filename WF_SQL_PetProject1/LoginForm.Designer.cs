namespace WF_SQL_PetProject1
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.MainPanelLogin = new System.Windows.Forms.Panel();
            this.labelRegistration = new System.Windows.Forms.Label();
            this.CheckBoxPasswordLogin = new System.Windows.Forms.CheckBox();
            this.buttonEnterLogin = new System.Windows.Forms.Button();
            this.PasswordBoxLogin = new System.Windows.Forms.TextBox();
            this.UserBoxLogin = new System.Windows.Forms.TextBox();
            this.PassPicBoxLogin = new System.Windows.Forms.PictureBox();
            this.UserPicBoxLogin = new System.Windows.Forms.PictureBox();
            this.UpperPanelLogin = new System.Windows.Forms.Panel();
            this.AppMinimized = new System.Windows.Forms.Label();
            this.LabelCloseWindowLogin = new System.Windows.Forms.Label();
            this.LabelAuthorization = new System.Windows.Forms.Label();
            this.SysTrayLogin = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripLogin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassPicBoxLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicBoxLogin)).BeginInit();
            this.UpperPanelLogin.SuspendLayout();
            this.contextMenuStripLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanelLogin
            // 
            this.MainPanelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(68)))), ((int)(((byte)(175)))));
            this.MainPanelLogin.Controls.Add(this.labelRegistration);
            this.MainPanelLogin.Controls.Add(this.CheckBoxPasswordLogin);
            this.MainPanelLogin.Controls.Add(this.buttonEnterLogin);
            this.MainPanelLogin.Controls.Add(this.PasswordBoxLogin);
            this.MainPanelLogin.Controls.Add(this.UserBoxLogin);
            this.MainPanelLogin.Controls.Add(this.PassPicBoxLogin);
            this.MainPanelLogin.Controls.Add(this.UserPicBoxLogin);
            this.MainPanelLogin.Controls.Add(this.UpperPanelLogin);
            this.MainPanelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanelLogin.Location = new System.Drawing.Point(0, 0);
            this.MainPanelLogin.Name = "MainPanelLogin";
            this.MainPanelLogin.Size = new System.Drawing.Size(408, 495);
            this.MainPanelLogin.TabIndex = 0;
            this.MainPanelLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanelLogin_MouseDown);
            this.MainPanelLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanelLogin_MouseMove);
            // 
            // labelRegistration
            // 
            this.labelRegistration.AutoSize = true;
            this.labelRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegistration.Location = new System.Drawing.Point(171, 453);
            this.labelRegistration.Name = "labelRegistration";
            this.labelRegistration.Size = new System.Drawing.Size(61, 17);
            this.labelRegistration.TabIndex = 10;
            this.labelRegistration.Text = "Register";
            this.labelRegistration.Click += new System.EventHandler(this.labelRegistration_Click);
            // 
            // CheckBoxPasswordLogin
            // 
            this.CheckBoxPasswordLogin.AutoSize = true;
            this.CheckBoxPasswordLogin.Location = new System.Drawing.Point(104, 288);
            this.CheckBoxPasswordLogin.Name = "CheckBoxPasswordLogin";
            this.CheckBoxPasswordLogin.Size = new System.Drawing.Size(128, 17);
            this.CheckBoxPasswordLogin.TabIndex = 6;
            this.CheckBoxPasswordLogin.Text = "Показывать пароль";
            this.CheckBoxPasswordLogin.UseVisualStyleBackColor = true;
            this.CheckBoxPasswordLogin.CheckedChanged += new System.EventHandler(this.CheckBoxPasswordLogin_CheckedChanged);
            // 
            // buttonEnterLogin
            // 
            this.buttonEnterLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnterLogin.FlatAppearance.BorderSize = 0;
            this.buttonEnterLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnterLogin.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnterLogin.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonEnterLogin.Location = new System.Drawing.Point(135, 346);
            this.buttonEnterLogin.Name = "buttonEnterLogin";
            this.buttonEnterLogin.Size = new System.Drawing.Size(127, 42);
            this.buttonEnterLogin.TabIndex = 5;
            this.buttonEnterLogin.Text = "Log In";
            this.buttonEnterLogin.UseVisualStyleBackColor = true;
            this.buttonEnterLogin.Click += new System.EventHandler(this.buttonEnterLogin_Click);
            // 
            // PasswordBoxLogin
            // 
            this.PasswordBoxLogin.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordBoxLogin.Location = new System.Drawing.Point(104, 243);
            this.PasswordBoxLogin.Name = "PasswordBoxLogin";
            this.PasswordBoxLogin.Size = new System.Drawing.Size(240, 39);
            this.PasswordBoxLogin.TabIndex = 4;
            this.PasswordBoxLogin.UseSystemPasswordChar = true;
            // 
            // UserBoxLogin
            // 
            this.UserBoxLogin.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserBoxLogin.Location = new System.Drawing.Point(104, 145);
            this.UserBoxLogin.Name = "UserBoxLogin";
            this.UserBoxLogin.Size = new System.Drawing.Size(240, 39);
            this.UserBoxLogin.TabIndex = 3;
            // 
            // PassPicBoxLogin
            // 
            this.PassPicBoxLogin.Image = global::WF_SQL_PetProject1.Properties.Resources._lock;
            this.PassPicBoxLogin.Location = new System.Drawing.Point(38, 232);
            this.PassPicBoxLogin.Name = "PassPicBoxLogin";
            this.PassPicBoxLogin.Size = new System.Drawing.Size(60, 60);
            this.PassPicBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PassPicBoxLogin.TabIndex = 2;
            this.PassPicBoxLogin.TabStop = false;
            // 
            // UserPicBoxLogin
            // 
            this.UserPicBoxLogin.Image = global::WF_SQL_PetProject1.Properties.Resources.user;
            this.UserPicBoxLogin.Location = new System.Drawing.Point(38, 134);
            this.UserPicBoxLogin.Name = "UserPicBoxLogin";
            this.UserPicBoxLogin.Size = new System.Drawing.Size(60, 60);
            this.UserPicBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserPicBoxLogin.TabIndex = 1;
            this.UserPicBoxLogin.TabStop = false;
            // 
            // UpperPanelLogin
            // 
            this.UpperPanelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(175)))), ((int)(((byte)(68)))));
            this.UpperPanelLogin.Controls.Add(this.AppMinimized);
            this.UpperPanelLogin.Controls.Add(this.LabelCloseWindowLogin);
            this.UpperPanelLogin.Controls.Add(this.LabelAuthorization);
            this.UpperPanelLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperPanelLogin.Location = new System.Drawing.Point(0, 0);
            this.UpperPanelLogin.Name = "UpperPanelLogin";
            this.UpperPanelLogin.Size = new System.Drawing.Size(408, 100);
            this.UpperPanelLogin.TabIndex = 0;
            // 
            // AppMinimized
            // 
            this.AppMinimized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(133)))), ((int)(((byte)(212)))));
            this.AppMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AppMinimized.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AppMinimized.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.AppMinimized.Location = new System.Drawing.Point(348, 0);
            this.AppMinimized.Name = "AppMinimized";
            this.AppMinimized.Size = new System.Drawing.Size(27, 26);
            this.AppMinimized.TabIndex = 3;
            this.AppMinimized.Text = "_";
            this.AppMinimized.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.AppMinimized.Click += new System.EventHandler(this.AppMinimized_Click);
            // 
            // LabelCloseWindowLogin
            // 
            this.LabelCloseWindowLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(133)))), ((int)(((byte)(212)))));
            this.LabelCloseWindowLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelCloseWindowLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCloseWindowLogin.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.LabelCloseWindowLogin.Location = new System.Drawing.Point(381, 0);
            this.LabelCloseWindowLogin.Name = "LabelCloseWindowLogin";
            this.LabelCloseWindowLogin.Size = new System.Drawing.Size(27, 26);
            this.LabelCloseWindowLogin.TabIndex = 1;
            this.LabelCloseWindowLogin.Text = "X";
            this.LabelCloseWindowLogin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.LabelCloseWindowLogin.Click += new System.EventHandler(this.LabelCloseWindowLogin_Click);
            // 
            // LabelAuthorization
            // 
            this.LabelAuthorization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(133)))), ((int)(((byte)(212)))));
            this.LabelAuthorization.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAuthorization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(238)))));
            this.LabelAuthorization.Location = new System.Drawing.Point(0, 0);
            this.LabelAuthorization.Name = "LabelAuthorization";
            this.LabelAuthorization.Size = new System.Drawing.Size(408, 100);
            this.LabelAuthorization.TabIndex = 0;
            this.LabelAuthorization.Text = "Authorization";
            this.LabelAuthorization.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelAuthorization.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelAuthorization_MouseDown);
            this.LabelAuthorization.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelAuthorization_MouseMove);
            // 
            // SysTrayLogin
            // 
            this.SysTrayLogin.ContextMenuStrip = this.contextMenuStripLogin;
            this.SysTrayLogin.Icon = ((System.Drawing.Icon)(resources.GetObject("SysTrayLogin.Icon")));
            this.SysTrayLogin.Text = "notifyIcon1";
            this.SysTrayLogin.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SysTrayLogin_MouseDoubleClick);
            // 
            // contextMenuStripLogin
            // 
            this.contextMenuStripLogin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.contextMenuStripLogin.Name = "contextMenuStripLogin";
            this.contextMenuStripLogin.Size = new System.Drawing.Size(104, 26);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 495);
            this.Controls.Add(this.MainPanelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Resize += new System.EventHandler(this.LoginForm_Resize);
            this.MainPanelLogin.ResumeLayout(false);
            this.MainPanelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassPicBoxLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicBoxLogin)).EndInit();
            this.UpperPanelLogin.ResumeLayout(false);
            this.contextMenuStripLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanelLogin;
        private System.Windows.Forms.Panel UpperPanelLogin;
        private System.Windows.Forms.Label LabelAuthorization;
        private System.Windows.Forms.Label LabelCloseWindowLogin;
        private System.Windows.Forms.PictureBox UserPicBoxLogin;
        private System.Windows.Forms.PictureBox PassPicBoxLogin;
        private System.Windows.Forms.Button buttonEnterLogin;
        private System.Windows.Forms.CheckBox CheckBoxPasswordLogin;
        private System.Windows.Forms.Label labelRegistration;
        private System.Windows.Forms.Label AppMinimized;
        private System.Windows.Forms.NotifyIcon SysTrayLogin;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripLogin;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        public System.Windows.Forms.TextBox PasswordBoxLogin;
        public System.Windows.Forms.TextBox UserBoxLogin;
    }
}