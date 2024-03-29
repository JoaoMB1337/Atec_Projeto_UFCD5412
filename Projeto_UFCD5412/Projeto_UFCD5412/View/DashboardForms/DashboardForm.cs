﻿using System;
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
            funcionarios = empresaController.ListarFuncionarios();

            int totalFuncionarios = empresaController.CountTotalFuncionarios(); ;
            ContadorFunc_label.Text = totalFuncionarios.ToString();

            ContFuncionarios_label.Text = empresaController.CountNumeroTipoFuncionarios("Funcionario").ToString();
            Contador_Diretores_label.Text = empresaController.CountNumeroTipoFuncionarios("Diretor").ToString();
            Contador_Secretari_label.Text = empresaController.CountNumeroTipoFuncionarios("Secretaria").ToString();
            Contador_Formadores_label.Text = empresaController.CountNumeroTipoFuncionarios("Formador").ToString();
            ContCoordenadores_label.Text = empresaController.CountNumeroTipoFuncionarios("Coordenador").ToString();


            int contratosAtivos = empresaController.CountContratosAtivos(dataAtual);
            ContadorContratos_label.Text = $"Contratos Ativos: {contratosAtivos}";

            int contratosInativos = empresaController.CountContratosInativos(dataAtual);
            ContadorContratosInativos_label.Text = $"Contratos Inativos: {contratosInativos}";

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

   
            Funcionario funcionarioMaisRecente = empresaController.FuncionarioMaisRecente();
            if (funcionarioMaisRecente != null)
            {
                FuncionarioRecente_label.Text = $"{funcionarioMaisRecente.Nome} {funcionarioMaisRecente.DataContrato.Day}/{funcionarioMaisRecente.DataContrato.Month}/{funcionarioMaisRecente.DataContrato.Year}";
            }
            else
            {
                FuncionarioRecente_label.Text = "Não há funcionários registados.";
            }

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
            DateTime dataAtual = dateTimeController.GetDateTime();
            string selectedTipo = TipoFuncionarioComboBox.SelectedItem.ToString();
            decimal totalSalarios = empresaController.CalcularTotalSalariosPorTipo(selectedTipo, dataAtual);
            totalSalario_lbl.Text = totalSalarios.ToString();
        }

        private void PanelContratosInativos_MouseEnter(object sender, EventArgs e)
        {
            DateTime dataAtual = dateTimeController.GetDateTime();
            List<string> nomesFuncionariosInativos = empresaController.ListarNomesFuncionariosInativos(dataAtual);

            // Construir uma mensagem com os nomes dos funcionários
            StringBuilder mensagem = new StringBuilder();
            mensagem.AppendLine("Funcionários com contratos Inativos:");
            foreach (string nome in nomesFuncionariosInativos)
            {
                mensagem.AppendLine(nome);
            }

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(PanelContratosInativos, mensagem.ToString());
        }

        private void PanelRegistoCriminalInativos_MouseEnter(object sender, EventArgs e)
        {
            DateTime dataAtual = dateTimeController.GetDateTime();
            List<string> nomesFuncionariosComRegistroCriminalInativos = empresaController.ListarNomesFunciomariosComRegistoCriminalInativo(dataAtual);
            StringBuilder mensagem = new StringBuilder();
            mensagem.AppendLine("Funcionários com contratos Inativos:");
            foreach (string nome in nomesFuncionariosComRegistroCriminalInativos)
            {
                mensagem.AppendLine(nome);
            }

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(PanelRegistoCriminalInativos, mensagem.ToString());
        }

    }
}

