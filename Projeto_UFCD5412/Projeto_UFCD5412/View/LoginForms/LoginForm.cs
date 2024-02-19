using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_UFCD5412.Controller;

namespace Projeto_UFCD5412.View.LoginForms
{
    public partial class LoginForm : Form
    {
        LoginController loginController = new LoginController();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void UserLogin_Btn_Click(object sender, EventArgs e)
        {
            if(loginController.Login(User_Textbox.Text, Password_TextBox.Text))
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.FormClosed += MainWindow_FormClosed;
                mainWindow.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect");
            }

            this.Hide();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();

            Application.Exit();
        }
    }
}
