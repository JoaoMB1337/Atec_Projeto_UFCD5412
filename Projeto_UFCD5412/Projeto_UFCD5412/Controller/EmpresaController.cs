using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_UFCD5412.Data;
using Projeto_UFCD5412.Model;

namespace Projeto_UFCD5412
{
    internal class EmpresaController
    {
        public List<Funcionario> Funcionarios { get; set; }

        public EmpresaController()
        {
            Funcionarios = new List<Funcionario>();
        }

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            Funcionarios.Add(funcionario);
        }

        public void ListarFuncionarios()
        {
            foreach (var funcionario in Funcionarios)
            {
                Console.WriteLine(funcionario);
            }
        }

        public void AlterarRegistroCriminal(int id, bool atualizado)
        {
            var funcionario = Funcionarios.FirstOrDefault(f => f.Id == id);//FirstOrDefault retorna o primeiro elemento de uma sequência ou um valor padrão se a sequência não contiver elementos.
            if (funcionario != null)
            {
                funcionario.RegistoCriminalAtualizado = atualizado;
                Console.WriteLine("Registro criminal atualizado.");
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
        }

        public void ListarFuncionariosComContratoValido(DateTime dataAtual)
        {
            var funcionariosComContratoValido = Funcionarios.Where(f => f.DataContrato <= dataAtual).ToList();//filtrar os funcionários cuja  (DataContrato) <= à dataAtual, ToList() converte o resultado do filtro em uma lista
            if (funcionariosComContratoValido.Any())
            {
                Console.WriteLine("Funcionários com contrato válido para a data atual:");
                foreach (var funcionario in funcionariosComContratoValido)
                {
                    Console.WriteLine(funcionario);
                }
            }
            else
            {
                Console.WriteLine("Nenhum funcionário possui contrato válido para a data atual.");
            }
        }

        public void ListarFuncionariosComRegistoCriminalExpirado(DateTime dataAtual)
        {
            var funcionariosComRegistoCriminalExpirado = Funcionarios.Where(f => f.DataRegistoCriminal <= dataAtual).ToList();//filtrar os funcionários cuja  (DataRegistoCriminal) <= à dataAtual, ToList() converte o resultado do filtro em uma lista
            if (funcionariosComRegistoCriminalExpirado.Any())
            {
                Console.WriteLine("Funcionários com registo criminal expirado para a data atual:");
                foreach (var funcionario in funcionariosComRegistoCriminalExpirado)
                {
                    Console.WriteLine(funcionario);
                }
            }
            else
            {
                Console.WriteLine("Nenhum funcionário possui registo criminal expirado para a data atual.");
            }
        }

        public decimal CalcularValorAPagar(Formador formador, DateTime dataInicio, DateTime dataFim)
        {
            int totalDias = (int)(dataFim - dataInicio).TotalDays + 1;

            int totalHoras = totalDias * 6;

            decimal valorTotal = totalHoras * formador.ValorHora;

            return valorTotal;
        }




    }
}
