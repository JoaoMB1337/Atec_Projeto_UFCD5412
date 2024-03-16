using Projeto_UFCD5412.Data;
using Projeto_UFCD5412.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Projeto_UFCD5412.Controller;

namespace Projeto_UFCD5412.View.CoordenacaoForms
{
    public partial class EditarFormacaoForm : Form
    {
        private readonly CoordenadorController coordenadorController = CoordenadorController.Instance;
        private readonly Formacao formacaoOriginal;
        private DateTime dataInicioFormacao;
        private DateTime dataFimFormacao;
        private Formacao formacaoEditada;


        public EditarFormacaoForm(Formacao formacao)
        {
            InitializeComponent();
            formacaoOriginal = formacao;
            LoadFormacao();
        }

        private void LoadFormacao()
        {
            CarregarFormadores();
            CarregarHoras();
            CarregarTurmas();
            dataInicioFormacao = formacaoOriginal.DataInicio;
            dataFimFormacao = formacaoOriginal.DataFim;
            HoraIncio_combo.SelectedItem = formacaoOriginal.HoraInicio;
            HoraFim_combo.SelectedItem = formacaoOriginal.HoraFim;
            FormadorNomes_combo.SelectedItem = formacaoOriginal.Formador;
            Turmas_combo.SelectedItem = formacaoOriginal.Turma;
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

        private void Sair_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditarFormacao_btn_Click(object sender, EventArgs e)
        {
            string horaInicio = HoraIncio_combo.SelectedItem?.ToString();
            string horaFim = HoraFim_combo.SelectedItem?.ToString();
            string formador = FormadorNomes_combo.SelectedItem?.ToString();
            string turma = Turmas_combo.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(formador) || string.IsNullOrEmpty(turma) || string.IsNullOrEmpty(horaInicio) || string.IsNullOrEmpty(horaFim))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de editar a formação.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime horaInicioDateTime;
            DateTime horaFimDateTime;
            if (!DateTime.TryParseExact(horaInicio, "hh:mm tt", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out horaInicioDateTime) ||
                !DateTime.TryParseExact(horaFim, "hh:mm tt", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out horaFimDateTime))
            {
                MessageBox.Show("Formato de hora inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (horaFimDateTime <= horaInicioDateTime)
            {
                MessageBox.Show("A hora de término deve ser maior que a hora de início.", "Horário Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            formacaoEditada = new Formacao(dataInicioFormacao, dataInicioFormacao, horaInicio, horaFim, formador, turma);

            coordenadorController.EditarFormacao(formacaoOriginal, formacaoEditada);

            MessageBox.Show("Formação atualizada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        public Formacao GetFormacaoEditada()
        {
            return formacaoEditada;
        }

        private void RemoverFormacao_Btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza de que deseja remover esta formação?", "Confirmação de Remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                coordenadorController.RemoverFormacao(formacaoOriginal);

                MessageBox.Show("Formação removida com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }
    }
}
