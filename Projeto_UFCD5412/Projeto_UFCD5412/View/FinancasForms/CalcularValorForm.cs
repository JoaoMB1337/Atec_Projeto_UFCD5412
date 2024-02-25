using Projeto_UFCD5412.Controller;
using Projeto_UFCD5412.Model;
using Projeto_UFCD5412.View.DashboardForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Projeto_UFCD5412.View.FinancasForms
{
    public partial class CalcularValorForm : Form
    {
        private EmpresaController empresaController = EmpresaController.Instance;
        private List<Funcionario> funcionarios = new List<Funcionario>();

        public CalcularValorForm()
        {
            InitializeComponent();
            LoadComboBox();
            InitializeDataGridView();
        }

        private void LoadComboBox()
        {
            TipoFuncionario_ComboBox.Items.Add("Funcionario");
            TipoFuncionario_ComboBox.Items.Add("Formador");
            TipoFuncionario_ComboBox.Items.Add("Coordenador");
            TipoFuncionario_ComboBox.Items.Add("Secretaria");
            TipoFuncionario_ComboBox.Items.Add("Diretor");
            TipoFuncionario_ComboBox.Items.Add("Todos");
            TipoFuncionario_ComboBox.SelectedIndexChanged += TipoFuncionario_ComboBox_SelectedIndexChanged;
        }

        private void InitializeDataGridView()
        {
            ValorPagarDataGridView.AutoGenerateColumns = false;
            ValorPagarDataGridView.Columns.Add("Nome", "Nome");
            ValorPagarDataGridView.Columns.Add("Tipo", "Tipo");
            ValorPagarDataGridView.Columns.Add("Salario", "Salário");
            ValorPagarDataGridView.Columns.Add("DataContrato", "Data Contrato");
            ValorPagarDataGridView.Columns.Add("DataFimContrato", "Data Fim Contrato");

            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            funcionarios = empresaController.ListarFuncionarios();
            AtualizarDataGridView(funcionarios);
        }

        private void AtualizarDataGridView(List<Funcionario> funcionarios)
        {
            ValorPagarDataGridView.Rows.Clear();
            foreach (var funcionario in funcionarios)
            {
                decimal salario = CalcularSalario(funcionario);
                ValorPagarDataGridView.Rows.Add(funcionario.Nome, funcionario.Tipo, salario, funcionario.DataContrato, funcionario.DataFimContrato);
            }
        }

        private decimal CalcularSalario(Funcionario funcionario)
        {
            if (funcionario is Formador formador)
            {
                DateTime dataInicio = funcionario.DataContrato;
                DateTime dataFim = funcionario.DataFimContrato;
                int totalDias = (int)(dataFim - dataInicio).TotalDays + 1;
                int totalHoras = totalDias * 6; 
                return totalHoras * formador.ValorHora; 
            }
            else
            {
                return funcionario.Salario; 
            }
        }

        private void TipoFuncionario_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoSelecionado = TipoFuncionario_ComboBox.SelectedItem.ToString();
            List<Funcionario> funcionariosFiltrados = funcionarios;

            if (tipoSelecionado != "Todos")
            {
                funcionariosFiltrados = funcionarios.Where(funcionario => funcionario.Tipo == tipoSelecionado).ToList();
            }
            AtualizarDataGridView(funcionariosFiltrados);
        }

 

        private void Sair_Btn_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
            this.Hide();
        }

        private void PesquisarFuncinarioPorNome_Textbox_TextChanged(object sender, EventArgs e)
        {
            string nomePesquisado = PesquisarFuncinarioPorNome_Textbox.Text;
            List<Funcionario> funcionariosFiltrados = empresaController.PesquisarFuncionariosPorNome(nomePesquisado);
            AtualizarDataGridView(funcionariosFiltrados);
        }
    }
}

