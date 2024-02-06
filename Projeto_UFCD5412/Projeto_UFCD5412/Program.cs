using Projeto_UFCD5412.Data;
using Projeto_UFCD5412.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            List<Funcionario> funcionarios = new List<Funcionario>
            {
                new Diretor(1, "Diretor1", "Morada1", "123456789", "Diretor", DateTime.Now, DateTime.Now, true, 1000, true, "Departamento1"),
                new Secretaria(2, "Secretaria1", "Morada2", "987654321", "Secretaria", DateTime.Now, DateTime.Now, "Diretor1", "Area1"),
                new Formador(3, "Formador1", "Morada3", "567890123", "Formador", DateTime.Now, DateTime.Now, "AreaLecionada1", "Disponibilidade1", 50),
                new Coordenador(4, "Coordenador1", "Morada4", "456789012", "Coordenador", DateTime.Now, DateTime.Now, "Curso1", new List<Formador> { new Formador(5, "Formador2", "Morada5", "123450987", "Formador", DateTime.Now, DateTime.Now, "AreaLecionada2", "Disponibilidade2", 60) })
            };

            CSVHandler.ExportToCSV(funcionarios);
            CSVHandler.ExportToCSVDiretor(funcionarios.OfType<Diretor>().ToList());
            CSVHandler.ExportToCSVSecretaria(funcionarios.OfType<Secretaria>().ToList());
            CSVHandler.ExportToCSVFormador(funcionarios.OfType<Formador>().ToList());
            CSVHandler.ExportToCSVCoordenador(funcionarios.OfType<Coordenador>().ToList());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
