using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
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
                using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
                {
                    sw.WriteLine("ID;Nome;Morada;Contacto;FimContrato;RegistoCriminal;Tipo;OutrosAtributosEspecificos");

                    foreach (var funcionario in funcionarios)
                    {
                        string commonAttributes = $"{funcionario.Id};{funcionario.Nome};{funcionario.Morada};{funcionario.Contacto};{funcionario.Tipo};{funcionario.DataContrato};" +
                            $"{funcionario.DataFimContrato};{funcionario.DataRegistoCriminal};{funcionario.DataRegistoCriminal}";

                        if (funcionario is Diretor diretor)
                        {
                            sw.WriteLine($"{commonAttributes};{diretor.IseHorario};{diretor.BonusMensal};{diretor.CarroEmpresa};{diretor.Departamento}");
                        }
                        else if (funcionario is Secretaria secretaria)
                        {
                            sw.WriteLine($"{commonAttributes};{secretaria.DiretorResponsavel};{secretaria.Area}");
                        }
                        else if (funcionario is Formador formador)
                        {
                            sw.WriteLine($"{commonAttributes};{formador.AreaLecionada};{formador.Disponibilidade};{formador.ValorHora}");
                        }
                        else if (funcionario is Coordenador coordenador)
                        {
                            sw.WriteLine($"{commonAttributes};{coordenador.Curso};{coordenador.FormadoresAssociados}");
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

        public static List<Funcionario> LoadFromCSV()
        {
            List<Funcionario> Funcionarios = new List<Funcionario>();

            try
            {
                using (StreamReader sr = new StreamReader(@"funcionarios.csv"))
                {

                    sr.ReadLine(); // Ignorar a primeira linha (cabeçalho)

                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(';');

                        int id = int.Parse(line[0]);
                        string nome = line[1];
                        string morada = line[2];
                        string contacto = line[3];
                        string tipo = line[4];
                        DateTime dataContrato = DateTime.Parse(line[5]);
                        DateTime dataFimContrato = DateTime.Parse(line[6]);
                        DateTime dataRegistoCriminal = DateTime.Parse(line[7]);
                        DateTime dataFimRegistoCriminal = DateTime.Parse(line[8]);

                        switch (tipo)
                        {
                            case "Diretor":
                                bool isencaoHorario = bool.Parse(line[9]);
                                decimal bonusMensal = decimal.Parse(line[10]);
                                bool carroEmpresa = bool.Parse(line[11]);
                                string departamento = line[12];

                                Funcionarios.Add(new Diretor(id, nome, morada, contacto, tipo, dataContrato, dataFimContrato, dataRegistoCriminal, dataFimRegistoCriminal, isencaoHorario, bonusMensal, carroEmpresa, departamento));
                                break;

                            case "Secretaria":
                                string diretorResponsavel = line[9];
                                string area = line[10];

                                Funcionarios.Add(new Secretaria(id, nome, morada, contacto, tipo, dataContrato, dataFimContrato, dataRegistoCriminal, dataFimRegistoCriminal, diretorResponsavel, area));
                                break;

                            case "Formador":
                                string areaLecionada = line[9];
                                string disponibilidade = line[10];
                                decimal valorHora = decimal.Parse(line[11]);

                                Funcionarios.Add(new Formador(id, nome, morada, contacto, tipo, dataContrato, dataFimContrato, dataRegistoCriminal, dataFimRegistoCriminal, areaLecionada, disponibilidade, valorHora));
                                break;

                            case "Coordenador":
                                string curso = line[9];
                                List<Formador> formadoresAssociados = new List<Formador>();
                                Funcionarios.Add(new Coordenador(id, nome, morada, contacto, tipo, dataContrato, dataFimContrato, dataRegistoCriminal, dataFimRegistoCriminal, curso, formadoresAssociados));
                                break;

                            default:
                                
                                break;
                        }
                    }
                }

                Console.WriteLine("Importação do CSV concluída com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao importar do CSV: {ex.Message}");
            }

            return Funcionarios;
        }

    }
}
