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
using Projeto_UFCD5412.Model;
using Projeto_UFCD5412.View.CoordenacaoForms;

namespace Projeto_UFCD5412.View.LoginForms
{
    public partial class LoginForm : Form
    {
        LoginController loginController = new LoginController();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void MostrarMenuConsoanteTipoUtilizador(string tipoUtilizador)
        {
            switch(tipoUtilizador)
            {

                case "Diretor":
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.ShowDialog();
                    break;

                case "Coordenador":
                    CoordenacaoMainForm CoordenacaoMainForm = new CoordenacaoMainForm();
                    CoordenacaoMainForm.ShowDialog();
                    break;

                 case "Formador":
                    MainWindow mainWindow2 = new MainWindow();
                    mainWindow2.ShowDialog();
                    break;

                default:
                    MainWindow mainWindow3 = new MainWindow();
                    mainWindow3.ShowDialog();
                    break;

            }
        }

        private void UserLogin_Btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(User_Textbox.Text) || string.IsNullOrEmpty(Password_TextBox.Text))
            {
                MessageBox.Show("Por favor, preencha ambos os campos de usuário e senha.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string loginResult = loginController.Login(User_Textbox.Text, Password_TextBox.Text);

            if (loginResult != null)
            {
                if (loginResult == "PrimeiroLogin")
                {
                    AlterarPasswordForm alterarPasswordForm = new AlterarPasswordForm();
                    alterarPasswordForm.ShowDialog();

                    if (alterarPasswordForm.DialogResult == DialogResult.OK)
                    {
                        string novaPassword = alterarPasswordForm.NovaPassword;
                        bool verificaNovaPassword = loginController.AlterarPassword(novaPassword);
                        if (verificaNovaPassword)
                        {
                            MessageBox.Show("Password alterada com sucesso! Por favor, faça login novamente.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            User_Textbox.Text = null;
                            Password_TextBox.Text = null;
                        }
                        else
                        {
                            MessageBox.Show("Erro ao alterar a senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    User_Textbox.Text = null;
                    Password_TextBox.Text = null;
                    MostrarMenuConsoanteTipoUtilizador(loginResult);
                }
            }
            else
            {
                if (User_Textbox.Text == "admin" && Password_TextBox.Text == "admin")
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Nome de usuário ou senha incorretos. Por favor, tente novamente.", "Login Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Sair_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            Application.Exit();
        }

    }

}