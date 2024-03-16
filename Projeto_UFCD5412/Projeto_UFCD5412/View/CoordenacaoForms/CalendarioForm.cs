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
            eventosPorDia.Clear();
            foreach (var formacao in CSVFormacao.LoadFromCSV())
            {
                if (!eventosPorDia.ContainsKey(formacao.DataInicio.Date))
                    eventosPorDia[formacao.DataInicio.Date] = new List<Formacao>();

                eventosPorDia[formacao.DataInicio.Date].Add(formacao);
            }
        }

        private void CalendarioForm_Resize(object sender, EventArgs e) => AjustarTamanhoCelulas();

        private void AtualizarCalendario()
        {
            tableLayoutPanel1.Controls.Clear();
            PreencherCalendario(dataAtual);
            AjustarTamanhoCelulas();
        }

        private void AjustarTamanhoCelulas()
        {
            int larguraCelula = tableLayoutPanel1.Width / tableLayoutPanel1.ColumnCount;
            int alturaCelula = tableLayoutPanel1.Height / tableLayoutPanel1.RowCount;

            foreach (ColumnStyle columnStyle in tableLayoutPanel1.ColumnStyles)
                columnStyle.Width = larguraCelula;

            foreach (RowStyle rowStyle in tableLayoutPanel1.RowStyles)
                rowStyle.Height = alturaCelula;
        }

        private void PreencherCalendario(DateTime data)
        {
            tableLayoutPanel1.Controls.Clear();

            int diasNoMes = DateTime.DaysInMonth(data.Year, data.Month);
            DayOfWeek primeiroDiaDoMes = new DateTime(data.Year, data.Month, 1).DayOfWeek;

            int numLinhas = tableLayoutPanel1.RowCount;
            int numColunas = tableLayoutPanel1.ColumnCount;

            int diaAtual = 1;
            int linhaAtual = 2;
            bool preencher = false;

            int diaAtualDoMes = DateTime.Today.Day;

            AdicionarLabelMes(data, numColunas);
            AdicionarLabelsDiasSemana(numColunas);

            for (int i = 0; i < numLinhas - 2; i++)
            {
                for (int j = 0; j < numColunas; j++)
                {
                    if (!preencher && j == (int)primeiroDiaDoMes)
                        preencher = true;

                    if (preencher && diaAtual <= diasNoMes)
                    {
                        AdicionarLabelDia(data, diaAtual, linhaAtual, j);
                        diaAtual++;
                    }
                }
                if (preencher && diaAtual > diasNoMes)
                    break;
                linhaAtual++;
            }
        }

        private void AdicionarLabelMes(DateTime data, int numColunas)
        {
            Label lblMes = new Label
            {
                Text = data.ToString("MMMM yyyy"),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font(Font, FontStyle.Bold),
                ForeColor = Color.White
            };
            tableLayoutPanel1.Controls.Add(lblMes, 0, 0);
            tableLayoutPanel1.SetColumnSpan(lblMes, numColunas);
        }

        private void AdicionarLabelsDiasSemana(int numColunas)
        {
            string[] diasDaSemana = Enum.GetNames(typeof(DayOfWeek));
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
        }

        private void AdicionarLabelDia(DateTime data, int diaAtual, int linhaAtual, int colunaAtual)
        {
            Label lbl = new Label
            {
                Text = diaAtual.ToString(),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font(Font, FontStyle.Bold),
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(3),
                Tag = diaAtual
            };

            DateTime dataAtual = new DateTime(data.Year, data.Month, diaAtual);
            if (eventosPorDia.TryGetValue(dataAtual, out var formacoes) && formacoes.Count > 0)
            {
                lbl.BackColor = Color.LightGreen;
                lbl.Text += "\n";
                foreach (var formacao in formacoes)
                    lbl.Text += $"{formacao.Formador} - {formacao.Turma}\n";

                lbl.Font = new Font(lbl.Font, FontStyle.Bold);
                Size size = TextRenderer.MeasureText(lbl.Text, lbl.Font);
                lbl.Size = new Size(size.Width + 10, size.Height + 10);
            }
            else
            {
                lbl.BackColor = diaAtual == DateTime.Today.Day ? Color.Gray : Color.White;
            }

            lbl.Click += Label_Click;
            lbl.Cursor = Cursors.Hand;

            tableLayoutPanel1.Controls.Add(lbl, colunaAtual, linhaAtual);
        }

        private void ExibirDiasSalvosNoCalendario()
        {
            eventosPorDia.Keys.ToList().ForEach(AtualizarCelula);
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

                if (eventosPorDia.TryGetValue(dataSelecionada, out var formacoes) && formacoes.Count > 0)
                {
                    EditarFormacaoForm editarFormacaoForm = new EditarFormacaoForm(formacoes[0]);
                    editarFormacaoForm.FormClosed += (s, args) =>
                    {
                        CarregarAulasSalvas();
                        AtualizarCelula(dataSelecionada);
                    };
                    editarFormacaoForm.ShowDialog();
                }
                else
                {
                    AdicionarEvento(dataAtual.Year, dataAtual.Month, diaSelecionado);
                    CarregarAulasSalvas();
                    AtualizarCalendario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao processar clique: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    eventosPorDia[dataSelecionada] = new List<Formacao>();

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
                if (control is Label label && label.Tag is int diaCelula)
                {
                    DateTime dataCelula = new DateTime(data.Year, data.Month, diaCelula);
                    if (dataCelula == data)
                    {
                        if (eventosPorDia.TryGetValue(data, out var formacoes) && formacoes.Count > 0)
                        {
                            label.BackColor = Color.LightGreen;
                            label.Text = diaCelula.ToString() + "\n";
                            foreach (var formacao in formacoes)
                                label.Text += $"{formacao.Formador} - {formacao.Turma}\n";

                            label.Font = new Font(label.Font, FontStyle.Bold);
                            Size size = TextRenderer.MeasureText(label.Text, label.Font);
                            label.Size = new Size(size.Width + 10, size.Height + 10);
                        }
                        else
                        {
                            label.BackColor = diaCelula == DateTime.Today.Day ? Color.Gray : Color.White;
                            label.Text = diaCelula.ToString();
                        }
                        label.Click -= Label_Click;
                        label.Click += Label_Click;
                    }
                }
            }
        }
    }
}
