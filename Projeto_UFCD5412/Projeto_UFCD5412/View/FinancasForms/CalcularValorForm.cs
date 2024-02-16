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
using Projeto_UFCD5412.Model;
using Projeto_UFCD5412.View.Forms;
using Projeto_UFCD5412.View.FuncionarioForms;

namespace Projeto_UFCD5412.View.FinancasForms
{
    public partial class CalcularValorForm : Form
    {
        private EmpresaController empresaController = EmpresaController.Instance;
        private List<Funcionario> funcionarios;

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
            TipoFuncionario_ComboBox.SelectedIndex = 5; 
        }

        private void InitializeDataGridView()
        {
           
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("Nome", "Nome");
            dataGridView1.Columns.Add("Tipo", "Tipo");
            dataGridView1.Columns.Add("Salario", "Salário");
            dataGridView1.Columns.Add("TotalMes", "Total por Mês");

            
            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            funcionarios = empresaController.ListarFuncionarios();

            foreach (var funcionario in funcionarios)
            {
                
                decimal totalMes = funcionario.Salario * 30; 

                
                dataGridView1.Rows.Add(funcionario.Nome, funcionario.Tipo, funcionario.Salario, totalMes);
            }
        }

        private void CalcularValorBtn_Click(object sender, EventArgs e)
        {
            
            decimal totalGeral = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    string tipoFuncionario = row.Cells["Tipo"].Value.ToString();
                    decimal salario = Convert.ToDecimal(row.Cells["Salario"].Value);

                    totalGeral += salario;
                }
            }

            
            MessageBox.Show($"Total a pagar para todos os funcionários: {totalGeral:C2}");
        }

        private void PesquisarFuncinarioPorNome_Textbox_TextChanged(object sender, EventArgs e)
        {
            string nomePesquisado = PesquisarFuncinarioPorNome_Textbox.Text.ToLower(); 

            
            dataGridView1.Rows.Clear();

            
            foreach (var funcionario in funcionarios)
            {
                if (funcionario.Nome.ToLower().Contains(nomePesquisado))
                {
                    
                    dataGridView1.Rows.Add(funcionario.Nome, funcionario.Tipo, funcionario.Salario);
                }
            }
        }



    }
}