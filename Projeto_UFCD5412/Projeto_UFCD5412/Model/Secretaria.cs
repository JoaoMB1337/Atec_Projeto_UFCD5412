using System;
using System.Collections.Generic;

namespace Projeto_UFCD5412.Model
{
    internal class Secretaria : Funcionario
    {
        public string DiretorResponsavel { get; set; }
        public string Area { get; set; }

        public Secretaria(int id, string nome, string morada, string contacto, string tipo,
                          decimal salario, DateTime dataAniverario, DateTime dataContrato,
                          DateTime dataFimContrato, DateTime dataRegistoCriminal,
                          DateTime dataFimRegistoCriminal, string username, string password,
                          bool primeiroLogin, string diretorResponsavel, string area)
            : base(id, nome, morada, contacto, tipo, salario, dataAniverario, dataContrato,
                   dataFimContrato, dataRegistoCriminal, dataFimRegistoCriminal, username,
                   password, primeiroLogin)
        {
            DiretorResponsavel = diretorResponsavel;
            Area = area;
            Tipo = "Secretaria";
        }
    }
}
