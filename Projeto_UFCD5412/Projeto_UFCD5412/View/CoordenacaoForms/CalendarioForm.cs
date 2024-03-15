using Projeto_UFCD5412.Model;
using Projeto_UFCD5412.Data;
using Projeto_UFCD5412.Controller;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_UFCD5412.View.CoordenacaoForms
{
    public partial class CalendarioForm : Form
    {
        private DateTime dataAtual;
        private readonly Dictionary<DateTime, List<Formacao>> eventosPorDia = new Dictionary<DateTime, List<Formacao>>();
        private readonly CoordenadorController coordenadorController = CoordenadorController.Instance;

        public enum DiaDaSemana
        {
            Domingo,
            Segunda,
            Terca,
            Quarta,
            Quinta,
            Sexta,
            Sabado
        }

        public CalendarioForm()
        {
            InitializeComponent();
            dataAtual = DateTime.Today;
            CarregarAulasSalvas();

            this.Resize += CalendarioForm_Resize;
            ExibirDiasSalvosNoCalendario();
            AtualizarCalendario();
        }

        private void CarregarAulasSalvas()
        {
            List<Formacao> listaFormacoes = CSVFormacao.LoadFromCSV();

            foreach (Formacao formacao in listaFormacoes)
            {
                DateTime dataInicio = formacao.DataInicio.Date;
                if (!eventosPorDia.ContainsKey(dataInicio))
                {
                    eventosPorDia[dataInicio] = new List<Formacao>();
                }

                eventosPorDia[dataInicio].Add(formacao);
            }
            AtualizarCalendario();
        }

        private void CalendarioForm_Resize(object sender, EventArgs e)
        {
            AjustarTamanhoCelulas();
        }

        private void AtualizarCalendario()
        {
            // Limpar o calendário antes de atualizar
            tableLayoutPanel1.Controls.Clear();

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
            // Remover todas as labels existentes
            tableLayoutPanel1.Controls.Clear();

            int diasNoMes = DateTime.DaysInMonth(data.Year, data.Month);
            DayOfWeek primeiroDiaDoMes = new DateTime(data.Year, data.Month, 1).DayOfWeek;

            int numLinhas = tableLayoutPanel1.RowCount;
            int numColunas = tableLayoutPanel1.ColumnCount;

            int diaAtual = 1;
            int linhaAtual = 2;
            bool preencher = false;

            int diaAtualDoMes = DateTime.Today.Day;

            Label lblMes = new Label
            {
                Text = data.ToString("MMMM yyyy"),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font(Font, FontStyle.Bold),
                ForeColor = Color.White
            };
            tableLayoutPanel1.Controls.Add(lblMes, 0, 0);
            tableLayoutPanel1.SetColumnSpan(lblMes, numColunas);

            string[] diasDaSemana = Enum.GetNames(typeof(DiaDaSemana));
            for (int i = 0; i < numColunas; i++)
            {
                Label lblDiaSemana = new Label
                {
                    Text = diasDaSemana[i],
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font(Font, FontStyle.Bold),
                    ForeColor = Color.Orange
                };
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
                        Label lbl = new Label
                        {
                            Text = diaAtual.ToString(),
                            TextAlign = ContentAlignment.MiddleCenter,
                            Font = new Font(Font, FontStyle.Bold),
                            BorderStyle = BorderStyle.FixedSingle,
                            Margin = new Padding(3)
                        };
                        // Definir o número do dia como tag
                        lbl.Tag = diaAtual;

                        DateTime dataAtual = new DateTime(data.Year, data.Month, diaAtual);
                        if (eventosPorDia.ContainsKey(dataAtual) && eventosPorDia[dataAtual].Count > 0)
                        {
                            lbl.BackColor = Color.LightGreen;
                            lbl.Text += "\n";
                            foreach (var formacao in eventosPorDia[dataAtual])
                            {
                                lbl.Text += $"{formacao.Formador} - {formacao.Turma}\n";
                            }
                            lbl.Font = new Font(lbl.Font, FontStyle.Bold);

                            Size size = TextRenderer.MeasureText(lbl.Text, lbl.Font);
                            lbl.Size = new Size(size.Width + 10, size.Height + 10);
                        }
                        else
                        {
                            if (diaAtual == diaAtualDoMes)
                            {
                                lbl.BackColor = Color.Gray;
                            }
                            else
                            {
                                lbl.BackColor = Color.White;
                            }
                        }

                        lbl.Click += Label_Click; // Adiciona o manipulador de evento de clique

                        lbl.Cursor = Cursors.Hand;

                        tableLayoutPanel1.Controls.Add(lbl, j, linhaAtual);

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
            try
            {
                if (ano <= 0 || mes < 1 || mes > 12 || dia < 1 || dia > DateTime.DaysInMonth(ano, mes))
                {
                    MessageBox.Show("Data inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime dataSelecionada = new DateTime(ano, mes, dia);

                if (dataSelecionada < DateTime.Today)
                {
                    MessageBox.Show("Não é possível adicionar formações em dias passados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!eventosPorDia.ContainsKey(dataSelecionada))
                {
                    eventosPorDia[dataSelecionada] = new List<Formacao>();
                }

                AdicionarFormacaoForm adicionarFormacaoForm = new AdicionarFormacaoForm(dataSelecionada);

                if (adicionarFormacaoForm.ShowDialog() == DialogResult.OK)
                {
                    Formacao novaFormacao = adicionarFormacaoForm.FormacaoAdicionada;

                    if (novaFormacao != null)
                    {
                        eventosPorDia[dataSelecionada].Add(novaFormacao);
                        AtualizarCelula(dataSelecionada);
                    }
                    else
                    {
                        MessageBox.Show("Formação inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar evento: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Exception in AdicionarEvento: {ex}");
            }
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
                                if (eventosPorDia.ContainsKey(data) && eventosPorDia[data].Count > 0)
                                {
                                    label.BackColor = Color.LightGreen;
                                    label.Text += "\n";
                                    foreach (var formacao in eventosPorDia[data])
                                    {
                                        label.Text += $"{formacao.Formador} - {formacao.Turma}\n";
                                    }
                                    label.Font = new Font(label.Font, FontStyle.Bold);

                                    Size size = TextRenderer.MeasureText(label.Text, label.Font);
                                    label.Size = new Size(size.Width + 10, size.Height + 10);
                                }
                                else
                                {
                                    // Limpar as configurações de fundo e texto se não houver evento para este dia
                                    label.BackColor = Color.White;
                                    label.Text = diaCelula.ToString();
                                }
                                // Adicione ou atualize o evento de clique da label
                                label.Click -= Label_Click; // Remova o manipulador de evento existente, se houver
                                label.Click += Label_Click; // Adicione o manipulador de evento atualizado
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

        private void ExibirDiasSalvosNoCalendario()
        {
            foreach (var formacaoList in eventosPorDia.Values)
            {
                foreach (var formacao in formacaoList)
                {
                    AtualizarCelula(formacao.DataInicio);
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

        private void Label_Click(object sender, EventArgs e)
        {
            try
            {
                Label selectedLabel = (Label)sender;
                int diaSelecionado = (int)selectedLabel.Tag;
                DateTime dataSelecionada = new DateTime(dataAtual.Year, dataAtual.Month, diaSelecionado);

                if (eventosPorDia.ContainsKey(dataSelecionada) && eventosPorDia[dataSelecionada].Count > 0)
                {
                    EditarFormacaoForm editarFormacaoForm = new EditarFormacaoForm(eventosPorDia[dataSelecionada][0]);
                    if (editarFormacaoForm.ShowDialog() == DialogResult.OK)
                    {
                        AtualizarCalendario();
                    }
                }
                else
                {
                    AdicionarEvento(dataAtual.Year, dataAtual.Month, diaSelecionado);
                    AtualizarCalendario();
                }
                // Atualiza a célula independentemente de ter sido adicionada ou editada
                AtualizarCelula(dataSelecionada);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao processar clique: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
