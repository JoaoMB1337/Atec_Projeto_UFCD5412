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
using Projeto_UFCD5412.View.Forms;
using Projeto_UFCD5412.View.FuncionarioForms;

namespace Projeto_UFCD5412.View.DashboardForms
{
    public partial class DashboardForm : Form
    {
        EmpresaController empresaController = EmpresaController.Instance;

        public DashboardForm()
        {
            InitializeComponent();
        }

        

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            //ContadorFunc_label.Text = empresaController.CountNumeroTotalFuncionarios().ToString();
            //Contador_Func_label.Text = empresaController.CountNumeroTipoFuncionarios("Formador").ToString();
            //Contador_Diretores_label.Text = empresaController.CountNumeroTipoFuncionarios("Coordenador").ToString();
            //Contador_Secretari_label.Text = empresaController.CountNumeroTipoFuncionarios("Secretaria").ToString();
            //Contador_Formadores_label.Text = empresaController.CountNumeroTipoFuncionarios("Diretor").ToString();
        }

        private void iconButton1_Click(object sender, EventArgs e)
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
    }

}

