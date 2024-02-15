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


        private void CalcularValorForm_Load(object sender, EventArgs e)
        {
            TipoFuncionario_ComboBox_SelectedIndexChanged_1();
            ListarFuncionarioDataGrid();
        }

        private void TipoFuncionario_ComboBox_SelectedIndexChanged_1()
        {
            TipoFuncionario_ComboBox.Items.Add("Funcionario");
            TipoFuncionario_ComboBox.Items.Add("Formador");
            TipoFuncionario_ComboBox.Items.Add("Coordenador");
            TipoFuncionario_ComboBox.Items.Add("Secretaria");
            TipoFuncionario_ComboBox.Items.Add("Diretor");
            TipoFuncionario_ComboBox.Items.Add("Todos");
            TipoFuncionario_ComboBox.SelectedItem = "Todos"; //Valor Default
        }

        private void ListarFuncionarioDataGrid()
        {
            List<Funcionario> funcionarios = empresaController.ListarFuncionarios();
            ListaFuncionariosValorAPagar_DataGrid.Columns.Clear();

            ListaFuncionariosValorAPagar_DataGrid.AutoGenerateColumns = false;
            ListaFuncionariosValorAPagar_DataGrid.Columns.Add("Id", "ID");
            ListaFuncionariosValorAPagar_DataGrid.Columns.Add("Nome", "Nome");
            ListaFuncionariosValorAPagar_DataGrid.Columns.Add("Morada", "Morada");
            ListaFuncionariosValorAPagar_DataGrid.Columns.Add("Contacto", "Contacto");
            ListaFuncionariosValorAPagar_DataGrid.Columns.Add("Tipo", "Tipo");
            ListaFuncionariosValorAPagar_DataGrid.Columns.Add("Salario", "Salario");
            ListaFuncionariosValorAPagar_DataGrid.Columns.Add("DataAniversario", "Data Aniversario");
            ListaFuncionariosValorAPagar_DataGrid.Columns.Add("DataContrato", "Data Contrato");
            ListaFuncionariosValorAPagar_DataGrid.Columns.Add("DataFimContrato", "Data Fim Contrato");
            ListaFuncionariosValorAPagar_DataGrid.Columns.Add("DataRegistoCriminal", "Data Registo Criminal");
            ListaFuncionariosValorAPagar_DataGrid.Columns.Add("DataFimRegistoCriminal", "Data Fim Registo Criminal");

            AtualizarDataGridView(funcionarios);
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

        private void TipoFuncionario_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListaFuncionariosValorAPagar_DataGrid.Refresh();
            ListarFuncionarioDataGrid();
        }

        private void CalcularValorAPagar_Btn_Click(object sender, EventArgs e)
        {
            //CalcularValorAPagarForm calcularValorAPagarForm = new CalcularValorAPagarForm();
            //calcularValorAPagarForm.ShowDialog();
        }
        
    }
}
