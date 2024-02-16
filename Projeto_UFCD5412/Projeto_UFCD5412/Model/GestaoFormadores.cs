using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UFCD5412.Model
{
    internal class GestaoFormadores //esta classe serve para gerir os formadores , aloca-los a cursos e disciplinas , respetivos horarios de formacao.
    {
        public int FormacaoID { get; set; }
        public string NomeFormador { get; set; }
        public string Descricao { get; set; }
        public DateTime InicioFormacao { get; set; }
        public DateTime FimFormacao { get; set; }

        public GestaoFormadores(int formacaoID, string nomeFormador, string descricao, DateTime inicioFormacao, DateTime fimFormacao)//construtor para listar formadores
        {
            FormacaoID = formacaoID;
            NomeFormador = nomeFormador;
            Descricao = descricao;
            InicioFormacao = inicioFormacao;
            FimFormacao = fimFormacao;
        }

       


    }
}
