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

namespace Projeto_UFCD5412.View
{
    public partial class ListarFuncionarioForms : Form
    {
        private EmpresaController empresaController;
        public ListarFuncionarioForms()
        {
            InitializeComponent();
            empresaController = new EmpresaController();
        }

        private void ListarFuncionarioForms_Load(object sender, EventArgs e)
        {
            ListarFuncionariosDataGrid();
        }

        private void ListarFuncionariosDataGrid()
        {
            empresaController.ListarFuncionarios();

            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nome");
            dt.Columns.Add("Morada");
            dt.Columns.Add("Contacto");
            dt.Columns.Add("Tipo");
            dt.Columns.Add("DataContrato");
            dt.Columns.Add("DataFimContrato");
            dt.Columns.Add("DataRegistoCriminal");
            dt.Columns.Add("DataFimRegistoCriminal");

            foreach (var funcionario in empresaController.Funcionarios)
            {
                dt.Rows.Add(
                    funcionario.Id,
                    funcionario.Nome,
                    funcionario.Morada,
                    funcionario.Contacto,
                    funcionario.Tipo,
                    funcionario.DataContrato.ToString("dd/MM/yyyy"),
                    funcionario.DataFimContrato.ToString("dd/MM/yyyy"),
                    funcionario.DataRegistoCriminal.ToString("dd/MM/yyyy"),
                    funcionario.DataFimRegistoCriminal.ToString("dd/MM/yyyy")
                );
            }

            FuncionariosList_DataGrid.DataSource = dt;
        }




    }
}
