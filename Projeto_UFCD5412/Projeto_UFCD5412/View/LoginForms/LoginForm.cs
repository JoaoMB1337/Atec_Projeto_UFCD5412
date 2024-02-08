using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_UFCD5412.View.LoginForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void UserLogin_Btn_Click(object sender, EventArgs e)
        {
             MainWindow mainWindow = new MainWindow();

            mainWindow.FormClosed += MainWindow_FormClosed;

            mainWindow.Show();

            this.Hide();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();

            Application.Exit();
        }
    }
}
