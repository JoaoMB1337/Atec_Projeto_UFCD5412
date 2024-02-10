﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UFCD5412.Model
{
    internal class Diretor : Funcionario
    {
        public bool IseHorario { get; set; }
        public decimal BonusMensal { get; set; }
        public bool CarroEmpresa { get; set; }
        public string Departamento { get; set; }

        public Diretor(int id, string nome, string morada, string contacto,string tipo, DateTime dataContrato, DateTime dataFimContrato, DateTime dataRegistoCriminal, DateTime dataFimRegistoCriminal, bool isencaoHorario, decimal bonusMensal, bool carroEmpresa, string departamento, DateTime dataAniverario, string username, string password, decimal salario, bool primeiroLogin)
          : base(id, nome, morada, contacto,tipo, dataContrato, dataFimContrato, dataRegistoCriminal, dataFimRegistoCriminal, dataAniverario, username, password, salario, primeiroLogin)
        {
            IseHorario = isencaoHorario;
            BonusMensal = bonusMensal;
            CarroEmpresa = carroEmpresa;
            Departamento = departamento;
            Tipo = "Diretor";
        }
    }
}
