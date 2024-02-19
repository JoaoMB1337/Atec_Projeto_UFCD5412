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

        public bool Login(string username, string password)
        {
            Funcionario funcionario = funcionarios.Find(f => f.Username == username && f.Password == password);  
            if (funcionario != null)
            {
                if(funcionario.PrimeiroLogin)
                {
                    MessageBox.Show("You are logging in for the first time, please change your password");
                    return true;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
