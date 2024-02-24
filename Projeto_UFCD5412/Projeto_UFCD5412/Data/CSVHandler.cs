using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                    sw.WriteLine("ID;Nome;Morada;Contacto;Tipo;Salario;DataAniversario;DataContrato;DataFimContrato;DataRegistoCriminal;DataFimRegistoCriminal;Username;Password;PrimeiroLogin");

                    foreach (var funcionario in funcionarios)
                    {
                        string commonAttributes = $"{funcionario.Id};{funcionario.Nome};{funcionario.Morada};{funcionario.Contacto};" +
                            $"{funcionario.Tipo};{funcionario.Salario};{funcionario.DataAniversario};" +
                            $"{funcionario.DataContrato};{funcionario.DataFimContrato};{funcionario.DataRegistoCriminal};" +
                            $"{funcionario.DataFimRegistoCriminal};{funcionario.Username};{funcionario.Password};{funcionario.PrimeiroLogin}";

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
                        else if (funcionario is Funcionario)
                        {
                            sw.WriteLine(commonAttributes);
                        }

                        Console.WriteLine(funcionario.ToString());
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

                    sr.ReadLine();

                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(';');

                        int id = int.Parse(line[0]);
                        string nome = line[1];
                        string morada = line[2];
                        string contacto = line[3];
                        string tipo = line[4];
                        decimal salario = decimal.Parse(line[5]);
                        DateTime dataAniversario = DateTime.Parse(line[6]);
                        DateTime dataContrato = DateTime.Parse(line[7]);
                        DateTime dataFimContrato = DateTime.Parse(line[8]);
                        DateTime dataRegistoCriminal = DateTime.Parse(line[9]);
                        DateTime dataFimRegistoCriminal = DateTime.Parse(line[10]);
                        string username = line[11];
                        string password = line[12];
                        bool primeiroLogin = bool.Parse(line[13]);

                        switch (tipo)
                        {
                            case "Diretor":
                                bool isencaoHorario = bool.Parse(line[14]);
                                decimal bonusMensal = decimal.Parse(line[15]);
                                bool carroEmpresa = bool.Parse(line[16]);
                                string departamento = line[17];

                                Funcionarios.Add(new Diretor(id, nome, morada, contacto, tipo, salario, dataAniversario, dataContrato, dataFimContrato, dataRegistoCriminal, dataFimRegistoCriminal, username, password, primeiroLogin, isencaoHorario, bonusMensal, carroEmpresa, departamento));
                                break;

                            case "Secretaria":
                                string diretorResponsavel = line[14];
                                string area = line[15];

                                Funcionarios.Add(new Secretaria(id, nome, morada, contacto, tipo, salario, dataAniversario, dataContrato, dataFimContrato, dataRegistoCriminal, dataFimRegistoCriminal, username, password, primeiroLogin, diretorResponsavel, area));
                                break;

                            case "Formador":
                                string areaLecionada = line[14];
                                string disponibilidade = line[15];
                                decimal valorHora = decimal.Parse(line[16]);

                                Funcionarios.Add(new Formador(id, nome, morada, contacto, tipo, salario, dataAniversario, dataContrato, dataFimContrato, dataRegistoCriminal, dataFimRegistoCriminal, username, password, primeiroLogin, areaLecionada, disponibilidade, valorHora));
                                break;

                            case "Coordenador":
                                string curso = line[14];
                                List<Formador> formadoresAssociados = new List<Formador>();

                                Funcionarios.Add(new Coordenador(id, nome, morada, contacto, tipo, salario, dataAniversario, dataContrato, dataFimContrato, dataRegistoCriminal, dataFimRegistoCriminal, username, password, primeiroLogin, curso, formadoresAssociados));
                                break;
                            case "Funcionario":
                                Funcionarios.Add(new Funcionario(id, nome, morada, contacto, tipo, salario, dataAniversario, dataContrato, dataFimContrato, dataRegistoCriminal, dataFimRegistoCriminal, username, password, primeiroLogin));
                                break;

                            default:
                                throw new Exception("Tipo de funcionário desconhecido.");

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

        public static void AddFuncionario(Funcionario novoFuncionario)
        {
            string filePath = @"funcionarios.csv";

            try
            {
                 CultureInfo culture = new CultureInfo("pt-PT");

                using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.UTF8))
                {
                    string dataAniversario = novoFuncionario.DataAniversario.ToString("dd/MM/yyyy HH:mm:ss");
                    string dataContrato = novoFuncionario.DataContrato.ToString("dd/MM/yyyy HH:mm:ss");
                    string dataFimContrato = novoFuncionario.DataFimContrato.ToString("dd/MM/yyyy HH:mm:ss");
                    string dataRegistoCriminal = novoFuncionario.DataRegistoCriminal.ToString("dd/MM/yyyy HH:mm:ss");
                    string dataFimRegistoCriminal = novoFuncionario.DataFimRegistoCriminal.ToString("dd/MM/yyyy HH:mm:ss");

                    string commonAttributes = $"{novoFuncionario.Id};{novoFuncionario.Nome};{novoFuncionario.Morada};{novoFuncionario.Contacto};" +
                        $"{novoFuncionario.Tipo};{novoFuncionario.Salario};{dataAniversario};" +
                        $"{dataContrato};{dataFimContrato};{dataRegistoCriminal};" +
                        $"{dataFimRegistoCriminal};{novoFuncionario.Username};{novoFuncionario.Password};{novoFuncionario.PrimeiroLogin}";

                    if (novoFuncionario is Diretor diretor)
                    {
                        sw.WriteLine($"{commonAttributes};{diretor.IseHorario};{diretor.BonusMensal};{diretor.CarroEmpresa};{diretor.Departamento}");
                    }
                    else if (novoFuncionario is Secretaria secretaria)
                    {
                        sw.WriteLine($"{commonAttributes};{secretaria.DiretorResponsavel};{secretaria.Area}");
                    }
                    else if (novoFuncionario is Formador formador)
                    {
                        sw.WriteLine($"{commonAttributes};{formador.AreaLecionada};{formador.Disponibilidade};{formador.ValorHora}");
                    }
                    else if (novoFuncionario is Coordenador coordenador)
                    {
                        sw.WriteLine($"{commonAttributes};{coordenador.Curso};{coordenador.FormadoresAssociados}");
                    }
                    else if (novoFuncionario is Funcionario)
                    {
                        sw.WriteLine(commonAttributes);
                    }

                    Console.WriteLine("Novo funcionário adicionado com sucesso ao CSV.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao adicionar novo funcionário ao CSV: {ex.Message}");
            }
        }

        public void ExportCsvToSystem( string caminho)
        {
            try
            {
                List<Funcionario> funcionarios = LoadFromCSV(); // Load data from CSV

                using (StreamWriter sw = new StreamWriter(caminho, false, Encoding.UTF8))
                {
                    sw.WriteLine("ID;Nome;Morada;Contacto;Tipo;Salario;DataAniversario;DataContrato;DataFimContrato;DataRegistoCriminal;DataFimRegistoCriminal;Username;Password;PrimeiroLogin");

                    foreach (var funcionario in funcionarios)
                    {
                        string commonAttributes = $"{funcionario.Id};{funcionario.Nome};{funcionario.Morada};{funcionario.Contacto};" +
                            $"{funcionario.Tipo};{funcionario.Salario};{funcionario.DataAniversario};" +
                            $"{funcionario.DataContrato};{funcionario.DataFimContrato};{funcionario.DataRegistoCriminal};" +
                            $"{funcionario.DataFimRegistoCriminal};{funcionario.Username};{funcionario.Password};{funcionario.PrimeiroLogin}";

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
                        else if (funcionario is Funcionario)
                        {
                            sw.WriteLine(commonAttributes);
                        }

                        Console.WriteLine(funcionario.ToString());
                    }

                    Console.WriteLine("Sucesso!!!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro a exportar {ex.Message}");
            } 
        }

        public void ExportJsonToSystem(string caminho)
        {
         
        }
    }
}
