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
using Projeto_UFCD5412.View.SettingsForms;

namespace Projeto_UFCD5412.View.DashboardForms
{
    public partial class DashboardForm : Form
    {
        EmpresaController empresaController = EmpresaController.Instance;
        List<Funcionario> funcionarios = new List<Funcionario>();

        public DashboardForm()
        {
            InitializeComponent();
            LoadData();
            LoadComboBox();
           
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
            // Carrega a lista de funcionários
                funcionarios = empresaController.ListarFuncionarios();

                // Calcula o total de funcionários
                int totalFuncionarios = funcionarios.Count;
                ContadorFunc_label.Text = totalFuncionarios.ToString();

                // Calcula o total de funcionários por tipo
                ContFuncionarios_label.Text = empresaController.CountNumeroTipoFuncionarios("Formador").ToString();
                Contador_Diretores_label.Text = empresaController.CountNumeroTipoFuncionarios("Coordenador").ToString();
                Contador_Secretari_label.Text = empresaController.CountNumeroTipoFuncionarios("Secretaria").ToString();
                Contador_Formadores_label.Text = empresaController.CountNumeroTipoFuncionarios("Diretor").ToString();

                int contratosAtivos = funcionarios.Count(f => f.DataFimContrato > DateTime.Today);
                ContadorContratos_label.Text = $"Contratos Ativos: {contratosAtivos}";

                int contratosInativos = funcionarios.Count(f => f.DataFimContrato < DateTime.Today);
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

                int RegistosCriminaisAtivos = funcionarios.Count(f => f.DataFimRegistoCriminal > DateTime.Today);
                ContadorRegistosCriminais_label.Text = $"Registos Criminais Ativos: {RegistosCriminaisAtivos}";

                int RegistosCriminaisInativos = funcionarios.Count(f => f.DataFimRegistoCriminal < DateTime.Today);
                ContadorRegistosCriminaisInativos_label.Text = $"Registos Criminais Inativos: {RegistosCriminaisInativos}";

                decimal totalSalarios = empresaController.CalcularTotalSalariosPorTipo("Formador");
                totalSalario_lbl.Text = totalSalarios.ToString();

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

