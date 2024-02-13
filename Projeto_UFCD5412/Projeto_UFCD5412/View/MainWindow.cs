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
using Projeto_UFCD5412.View.Forms;
using Projeto_UFCD5412.View.FuncionarioForms;
namespace Projeto_UFCD5412
{
    public partial class MainWindow : Form
    {   
        //Variáveis
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        

        public MainWindow()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            //this.ControlBox = false;
            this.DoubleBuffered = true;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;



            Timer timer = new Timer();
            timer.Interval = (1 * 1000); // 10 secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        //Eventos
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);          
            public static Color color6 = Color.FromArgb(24, 161, 251);          
        }

        //Métodos
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icone Atual


            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(object childForm)
        {
          if(currentChildForm != null)
            {
                //Abrir apenas um formulário
              currentChildForm.Close();
          }
            //currentChildForm = childForm;
            //childForm.TopLevel = false;
            //childForm.FormBorderStyle = FormBorderStyle.None;
            //childForm.Dock = DockStyle.Fill;
            //panelDesktop.Controls.Add(childForm);
            //panelDesktop.Tag = childForm;
            //childForm.BringToFront();
            //childForm.Show();
            //HomeDash_Btn.Text = childForm.Text;
        }
   
        private void Home_Btn_Click(object sender, EventArgs e)
        {
            Reset();
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;

            //HomeDash_Btn.Text = "Home";
        }
        //drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer_label.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

        }

        private void Dashboard_Btn_Click(object sender, EventArgs e)
        {

            Menus_TabControl.SelectedTab = Menus_TabControl.TabPages["tabDashboard"];

        }

        private void DashboardFuncionario_Btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
           Menus_TabControl.SelectedTab = Menus_TabControl.TabPages["tabDashboardFuncionario"];

        }

        private void DashboardFormadores_Btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
           Menus_TabControl.SelectedTab = Menus_TabControl.TabPages["tabDashboardFormadores"];

            AdicionarFuncionarioForm adicionarFuncionarioForm = new AdicionarFuncionarioForm();
        }

        private void DashboardFinancas_Btn_Click(object sender, EventArgs e)
        {
           Menus_TabControl.SelectedTab = Menus_TabControl.TabPages["tabDashboardFinancas"];
        }

        private void Defincoes_Btn_Click(object sender, EventArgs e)
        {
            Menus_TabControl.SelectedTab = Menus_TabControl.TabPages["tabDashboardDefinicoes"];
        }


        private void AdicionarFuncionario_Btn_Click_1(object sender, EventArgs e)
        {
            AdicionarFuncionarioForm adicionarFuncionarioForm = new AdicionarFuncionarioForm();

            adicionarFuncionarioForm.TopLevel = false;
            adicionarFuncionarioForm.FormBorderStyle = FormBorderStyle.None;
            adicionarFuncionarioForm.Dock = DockStyle.Fill;

            Menus_TabControl.SelectedTab.Controls.Add(adicionarFuncionarioForm);
            adicionarFuncionarioForm.BringToFront();

            // Exibe o formulário
            adicionarFuncionarioForm.Show();

        }

        private void ListarFuncionario_Btn_Click(object sender, EventArgs e)
        {
            ListarFuncionariosForm listarFuncionariosForm = new ListarFuncionariosForm();
            listarFuncionariosForm.TopLevel = false;
            listarFuncionariosForm.FormBorderStyle = FormBorderStyle.None;
            listarFuncionariosForm.Dock = DockStyle.Fill;

            Menus_TabControl.SelectedTab.Controls.Add(listarFuncionariosForm);

            listarFuncionariosForm.BringToFront();
            listarFuncionariosForm.Show();

        }


        private void EditarFuncionario_Btn_Click(object sender, EventArgs e)
        {

            ListarFuncionariosForm listarFuncionariosForm = new ListarFuncionariosForm();

            listarFuncionariosForm.SetParameter("editar");  // enviar parametro para o form
            listarFuncionariosForm.TopLevel = false;
            listarFuncionariosForm.FormBorderStyle = FormBorderStyle.None;
            listarFuncionariosForm.Dock = DockStyle.Fill;

            Menus_TabControl.SelectedTab.Controls.Add(listarFuncionariosForm);
            listarFuncionariosForm.BringToFront();
            listarFuncionariosForm.Show();
        }
    }
}
