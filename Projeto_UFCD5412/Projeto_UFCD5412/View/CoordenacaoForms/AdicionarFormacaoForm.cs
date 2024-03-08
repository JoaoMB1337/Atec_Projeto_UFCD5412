using Projeto_UFCD5412.Data;
using Projeto_UFCD5412.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Projeto_UFCD5412.Controller;

namespace Projeto_UFCD5412.View.CoordenacaoForms
{
    public partial class AdicionarFormacaoForm : Form
    {
        private readonly CoordenadorController coordenadorController = CoordenadorController.Instance;
        private DateTime dataSelecionada;

        // Adicione a declaração da propriedade FormacaoAdicionada
        public Formacao FormacaoAdicionada { get; private set; }

        public AdicionarFormacaoForm(DateTime dataSelecionada)
        {
            InitializeComponent();
            CarregarFormadores();
            CarregarTurmas();
            this.dataSelecionada = dataSelecionada;
            DataInicio_calendar.Value = dataSelecionada;
            DataFim_calendar.Value = dataSelecionada;
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

        private void AdicionarFormacao_btn_Click_1(object sender, EventArgs e)
        {
            DateTime dataInicio = dataSelecionada;
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

            coordenadorController.AdicionarFormacao(novaFormacao);
            DialogResult = DialogResult.OK;
            FormacaoAdicionada = novaFormacao;
            Close();
        }

        private void Sair_Btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DataSistema_DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Data alterada com sucesso");
        }
    }
}