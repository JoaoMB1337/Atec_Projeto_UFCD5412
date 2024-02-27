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
        private static EmpresaController instance;
        private static readonly object lockObject = new object();

        private static int contadorId = 1;

        public EmpresaController()
        {
            Funcionarios = CSVHandler.LoadFromCSV();
            contadorId = Funcionarios.Count > 0 ? Funcionarios.Max(f => f.Id) + 1 : 1;
        }

        // Singleton Pattern - Garante que apenas existe uma instancia da classe
        public static EmpresaController Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new EmpresaController();
                    }
                    return instance;
                }
            }
        }


        #region Regiao de Contadores

        public int CountNumeroTotalFuncionarios()
        {
            return Funcionarios.Count;
        }   

        public int CountNumeroTipoFuncionarios(string tipo)
        {
            return Funcionarios.Count(f => f.Tipo == tipo);
        }

        public int CountContratosAtivos(DateTime dataAtual)
        {
            return Funcionarios.Count(f => f.DataFimContrato > dataAtual);
        }

        public Formador GetFormadorById(int id)
        {
            var formador = Funcionarios.FirstOrDefault(f => f.Id == id) as Formador;
            return formador;
        }

        public int CountContratosInativos(DateTime dataAtual)
        {
            return Funcionarios.Count(f => f.DataFimContrato < dataAtual);
        }

        public int CountRegistosCriminaisExpirados(DateTime dataAtual)
        {
            return Funcionarios.Count(f => f.DataFimRegistoCriminal < dataAtual);
        }

        public int CountRegistosCriminaisValidos(DateTime dataAtual)
        {
            return Funcionarios.Count(f => f.DataFimRegistoCriminal > dataAtual);
        }

        public int CountTotalFuncionarios()
        {
            return Funcionarios.Count;
        }

        #endregion


        #region Regiao Listagem funcionarios

        public List<Funcionario> ListarFuncionarios()
        {
            return Funcionarios;
        }

        public List<Funcionario> PesquisarFuncionariosPorNome(string nome)
        {
            var FuncionarioSearchName = Funcionarios.Where(funcionario => funcionario.Nome.ToLower().Contains(nome.ToLower())).ToList();
            return FuncionarioSearchName;

        }

        public List<Funcionario> ListarFuncionariosComContratoValido(DateTime dataAtual)
        {
            var funcionariosComContratoValido = Funcionarios.Where(f => f.DataFimContrato >= dataAtual).ToList();
            return funcionariosComContratoValido;
        }

        public List<Funcionario> ListarFuncionariosComRegistoCriminalExpirado(DateTime dataAtual)
        {
            var funcionariosComRegistoCriminalExpirado = Funcionarios.Where(f => f.DataFimRegistoCriminal <= dataAtual).ToList();
            return funcionariosComRegistoCriminalExpirado;
        }
        
        public Funcionario GetFuncionarioById(int id)
        {
            var funcionario = Funcionarios.FirstOrDefault(f => f.Id == id);
            return funcionario;
        }

        public Funcionario ProximoAniversario(DateTime dataAtual)
        {
            var proximoAniversario = Funcionarios
            .OrderBy(f =>
            {
                int mesAniversario = f.DataAniversario.Month;
                int diaAniversario = f.DataAniversario.Day;

                if (mesAniversario < dataAtual.Month || (mesAniversario == dataAtual.Month && diaAniversario < dataAtual.Day))
                {
                    return mesAniversario * 100 + diaAniversario + 10000;
                }
                else
                {
                    return mesAniversario * 100 + diaAniversario;
                }
            })
            .FirstOrDefault();

                return proximoAniversario;
        }


        #endregion


        #region Regiao de Adicionar, Atualizar e Remover Funcionarios
        public void AdicionarFuncionario(Funcionario funcionario)
        {
            funcionario.Id = Funcionarios.Count + 1;
            Funcionarios.Add(funcionario);
            CSVHandler.AddFuncionario(funcionario);
        }

        public void UpdateFuncionario(Funcionario updateFuncionario)
        {
            var funcionario = Funcionarios.FirstOrDefault(f => f.Id == updateFuncionario.Id);

            if (funcionario != null)
            {
                funcionario.Nome = updateFuncionario.Nome;
                funcionario.Morada = updateFuncionario.Morada;
                funcionario.Contacto = updateFuncionario.Contacto;
                funcionario.Tipo = updateFuncionario.Tipo;
                funcionario.DataContrato = updateFuncionario.DataContrato;
                funcionario.DataFimContrato = updateFuncionario.DataFimContrato;
                funcionario.DataRegistoCriminal = updateFuncionario.DataRegistoCriminal;
                funcionario.DataFimRegistoCriminal = updateFuncionario.DataFimRegistoCriminal;
                funcionario.DataAniversario = updateFuncionario.DataAniversario;
                funcionario.Salario = updateFuncionario.Salario;
                CSVHandler.ExportToCSV(Funcionarios);
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
        }

        public void RemoverFuncionario(Funcionario removerFuncionario)
       {
            var funcionario = Funcionarios.FirstOrDefault(f => f.Id == removerFuncionario.Id);

            if (funcionario != null)
            {
                Funcionarios.Remove(funcionario);
                CSVHandler.ExportToCSV(Funcionarios);
                Console.WriteLine("Funcionário removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
        }

        public void AtualizarRegistoCriminal(int id, DateTime dataFimRegistoCriminal)
        {
            var funcionario = Funcionarios.FirstOrDefault(f => f.Id == id);//FirstOrDefault() retorna o primeiro elemento que satisfaça a condição ou null se não existir nenhum
            if (funcionario != null)
            {
                funcionario.DataFimRegistoCriminal = dataFimRegistoCriminal;
                Console.WriteLine("Registo criminal atualizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
        }

        #endregion


        #region Calcular Salarios

        public decimal CalcularValorAPagar(Formador formador, DateTime dataInicio, DateTime dataFim)
        {
            int totalDias = (int)(dataFim - dataInicio).TotalDays + 1;

            int totalHoras = totalDias * 6;

            decimal valorTotal = totalHoras * formador.ValorHora;

            return valorTotal;
        }

        public decimal CalcularTotalSalariosPorTipo(string tipoFuncionario)
        {
            decimal totalSalarios = 0;

            if (tipoFuncionario == "Todos")
            {
                foreach (var funcionario in Funcionarios)
                {
                    totalSalarios += funcionario.Salario;
                }
            }
            else
            {
                var funcionarios = Funcionarios.Where(f => f.Tipo == tipoFuncionario).ToList();
                foreach (var funcionario in funcionarios)
                {
                    totalSalarios += funcionario.Salario;
                }
            }
            return totalSalarios;
        }


        #endregion



    }
}