using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WF_SQL_PetProject1
{
    public partial class MainForm : Form
    {
        Point lastPoint; // special class for setting coordinates
        public MainForm(string text)
        {
            InitializeComponent();
            FillData(text);
        }

        public MainForm(string name, string surname)
        {
            InitializeComponent();

            LabelName.Text = name;
            LabelName.Text = surname;
        }

        private void FillData(string text)
        {
            string connectionString = "server=localhost;port=3306;user=root;password=root;database=userdb";
            MySqlConnection connection = new MySqlConnection(connectionString);
            LoginForm loginForm = new LoginForm();
            try
            {
                // Выполняем запрос к базе данных
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = $"SELECT * FROM users WHERE login = '{text}'";
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Получаем данные из базы данных
                    string name = reader.GetString("Name");

                    // Выводим данные в форму
                    LabelName.Text = name;
                }
                else
                {
                    MessageBox.Show("Нет данных в базе данных.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Закрываем подключение к базе данных
                connection.Close();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SysTrayMain.BalloonTipTitle = "Name of App";
            SysTrayMain.BalloonTipText = "fdsfds";
            SysTrayMain.Text = "name of app";
        }

        private void LabelCloseWindowLogin_Click(object sender, EventArgs e) // close app
        {
            Application.Exit();
        }

        private void AppMinimized_Click(object sender, EventArgs e) // min app
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MainForm_Resize(object sender, EventArgs e) // sys tray
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                SysTrayMain.Visible = true;
                SysTrayMain.ShowBalloonTip(1000);
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                SysTrayMain.Visible = false;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e) // close main window into sys tray
        {
            Application.Exit();
        }

        private void SysTrayMain_MouseDoubleClick(object sender, MouseEventArgs e) // sys tray
        {
            this.Show();
            SysTrayMain.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void MainPanelForm_MouseMove(object sender, MouseEventArgs e)  // move main window
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainPanelForm_MouseDown(object sender, MouseEventArgs e) // setting new coordinates after move
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
