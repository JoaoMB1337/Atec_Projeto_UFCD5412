using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_UFCD5412.Model;


namespace Projeto_UFCD5412.Data
{
    internal class CSVHandler
    {
        const string PATH = @"funcionarios.csv";
        public static void EscreverCsv(List<Funcionario> funcionarios)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(PATH, true, Encoding.UTF8))
                {
                    foreach (var funcionario in funcionarios)
                    {
                        string linha = $"{funcionario.Id},{funcionario.Nome},{funcionario.Morada},{funcionario.Contacto},{funcionario.DataFimContrato},{funcionario.DataRegistoCriminal}";

                        if (funcionario is Diretor diretor)
                        {
                            linha += $",{diretor.IseHorario},{diretor.BonusMensal},{diretor.CarroEmpresa},{diretor.Departamento}";
                        }
                        else if (funcionario is Secretaria secretaria)
                        {
                            linha += $",{secretaria.DiretorResponsavel},{secretaria.Area}";
                        }
                        else if (funcionario is Formador formador)
                        {
                            linha += $",{formador.AreaLecionada},{formador.Disponibilidade},{formador.ValorHora}";
                        }
                        else if (funcionario is Coordenador coordenador)
                        {
                            linha += $",{coordenador.Curso}";

                            if (coordenador.FormadoresAssociados != null && coordenador.FormadoresAssociados.Count > 0)
                            {
                                linha += $",{string.Join(",", coordenador.FormadoresAssociados.Select(formadador => formadador.Id))}";
                            }
                        }

                        sw.WriteLine(linha);
                    }
                }

                Console.WriteLine("Ficheiro CSV criado com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao escrever ficheiro CSV: " + e.Message);
            }
        }

    }
}
