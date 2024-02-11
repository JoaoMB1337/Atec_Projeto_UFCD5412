using System;
using System.Collections.Generic;

namespace Projeto_UFCD5412.Model
{
    internal class Formador : Funcionario
    {
        public string AreaLecionada { get; set; }
        public string Disponibilidade { get; set; }
        public decimal ValorHora { get; set; }

        public Formador(int id, string nome, string morada, string contacto, string tipo,
                        decimal salario, DateTime dataAniverario, DateTime dataContrato,
                        DateTime dataFimContrato, DateTime dataRegistoCriminal,
                        DateTime dataFimRegistoCriminal, string username, string password,
                        bool primeiroLogin, string areaLecionada, string disponibilidade,
                        decimal valorHora)
            : base(id, nome, morada, contacto, tipo, salario, dataAniverario, dataContrato,
                   dataFimContrato, dataRegistoCriminal, dataFimRegistoCriminal, username,
                   password, primeiroLogin)
        {
            AreaLecionada = areaLecionada;
            Disponibilidade = disponibilidade;
            ValorHora = valorHora;
            Tipo = "Formador";
        }
    }
}
