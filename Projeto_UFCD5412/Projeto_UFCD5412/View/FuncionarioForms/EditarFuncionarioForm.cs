using Projeto_UFCD5412.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_UFCD5412.Controller;

namespace Projeto_UFCD5412.View.FuncionarioForms
{
    public partial class EditarFuncionarioForm : Form
    {
        public int _funcionarioId;
        private EmpresaController empresaController = EmpresaController.Instance;
        public EditarFuncionarioForm()
        {
            InitializeComponent();
        }

        internal void SetParameter(int funcionarioId)
        {
           _funcionarioId = funcionarioId;
        }

        private void LoadInformacaoFuncionario()
        {
            var funcionario = empresaController.GetFuncionarioById(_funcionarioId);
            var formador = empresaController.GetFormadorById(_funcionarioId);
            if(funcionario == null)
            {
                MessageBox.Show("Funcionário não encontrado");
                this.Close();
            }
            else
            {
                nome_textbox.Text = funcionario.Nome;
                morada_textbox.Text = funcionario.Morada;
                contacto_textbox.Text = funcionario.Contacto;
                TipoFuncionario_ComboBox.SelectedItem = funcionario.Tipo;
                DataContrato_DateTimePicker.Value = funcionario.DataContrato;
                DataFimContrato_DateTimePicker.Value = funcionario.DataFimContrato;
                DataRegistoCriminal_DateTimePicker.Value = funcionario.DataRegistoCriminal;
                DataFimRegistoCriminal_DateTimePicker.Value = funcionario.DataFimRegistoCriminal;
                DataNascimento_DateTimePicker.Value = funcionario.DataAniversario;
                salario_textbox.Text = funcionario.Salario.ToString();
                SalarioHoraTextBox.Text = formador.ValorHora.ToString();
                TipoFuncionario_ComboBox.SelectedItem = funcionario.Tipo;
            }
           
        }

        private void LoadTipoFuncionarioComboBox()
        {
            TipoFuncionario_ComboBox.Items.Add("Funcionario");
            TipoFuncionario_ComboBox.Items.Add("Diretor");
            TipoFuncionario_ComboBox.Items.Add("Formador");
            TipoFuncionario_ComboBox.Items.Add("Secretaria");
            TipoFuncionario_ComboBox.Items.Add("Coordenador");
        }

        private void EditarFuncionarioForm_Load(object sender, EventArgs e)
        {
            LoadTipoFuncionarioComboBox();
            LoadInformacaoFuncionario();
        }

        private void EditFuncionario_Btn_Click(object sender, EventArgs e)
        {
            UpdateInfoFuncionario();

        }

        private void Sair_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateInfoFuncionario()
        {
            var funcionario = empresaController.GetFuncionarioById(_funcionarioId);
            if(funcionario == null)
            {
                MessageBox.Show("Funcionário não encontrado");
                this.Close();
            }
            else
            {
                funcionario.Nome = nome_textbox.Text;
                funcionario.Morada = morada_textbox.Text;
                funcionario.Contacto = contacto_textbox.Text;
                funcionario.Tipo = TipoFuncionario_ComboBox.SelectedItem.ToString();
                funcionario.DataContrato = DataContrato_DateTimePicker.Value;
                funcionario.DataFimContrato = DataFimContrato_DateTimePicker.Value;
                funcionario.DataRegistoCriminal = DataRegistoCriminal_DateTimePicker.Value;
                funcionario.DataFimRegistoCriminal = DataFimRegistoCriminal_DateTimePicker.Value;
                funcionario.DataAniversario = DataNascimento_DateTimePicker.Value;
                if (!decimal.TryParse(salario_textbox.Text, out decimal salario))
                {
                    MessageBox.Show("Por favor, insira um valor de salário válido.");
                    return;
                }
                empresaController.UpdateFuncionario(funcionario);
                MessageBox.Show("Funcionário atualizado com sucesso");
                this.Close();
            }
        }
    }
}
