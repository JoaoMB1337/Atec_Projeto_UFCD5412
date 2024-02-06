using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projeto_UFCD5412.Model
{
    internal class Coordenador : Funcionario
    {
        public string Curso { get; set; }
        public List<Formador> FormadoresAssociados { get; set; }

        public Coordenador(int id, string nome, string morada, string contacto, string tipo, DateTime dataFimContrato, DateTime dataRegistoCriminal, string curso, List<Formador> formadoresAssociados)
          : base(id, nome, morada, contacto, tipo, dataFimContrato, dataRegistoCriminal)
        {
            Curso = curso;
            FormadoresAssociados = formadoresAssociados;
            Tipo = "Coordenador";
        }
    }
}
