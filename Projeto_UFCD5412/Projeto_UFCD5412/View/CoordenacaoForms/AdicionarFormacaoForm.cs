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

        public Formacao FormacaoAdicionada { get; private set; }

        public AdicionarFormacaoForm(DateTime dataSelecionada)
        {
            InitializeComponent();
            CarregarFormadores();
            CarregarTurmas();
            CarregarHoras();
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

        private void CarregarHoras()
        {
            HoraIncio_combo.Items.Clear();
            HoraFim_combo.Items.Clear();
            string[] horas = { "07:00 AM", "08:00 AM", "09:00 AM", "10:00 AM", "11:00 AM", "12:00 PM", "01:00 PM", 
                "02:00 PM", "03:00 PM", "04:00 PM", "05:00 PM", "06:00 PM", "07:00 PM", "08:00 PM", "09:00 PM", "10:00 PM", "11:00 PM" };
            HoraIncio_combo.Items.AddRange(horas);
            HoraFim_combo.Items.AddRange(horas);
        }

        private void AdicionarFormacao_btn_Click_1(object sender, EventArgs e)
        {
            DateTime dataInicio = dataSelecionada;
            DateTime dataFim = dataSelecionada;
            string horaInicio = HoraIncio_combo.SelectedItem?.ToString();
            string horaFim = HoraFim_combo.SelectedItem?.ToString();
            string formador = FormadorNomes_combo.SelectedItem?.ToString();
            string turma = Turmas_combo.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(formador) || string.IsNullOrEmpty(turma) || string.IsNullOrEmpty(horaInicio) || string.IsNullOrEmpty(horaFim))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de adicionar a formação.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime horaInicioDateTime = DateTime.ParseExact(horaInicio, "hh:mm tt", System.Globalization.CultureInfo.InvariantCulture);
            DateTime horaFimDateTime = DateTime.ParseExact(horaFim, "hh:mm tt", System.Globalization.CultureInfo.InvariantCulture);

            if (horaFimDateTime <= horaInicioDateTime)
            {
                MessageBox.Show("A hora de término deve ser maior que a hora de início.", "Horário Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Formacao novaFormacao = new Formacao(dataInicio, dataFim, horaInicio, horaFim, formador, turma);

            coordenadorController.AdicionarFormacao(novaFormacao);
            DialogResult = DialogResult.OK;
            FormacaoAdicionada = novaFormacao;
            this.Close();
        }

        private void Sair_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataSistema_DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Data alterada com sucesso");
        }
    }
}