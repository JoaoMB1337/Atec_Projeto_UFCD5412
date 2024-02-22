using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Projeto_UFCD5412.Controller;
using Projeto_UFCD5412.Model;
using Projeto_UFCD5412.View.Forms;
using Projeto_UFCD5412.View.FuncionarioForms;

namespace Projeto_UFCD5412.View.DashboardForms
{
    public partial class DashboardForm : Form
    {
        EmpresaController empresaController = EmpresaController.Instance;
        DateTimeController dateTimeController = DateTimeController.Instance;
        List<Funcionario> funcionarios = new List<Funcionario>();

        public DashboardForm()
        {
            InitializeComponent();
            LoadComboBox();
            LoadData();

        }

        private void LoadComboBox()
        {
            TipoFuncionarioComboBox.Items.Add("Todos");
            TipoFuncionarioComboBox.Items.Add("Funcionario");
            TipoFuncionarioComboBox.Items.Add("Formador");
            TipoFuncionarioComboBox.Items.Add("Coordenador");
            TipoFuncionarioComboBox.Items.Add("Secretaria");
            TipoFuncionarioComboBox.Items.Add("Diretor");

            TipoFuncionarioComboBox.SelectedIndex = 0;
        }

        private void LoadData()
        {
            //Vai Buscar a data definida no sistema.
            DateTime dataAtual = dateTimeController.GetDateTime();

            // Carrega a lista de funcionários
            funcionarios = empresaController.ListarFuncionarios();

            // Calcula o total de funcionários
            int totalFuncionarios = funcionarios.Count;
            ContadorFunc_label.Text = totalFuncionarios.ToString();

            // Calcula o total de funcionários por tipo
            ContFuncionarios_label.Text = empresaController.CountNumeroTipoFuncionarios("Formador").ToString();
            Contador_Diretores_label.Text = empresaController.CountNumeroTipoFuncionarios("Diretor").ToString();
            Contador_Secretari_label.Text = empresaController.CountNumeroTipoFuncionarios("Secretaria").ToString();
            Contador_Formadores_label.Text = empresaController.CountNumeroTipoFuncionarios("Coordenador").ToString();

            int contratosAtivos = empresaController.CountContratosAtivos(dataAtual);
            ContadorContratos_label.Text = $"Contratos Ativos: {contratosAtivos}";

            int contratosInativos = empresaController.CountContratosInativos(dataAtual);
            ContadorContratosInativos_label.Text = $"Contratos Inativos: {contratosInativos}";                                                                                                                                      

            // Encontra o próximo aniversário de um funcionário
            var proximoAniversario = funcionarios.OrderBy(f => (f.DataAniversario.Month < DateTime.Today.Month || (f.DataAniversario.Month == DateTime.Today.Month && f.DataAniversario.Day >= DateTime.Today.Day)) ? f.DataAniversario.Month * 100 + f.DataAniversario.Day : (f.DataAniversario.Month + 12) * 100 + f.DataAniversario.Day).FirstOrDefault();
                                                                                            
            if (proximoAniversario != null)
            {
                ProximoAniversarioLabel.Text = $" {proximoAniversario.Id} {proximoAniversario.Nome} {proximoAniversario.DataAniversario.Day}/{proximoAniversario.DataAniversario.Month}";
            }
            else
            {
                ProximoAniversarioLabel.Text = "Não há aniversários próximos.";
            }

            int RegistosCriminaisAtivos = empresaController.CountRegistosCriminaisValidos(dataAtual);
            ContadorRegistosCriminais_label.Text = $"Registos Criminais Ativos: {RegistosCriminaisAtivos}";

            int RegistosCriminaisInativos = empresaController.CountRegistosCriminaisExpirados(DateTime.Today);
            ContadorRegistosCriminaisInativos_label.Text = $"Registos Criminais Inativos: {RegistosCriminaisInativos}";

            // salarios por tipo
            decimal totalSalarios = empresaController.CalcularTotalSalariosPorTipo("Todos");
            totalSalario_lbl.Text = totalSalarios.ToString();

        }

        private void Home_Button_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
            mainWindow.TopLevel = false;
            mainWindow.FormBorderStyle = FormBorderStyle.None;
            mainWindow.Dock = DockStyle.Fill;
            mainWindow.BringToFront();
            mainWindow.Show();
        }

        private void TipoFuncionarioComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoFuncionarioSelecionado = TipoFuncionarioComboBox.SelectedItem.ToString();
            decimal totalSalarios = empresaController.CalcularTotalSalariosPorTipo(tipoFuncionarioSelecionado);
            totalSalario_lbl.Text = totalSalarios.ToString();
        }

     
    }
}

