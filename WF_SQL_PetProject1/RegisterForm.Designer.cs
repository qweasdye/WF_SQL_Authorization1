namespace WF_SQL_PetProject1
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.MainPanelRegister = new System.Windows.Forms.Panel();
            this.labelLogIn = new System.Windows.Forms.Label();
            this.userSurnameBoxRegister = new System.Windows.Forms.TextBox();
            this.userNameBoxRegister = new System.Windows.Forms.TextBox();
            this.CheckBoxPasswordRegister = new System.Windows.Forms.CheckBox();
            this.buttonEnterRegister = new System.Windows.Forms.Button();
            this.PasswordBoxRegister = new System.Windows.Forms.TextBox();
            this.UserBoxRegister = new System.Windows.Forms.TextBox();
            this.PassPicBoxRegister = new System.Windows.Forms.PictureBox();
            this.UserPicBoxRegister = new System.Windows.Forms.PictureBox();
            this.UpperPanelLogin = new System.Windows.Forms.Panel();
            this.AppMinimized = new System.Windows.Forms.Label();
            this.LabelCloseWindowRegister = new System.Windows.Forms.Label();
            this.LabelRegister = new System.Windows.Forms.Label();
            this.SysTrayRegister = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripRegister = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanelRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassPicBoxRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicBoxRegister)).BeginInit();
            this.UpperPanelLogin.SuspendLayout();
            this.contextMenuStripRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanelRegister
            // 
            this.MainPanelRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(68)))), ((int)(((byte)(175)))));
            this.MainPanelRegister.Controls.Add(this.labelLogIn);
            this.MainPanelRegister.Controls.Add(this.userSurnameBoxRegister);
            this.MainPanelRegister.Controls.Add(this.userNameBoxRegister);
            this.MainPanelRegister.Controls.Add(this.CheckBoxPasswordRegister);
            this.MainPanelRegister.Controls.Add(this.buttonEnterRegister);
            this.MainPanelRegister.Controls.Add(this.PasswordBoxRegister);
            this.MainPanelRegister.Controls.Add(this.UserBoxRegister);
            this.MainPanelRegister.Controls.Add(this.PassPicBoxRegister);
            this.MainPanelRegister.Controls.Add(this.UserPicBoxRegister);
            this.MainPanelRegister.Controls.Add(this.UpperPanelLogin);
            this.MainPanelRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanelRegister.Location = new System.Drawing.Point(0, 0);
            this.MainPanelRegister.Name = "MainPanelRegister";
            this.MainPanelRegister.Size = new System.Drawing.Size(642, 456);
            this.MainPanelRegister.TabIndex = 1;
            this.MainPanelRegister.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanelRegister_MouseDown);
            this.MainPanelRegister.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanelRegister_MouseMove);
            // 
            // labelLogIn
            // 
            this.labelLogIn.AutoSize = true;
            this.labelLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogIn.Location = new System.Drawing.Point(312, 417);
            this.labelLogIn.Name = "labelLogIn";
            this.labelLogIn.Size = new System.Drawing.Size(47, 17);
            this.labelLogIn.TabIndex = 9;
            this.labelLogIn.Text = "Log In";
            this.labelLogIn.Click += new System.EventHandler(this.labelLogIn_Click);
            // 
            // userSurnameBoxRegister
            // 
            this.userSurnameBoxRegister.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userSurnameBoxRegister.Location = new System.Drawing.Point(412, 225);
            this.userSurnameBoxRegister.Name = "userSurnameBoxRegister";
            this.userSurnameBoxRegister.Size = new System.Drawing.Size(218, 39);
            this.userSurnameBoxRegister.TabIndex = 8;
            this.userSurnameBoxRegister.Enter += new System.EventHandler(this.userSurnameBoxRegister_Enter);
            this.userSurnameBoxRegister.Leave += new System.EventHandler(this.userSurnameBoxRegister_Leave);
            // 
            // userNameBoxRegister
            // 
            this.userNameBoxRegister.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameBoxRegister.Location = new System.Drawing.Point(412, 127);
            this.userNameBoxRegister.Name = "userNameBoxRegister";
            this.userNameBoxRegister.Size = new System.Drawing.Size(218, 39);
            this.userNameBoxRegister.TabIndex = 7;
            this.userNameBoxRegister.Enter += new System.EventHandler(this.userNameBoxRegister_Enter);
            this.userNameBoxRegister.Leave += new System.EventHandler(this.userNameBoxRegister_Leave);
            // 
            // CheckBoxPasswordRegister
            // 
            this.CheckBoxPasswordRegister.AutoSize = true;
            this.CheckBoxPasswordRegister.Location = new System.Drawing.Point(74, 270);
            this.CheckBoxPasswordRegister.Name = "CheckBoxPasswordRegister";
            this.CheckBoxPasswordRegister.Size = new System.Drawing.Size(128, 17);
            this.CheckBoxPasswordRegister.TabIndex = 6;
            this.CheckBoxPasswordRegister.Text = "Показывать пароль";
            this.CheckBoxPasswordRegister.UseVisualStyleBackColor = true;
            this.CheckBoxPasswordRegister.CheckedChanged += new System.EventHandler(this.CheckBoxPasswordRegister_CheckedChanged);
            // 
            // buttonEnterRegister
            // 
            this.buttonEnterRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnterRegister.FlatAppearance.BorderSize = 0;
            this.buttonEnterRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnterRegister.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnterRegister.Location = new System.Drawing.Point(274, 302);
            this.buttonEnterRegister.Name = "buttonEnterRegister";
            this.buttonEnterRegister.Size = new System.Drawing.Size(127, 42);
            this.buttonEnterRegister.TabIndex = 5;
            this.buttonEnterRegister.Text = "Register";
            this.buttonEnterRegister.UseVisualStyleBackColor = true;
            this.buttonEnterRegister.Click += new System.EventHandler(this.buttonEnterRegister_Click);
            // 
            // PasswordBoxRegister
            // 
            this.PasswordBoxRegister.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordBoxRegister.Location = new System.Drawing.Point(74, 225);
            this.PasswordBoxRegister.Name = "PasswordBoxRegister";
            this.PasswordBoxRegister.Size = new System.Drawing.Size(240, 39);
            this.PasswordBoxRegister.TabIndex = 4;
            this.PasswordBoxRegister.UseSystemPasswordChar = true;
            // 
            // UserBoxRegister
            // 
            this.UserBoxRegister.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserBoxRegister.Location = new System.Drawing.Point(74, 127);
            this.UserBoxRegister.Name = "UserBoxRegister";
            this.UserBoxRegister.Size = new System.Drawing.Size(240, 39);
            this.UserBoxRegister.TabIndex = 3;
            // 
            // PassPicBoxRegister
            // 
            this.PassPicBoxRegister.Image = global::WF_SQL_PetProject1.Properties.Resources._lock;
            this.PassPicBoxRegister.Location = new System.Drawing.Point(8, 214);
            this.PassPicBoxRegister.Name = "PassPicBoxRegister";
            this.PassPicBoxRegister.Size = new System.Drawing.Size(60, 60);
            this.PassPicBoxRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PassPicBoxRegister.TabIndex = 2;
            this.PassPicBoxRegister.TabStop = false;
            // 
            // UserPicBoxRegister
            // 
            this.UserPicBoxRegister.Image = global::WF_SQL_PetProject1.Properties.Resources.user;
            this.UserPicBoxRegister.Location = new System.Drawing.Point(8, 116);
            this.UserPicBoxRegister.Name = "UserPicBoxRegister";
            this.UserPicBoxRegister.Size = new System.Drawing.Size(60, 60);
            this.UserPicBoxRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserPicBoxRegister.TabIndex = 1;
            this.UserPicBoxRegister.TabStop = false;
            // 
            // UpperPanelLogin
            // 
            this.UpperPanelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(175)))), ((int)(((byte)(68)))));
            this.UpperPanelLogin.Controls.Add(this.AppMinimized);
            this.UpperPanelLogin.Controls.Add(this.LabelCloseWindowRegister);
            this.UpperPanelLogin.Controls.Add(this.LabelRegister);
            this.UpperPanelLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperPanelLogin.Location = new System.Drawing.Point(0, 0);
            this.UpperPanelLogin.Name = "UpperPanelLogin";
            this.UpperPanelLogin.Size = new System.Drawing.Size(642, 100);
            this.UpperPanelLogin.TabIndex = 0;
            // 
            // AppMinimized
            // 
            this.AppMinimized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(133)))), ((int)(((byte)(212)))));
            this.AppMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AppMinimized.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AppMinimized.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.AppMinimized.Location = new System.Drawing.Point(582, 0);
            this.AppMinimized.Name = "AppMinimized";
            this.AppMinimized.Size = new System.Drawing.Size(27, 26);
            this.AppMinimized.TabIndex = 2;
            this.AppMinimized.Text = "_";
            this.AppMinimized.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.AppMinimized.Click += new System.EventHandler(this.AppMinimized_Click);
            // 
            // LabelCloseWindowRegister
            // 
            this.LabelCloseWindowRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(133)))), ((int)(((byte)(212)))));
            this.LabelCloseWindowRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelCloseWindowRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCloseWindowRegister.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.LabelCloseWindowRegister.Location = new System.Drawing.Point(615, 0);
            this.LabelCloseWindowRegister.Name = "LabelCloseWindowRegister";
            this.LabelCloseWindowRegister.Size = new System.Drawing.Size(27, 26);
            this.LabelCloseWindowRegister.TabIndex = 1;
            this.LabelCloseWindowRegister.Text = "X";
            this.LabelCloseWindowRegister.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.LabelCloseWindowRegister.Click += new System.EventHandler(this.LabelCloseWindowRegister_Click);
            // 
            // LabelRegister
            // 
            this.LabelRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(133)))), ((int)(((byte)(212)))));
            this.LabelRegister.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(238)))));
            this.LabelRegister.Location = new System.Drawing.Point(0, 0);
            this.LabelRegister.Name = "LabelRegister";
            this.LabelRegister.Size = new System.Drawing.Size(642, 100);
            this.LabelRegister.TabIndex = 0;
            this.LabelRegister.Text = "Registration";
            this.LabelRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelRegister.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelAuthorization_MouseDown);
            this.LabelRegister.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelAuthorization_MouseMove);
            // 
            // SysTrayRegister
            // 
            this.SysTrayRegister.ContextMenuStrip = this.contextMenuStripRegister;
            this.SysTrayRegister.Icon = ((System.Drawing.Icon)(resources.GetObject("SysTrayRegister.Icon")));
            this.SysTrayRegister.Text = "notifyIcon1";
            this.SysTrayRegister.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SysTrayRegister_MouseDoubleClick);
            // 
            // contextMenuStripRegister
            // 
            this.contextMenuStripRegister.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.contextMenuStripRegister.Name = "contextMenuStripRegister";
            this.contextMenuStripRegister.Size = new System.Drawing.Size(104, 26);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(642, 456);
            this.Controls.Add(this.MainPanelRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.Resize += new System.EventHandler(this.RegisterForm_Resize);
            this.MainPanelRegister.ResumeLayout(false);
            this.MainPanelRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassPicBoxRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicBoxRegister)).EndInit();
            this.UpperPanelLogin.ResumeLayout(false);
            this.contextMenuStripRegister.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanelRegister;
        private System.Windows.Forms.CheckBox CheckBoxPasswordRegister;
        private System.Windows.Forms.Button buttonEnterRegister;
        private System.Windows.Forms.TextBox PasswordBoxRegister;
        private System.Windows.Forms.TextBox UserBoxRegister;
        private System.Windows.Forms.PictureBox PassPicBoxRegister;
        private System.Windows.Forms.PictureBox UserPicBoxRegister;
        private System.Windows.Forms.Panel UpperPanelLogin;
        private System.Windows.Forms.Label LabelCloseWindowRegister;
        private System.Windows.Forms.Label LabelRegister;
        public System.Windows.Forms.TextBox userSurnameBoxRegister;
        public System.Windows.Forms.TextBox userNameBoxRegister;
        private System.Windows.Forms.Label labelLogIn;
        private System.Windows.Forms.NotifyIcon SysTrayRegister;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRegister;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label AppMinimized;
    }
}