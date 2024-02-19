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
            if (string.IsNullOrEmpty(User_Textbox.Text) || string.IsNullOrEmpty(Password_TextBox.Text))
            {
                MessageBox.Show("Por favor, preencha ambos os campos de user e password.");
                return;
            }
            string loginResult = loginController.Login(User_Textbox.Text, Password_TextBox.Text);
            if (loginResult != null)
            {
                if (loginResult == "PrimeiroLogin")
                {
                    AlterarPasswordForm alterarPasswordForm = new AlterarPasswordForm();
                    alterarPasswordForm.ShowDialog();

                    if(alterarPasswordForm.DialogResult == DialogResult.OK)
                    {
                        string novaPassword = alterarPasswordForm.NovaPassword;
                        bool verificaNovaPassword = loginController.AlterarPassword(User_Textbox.Text, novaPassword);
                        if(verificaNovaPassword)
                        {                            
                            MessageBox.Show("Password alterada com sucesso!");
                            MainWindow mainWindow = new MainWindow();
                            mainWindow.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao alterar a password!");
                        }
                    }
                }
                else
                {
                   MainWindow mainWindow = new MainWindow();
                   mainWindow.ShowDialog();
                }
            }
            else
            {
               if(User_Textbox.Text == "admin" && Password_TextBox.Text == "admin")
               {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.ShowDialog();
                }
               else
               {
                   MessageBox.Show("Username ou Password incorretos!");
               }
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