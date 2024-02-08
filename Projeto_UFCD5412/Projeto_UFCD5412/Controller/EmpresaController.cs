using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_UFCD5412.Data;
using Projeto_UFCD5412.Model;

namespace Projeto_UFCD5412.Controller
{
    internal class EmpresaController
    {
        public List<Funcionario> Funcionarios { get; set; }

        public EmpresaController()
        {
            Funcionarios = new List<Funcionario>();
            Funcionarios = CSVHandler.LoadFromCSV();
        }

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            Funcionarios.Add(funcionario);
        }

        public List<Funcionario> ListarFuncionarios()
        {
            return Funcionarios;
        }

        public List<Funcionario> ListarFuncionariosComContratoValido(DateTime dataAtual)
        {
            var funcionariosComContratoValido = Funcionarios.Where(f => f.DataContrato <= dataAtual).ToList();
            return funcionariosComContratoValido;
        }

        public List<Funcionario> ListarFuncionariosComRegistoCriminalExpirado(DateTime dataAtual)
        {
            var funcionariosComRegistoCriminalExpirado = Funcionarios.Where(f => f.DataFimRegistoCriminal <= dataAtual).ToList();
            return funcionariosComRegistoCriminalExpirado;
        }

        public void AtualizarRegistoCriminal(int id, DateTime dataFimRegistoCriminal)
        {
            var funcionario = Funcionarios.FirstOrDefault(f => f.Id == id);//FirstOrDefault() retorna o primeiro elemento que satisfaça a condição ou null se não existir nenhum
            if (funcionario != null)
            {
                funcionario.DataFimRegistoCriminal = dataFimRegistoCriminal;
              
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