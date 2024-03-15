using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UFCD5412.Model
{
    public class Formacao
    {
        //campos da formação
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFim { get; set; }
        public string Formador { get; set; }
        public string Turma { get; set; }

        //construtor
        public Formacao(DateTime dataInicio, DateTime dataFim, string horaInicio, string horaFim, string formador, string turma)
        {
            DataInicio = dataInicio;
            DataFim = dataFim;
            HoraInicio = horaInicio;
            HoraFim = horaFim;
            Formador = formador;
            Turma = turma;
        }


        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Formacao formacao = (Formacao)obj;
            return DataInicio == formacao.DataInicio && DataFim == formacao.DataFim && HoraInicio == formacao.HoraInicio && HoraFim == formacao.HoraFim && Formador == formacao.Formador && Turma == formacao.Turma;
        }

        public override int GetHashCode()
        {
            return DataInicio.GetHashCode() ^ DataFim.GetHashCode() ^ HoraInicio.GetHashCode() ^ HoraFim.GetHashCode() ^ Formador.GetHashCode() ^ Turma.GetHashCode();
        }



    }
}
