using Projeto_UFCD5412.Data;
using Projeto_UFCD5412.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using Projeto_UFCD5412.View.Forms;
using Projeto_UFCD5412.View.LoginForms;
using System.Security.Cryptography.X509Certificates;
using Projeto_UFCD5412.Controller;
using Projeto_UFCD5412.View.CoordenacaoForms;
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

            //// Criar instâncias de funcionários
            //Diretor diretor1 = new Diretor(1, "Diretor1", "Morada1", "123456789", "Diretor", 5000, DateTime.Now.AddYears(-40), DateTime.Now.AddYears(-5), DateTime.Now.AddYears(5), DateTime.Now.AddYears(-2), DateTime.Now.AddYears(3), "dir1", "pass1", false, true, 1000, true, "Departamento1");
            //Diretor diretor2 = new Diretor(2, "Diretor2", "Morada2", "987654321", "Diretor", 6000, DateTime.Now.AddYears(-35), DateTime.Now.AddYears(-4), DateTime.Now.AddYears(4), DateTime.Now.AddYears(-1), DateTime.Now.AddYears(2), "dir2", "pass2", false, false, 800, false, "Departamento2");

            //Secretaria secretaria1 = new Secretaria(3, "Secretaria1", "Morada3", "111222333", "Secretaria", 3000, DateTime.Now.AddYears(-25), DateTime.Now.AddYears(-3), DateTime.Now.AddYears(3), DateTime.Now.AddYears(-1), DateTime.Now.AddYears(2), "sec1", "pass3", false, "Diretor1", "Área1");
            //Secretaria secretaria2 = new Secretaria(4, "Secretaria2", "Morada4", "444555666", "Secretaria", 3500, DateTime.Now.AddYears(-30), DateTime.Now.AddYears(-2), DateTime.Now.AddYears(2), DateTime.Now.AddYears(0), DateTime.Now.AddYears(1), "sec2", "pass4", false, "Diretor2", "Área2");

            //Formador formador1 = new Formador(5, "Formador1", "Morada5", "555666777", "Formador", 4000, DateTime.Now.AddYears(-28), DateTime.Now.AddYears(-2), DateTime.Now.AddYears(2), DateTime.Now.AddYears(-1), DateTime.Now.AddYears(1), "form1", "pass5", false, "Área1", "Tarde", 50);
            //Formador formador2 = new Formador(6, "Formador2", "Morada6", "888999000", "Formador", 4500, DateTime.Now.AddYears(-32), DateTime.Now.AddYears(-1), DateTime.Now.AddYears(1), DateTime.Now.AddYears(0), DateTime.Now.AddYears(1), "form2", "pass6", false, "Área2", "Manhã", 60);

            //Coordenador coordenador1 = new Coordenador(7, "Coordenador1", "Morada7", "123123123", "Coordenador", 5500, DateTime.Now.AddYears(-38), DateTime.Now.AddYears(-4), DateTime.Now.AddYears(4), DateTime.Now.AddYears(-2), DateTime.Now.AddYears(2), "coord1", "pass7", false, "Curso1", new List<Formador> { formador1, formador2 });
            //Coordenador coordenador2 = new Coordenador(8, "Coordenador2", "Morada8", "321321321", "Coordenador", 6000, DateTime.Now.AddYears(-40), DateTime.Now.AddYears(-3), DateTime.Now.AddYears(3), DateTime.Now.AddYears(-1), DateTime.Now.AddYears(1), "coord2", "pass8", false, "Curso2", new List<Formador> { formador1, formador2 });

            //// Criar listas
            //List<Funcionario> funcionarios = new List<Funcionario>
            //{
            //    diretor1, diretor2,
            //    secretaria1, secretaria2,
            //    formador1, formador2,
            //    coordenador1, coordenador2
            //};

            //// Exportar para CSV
            //CSVHandler.ExportToCSV(funcionarios);

            //// Limpar a lista (opcional, dependendo dos requisitos do seu programa)
            //funcionarios.Clear();

            //// Importar do CSV
            //funcionarios = CSVHandler.LoadFromCSV();

            //// Exibir informações
            //foreach (var funcionario in funcionarios)
            //{
            //    Console.WriteLine(funcionario);
            //}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CoordenacaoMainForm());



        }
    }
}
