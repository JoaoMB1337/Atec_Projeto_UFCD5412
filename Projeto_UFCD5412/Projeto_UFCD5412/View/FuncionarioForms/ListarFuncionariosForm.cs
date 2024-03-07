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
using Projeto_UFCD5412.Data;
using Projeto_UFCD5412.View.Forms;
using System.Runtime.CompilerServices;

namespace Projeto_UFCD5412.View.FuncionarioForms
{
    public partial class ListarFuncionariosForm : Form
    {
        private EmpresaController empresaController = EmpresaController.Instance;
        private DateTimeController dateTimeController = DateTimeController.Instance;

        public ListarFuncionariosForm()
        {
            InitializeComponent();
        }

        internal void SetParameter( string parametro)
        {
            if (parametro == "editar")
            {
                ListaFuncionarios_DataGrid.CellDoubleClick += ListaFuncionarios_DataGrid_CellDoubleClick;
            }
        }

        private void ListarFuncionariosForm_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            ListarFuncionarioDataGrid();
        }

        private void LoadComboBox()
        {
            TipoFuncionario_ComboBox.Items.Add("Todos");
            TipoFuncionario_ComboBox.Items.Add("Funcionario");
            TipoFuncionario_ComboBox.Items.Add("Formador");
            TipoFuncionario_ComboBox.Items.Add("Coordenador");
            TipoFuncionario_ComboBox.Items.Add("Secretaria");
            TipoFuncionario_ComboBox.Items.Add("Diretor");

            TipoFuncionario_ComboBox.SelectedIndex = 0;
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
                        funcionario.DataAniversario.ToShortDateString(),
                        funcionario.DataContrato.ToShortDateString(),
                        funcionario.DataFimContrato.ToShortDateString(),
                        funcionario.DataRegistoCriminal.ToShortDateString(),
                        funcionario.DataFimRegistoCriminal.ToShortDateString());
                }
            }
        }


        public void ListarFuncionarioDataGrid()
        {
            List<Funcionario> funcionarios = empresaController.ListarFuncionarios();
            ListaFuncionarios_DataGrid.Columns.Clear();

            ListaFuncionarios_DataGrid.AutoGenerateColumns = false;
            ListaFuncionarios_DataGrid.Columns.Add("Id", "ID");
            ListaFuncionarios_DataGrid.Columns.Add("Nome", "Nome");
            ListaFuncionarios_DataGrid.Columns.Add("Morada", "Morada");
            ListaFuncionarios_DataGrid.Columns.Add("Contacto", "Contacto");
            ListaFuncionarios_DataGrid.Columns.Add("Tipo", "Tipo");
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

        private void RegistoCriminal_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (RegistoCriminal_CheckBox.Checked)
            {
                DateTime dataAtual = dateTimeController.GetDateTime();
                List<Funcionario> funcionariosComRegistoExpirado = empresaController.ListarFuncionariosComRegistoCriminalExpirado(dataAtual);
                AtualizarDataGridView(funcionariosComRegistoExpirado);
            }
            else
            {
                ListarFuncionarioDataGrid();
            }
        }

        private void ContratoValido_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ContratoValido_CheckBox.Checked)
            {
                DateTime dataAtual = dateTimeController.GetDateTime();
                List<Funcionario> funcionariosComContratoValido = empresaController.ListarFuncionariosComContratoValido(dataAtual);
                AtualizarDataGridView(funcionariosComContratoValido);
            }
            else
            {
                ListarFuncionarioDataGrid();
            }
        }

        private void ListaFuncionarios_DataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        { 
            int rowIndex = e.RowIndex;
            int funcionarioId = Convert.ToInt32(ListaFuncionarios_DataGrid.Rows[rowIndex].Cells["Id"].Value);
            EditarFuncionarioForm editarFuncionarioForm = new EditarFuncionarioForm(); 
            editarFuncionarioForm.SetParameter(funcionarioId);
            editarFuncionarioForm.FormClosed += (s, args) => ListarFuncionarioDataGrid();
            editarFuncionarioForm.ShowDialog();
        }

        private void Addfuncionario_Btn_Click(object sender, EventArgs e)
        {
            AdicionarFuncionarioForm adicionarFuncionarioForm = new AdicionarFuncionarioForm();
            adicionarFuncionarioForm.FormClosed += (s, args) => ListarFuncionarioDataGrid();
            adicionarFuncionarioForm.ShowDialog();
        }

        private void Editarfuncionario_Btn_Click(object sender, EventArgs e)
        {
           SetParameter("editar");
        }

        private void Sair_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
