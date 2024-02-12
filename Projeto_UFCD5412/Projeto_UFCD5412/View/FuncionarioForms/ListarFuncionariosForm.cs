﻿using Projeto_UFCD5412.Controller;
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
using Projeto_UFCD5412.Controller;
using Projeto_UFCD5412.Data;

namespace Projeto_UFCD5412.View.FuncionarioForms
{
    public partial class ListarFuncionariosForm : Form
    {
        private EmpresaController empresaController = EmpresaController.Instance;
        public ListarFuncionariosForm()
        {
            InitializeComponent();
            CSVHandler.LoadFromCSV();
        }

        private void ListarFuncionariosForm_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            ListarFuncionarioDataGrid();
        }

        private void LoadComboBox()
        {
            TipoFuncionario_ComboBox.Items.Add("Funcionario");
            TipoFuncionario_ComboBox.Items.Add("Formador");
            TipoFuncionario_ComboBox.Items.Add("Coordenador");
            TipoFuncionario_ComboBox.Items.Add("Secretaria");
            TipoFuncionario_ComboBox.Items.Add("Diretor");
            TipoFuncionario_ComboBox.Items.Add("Todos");
            TipoFuncionario_ComboBox.SelectedItem = "Todos"; //Valor Default

        }

        private void AtualizarDataGridView(List<Funcionario> funcionarios)
        {
            ListaFuncionarios_DataGrid.Rows.Clear();

            foreach (var funcionario in funcionarios)
            {
                if ((funcionario.Tipo == TipoFuncionario_ComboBox.SelectedItem.ToString()) || (TipoFuncionario_ComboBox.SelectedItem.ToString() == "Todos"))
                {
                    ListaFuncionarios_DataGrid.Rows.Add(
                    funcionario.Id,
                    funcionario.Nome,
                    funcionario.Morada,
                    funcionario.Contacto,
                    funcionario.Tipo,
                    funcionario.Salario,
                    funcionario.DataAniversario.ToShortDateString(),
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
            ListaFuncionarios_DataGrid.Columns.Clear();

            ListaFuncionarios_DataGrid.AutoGenerateColumns = false;
            ListaFuncionarios_DataGrid.Columns.Add("Id", "ID");
            ListaFuncionarios_DataGrid.Columns.Add("Nome", "Nome");
            ListaFuncionarios_DataGrid.Columns.Add("Morada", "Morada");
            ListaFuncionarios_DataGrid.Columns.Add("Contacto", "Contacto");
            ListaFuncionarios_DataGrid.Columns.Add("Tipo", "Tipo");
            ListaFuncionarios_DataGrid.Columns.Add("Salario", "Salario");
            ListaFuncionarios_DataGrid.Columns.Add("DataAniversario", "Data Aniversario");
            ListaFuncionarios_DataGrid.Columns.Add("DataContrato", "Data Contrato");
            ListaFuncionarios_DataGrid.Columns.Add("DataFimContrato", "Data Fim Contrato");
            ListaFuncionarios_DataGrid.Columns.Add("DataRegistoCriminal", "Data Registo Criminal");
            ListaFuncionarios_DataGrid.Columns.Add("DataFimRegistoCriminal", "Data Fim Registo Criminal");

            AtualizarDataGridView(funcionarios);
        }

        private void TipoFuncionario_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListaFuncionarios_DataGrid.Refresh();
            ListarFuncionarioDataGrid();
        }

        private void PesquisarFuncinarioPorNome_Textbox_TextChanged(object sender, EventArgs e)
        {
            string nomePesquisado = PesquisarFuncinarioPorNome_Textbox.Text;
            List<Funcionario> funcionariosFiltrados = empresaController.PesquisarFuncionariosPorNome(nomePesquisado);
            AtualizarDataGridView(funcionariosFiltrados);
        }

        private void Sair_Btn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void atualizarCsv_btn_Click(object sender, EventArgs e)
        {
            CSVHandler.ExportToCSV(empresaController.Funcionarios);
        }
    }
}
