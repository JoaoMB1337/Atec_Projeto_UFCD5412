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

        public List<Funcionario> ListarFuncionariosPorTipo(string tipo)
        {
            var funcionariosPorTipo = Funcionarios.Where(f => f.Tipo == tipo).ToList();
            return funcionariosPorTipo;
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

        public List<string> ListarNomesFuncionariosInativos(DateTime dataAtual)
        {
            var nomesFuncionariosInativos = Funcionarios
            .Where(f => f.DataFimContrato < dataAtual)
            .Select(f => f.Nome)
            .ToList();
            return nomesFuncionariosInativos;
        }

        public List<string> ListarNomesFunciomariosComRegistoCriminalInativo(DateTime dataAtual)
        {
            var nomesFuncionariosComRegistoCriminalInativo = Funcionarios
            .Where(f => f.DataFimRegistoCriminal < dataAtual)
            .Select(f => f.Nome)
            .ToList();
            return nomesFuncionariosComRegistoCriminalInativo;
        }


        #endregion


        #region Regiao de Adicionar, Atualizar e Remover Funcionarios
        public void AdicionarFuncionario(Funcionario funcionario)
        {
            lock (lockObject)
            {
                funcionario.Id = contadorId++;
                Funcionarios.Add(funcionario);
                CSVHandler.AddFuncionario(funcionario);
            }
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


        public decimal CalcularTotalSalariosPorTipo(string tipoFuncionario,DateTime dataAtual)
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
                var funcionariosPorTipo = Funcionarios.Where(f => f.Tipo == tipoFuncionario).ToList(); 
                if(tipoFuncionario == "Formador")
                {
                    var formadores = Funcionarios.Where(f => f.Tipo == "Formador").ToList();
                    foreach (var formador in formadores)
                    {
                        totalSalarios += CalcularSalarioFormadores(formador, dataAtual);
                    }

                }
                else
                {
                    foreach (var funcionario in funcionariosPorTipo)
                    {
                        totalSalarios += funcionario.Salario;
                    }
                }
                
            }
            return totalSalarios;
        }


        public int CalcularDiasTrabalhadosNoMes(DateTime dataReferencia, DateTime dataInicio, DateTime dataFim)
        {
            int diasTrabalhados = 0;
            for (DateTime dataAtual = dataInicio; dataAtual <= dataFim; dataAtual = dataAtual.AddDays(1))
            {
                if (dataAtual.Month == dataReferencia.Month && dataAtual.Year == dataReferencia.Year)
                {
                    if (dataAtual.DayOfWeek != DayOfWeek.Saturday && dataAtual.DayOfWeek != DayOfWeek.Sunday)
                    {
                        diasTrabalhados++;
                    }
                }
            }

            return diasTrabalhados;
        }

        public decimal CalcularSalarioFormadores(Funcionario funcionario, DateTime dataReferencia)
        {
            if (funcionario is Formador formador)
            {
                DateTime dataInicio = funcionario.DataContrato;
                DateTime dataFim = funcionario.DataFimContrato;

                // Calcular o número de dias trabalhados no mês em questão
                int diasTrabalhadosNoMes = CalcularDiasTrabalhadosNoMes(dataReferencia, dataInicio, dataFim);

                // Calcular o salário com base nos dias trabalhados
                decimal salario = diasTrabalhadosNoMes * 6 * formador.ValorHora;
                return salario;
            }
            else
            {
                return funcionario.Salario;
            }
        }


        #endregion


        #region Algumas Verificacoes

        public bool VerificarSeUsernameExite(string username)
        {
            var funcionario = Funcionarios.FirstOrDefault(f => f.Username == username);
            return funcionario != null;
        }


        public bool VerificarNumerosTelefone(string contacto)
        {
            return contacto.Length == 9 && contacto.All(char.IsDigit);
        }

        public bool VerificarSeDataNascimentoValida(DateTime dataNascimento)
        {
            return dataNascimento < DateTime.Now;
        }

        public bool VerificarSeDataContratoValida(DateTime dataContrato)
        {
            return dataContrato < DateTime.Now;
        }

        public bool VerificarSeDataFimContratoValida(DateTime dataFimContrato, DateTime dataContrato)
        {
            return dataFimContrato > dataContrato;
        }
        public bool VerificarSeSalarioValido(decimal salario)
        {
            return salario > 0;
        }

        public bool VerificarSeValorHoraValido(decimal valorHora)
        {
            return valorHora > 0;
        }

        public bool VerificarAreaEnsino(string areaEnsino)
        {
            return areaEnsino != "";
        }


        public bool VerificarSeDataRegistoCriminalValida(DateTime dataRegistoCriminal)
        {
            return dataRegistoCriminal < DateTime.Now;
        }

        public bool VerificarSeDataFimRegistoCriminalValida(DateTime dataFimRegistoCriminal, DateTime dataRegistoCriminal)
        {
            return dataFimRegistoCriminal > dataRegistoCriminal;
        }
    
        
        public bool VerificarUsernameUnico(string username)
        {
            return Funcionarios.All(f => f.Username != username);
        }

        internal Funcionario FuncionarioMaisRecente()
        {
            return Funcionarios.OrderByDescending(f => f.DataContrato).FirstOrDefault();
        }



        #endregion

    }
}