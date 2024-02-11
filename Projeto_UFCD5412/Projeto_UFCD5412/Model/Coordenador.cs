using System;
using System.Collections.Generic;

namespace Projeto_UFCD5412.Model
{
    internal class Coordenador : Funcionario
    {
        public string Curso { get; set; }
        public List<Formador> FormadoresAssociados { get; set; }

        public Coordenador(int id, string nome, string morada, string contacto, string tipo,
                           decimal salario, DateTime dataAniverario, DateTime dataContrato,
                           DateTime dataFimContrato, DateTime dataRegistoCriminal,
                           DateTime dataFimRegistoCriminal, string username, string password,
                           bool primeiroLogin, string curso, List<Formador> formadoresAssociados)
            : base(id, nome, morada, contacto, tipo, salario, dataAniverario, dataContrato,
                   dataFimContrato, dataRegistoCriminal, dataFimRegistoCriminal, username,
                   password, primeiroLogin)
        {
            Curso = curso;
            FormadoresAssociados = formadoresAssociados;
            Tipo = "Coordenador";
        }
    }
}
