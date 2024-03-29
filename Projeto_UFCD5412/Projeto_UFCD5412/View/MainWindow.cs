﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Projeto_UFCD5412.View.CoordenacaoForms;
using Projeto_UFCD5412.View.Forms;
using Projeto_UFCD5412.View.FuncionarioForms;
using Projeto_UFCD5412.View.SettingsForms;
using Projeto_UFCD5412.View.FinancasForms;
using System.Windows.Media.Animation;
using Projeto_UFCD5412.Controller;
using Projeto_UFCD5412.View.DashboardForms;
using Projeto_UFCD5412.Model;

namespace Projeto_UFCD5412
{
    public partial class MainWindow : Form
    {   
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        DateTimeController dateTimeController = DateTimeController.Instance;

        public MainWindow()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            panelMenu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.DoubleBuffered = true;
          
            Timer timer = new Timer(); // Adicione esta linha
            DateTimeController.DateTimeChanged += DateTimeController_DateTimeChanged;
            dateTimeController.SetDateTime(DateTime.Now);

            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            timer.Start();

            timer_label.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            LoadDashboardForm();

            MostrarNomeUtilizador();

        
        }

        public void LoadDashboardForm()
        {
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.TopLevel = false;
            dashboardForm.FormBorderStyle = FormBorderStyle.None;
            dashboardForm.Dock = DockStyle.Fill;
            Menus_TabControl.SelectedTab.Controls.Add(dashboardForm);
            dashboardForm.BringToFront();
            dashboardForm.Show();
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);          
            public static Color color6 = Color.FromArgb(24, 161, 251);          
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(45,52,54);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(45, 52, 54);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime newDateTime = DateTime.Now;

            if (newDateTime.Date != dateTimeController.GetDateTime().Date)
            {
                dateTimeController.SetDateTime(dateTimeController.GetDateTime().Date.Add(newDateTime.TimeOfDay));
            }
            else
            {
                dateTimeController.SetDateTime(newDateTime);
            }

            timer_label.Text = dateTimeController.GetDateTime().ToString("dd/MM/yyyy HH:mm:ss");

        }

        private void Dashboard_Btn_Click(object sender, EventArgs e)
        {
            Menus_TabControl.SelectedTab = Menus_TabControl.TabPages["tabDashboard"];
            ActivateButton(sender, RGBColors.color1);
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.TopLevel = false;
            dashboardForm.FormBorderStyle = FormBorderStyle.None;
            dashboardForm.Dock = DockStyle.Fill;

            dashboardForm.Size = Menus_TabControl.SelectedTab.ClientSize;

            Menus_TabControl.SelectedTab.Controls.Add(dashboardForm);
            dashboardForm.BringToFront();
            dashboardForm.Show();
        }

        private void DashboardFuncionario_Btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
           Menus_TabControl.SelectedTab = Menus_TabControl.TabPages["tabDashboardFuncionario"];
            ListarFuncionariosForm listarFuncionariosForm = new ListarFuncionariosForm();
            listarFuncionariosForm.TopLevel = false;
            listarFuncionariosForm.FormBorderStyle = FormBorderStyle.None;
            listarFuncionariosForm.Dock = DockStyle.Fill;
            Menus_TabControl.SelectedTab.Controls.Add(listarFuncionariosForm);
            listarFuncionariosForm.BringToFront();
            listarFuncionariosForm.Show();
            
        }

        private void DashboardFormadores_Btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
           Menus_TabControl.SelectedTab = Menus_TabControl.TabPages["tabDashboardFormadores"];
        }

        private void DashboardFinancas_Btn_Click(object sender, EventArgs e)
        {
           Menus_TabControl.SelectedTab = Menus_TabControl.TabPages["tabDashboardFinancas"];
            ActivateButton(sender, RGBColors.color4);
            Menus_TabControl.SelectedTab = Menus_TabControl.TabPages["tabDashboardFinancas"];
            CalcularValorForm financasMainForm = new CalcularValorForm();
            financasMainForm.TopLevel = false;
            financasMainForm.FormBorderStyle = FormBorderStyle.None;
            financasMainForm.Dock = DockStyle.Fill;
            Menus_TabControl.SelectedTab.Controls.Add(financasMainForm);
            financasMainForm.BringToFront();
            financasMainForm.Show();


        }

        private void Defincoes_Btn_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            ActivateButton(sender, RGBColors.color5);
            Menus_TabControl.SelectedTab = Menus_TabControl.TabPages["tabDashboardDefinicoes"];
            settingsForm.TopLevel = false;
            settingsForm.FormBorderStyle = FormBorderStyle.None;
            settingsForm.Dock = DockStyle.Fill;
            Menus_TabControl.SelectedTab.Controls.Add(settingsForm);
            settingsForm.BringToFront();
            settingsForm.Show();
            Menus_TabControl.SelectedTab = Menus_TabControl.TabPages["tabDashboardDefinicoes"];
        }

        private void DateTimeController_DateTimeChanged(object sender, DateTimeChangedEventArgs e)
        {
            timer_label.Text = e.NewDateTime.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void MostrarNomeUtilizador()
        {
            if (LoginController.funcionarioLogado != null)
            {
                NomeFuncionario_Label.Text = "Bem-vindo, " + LoginController.funcionarioLogado.Nome;
            }
            else
            {
                NomeFuncionario_Label.Text = "Bem-vindo, Administrador";
            }
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
