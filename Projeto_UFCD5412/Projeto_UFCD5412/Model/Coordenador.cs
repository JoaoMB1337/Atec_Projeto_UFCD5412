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

        public Coordenador(int id, string nome, string morada, string contacto, string tipo, DateTime dataContrato, DateTime dataFimContrato, DateTime dataRegistoCriminal, DateTime dataFimRegistoCriminal, string curso, List<Formador> formadoresAssociados, DateTime dataAniverario, string username, string password, decimal salario, bool primeiroLogin)
          : base(id, nome, morada, contacto, tipo, dataContrato, dataFimContrato, dataRegistoCriminal, dataFimRegistoCriminal, dataAniverario, username, password, salario, primeiroLogin)
        {
            Curso = curso;
            FormadoresAssociados = formadoresAssociados;
            Tipo = "Coordenador";
        }
    }
}
