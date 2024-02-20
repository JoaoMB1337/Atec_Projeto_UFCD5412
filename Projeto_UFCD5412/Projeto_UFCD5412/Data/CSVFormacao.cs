using Projeto_UFCD5412.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UFCD5412.Data
{
    public class CSVFormacao
    {
        private const string filePath = "formacoes.csv";

        public static Dictionary<DateTime, List<Formacao.FormacaoAgendada>> ImportarFormacoes()
        {
            var eventosPorDia = new Dictionary<DateTime, List<Formacao.FormacaoAgendada>>();

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 6)
                        {
                            DateTime dataInicio = DateTime.Parse(parts[0]);
                            DateTime dataFim = DateTime.Parse(parts[1]);
                            string horaInicio = parts[2];
                            string horaFim = parts[3];
                            string formador = parts[4];
                            string turma = parts[5];
                            var novaFormacao = new Formacao.FormacaoAgendada
                            {
                                Data = dataInicio,
                                HoraInicio = horaInicio,
                                HoraFim = horaFim,
                                Formador = formador,
                                Turma = turma
                            };

                            if (!eventosPorDia.ContainsKey(dataInicio))
                            {
                                eventosPorDia[dataInicio] = new List<Formacao.FormacaoAgendada>();
                            }
                            eventosPorDia[dataInicio].Add(novaFormacao);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                // Handle file not found exception
            }

            return eventosPorDia;
        }

        public static void ExportarFormacoes(Dictionary<DateTime, List<Formacao.FormacaoAgendada>> eventosPorDia)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (var kvp in eventosPorDia)
                    {
                        foreach (var formacao in kvp.Value)
                        {
                            string line = $"{kvp.Key},{formacao.Data},{formacao.HoraInicio},{formacao.HoraFim},{formacao.Formador},{formacao.Turma}";
                            sw.WriteLine(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao exportar as formações: {ex.Message}");
            }
        }
    }
}