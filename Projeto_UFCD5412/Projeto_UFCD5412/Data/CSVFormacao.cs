using Projeto_UFCD5412.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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


        //public static Dictionary<DateTime, List<Formacao>> ImportarFormacoes()
        //{
        //    var eventosPorDia = new Dictionary<DateTime, List<Formacao>>();

        //    try
        //    {
        //        if (!File.Exists(filePath))
        //        {
        //            // If the file does not exist, create it
        //            File.Create(filePath).Close();
        //        }

        //        using (StreamReader sr = new StreamReader(filePath))
        //        {
        //            string line;
        //            while ((line = sr.ReadLine()) != null)
        //            {
        //                string[] parts = line.Split(',');
        //                if (parts.Length == 3)
        //                {
        //                    DateTime dataInicio = DateTime.ParseExact(parts[0], "yyyy-MM-dd HH:mm:ss", null).Date;
        //                    string formador = parts[1];
        //                    string turma = parts[2];
        //                    var novaFormacao = new Formacao
        //                    {
        //                        Data = dataInicio,
        //                        Formador = formador,
        //                        Turma = turma
        //                    };

        //                    if (!eventosPorDia.ContainsKey(dataInicio))
        //                    {
        //                        eventosPorDia[dataInicio] = new List<Formacao>();
        //                    }
        //                    eventosPorDia[dataInicio].Add(novaFormacao);
        //                }
        //            }
        //        }
        //    }
        //    catch (FileNotFoundException)
        //    {
        //        // Handle file not found exception
        //    }

        //    return eventosPorDia;
        //}

        //public static void ExportarFormacoes(Dictionary<DateTime, List<Formacao>> eventosPorDia)
        //{
        //    try
        //    {
        //        if (eventosPorDia != null && eventosPorDia.Any())
        //        {
        //            using (StreamWriter sw = new StreamWriter(filePath))
        //            {
        //                foreach (var kvp in eventosPorDia)
        //                {
        //                    foreach (var formacao in kvp.Value)
        //                    {
        //                    //    string formattedDate = formacao.Data.ToString("yyyy-MM-dd HH:mm:ss");
        //                    //    string line = $"{formattedDate},{formacao.Formador},{formacao.Turma},{formacao.HoraInicio},{formacao.HoraFim}";
        //                    //    sw.WriteLine(line);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Ocorreu um erro ao exportar as formações: {ex.Message}");
        //    }
        //}



    }
}
