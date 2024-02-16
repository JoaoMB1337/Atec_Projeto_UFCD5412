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


namespace Projeto_UFCD5412.View.CoordenacaoForms
{
    public partial class CalendarioForm : Form
    {
        private DateTime dataAtual;

        public CalendarioForm()
        {
            InitializeComponent();

            dataAtual = DateTime.Today;
            AtualizarCalendario();

            this.Resize += CalendarioForm_Resize;
        }

        private void CalendarioForm_Resize(object sender, EventArgs e)
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

        private void AtualizarCalendario()
        {
            PreencherCalendario(dataAtual);
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

                        if (diaAtual == diaAtualDoMes)
                        {
                            lbl.BackColor = Color.Yellow;
                        }
                        else
                        {
                            lbl.BackColor = Color.LightBlue;
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
            MessageBox.Show($"Você está adicionando um evento para o dia {dia}/{mes}/{ano}.");
            AdicionarFormacaoForm adicionarFormacaoForm = new AdicionarFormacaoForm(new DateTime(ano, mes, dia));
            adicionarFormacaoForm.ShowDialog();
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

        public void AdicionarFormacaoAoCalendario(Formacao formacao)
        {
            MessageBox.Show($"Adicionando formação ao calendário: {formacao.DataInicio.ToShortDateString()} - {formacao.DataFim.ToShortDateString()}");
            // Aqui você pode adicionar a formação ao calendário e aparecer no dia correto
        }
    }
}