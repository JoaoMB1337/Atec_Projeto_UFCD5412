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
        public DateTime DataContrato { get; set; }
        public DateTime DataFimContrato { get; set; }
        public DateTime DataRegistoCriminal { get; set; }
        public DateTime DataFimRegistoCriminal { get; set; }

        public Funcionario(int id, string nome, string morada, string contacto,string tipo, DateTime dataContrato, DateTime dataFimContrato, DateTime dataRegistoCriminal, DateTime dataFimRegistoCriminal)
        {
            Id = id;
            Nome = nome;
            Morada = morada;
            Contacto = contacto;
            Tipo = tipo;
            DataContrato = dataContrato;
            DataFimContrato = dataFimContrato;
            DataRegistoCriminal = dataRegistoCriminal;
            DataFimRegistoCriminal = dataFimRegistoCriminal;
            
        }
    }
}
