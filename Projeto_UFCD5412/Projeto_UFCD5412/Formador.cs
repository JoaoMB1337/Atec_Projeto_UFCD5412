﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UFCD5412
{
    internal class Formador : Funcionario
    {
        public string AreaLecionada { get; set; }
        public string Disponibilidade { get; set; }
        public decimal ValorHora { get; set; }

        public Formador(int id, string nome, string morada, string contacto, DateTime dataFimContrato, DateTime dataRegistoCriminal, string areaLecionada, string disponibilidade, decimal valorHora)
          : base(id, nome, morada, contacto, dataFimContrato, dataRegistoCriminal)
        {
            AreaLecionada = areaLecionada;
            Disponibilidade = disponibilidade;
            ValorHora = valorHora;
        }

    }
}