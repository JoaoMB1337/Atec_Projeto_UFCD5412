using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UFCD5412.Model
{
    public class Formacao
    {
        // Campos da formação
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFim { get; set; }
        public string Formador { get; set; }
        public string Turma { get; set; }

        // Construtor
        public Formacao(DateTime dataInicio, DateTime dataFim, string horaInicio, string horaFim, string formador, string turma)
        {
            DataInicio = dataInicio;
            DataFim = dataFim;
            HoraInicio = horaInicio;
            HoraFim = horaFim;
            Formador = formador;
            Turma = turma;
        }

        public class FormacaoAgendada
        {
            public DateTime Data { get; set; }
            public string Formador { get; set; }
            public string Turma { get; set; }
        }
    }
}
