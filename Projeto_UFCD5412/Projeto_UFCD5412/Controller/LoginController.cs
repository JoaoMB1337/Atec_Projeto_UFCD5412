using Projeto_UFCD5412.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Projeto_UFCD5412.Data;

namespace Projeto_UFCD5412.Controller
{
    internal class LoginController
    {

        private List<Funcionario> funcionarios = new List<Funcionario>();
        public LoginController()
        {
            funcionarios = CSVHandler.LoadFromCSV();
        }   

        public string Login(string username, string password)
        {
            if (username == "admin" && password == "admin")
            {
                return "admin";
            }
            Funcionario funcionario = funcionarios.Find(f => f.Username == username && f.Password == password);  
            if (funcionario != null)
            {
                if(funcionario.PrimeiroLogin)
                {
                    return "PrimeiroLogin"; 
                }
                else
                {
                    return funcionario.Tipo;  
                }
            }
            else
            {
                return null;
            }
           
        }

        public bool AlterarPassword(string username, string novaPassword)
        {
            Funcionario funcionario = funcionarios.Find(f => f.Username == username);
            funcionario.Password = novaPassword;
            funcionario.PrimeiroLogin = false;
            CSVHandler.ExportToCSV(funcionarios);
            return true;
        }
    }
}
