using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UFCD5412.Model
{
    internal class Diretor : Funcionario
    {
        private int v1;
        private double v2;
        private bool v3;

        public bool IseHorario { get; set; }
        public decimal BonusMensal { get; set; }
        public bool CarroEmpresa { get; set; }
        public string Departamento { get; set; }

        public Diretor(int id, string nome, string morada, string contacto,string tipo, DateTime dataContrato, DateTime dataFimContrato, DateTime dataRegistoCriminal, DateTime dataFimRegistoCriminal, bool isencaoHorario, decimal bonusMensal, bool carroEmpresa, string departamento)
          : base(id, nome, morada, contacto,tipo, dataContrato, dataFimContrato, dataRegistoCriminal, dataFimRegistoCriminal)
        {
            IseHorario = isencaoHorario;
            BonusMensal = bonusMensal;
            CarroEmpresa = carroEmpresa;
            Departamento = departamento;
            Tipo = "Diretor";
        }
    }
}
