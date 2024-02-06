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

        public static void ExportToCSV(List<Funcionario> funcionarios)
        {
            string filePath = @"funcionarios.csv";
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine("ID,Nome,Morada,Contacto,FimContrato,RegistoCriminal,Tipo,OutrosAtributosEspecificos");

                    foreach (var funcionario in funcionarios)
                    {
                        string commonAttributes = $"{funcionario.Id},{funcionario.Nome},{funcionario.Morada},{funcionario.Contacto},{funcionario.Tipo},{funcionario.DataFimContrato},{funcionario.DataRegistoCriminal},{funcionario.RegistoCriminalAtualizado},{funcionario.DataFimContrato},{funcionario.GetType().Name}";

                        if (funcionario is Diretor diretor)
                        {
                            sw.WriteLine($"{commonAttributes},{diretor.IseHorario},{diretor.BonusMensal},{diretor.CarroEmpresa}");
                        }
                        else if (funcionario is Secretaria secretaria)
                        {
                            sw.WriteLine($"{commonAttributes},{secretaria.DiretorResponsavel},{secretaria.Area}");
                        }
                        else if (funcionario is Formador formador)
                        {
                            sw.WriteLine($"{commonAttributes},{formador.AreaLecionada},{formador.Disponibilidade},{formador.ValorHora}");
                        }
                        else if(funcionario is Coordenador coordenador)
                        {
                            sw.WriteLine($"{commonAttributes},{coordenador.Curso},{coordenador.FormadoresAssociados}");
                        }
                    }
                }

                Console.WriteLine("Exportação para CSV concluída com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao exportar para CSV: {ex.Message}");
            }

        }   

        public static void ExportToCSVDiretor(List<Diretor> diretores)
        {
            string filePath = @"diretores.csv";
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine("ID,Nome,Morada,Contacto,FimContrato,RegistoCriminal,Tipo,OutrosAtributosEspecificos");

                    foreach (var diretor in diretores)
                    {
                        sw.WriteLine($"{diretor.Id},{diretor.Nome},{diretor.Morada},{diretor.Contacto},{diretor.Tipo},{diretor.DataFimContrato},{diretor.DataRegistoCriminal},{diretor.GetType().Name},{diretor.IseHorario},{diretor.BonusMensal},{diretor.CarroEmpresa}");
                    }
                }

                Console.WriteLine("Exportação para CSV concluída com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao exportar para CSV: {ex.Message}");
            }
                
        }

        public static void ExportToCSVFormador(List<Formador> formadores)
        {
            string filePath = @"formadores.csv";
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine("ID,Nome,Morada,Contacto,FimContrato,RegistoCriminal,Tipo,OutrosAtributosEspecificos");

                    foreach (var formador in formadores)
                    {
                        sw.WriteLine($"{formador.Id},{formador.Nome},{formador.Morada},{formador.Contacto},{formador.Tipo},{formador.DataFimContrato},{formador.DataRegistoCriminal},{formador.GetType().Name},{formador.AreaLecionada},{formador.Disponibilidade},{formador.ValorHora}");
                    }
                }

                Console.WriteLine("Exportação para CSV concluída com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao exportar para CSV: {ex.Message}");
            }
        }

        public static void ExportToCSVCoordenador(List<Coordenador> coordenadores)
        {
            string filePath = @"coordenadores.csv";
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine("ID,Nome,Morada,Contacto,FimContrato,RegistoCriminal,Tipo,OutrosAtributosEspecificos");

                    foreach (var coordenador in coordenadores)
                    {
                        sw.WriteLine($"{coordenador.Id},{coordenador.Nome},{coordenador.Morada},{coordenador.Contacto},{coordenador.Tipo},{coordenador.DataFimContrato},{coordenador.DataRegistoCriminal},{coordenador.GetType().Name},{coordenador.Curso},{coordenador.FormadoresAssociados}");
                    }
                }

                Console.WriteLine("Exportação para CSV concluída com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao exportar para CSV: {ex.Message}");
            }
        }

        public static void ExportToCSVSecretaria(List<Secretaria> secretarias)
        {
            string filePath = @"secretarias.csv";
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine("ID,Nome,Morada,Contacto,FimContrato,RegistoCriminal,Tipo,OutrosAtributosEspecificos");

                    foreach (var secretaria in secretarias)
                    {
                        sw.WriteLine($"{secretaria.Id},{secretaria.Nome},{secretaria.Morada},{secretaria.Contacto},{secretaria.Tipo},{secretaria.DataFimContrato},{secretaria.DataRegistoCriminal},{secretaria.GetType().Name},{secretaria.DiretorResponsavel},{secretaria.Area}");
                    }
                }

                Console.WriteLine("Exportação para CSV concluída com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao exportar para CSV: {ex.Message}");
            }
        }
    }
}
