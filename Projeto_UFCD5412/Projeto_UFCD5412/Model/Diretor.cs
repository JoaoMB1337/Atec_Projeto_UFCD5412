using System;
using System.Collections.Generic;

namespace Projeto_UFCD5412.Model
{
    internal class Diretor : Funcionario
    {
        public bool IseHorario { get; set; }
        public decimal BonusMensal { get; set; }
        public bool CarroEmpresa { get; set; }
        public string Departamento { get; set; }

        public Diretor(int id, string nome, string morada, string contacto, string tipo,
                       decimal salario, DateTime dataAniverario, DateTime dataContrato,
                       DateTime dataFimContrato, DateTime dataRegistoCriminal,
                       DateTime dataFimRegistoCriminal, string username, string password,
                       bool primeiroLogin, bool isencaoHorario, decimal bonusMensal,
                       bool carroEmpresa, string departamento)
            : base(id, nome, morada, contacto, tipo, salario, dataAniverario, dataContrato,
                   dataFimContrato, dataRegistoCriminal, dataFimRegistoCriminal, username,
                   password, primeiroLogin)
        {
            IseHorario = isencaoHorario;
            BonusMensal = bonusMensal;
            CarroEmpresa = carroEmpresa;
            Departamento = departamento;
            Tipo = "Diretor";
        }
    }
}
