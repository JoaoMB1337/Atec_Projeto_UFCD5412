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
            LoadData();
            LoadComboBox();


            
        }
       
        //carrega  a dashboard na inicialização no tabcontrol em ecra inteiro
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.TopLevel = false;
            dashboard.FormBorderStyle = FormBorderStyle.None;
            dashboard.Dock = DockStyle.Fill;
            dashboard.BringToFront();
            dashboard.Show();
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
            DateTime dataAtual = dateTimeController.GetDateTime();
            // Carrega a lista de funcionários
            funcionarios = empresaController.ListarFuncionarios();

            // Calcula o total de funcionários
            int totalFuncionarios = empresaController.CountTotalFuncionarios(); ;
            ContadorFunc_label.Text = totalFuncionarios.ToString();

            // Calcula o total de funcionários por tipo
            ContFuncionarios_label.Text = empresaController.CountNumeroTipoFuncionarios("Funcionario").ToString();
            Contador_Diretores_label.Text = empresaController.CountNumeroTipoFuncionarios("Diretor").ToString();
            Contador_Secretari_label.Text = empresaController.CountNumeroTipoFuncionarios("Secretaria").ToString();
            Contador_Formadores_label.Text = empresaController.CountNumeroTipoFuncionarios("Formador").ToString();

            int contratosAtivos = empresaController.CountContratosAtivos(dataAtual);
            ContadorContratos_label.Text = $"Contratos Ativos: {contratosAtivos}";

            int contratosInativos = empresaController.CountContratosInativos(dataAtual);
            ContadorContratosInativos_label.Text = $"Contratos Inativos: {contratosInativos}";

            // Encontra o próximo aniversário de um funcionário
            var proximoAniversario = empresaController.ProximoAniversario(dataAtual);

            if (proximoAniversario != null)
            {
                ProximoAniversarioLabel.Text = $"{proximoAniversario.Nome} {proximoAniversario.DataAniversario.Day}/{proximoAniversario.DataAniversario.Month}";
            }
            else
            {
                ProximoAniversarioLabel.Text = "Não há aniversários próximos.";
            }

            int RegistosCriminaisAtivos = empresaController.CountRegistosCriminaisValidos(dataAtual);
            ContadorRegistosCriminais_label.Text = $"Registos Criminais Ativos: {RegistosCriminaisAtivos}";

            int RegistosCriminaisInativos = empresaController.CountRegistosCriminaisExpirados(dataAtual);
            ContadorRegistosCriminaisInativos_label.Text = $"Registos Criminais Inativos: {RegistosCriminaisInativos}";

        }

        private void Home_Button_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();

            dashboard.TopLevel = false;
            dashboard.FormBorderStyle = FormBorderStyle.None;
            dashboard.Dock = DockStyle.Fill;
            dashboard.BringToFront();
            dashboard.Show();
        }

        private void TipoFuncionarioComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTipo = TipoFuncionarioComboBox.SelectedItem.ToString();


            decimal totalSalarios = empresaController.CalcularTotalSalariosPorTipo(selectedTipo);
            totalSalario_lbl.Text = totalSalarios.ToString();

        }

        

    }
}

