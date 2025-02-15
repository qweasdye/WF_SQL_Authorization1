using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_SQL_PetProject1
{
    public partial class RegisterForm : Form
    {

        Point lastPoint; // special class for setting coordinates
        public RegisterForm()
        {
            InitializeComponent();

            userNameBoxRegister.Text = "Введите имя";
            userNameBoxRegister.ForeColor = Color.Gray;
            userSurnameBoxRegister.Text = "Введите фамилию";
            userSurnameBoxRegister.ForeColor = Color.Gray;
        }

        private void LabelCloseWindowRegister_Click(object sender, EventArgs e) // close window register
        {
            Application.Exit();
        }

        private void MainPanelRegister_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void MainPanelRegister_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void LabelAuthorization_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void LabelAuthorization_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void CheckBoxPasswordRegister_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxPasswordRegister.Checked)
            {
                PasswordBoxRegister.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordBoxRegister.UseSystemPasswordChar = true;
            }
        }

        private void userNameBoxRegister_Enter(object sender, EventArgs e)
        {
            if (userNameBoxRegister.Text == "Введите имя")
            {
                userNameBoxRegister.Text = "";
                userNameBoxRegister.ForeColor = Color.Black;
            }
        }

        private void userNameBoxRegister_Leave(object sender, EventArgs e)
        {
            if (userNameBoxRegister.Text == "")
            {
                userNameBoxRegister.Text = "Введите имя";
                userNameBoxRegister.ForeColor = Color.Gray;
            }
        }

        private void userSurnameBoxRegister_Enter(object sender, EventArgs e)
        {
            if (userSurnameBoxRegister.Text == "Введите фамилию")
            {
                userSurnameBoxRegister.Text = "";
                userSurnameBoxRegister.ForeColor = Color.Black;
            }
        }
        private void userSurnameBoxRegister_Leave(object sender, EventArgs e)
        {
            if (userSurnameBoxRegister.Text == "")
            {
                userSurnameBoxRegister.Text = "Введите фамилию";
                userSurnameBoxRegister.ForeColor = Color.Gray;
            }
        }

        private void buttonEnterRegister_Click(object sender, EventArgs e)
        {
            if (userNameBoxRegister.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя!");
                return;
            }

            if (userSurnameBoxRegister.Text == "Введите фамилию")
            {
                MessageBox.Show("Введите фамилию!");
                return;
            }

            if (UserBoxRegister.Text == "")
            {
                MessageBox.Show("Введите логин!");
                return;
            }

            if (PasswordBoxRegister.Text == "")
            {
                MessageBox.Show("Введите пароль!");
                return;
            }

            if (isUserExists())
                return;

            DataBase dataBase = new DataBase();

            MySqlCommand sqlCommand = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `Name`,`Surname`) VALUES (@login, @password, @name, @surname)", dataBase.getConnection());

            sqlCommand.Parameters.Add("@login", MySqlDbType.VarChar).Value = UserBoxRegister.Text;
            sqlCommand.Parameters.Add("@password", MySqlDbType.VarChar).Value = PasswordBoxRegister.Text;
            sqlCommand.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameBoxRegister.Text;
            sqlCommand.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameBoxRegister.Text;

            dataBase.openConnection();

            if (sqlCommand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт был создан");
            } else
            {
                MessageBox.Show("Аккаунт не был создан");
            }

            dataBase.closeConnection();
        }

        public Boolean isUserExists()
        {
            DataBase dataBase = new DataBase();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter();
            MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", dataBase.getConnection());

            sqlCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = UserBoxRegister.Text;

            sqlAdapter.SelectCommand = sqlCommand;
            sqlAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Этот логин уже занят");
                return true;
            } else
            {
                return false;
            }
        }

        private void labelLogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();

            loginForm.Show();
        }
    }
}
