using Projeto_UFCD5412.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;

namespace Projeto_UFCD5412.Data
{
    public class CSVFormacao
    {
        private const string filePath = "formacoes.csv";

        public static List<Formacao> LoadFromCSV()
        {
            List<Formacao> formacoes = new List<Formacao>();

            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] parts = line.Split(',');

                            if (parts.Length == 6)
                            {
                                DateTime dataInicio = DateTime.ParseExact(parts[0], "yyyy-MM-dd HH:mm:ss", null);
                                DateTime dataFim = DateTime.ParseExact(parts[1], "yyyy-MM-dd HH:mm:ss", null);
                                string formador = parts[2];
                                string turma = parts[3];
                                string horaInicio = parts[4];
                                string horaFim = parts[5];

                                Formacao formacao = new Formacao(dataInicio, dataFim, horaInicio, horaFim, formador, turma);
                                formacoes.Add(formacao);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao carregar as formações do CSV: {ex.Message}");
            }

            return formacoes;
        }

        public static void ExportToCSV(List<Formacao> formacoes)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (var formacao in formacoes)
                    {
                        string formattedDataInicio = formacao.DataInicio.ToString("yyyy-MM-dd HH:mm:ss");
                        string formattedDataFim = formacao.DataFim.ToString("yyyy-MM-dd HH:mm:ss");
                        string line = $"{formattedDataInicio},{formattedDataFim},{formacao.Formador},{formacao.Turma},{formacao.HoraInicio},{formacao.HoraFim}";
                        sw.WriteLine(line);
                    }
                }

                Console.WriteLine("Formacoes exportadas com sucesso para o arquivo CSV.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao exportar as formações: {ex.Message}");
            }
        }

        public static void AdicionarFormacao(Formacao formacao)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    string formattedDataInicio = formacao.DataInicio.ToString("yyyy-MM-dd HH:mm:ss");
                    string formattedDataFim = formacao.DataFim.ToString("yyyy-MM-dd HH:mm:ss");
                    string line = $"{formattedDataInicio},{formattedDataFim},{formacao.Formador},{formacao.Turma},{formacao.HoraInicio},{formacao.HoraFim}";
                    sw.WriteLine(line);
                }

                Console.WriteLine("Formacao adicionada com sucesso ao arquivo CSV.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao adicionar formação ao CSV: {ex.Message}");
            }
        }

        public static void EditarFormacao(Formacao formacaoOriginal, Formacao formacaoEditada)
        {
            try
            {
                List<Formacao> formacoes = LoadFromCSV();
                formacoes.Remove(formacaoOriginal);
                formacoes.Add(formacaoEditada);
                ExportToCSV(formacoes);
                Console.WriteLine("Formacao editada com sucesso no arquivo CSV.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao editar formação no CSV: {ex.Message}");
            }
        }

    }
}
