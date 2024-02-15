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
using Projeto_UFCD5412.View.FuncionarioForms;

namespace Projeto_UFCD5412.View.FinancasForms
{
    public partial class CalcularValorForm : Form
    {
        private EmpresaController empresaController = EmpresaController.Instance;
        public CalcularValorForm()
        {
            InitializeComponent();
        }


        private void AtualizarDataGridView(List<Funcionario> funcionarios)
        {
            ListarFuncionariosForm listarFuncionariosForm = new ListarFuncionariosForm();   
            ListaFuncionariosValorAPagar_DataGrid.Rows.Clear();

            foreach (var funcionario in funcionarios)
            {
                if ((funcionario.Tipo == TipoFuncionario_ComboBox.SelectedItem.ToString()) || (TipoFuncionario_ComboBox.SelectedItem.ToString() == "Todos"))
                {
                    ListaFuncionariosValorAPagar_DataGrid.Rows.Add(
                    funcionario.Id,
                    funcionario.Nome,
                    funcionario.Tipo,
                    funcionario.Salario,
                    funcionario.DataContrato.ToShortDateString(),
                    funcionario.DataFimContrato.ToShortDateString());
                    
                }
            }
        }

        private void ListaFuncionariosValorAPagar_DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Funcionario> funcionarios = empresaController.ListarFuncionarios();
            ListaFuncionariosValorAPagar_DataGrid.Columns.Clear();

            ListaFuncionariosValorAPagar_DataGrid.Columns.Add("Id", "ID");
            ListaFuncionariosValorAPagar_DataGrid.Columns.Add("Nome", "Nome");
            ListaFuncionariosValorAPagar_DataGrid.Columns.Add("Tipo", "Tipo");
            ListaFuncionariosValorAPagar_DataGrid.Columns.Add("DataContrato", "Data Contrato");
            ListaFuncionariosValorAPagar_DataGrid.Columns.Add("DataFimContrato", "Data Fim Contrato");
            ListaFuncionariosValorAPagar_DataGrid.Columns.Add("DataFimContrato", "Data Fim Contrato");
            ListaFuncionariosValorAPagar_DataGrid.Columns.Add("ValorAPagar", "Valor a Pagar");
        }
    }
}
