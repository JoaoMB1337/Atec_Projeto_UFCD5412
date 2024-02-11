using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UFCD5412.Model
{
    internal class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Morada { get; set; }
        public string Contacto { get; set; }
        public string Tipo { get; set; }
        public decimal Salario { get; set; }

        public DateTime DataAniversario { get; set; }
        public DateTime DataContrato { get; set; }
        public DateTime DataFimContrato { get; set; }
        public DateTime DataRegistoCriminal { get; set; }
        public DateTime DataFimRegistoCriminal { get; set; }
       
        public string Username { get; set; }
        public string Password { get; set; }
        public bool PrimeiroLogin { get; set; }


        public Funcionario(int id, string nome, string morada, string contacto, string tipo, decimal salario, 
            DateTime dataAniverario, DateTime dataContrato, DateTime dataFimContrato, DateTime dataRegistoCriminal, DateTime dataFimRegistoCriminal,
            string username, string password, bool primeiroLogin){

            //Dados Pessoais
            Id = id;
            Nome = nome;
            Morada = morada;
            Contacto = contacto;
            Tipo = tipo;
            Salario = salario;

            //Datas
            DataAniversario = dataAniverario;
            DataContrato = dataContrato;
            DataFimContrato = dataFimContrato;
            DataRegistoCriminal = dataRegistoCriminal;
            DataFimRegistoCriminal = dataFimRegistoCriminal;

            //Login
            Username = username;
            Password = password;
            PrimeiroLogin = primeiroLogin;
        }

    }
}
