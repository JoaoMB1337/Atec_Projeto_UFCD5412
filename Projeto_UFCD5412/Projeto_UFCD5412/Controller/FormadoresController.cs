using Projeto_UFCD5412.Data;
using Projeto_UFCD5412.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UFCD5412.Controller
{
    internal class FormadoresController
    {
        private List<Formador> formadores;

        public FormadoresController(List<Funcionario> funcionarios)
        {
            if (funcionarios == null)
            {
                throw new ArgumentNullException(nameof(funcionarios), "A lista de funcionários não pode ser nula.");
            }

            // Filtrar apenas os funcionários do tipo Formador
            formadores = funcionarios.OfType<Formador>().ToList();
        }

        public List<string> ListarFormadores()
        {
            // Retorna uma lista de nomes de formadores
            return formadores.Select(f => f.Nome).ToList();
        }

        public void ListarDetalhesFormador(string nomeFormador)
        {
            // Encontre o formador com o nome especificado
            var formador = formadores.FirstOrDefault(f => f.Nome == nomeFormador);
            if (formador != null)
            {
                // Aqui você pode fazer algo com os detalhes do formador, como exibir em uma janela de diálogo
                Console.WriteLine($"Detalhes do formador {formador.Nome}:");
                Console.WriteLine($"Área lecionada: {formador.AreaLecionada}");
                Console.WriteLine($"Disponibilidade: {formador.Disponibilidade}");
                Console.WriteLine($"Valor hora: {formador.ValorHora}");
            }
            else
            {
                Console.WriteLine($"Formador com o nome {nomeFormador} não encontrado.");
            }
        }
    }
}