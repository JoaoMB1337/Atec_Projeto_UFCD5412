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

        public int CountNumeroTotalFuncionarios()
        {
            return Funcionarios.Count;
        }   

        public int CountNumeroTipoFuncionarios(string tipo)
        {
            return Funcionarios.Count(f => f.Tipo == tipo);
        }





        public Funcionario GetFuncionarioById(int id)
        {
            var funcionario = Funcionarios.FirstOrDefault(f => f.Id == id);
            return funcionario;
        }


        public void AdicionarFuncionario(Funcionario funcionario)
        {
            funcionario.Id = Funcionarios.Count +1;
            Funcionarios.Add(funcionario);
            CSVHandler.AddFuncionario(funcionario);
        }

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
                Console.WriteLine("Registo criminal atualizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
        }

        public decimal CalcularValorAPagar(Formador formador, DateTime dataInicio, DateTime dataFim)
        {
            int totalDias = (int)(dataFim - dataInicio).TotalDays + 1;

            int totalHoras = totalDias * 6;

            decimal valorTotal = totalHoras * formador.ValorHora;

            return valorTotal;
        }

        private Funcionario EncontrarFuncionarioComSalarioMaisAlto(List<Funcionario> funcionarios)
        {
            if (funcionarios == null || funcionarios.Count == 0)
                return null;

            
            Funcionario funcionarioComSalarioMaisAlto = funcionarios[0];

           
            foreach (var funcionario in funcionarios)
            {
                if (funcionario.Salario > funcionarioComSalarioMaisAlto.Salario)
                {
                    funcionarioComSalarioMaisAlto = funcionario;
                }
            }

            return funcionarioComSalarioMaisAlto;
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
    }
}