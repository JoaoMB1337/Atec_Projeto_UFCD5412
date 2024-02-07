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
            ListarFuncionarioDataGrid();
        }

        private void ListarFuncionarioDataGrid()
        {
            DateTime datahj = DateTime.Now;
            List<Funcionario> funcionarios = empresaController.ListarFuncionarios();

            // Configurar as colunas do DataGridView
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

            foreach (var funcionario in funcionarios)
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
                    funcionario.DataFimRegistoCriminal.ToShortDateString()
                );
            }
        }

        private void AdicionarFuncionario_Btn_Click(object sender, EventArgs e)
        {
            AdicionarFuncionarioForms adicionarFuncionarioForms = new AdicionarFuncionarioForms();
            adicionarFuncionarioForms.ShowDialog();

        }
    }
}
