using Projeto_UFCD5412.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_UFCD5412.View.CoordenacaoForms
{
    public partial class CoordenacaoMainForm : Form
    {
        public CoordenacaoMainForm()
        {
            InitializeComponent();
            MostrarNomeUtilizador();
        }



        private void DashboardCalendario_Btn_Click(object sender, EventArgs e)
        {
            //abrir calendario dentro do flowpanel
            CalendarioForm calendarioForm = new CalendarioForm();
            calendarioForm.TopLevel = false;
            calendarioForm.AutoScroll = true;
            calendarioForm.FormBorderStyle = FormBorderStyle.None;
            flowLayoutPanel1.Controls.Add(calendarioForm);
            calendarioForm.Show();
        }

        private void MostrarNomeUtilizador()
        {
            //mostrar o nome do utilizador
            NomeFuncionario_Label.Text = "Bem-vindo, " + LoginController.funcionarioLogado.Nome;
        }


        private void Sair_btn_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
