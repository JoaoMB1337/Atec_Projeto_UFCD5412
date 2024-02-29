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
using Projeto_UFCD5412.Data;
using Projeto_UFCD5412.Controller;

namespace Projeto_UFCD5412.View.CoordenacaoForms
{
    public partial class CalendarioForm : Form
    {
        private DateTime dataAtual;
        private Dictionary<DateTime, List<Formacao>> eventosPorDia = new Dictionary<DateTime, List<Formacao>>();
        private CoordenadorController coordenadorController = CoordenadorController.Instance;

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
            AtualizarCalendario();
            this.Resize += CalendarioForm_Resize;
            ExibirDiasSalvosNoCalendario();
        }

        private void CarregarAulasSalvas()
        {
            List<Formacao> listaFormacoes = CSVFormacao.LoadFromCSV();
            eventosPorDia = listaFormacoes.GroupBy(f => f.DataInicio)
                                          .ToDictionary(g => g.Key, g => g.ToList());

            AtualizarCalendario();
            ExibirDiasSalvosNoCalendario();
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
            lblMes.ForeColor = Color.White;
            tableLayoutPanel1.Controls.Add(lblMes, 0, 0);
            tableLayoutPanel1.SetColumnSpan(lblMes, numColunas);

            string[] diasDaSemana = Enum.GetNames(typeof(DiaDaSemana));
            for (int i = 0; i < numColunas; i++)
            {
                Label lblDiaSemana = new Label();
                lblDiaSemana.Text = diasDaSemana[i];
                lblDiaSemana.TextAlign = ContentAlignment.MiddleCenter;
                lblDiaSemana.Font = new Font(lblDiaSemana.Font, FontStyle.Bold);
                lblDiaSemana.ForeColor = Color.Orange;
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

                        // Verifica se há formações para este dia
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

                            // Ajusta o tamanho da label com base no conteúdo
                            Size size = TextRenderer.MeasureText(lbl.Text, lbl.Font);
                            lbl.Size = new Size(size.Width + 10, size.Height + 10); // Aumenta um pouco o tamanho para folga
                        }
                        else
                        {
                            if (diaAtual == diaAtualDoMes)
                            {
                                lbl.BackColor = Color.DarkGray;
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
                        }

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
            DateTime dataSelecionada = new DateTime(ano, mes, dia);

            // Verificar se a data selecionada é anterior ao dia atual
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

                eventosPorDia[dataSelecionada].Add(novaFormacao);

                AtualizarCelula(dataSelecionada);
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
                                       // label.Text += $"{formacao.Formador} - {formacao.Turma}\n";
                                       label.Text += $"Hey\n";
                                         
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
    }
}