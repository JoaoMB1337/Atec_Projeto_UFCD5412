using Projeto_UFCD5412.Data;
using Projeto_UFCD5412.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_UFCD5412.View.CoordenacaoForms
{
    public partial class AdicionarFormacaoForm : Form
    {
        public Formacao FormacaoAdicionada { get; private set; }

        private readonly DateTime dataSelecionada;

        public AdicionarFormacaoForm(DateTime dataSelecionada)
        {
            InitializeComponent();
            CarregarFormadores();
            CarregarTurmas();
            this.dataSelecionada = dataSelecionada;
        }

        private void CarregarFormadores()
        {
            FormadorNomes_combo.Items.Clear();

            List<Funcionario> funcionarios = CSVHandler.LoadFromCSV();

            foreach (var funcionario in funcionarios)
            {
                if (funcionario is Formador formador)
                {
                    FormadorNomes_combo.Items.Add(formador.Nome);
                }
            }
        }

        private void CarregarTurmas()
        {
            Turmas_combo.Items.Clear();

            string[] turmas = { "UFCD 5412", "UFCD 5413", "UFCD 5414", "UFCD 5415", "UFCD 5416", "UFCD 5417" };
            Turmas_combo.Items.AddRange(turmas);
        }

        private void LimparCampos()
        {
            DataInicio_calendar.Value = DateTime.Today;
            DataFim_calendar.Value = DateTime.Today;
            HoraIncio_combo.SelectedIndex = -1;
            HoraFim_combo.SelectedIndex = -1;
            FormadorNomes_combo.SelectedIndex = -1;
            Turmas_combo.SelectedIndex = -1;
        }

        private void AdicionarFormacao_btn_Click_1(object sender, EventArgs e)
        {
            DateTime dataInicio = DataInicio_calendar.Value;
            DateTime dataFim = DataFim_calendar.Value;
            string horaInicio = HoraIncio_combo.SelectedItem?.ToString();
            string horaFim = HoraFim_combo.SelectedItem?.ToString();
            string formador = FormadorNomes_combo.SelectedItem?.ToString();
            string turma = Turmas_combo.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(formador) || string.IsNullOrEmpty(turma))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de adicionar a formação.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Formacao novaFormacao = new Formacao(dataInicio, dataFim, horaInicio, horaFim, formador, turma);
            FormacaoAdicionada = novaFormacao;

            DialogResult = DialogResult.OK;
        }

        private void Sair_Btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}