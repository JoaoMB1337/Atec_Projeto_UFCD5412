using System;
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

        public Diretor(int id, string nome, string morada, string contacto,string tipo, DateTime dataFimContrato, DateTime dataRegistoCriminal, bool isencaoHorario, decimal bonusMensal, bool carroEmpresa, string departamento)
          : base(id, nome, morada, contacto,tipo, dataFimContrato, dataRegistoCriminal)
        {
            IseHorario = isencaoHorario;
            BonusMensal = bonusMensal;
            CarroEmpresa = carroEmpresa;
            Departamento = departamento;
            Tipo = "Diretor";
        }
    }
}
