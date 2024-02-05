using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UFCD5412
{
    internal class Secretaria : Funcionario
    {
        public string DiretorResponsavel { get; set; }
        public string Area { get; set; }

        public Secretaria(int id, string nome, string morada, string contacto, DateTime dataFimContrato, DateTime dataRegistoCriminal, string diretorResponsavel, string area)
          : base(id, nome, morada, contacto, dataFimContrato, dataRegistoCriminal)
        {
            DiretorResponsavel = diretorResponsavel;
            Area = area;
        }
    }
}
