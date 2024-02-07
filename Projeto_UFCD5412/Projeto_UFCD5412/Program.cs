using Projeto_UFCD5412.Data;
using Projeto_UFCD5412.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Projeto_UFCD5412.Data;
using System.Runtime.CompilerServices;
using Projeto_UFCD5412.View.Forms;
namespace Projeto_UFCD5412
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Coordenador coordenador = new Coordenador(1, "João Silva", "Rua A, nº 123", "123456789", "Coordenador", DateTime.Now, DateTime.Now.AddYears(2), DateTime.Now, DateTime.Now.AddYears(1), "Engenharia", new List<Formador>());
            //Diretor diretor = new Diretor(2, "Maria Oliveira", "Rua B, nº 456", "987654321", "Diretor", DateTime.Now, DateTime.Now.AddYears(3), DateTime.Now, DateTime.Now.AddYears(2), true, 1500, true, "Administração");
            //Formador formador = new Formador(3, "Carlos Santos", "Rua C, nº 789", "111222333", "Formador", DateTime.Now, DateTime.Now.AddYears(1), DateTime.Now, DateTime.Now.AddMonths(6), "Programming", "Evenings", 30.5m);
            //Secretaria secretaria = new Secretaria(4, "Ana Pereira", "Rua D, nº 012", "444555666", "Secretaria", DateTime.Now, DateTime.Now.AddYears(2), DateTime.Now, DateTime.Now.AddYears(1), "João Diretor", "Administrativa");

            //List<Funcionario> funcionarios = new List<Funcionario>
            //{
            //    coordenador,
            //    diretor,
            //    formador,
            //    secretaria
            //};


            //foreach (var funcionario in funcionarios)
            //{
            //    Console.WriteLine($"ID: {funcionario.Id}, Nome: {funcionario.Nome}, Tipo: {funcionario.Tipo}");
            //}

            //CSVHandler.ExportToCSV(funcionarios);

            List<Funcionario> funcionarios = CSVHandler.LoadFromCSV();
            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine($"ID: {funcionario.Id}, Nome: {funcionario.Nome}, Tipo: {funcionario.Tipo}");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new AdicionarFuncionarioForm());
        }
    }
}
