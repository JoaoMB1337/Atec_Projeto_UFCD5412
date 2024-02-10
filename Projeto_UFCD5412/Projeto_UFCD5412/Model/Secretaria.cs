using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UFCD5412.Model
{
    internal class Secretaria : Funcionario
    {
        public string DiretorResponsavel { get; set; }
        public string Area { get; set; }

        public Secretaria(int id, string nome, string morada, string contacto, string tipo, DateTime dataContrato, DateTime dataFimContrato, DateTime dataRegistoCriminal, DateTime dataFimRegistoCriminal, string diretorResponsavel, string area, DateTime dataAniverario, string username, string password, decimal salario, bool primeiroLogin)
          : base(id, nome, morada, contacto, tipo, dataContrato, dataFimContrato, dataRegistoCriminal, dataFimRegistoCriminal, dataAniverario, username, password, salario, primeiroLogin)
        {
            DiretorResponsavel = diretorResponsavel;
            Area = area;
            Tipo = "Secretaria";
        }
    }
}
