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

namespace Projeto_UFCD5412.View
{
    public partial class ListarFuncionarioForms : Form
    {
        private EmpresaController empresaController = new EmpresaController();
        public ListarFuncionarioForms()
        {
            InitializeComponent();
        }


        private void ListarFuncionarioForms_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            ListarFuncionarioDataGrid();
        }
        private void LoadComboBox()
        {
            comboBox1.Items.Add("Funcionario");
            comboBox1.Items.Add("Formador");
            comboBox1.Items.Add("Coordenador");
            comboBox1.Items.Add("Secretaria");
            comboBox1.Items.Add("Diretor");
            comboBox1.Items.Add("Todos");
            comboBox1.SelectedItem = "Todos"; //Valor Default

        }

        private void AtualizarDataGridView(List<Funcionario> funcionarios)
        {
            FuncionariosList_DataGrid.Rows.Clear();

            foreach (var funcionario in funcionarios)
            {
                if ((funcionario.Tipo == comboBox1.SelectedItem.ToString()) || (comboBox1.SelectedItem.ToString() == "Todos"))
                {
                    FuncionariosList_DataGrid.Rows.Add(
                    funcionario.Id,
                    funcionario.Nome,
                    funcionario.Morada,
                    funcionario.Contacto,
                    funcionario.Tipo,
                    funcionario.DataContrato.ToShortDateString(),
                    funcionario.DataFimContrato.ToShortDateString(),
                    funcionario.DataRegistoCriminal.ToShortDateString(),
                    funcionario.DataFimRegistoCriminal.ToShortDateString());
                }

            }
        }

        private void ListarFuncionarioDataGrid()
        {
            List<Funcionario> funcionarios = empresaController.ListarFuncionarios();
            FuncionariosList_DataGrid.Columns.Clear();

            FuncionariosList_DataGrid.AutoGenerateColumns = false;
            FuncionariosList_DataGrid.Columns.Add("Id", "ID");
            FuncionariosList_DataGrid.Columns.Add("Nome", "Nome");
            FuncionariosList_DataGrid.Columns.Add("Morada", "Morada");
            FuncionariosList_DataGrid.Columns.Add("Contacto", "Contacto");
            FuncionariosList_DataGrid.Columns.Add("Tipo", "Tipo");
            FuncionariosList_DataGrid.Columns.Add("DataContrato", "Data Contrato");
            FuncionariosList_DataGrid.Columns.Add("DataFimContrato", "Data Fim Contrato");
            FuncionariosList_DataGrid.Columns.Add("DataRegistoCriminal", "Data Registo Criminal");
            FuncionariosList_DataGrid.Columns.Add("DataFimRegistoCriminal", "Data Fim Registo Criminal");

            AtualizarDataGridView(funcionarios);
        }


        private void AdicionarFuncionario_Btn_Click(object sender, EventArgs e)
        {
            AdicionarFuncionarioForms adicionarFuncionarioForms = new AdicionarFuncionarioForms();
            adicionarFuncionarioForms.ShowDialog();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FuncionariosList_DataGrid.Refresh();
            ListarFuncionarioDataGrid();
        }

        private void SearchName_TextBox_TextChanged(object sender, EventArgs e)
        {
            string nomePesquisado = SearchName_TextBox.Text;
            List<Funcionario> funcionariosFiltrados = empresaController.PesquisarFuncionariosPorNome(nomePesquisado);
            AtualizarDataGridView(funcionariosFiltrados);
        }
    }
}
