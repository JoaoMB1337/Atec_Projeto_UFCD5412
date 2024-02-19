using Projeto_UFCD5412.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Text.RegularExpressions;


namespace Projeto_UFCD5412.View.CoordenacaoForms
{
    public partial class CalendarioForm : Form
    {
        private DateTime dataAtual;

        private Dictionary<DateTime, List<Formacao.FormacaoAgendada>> eventosPorDia = new Dictionary<DateTime, List<Formacao.FormacaoAgendada>>();

        public CalendarioForm()
        {
            InitializeComponent();
            dataAtual = DateTime.Today;
            AtualizarCalendario();
            this.Resize += CalendarioForm_Resize;
        }

        private void CalendarioForm_Resize(object sender, EventArgs e)
        {
            AjustarTamanhoCelulas();
        }

        private void AtualizarCalendario()
        {
            PreencherCalendario(dataAtual);
            AjustarTamanhoCelulas();
        }

        private void AjustarTamanhoCelulas()
        {
            int larguraCelula = tableLayoutPanel1.Width / tableLayoutPanel1.ColumnCount;
            int alturaCelula = tableLayoutPanel1.Height / tableLayoutPanel1.RowCount;

            foreach (ColumnStyle columnStyle in tableLayoutPanel1.ColumnStyles)
            {
                columnStyle.Width = larguraCelula;
            }

            foreach (RowStyle rowStyle in tableLayoutPanel1.RowStyles)
            {
                rowStyle.Height = alturaCelula;
            }
        }

        private void PreencherCalendario(DateTime data)
        {
            tableLayoutPanel1.Controls.Clear();
            eventosPorDia.Clear();

            int diasNoMes = DateTime.DaysInMonth(data.Year, data.Month);
            DayOfWeek primeiroDiaDoMes = new DateTime(data.Year, data.Month, 1).DayOfWeek;

            int numLinhas = tableLayoutPanel1.RowCount;
            int numColunas = tableLayoutPanel1.ColumnCount;

            int diaAtual = 1;
            int linhaAtual = 2;
            bool preencher = false;

            int diaAtualDoMes = DateTime.Today.Day;

            Label lblMes = new Label();
            lblMes.Text = data.ToString("MMMM yyyy");
            lblMes.TextAlign = ContentAlignment.MiddleCenter;
            lblMes.Font = new Font(lblMes.Font, FontStyle.Bold);
            lblMes.ForeColor = Color.DarkBlue;
            tableLayoutPanel1.Controls.Add(lblMes, 0, 0);
            tableLayoutPanel1.SetColumnSpan(lblMes, numColunas);

            string[] diasDaSemana = { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };
            for (int i = 0; i < numColunas; i++)
            {
                Label lblDiaSemana = new Label();
                lblDiaSemana.Text = diasDaSemana[i];
                lblDiaSemana.TextAlign = ContentAlignment.MiddleCenter;
                lblDiaSemana.Font = new Font(lblDiaSemana.Font, FontStyle.Bold);
                lblDiaSemana.ForeColor = Color.DarkBlue;
                tableLayoutPanel1.Controls.Add(lblDiaSemana, i, 1);
            }

            for (int i = 0; i < numLinhas - 2; i++)
            {
                for (int j = 0; j < numColunas; j++)
                {
                    if (!preencher && j == (int)primeiroDiaDoMes)
                    {
                        preencher = true;
                    }

                    if (preencher && diaAtual <= diasNoMes)
                    {
                        Label lbl = new Label();
                        lbl.Text = diaAtual.ToString();
                        lbl.TextAlign = ContentAlignment.MiddleCenter;
                        lbl.Font = new Font(lbl.Font, FontStyle.Bold);
                        lbl.BorderStyle = BorderStyle.FixedSingle;
                        lbl.Margin = new Padding(3);

                        if (diaAtual == diaAtualDoMes)
                        {
                            lbl.BackColor = Color.LightGray;
                        }
                        else
                        {
                            lbl.BackColor = Color.White;
                        }

                        lbl.Click += (sender, e) =>
                        {
                            Label selectedLabel = (Label)sender;
                            int diaSelecionado = int.Parse(selectedLabel.Text);
                            AdicionarEvento(data.Year, data.Month, diaSelecionado);
                        };
                        lbl.Cursor = Cursors.Hand;

                        tableLayoutPanel1.Controls.Add(lbl, j, linhaAtual);

                        eventosPorDia[new DateTime(data.Year, data.Month, diaAtual)] = new List<Formacao.FormacaoAgendada>();
                        diaAtual++;
                    }
                }
                if (preencher && diaAtual > diasNoMes)
                    break;
                linhaAtual++;
            }
        }


