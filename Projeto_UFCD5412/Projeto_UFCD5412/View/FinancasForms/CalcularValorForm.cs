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

        
        private void LoadEmployeeData()  // funcao para carregar os dados dos funcionarios
        {
            funcionarios = empresaController.ListarFuncionarios();
            funcionarios = empresaController.ListarFuncionarios();

            foreach (var funcionario in funcionarios)
                
                {
                    ValorPagarDataGridView.Rows.Add(funcionario.Nome, funcionario.Tipo, funcionario.Salario, funcionario.DataContrato, funcionario.DataFimContrato);
                    string salarioFormatado = funcionario.Tipo == "Formador" ? "h " + funcionario.Salario.ToString() : funcionario.Salario.ToString();

                    if (funcionario.Tipo == "Formador")
                    {
                        DateTime dataInicio = funcionario.DataContrato;
                        DateTime dataFim = funcionario.DataFimContrato;

                        int totalDias = (int)(dataFim - dataInicio).TotalDays + 1;
                        int totalHoras = totalDias * 6;
                        decimal salario = totalHoras * funcionario.Salario;
                        salarioFormatado = "h " + salario.ToString();
                    }

                    ValorPagarDataGridView.Rows.Add(funcionario.Nome, funcionario.Tipo, salarioFormatado, funcionario.DataContrato, funcionario.DataFimContrato);
                }
        }

       

        private void TipoFuncionario_ComboBox_SelectedIndexChanged(object sender, EventArgs e) //filtrar funcionarios
        {
            string tipoSelecionado = TipoFuncionario_ComboBox.SelectedItem.ToString();
            List<Funcionario> funcionariosFiltrados = new List<Funcionario>();

            if (tipoSelecionado == "Todos")
            {
                AtualizarDataGridView(funcionarios);
                
            }
            else
            {
                funcionariosFiltrados = funcionarios.Where(funcionario => funcionario.Tipo == tipoSelecionado).ToList();
                AtualizarDataGridView(funcionariosFiltrados);
            }
        }



        private void AtualizarDataGridView(List<Funcionario> funcionarios)
        {

            ValorPagarDataGridView.Rows.Clear();

            foreach (var funcionario in funcionarios)
            {

                ValorPagarDataGridView.Rows.Add(funcionario.Nome, funcionario.Tipo, 
                    funcionario.Salario, funcionario.DataContrato, funcionario.DataFimContrato);
            }
        }

        
        private void CalcularFormadorBtnButton_Click(object sender, EventArgs e) // funcao para calcular o valor aos formadores
        {
            if (TipoFuncionario_ComboBox.SelectedItem != null)
            {
                string tipoSelecionado = TipoFuncionario_ComboBox.SelectedItem.ToString();
                if (tipoSelecionado == "Formador")
                {
                    StringBuilder message = new StringBuilder();


                        foreach (DataGridViewRow row in ValorPagarDataGridView.Rows)
                        {
                            if (!row.IsNewRow && row.Cells["Tipo"].Value.ToString() == "Formador")
                            {
                                
                                decimal valorHora = Convert.ToDecimal(row.Cells["Salario"].Value);
                                DateTime dataInicio = Convert.ToDateTime(row.Cells["DataContrato"].Value);
                                DateTime dataFim = Convert.ToDateTime(row.Cells["DataFimContrato"].Value);

                                int totalDias = (int)(dataFim - dataInicio).TotalDays + 1;
                                int totalHoras = totalDias * 6;
                                decimal totalFormador = totalHoras * valorHora;
                             


                                message.AppendLine($"Formador: {row.Cells["Nome"].Value}, Total a pagar: {totalFormador}");
                            }
                        }
                    MessageBox.Show(message.ToString(), "Valor a pagar para Formadores");
                }
                else
                {
                    MessageBox.Show("Selecione 'Formador' no tipo de funcionário para calcular o valor.");
                }
            }
            else
            {
                MessageBox.Show("Selecione um tipo de funcionário na ComboBox.");
            }
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