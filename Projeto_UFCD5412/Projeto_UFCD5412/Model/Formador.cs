using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UFCD5412.Model
{
    internal class Formador : Funcionario
    {
        public string AreaLecionada { get; set; }
        public string Disponibilidade { get; set; }
        public decimal ValorHora { get; set; }


        public Formador(int id, string nome, string morada, string contacto, string tipo, DateTime dataContrato, DateTime dataFimContrato, DateTime dataRegistoCriminal, DateTime dataFimRegistoCriminal, string areaLecionada, string disponibilidade, decimal valorHora)
          : base(id, nome, morada, contacto, tipo, dataContrato, dataFimContrato, dataRegistoCriminal, dataFimRegistoCriminal)
        {
            AreaLecionada = areaLecionada;
            Disponibilidade = disponibilidade;
            ValorHora = valorHora;
            Tipo = "Formador";  
        }

    }
}