        private void AdicionarEvento(int ano, int mes, int dia)
        {
            DateTime dataSelecionada = new DateTime(ano, mes, dia);

            // Verificar se já existem aulas agendadas para o dia selecionado
            if (eventosPorDia.ContainsKey(dataSelecionada) && eventosPorDia[dataSelecionada].Count > 0)
            {
                MessageBox.Show("Já existem aulas agendadas para este dia. Por favor, escolha outro dia.");
                return;
            }

            // Se não houver aulas agendadas, exibir o formulário para adicionar uma nova aula
            AdicionarFormacaoForm adicionarFormacaoForm = new AdicionarFormacaoForm(dataSelecionada);
            if (adicionarFormacaoForm.ShowDialog() == DialogResult.OK)
            {
                Formacao novaFormacao = adicionarFormacaoForm.FormacaoAdicionada;

                // Adicionar aula ao calendário
                eventosPorDia[dataSelecionada] = new List<Formacao.FormacaoAgendada> {
            new Formacao.FormacaoAgendada {
                Data = novaFormacao.DataInicio,
                Formador = novaFormacao.Formador,
                Turma = novaFormacao.Turma
            }
        };

                AtualizarCelula(dataSelecionada);
            }
        }

        private bool VerificarHorarioDisponivel(Formacao novaFormacao)
        {
            // Recuperar as formações agendadas para o mesmo dia que a nova formação
            List<Formacao.FormacaoAgendada> formacoesAgendadas = eventosPorDia[novaFormacao.DataInicio.Date];

            // Calcular o horário de término da nova formação
            DateTime horarioTerminoNovaFormacao = novaFormacao.DataInicio.AddHours(Convert.ToInt32(novaFormacao.HoraFim.Split(':')[0]));

            // Verificar se há conflito de horário com as formações agendadas
            foreach (Formacao.FormacaoAgendada formacaoAgendada in formacoesAgendadas)
            {
                // Calcular o horário de término da formação agendada
                DateTime horarioTerminoFormacaoAgendada = formacaoAgendada.Data.AddHours(Convert.ToInt32(formacaoAgendada.HoraFim.Split(':')[0]));

                // Verificar se o horário de início ou término da nova formação se sobrepõe com alguma formação agendada
                if ((novaFormacao.DataInicio >= formacaoAgendada.Data && novaFormacao.DataInicio < horarioTerminoFormacaoAgendada) ||
                    (horarioTerminoNovaFormacao > formacaoAgendada.Data && horarioTerminoNovaFormacao <= horarioTerminoFormacaoAgendada))
                {
                    return false; // Conflito de horário encontrado
                }
            }

            return true; // Horário disponível
        }



        private void AtualizarCelula(DateTime data)
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Label label && label.Text != "")
                {
                    string[] splitText = label.Text.Split('\n');
                    if (splitText.Length > 0)
                    {
                        if (int.TryParse(splitText[0], out int diaCelula))
                        {
                            if (new DateTime(data.Year, data.Month, diaCelula) == data)
                            {
                                label.Text = $"{diaCelula}\n({eventosPorDia[data].Count} aula)";
                                if (eventosPorDia.ContainsKey(data) && eventosPorDia[data].Count > 0)
                                {
                                    label.BackColor = Color.LightGreen;
                                    label.Text += "\n";
                                    foreach (var evento in eventosPorDia[data])
                                    {
                                        label.Text += $"{evento.Formador} - {evento.Turma}\n";
                                    }
                                    label.Font = new Font(label.Font, FontStyle.Bold);

                                    // Ajustar o tamanho da label com base no conteúdo
                                    Size size = TextRenderer.MeasureText(label.Text, label.Font);
                                    label.Size = new Size(size.Width + 10, size.Height + 10); // Aumenta um pouco o tamanho para folga
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Erro ao converter o texto \"{splitText[0]}\" do rótulo para um número inteiro.");
                        }
                    }
                }
            }
        }


        private void avancar_btn_Click(object sender, EventArgs e)
        {
            dataAtual = dataAtual.AddMonths(1);
            AtualizarCalendario();
        }

        private void retroceder_btn_Click(object sender, EventArgs e)
        {
            dataAtual = dataAtual.AddMonths(-1);
            AtualizarCalendario();
        }
    }
}