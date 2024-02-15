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
            int linhaAtual = 2; // Começar na terceira linha
            bool preencher = false;

            // Dia atual
            int diaAtualDoMes = DateTime.Today.Day;

            // Adicionar cabeçalho com nome do mês
            Label lblMes = new Label();
            lblMes.Text = data.ToString("MMMM yyyy");
            lblMes.TextAlign = ContentAlignment.MiddleCenter;
            lblMes.Font = new Font(lblMes.Font, FontStyle.Bold);
            lblMes.ForeColor = Color.DarkBlue;
            tableLayoutPanel1.Controls.Add(lblMes, 0, 0);
            tableLayoutPanel1.SetColumnSpan(lblMes, numColunas);

            // Adicionar labels com nome dos dias da semana
            string[] diasDaSemana = { "Seg", "Ter", "Qua", "Qui", "Sex", "Sáb", "Dom" };
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

                        // Destacar o dia atual com uma cor diferente
                        if (diaAtual == diaAtualDoMes)
                        {
                            lbl.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            lbl.BackColor = Color.LightBlue;
                            // Adicionar evento de clique para selecionar o dia
                            lbl.Click += (sender, e) =>
                            {
                                Label selectedLabel = (Label)sender;
                                int diaSelecionado = int.Parse(selectedLabel.Text);
                                // Aqui você pode adicionar a lógica para lidar com a seleção do dia
                                MessageBox.Show($"Você selecionou o dia {diaSelecionado}.");
                            };
                            lbl.Cursor = Cursors.Hand; // Alterar o cursor para indicar que é clicável
                        }

                        tableLayoutPanel1.Controls.Add(lbl, j, linhaAtual);
                        diaAtual++;
                    }
                }
                if (preencher && diaAtual > diasNoMes) // Verificar se todos os dias foram adicionados
                    break;
                linhaAtual++; // Mover para a próxima linha
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