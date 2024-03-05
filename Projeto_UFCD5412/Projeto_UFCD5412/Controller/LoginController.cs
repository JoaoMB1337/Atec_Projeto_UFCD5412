using Projeto_UFCD5412.Data;
using Projeto_UFCD5412.Model;
using System.Collections.Generic;
using Projeto_UFCD5412.Controller;


namespace Projeto_UFCD5412.Controller
{
    internal class LoginController
    {
        private List<Funcionario> funcionarios = new List<Funcionario>();
        private Funcionario funcionarioLogado; 

        public LoginController()
        {
            funcionarios = CSVHandler.LoadFromCSV();
        }

        public string Login(string username, string password)
        {
            if (username == "admin" && password == "admin")
            {
                funcionarioLogado = null;
                return "admin";
            }
            Funcionario funcionario = funcionarios.Find(f => f.Username == username && f.Password == EncryptController.EncryptPasswordStatic(password));

            if (funcionario != null)
            {
                if (funcionario.PrimeiroLogin)
                {
                    funcionarioLogado = funcionario;
                    return "PrimeiroLogin";
                }
                else
                {
                    funcionarioLogado = funcionario;
                    return funcionario.Tipo;
                }
            }
            else
            {
                return null;
            }
        }
        public bool AlterarPassword(string novaPassword)
        {
            if (funcionarioLogado != null)
            {
                string passwordEncripatada = EncryptController.EncryptPasswordStatic(novaPassword);
                funcionarioLogado.Password = passwordEncripatada;
                funcionarioLogado.PrimeiroLogin = false;
                CSVHandler.ExportToCSV(funcionarios);
                return true;
            }
            return false; 
        }
    }
}
