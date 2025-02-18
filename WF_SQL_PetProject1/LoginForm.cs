using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_SQL_PetProject1
{
    public partial class LoginForm : Form
    {
        Point lastPoint; // special class for setting coordinates


        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e) // sys tray name
        {
            SysTrayLogin.BalloonTipTitle = "Name of App";
            SysTrayLogin.BalloonTipText = "fdsfds";
            SysTrayLogin.Text = "name of app";
        }

        private void LoginForm_Resize(object sender, EventArgs e) // sys tray
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                SysTrayLogin.Visible = true;
                SysTrayLogin.ShowBalloonTip(1000);
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                SysTrayLogin.Visible = false;
            }
        }

        private void SysTrayLogin_MouseDoubleClick(object sender, MouseEventArgs e) // sys tray
        {
            this.Show();
            SysTrayLogin.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e) // sys tray close
        {
            Application.Exit();
        }

        private void LabelCloseWindowLogin_Click(object sender, EventArgs e) // button to close the login window
        {
            Application.Exit();
        }
        private void AppMinimized_Click(object sender, EventArgs e) // app minimized
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CheckBoxPasswordLogin_CheckedChanged(object sender, EventArgs e) // show password
        {
            if (CheckBoxPasswordLogin.Checked)
            {
                PasswordBoxLogin.UseSystemPasswordChar = false;
            } else
            {
                PasswordBoxLogin.UseSystemPasswordChar = true;
            }
        }


        private void MainPanelLogin_MouseMove(object sender, MouseEventArgs e) // move login window
        {
            if (e.Button == MouseButtons.Left) 
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainPanelLogin_MouseDown(object sender, MouseEventArgs e) // setting new coordinates after move
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void LabelAuthorization_MouseMove(object sender, MouseEventArgs e) // move login window
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LabelAuthorization_MouseDown(object sender, MouseEventArgs e) // setting new coordinates after move
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonEnterLogin_Click(object sender, EventArgs e) // database login
        {
            string userLogin = UserBoxLogin.Text;
            string userPassword = PasswordBoxLogin.Text;

            DataBase dataBase = new DataBase();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter();
            MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", dataBase.getConnection());

            sqlCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userLogin;
            sqlCommand.Parameters.Add("@uP", MySqlDbType.VarChar).Value = userPassword;

            sqlAdapter.SelectCommand = sqlCommand;
            sqlAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            } 
        }

        private void labelRegistration_Click(object sender, EventArgs e) // open register window
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();

            registerForm.Show();
        }
    }
}   
