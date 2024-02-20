using Projeto_UFCD5412.Controller;
using Projeto_UFCD5412.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("Nome", "Nome");
            dataGridView1.Columns.Add("Tipo", "Tipo");
            dataGridView1.Columns.Add("Salario", "Salário");
            dataGridView1.Columns.Add("TotalMes", "Total por Mês");
            dataGridView1.Columns.Add("DataContrato", "Data Contrato");
            dataGridView1.Columns.Add("DataFimContrato", "Data Fim Contrato");

            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            funcionarios = empresaController.ListarFuncionarios();

            foreach (var funcionario in funcionarios)
            {
                decimal totalMes = funcionario.Salario * 8;
                dataGridView1.Rows.Add(funcionario.Nome, funcionario.Tipo, funcionario.Salario, totalMes, funcionario.DataContrato, funcionario.DataFimContrato);
            }
        }

        private void TipoFuncionario_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoSelecionado = TipoFuncionario_ComboBox.SelectedItem.ToString();
            List<Funcionario> funcionariosFiltrados = new List<Funcionario>();

            if (tipoSelecionado == "Todos")
            {
                AtualizarDataGridView(funcionarios);
                // Tornar o botão de cálculo do formador invisível quando o tipo for "Todos"
                CalcularFormadorBtnButton.Visible = false;
                // Exibir a coluna "Total por Mês"
                dataGridView1.Columns["TotalMes"].Visible = true;
            }
            else if (tipoSelecionado == "Formador")
            {
                funcionariosFiltrados = funcionarios.Where(funcionario => funcionario.Tipo == "Formador").ToList();
                AtualizarDataGridView(funcionariosFiltrados);
                // Tornar o botão de cálculo do formador visível quando o tipo for "Formador"
                CalcularFormadorBtnButton.Visible = true;
                // Esconder a coluna "Total por Mês"
                dataGridView1.Columns["TotalMes"].Visible = false;
            }
            else
            {
                foreach (var funcionario in funcionarios)
                {
                    if (funcionario.Tipo == tipoSelecionado)
                    {
                        funcionariosFiltrados.Add(funcionario);
                    }
                }
                AtualizarDataGridView(funcionariosFiltrados);
                // Tornar o botão de cálculo do formador invisível para outros tipos de funcionários
                CalcularFormadorBtnButton.Visible = false;
                // Exibir a coluna "Total por Mês"
                dataGridView1.Columns["TotalMes"].Visible = true;
            }
        }



        private void AtualizarDataGridView(List<Funcionario> funcionarios)
        {

            dataGridView1.Rows.Clear();

            foreach (var funcionario in funcionarios)
            {
                decimal totalMes = funcionario.Salario * 30;
                dataGridView1.Rows.Add(funcionario.Nome, funcionario.Tipo, funcionario.Salario, totalMes, funcionario.DataContrato, funcionario.DataFimContrato);
            }
        }

        private void CalcularValorBtn_Click(object sender, EventArgs e)
        {
            decimal totalGeral = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    decimal salario = Convert.ToDecimal(row.Cells["Salario"].Value);
                    totalGeral += salario;
                }
            }

            MessageBox.Show($"Total a pagar para todos os funcionários: {totalGeral}");
        }

        private void PesquisarFuncinarioPorNome_Textbox_TextChanged(object sender, EventArgs e)
        {
            string nomePesquisado = PesquisarFuncinarioPorNome_Textbox.Text.ToLower();
            List<Funcionario> funcionariosFiltrados = new List<Funcionario>();

            foreach (var funcionario in funcionarios)
            {
                if (funcionario.Nome.ToLower().Contains(nomePesquisado))
                {
                    funcionariosFiltrados.Add(funcionario);
                }
            }

            AtualizarDataGridView(funcionariosFiltrados);
        }

        private void CalcularFormadorBtnButton_Click(object sender, EventArgs e)
        {
            if (TipoFuncionario_ComboBox.SelectedItem != null)
            {
                string tipoSelecionado = TipoFuncionario_ComboBox.SelectedItem.ToString();

                if (tipoSelecionado == "Formador")
                {
                    StringBuilder message = new StringBuilder();

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow && row.Cells["Tipo"].Value.ToString() == "Formador")
                        {
                            decimal salarioHora = Convert.ToDecimal(row.Cells["Salario"].Value);
                            DateTime dataInicio = Convert.ToDateTime(row.Cells["DataContrato"].Value);
                            DateTime dataFim = Convert.ToDateTime(row.Cells["DataFimContrato"].Value);

                            int totalDias = (int)(dataFim - dataInicio).TotalDays + 1;
                            int totalHoras = totalDias * 6;
                            decimal totalFormador = totalHoras * salarioHora;


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
    }
}
