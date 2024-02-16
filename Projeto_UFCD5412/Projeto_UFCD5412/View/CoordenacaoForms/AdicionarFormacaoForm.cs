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
        public AdicionarFormacaoForm()
        {
            InitializeComponent();
            CarregarFormadores();
            CarregarTurmas();
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
            //criar turmas estaticas

            Turmas_combo.Items.Add("UFCD 5412");
            Turmas_combo.Items.Add("UFCD 5413");
            Turmas_combo.Items.Add("UFCD 5414");
            Turmas_combo.Items.Add("UFCD 5415");
            Turmas_combo.Items.Add("UFCD 5416");
            Turmas_combo.Items.Add("UFCD 5417");

        }
        private void AdicionarFormacao_btn_Click(object sender, EventArgs e)
        {
            DateTime dataInicio = DataInicio_calendar.Value;
            DateTime dataFim = DataFim_calendar.Value;
            string horaInicio = HoraIncio_combo.SelectedItem.ToString();
            string horaFim = HoraFim_combo.SelectedItem.ToString();
            string formador = FormadorNomes_combo.SelectedItem.ToString();
            string turma = Turmas_combo.SelectedItem.ToString();

            if (string.IsNullOrEmpty(formador) || string.IsNullOrEmpty(turma))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de adicionar a formação.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Formacao novaFormacao = new Formacao(dataInicio, dataFim, horaInicio, horaFim, formador, turma);

            CalendarioForm calendarioForm = Application.OpenForms["CalendarioForm"] as CalendarioForm;
            if (calendarioForm != null)
            {
                calendarioForm.AdicionarFormacaoAoCalendario(novaFormacao);
            }
            else
            {
                MessageBox.Show("O formulário de calendário não está aberto. Não é possível adicionar a formação.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Formação adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparCampos();
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

    }
}
