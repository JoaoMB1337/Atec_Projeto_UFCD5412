using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UFCD5412
{
    internal class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Morada { get; set; }
        public string Contacto { get; set; }
        public DateTime DataFimContrato { get; set; }
        public DateTime DataRegistoCriminal { get; set; }

        public Funcionario(int id, string nome, string morada, string contacto, DateTime dataFimContrato, DateTime dataRegistoCriminal)
        {
            Id = id;
            Nome = nome;
            Morada = morada;
            Contacto = contacto;
            DataFimContrato = dataFimContrato;
            DataRegistoCriminal = dataRegistoCriminal;
        }
    }
}
