using System;
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
using Projeto_UFCD5412.View.FinancasForms;
using Projeto_UFCD5412.View.CoordenacaoForms;
using Projeto_UFCD5412.View.Forms;
using Projeto_UFCD5412.View.FuncionarioForms;
using Projeto_UFCD5412.View.SettingsForms;
namespace Projeto_UFCD5412
{
    public partial class MainWindow : Form
    {   
        //Variáveis
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        

        public MainWindow()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            //this.ControlBox = false;
            this.DoubleBuffered = true;

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
                currentBtn.BackColor = Color.FromArgb(0, 0, 64);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
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
            ListarFuncionariosForm listarFuncionariosForm = new ListarFuncionariosForm();
            Menus_TabControl.SelectedTab = Menus_TabControl.TabPages["tabDashboardFuncionario"];
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


            //abrir o coordenacaoMainForm fora do tabControl
            CoordenacaoMainForm coordenacaoMainForm = new CoordenacaoMainForm();
            coordenacaoMainForm.TopLevel = false;
            coordenacaoMainForm.FormBorderStyle = FormBorderStyle.None;
            coordenacaoMainForm.Dock = DockStyle.Fill;
            this.Controls.Add(coordenacaoMainForm);
            coordenacaoMainForm.BringToFront();
            coordenacaoMainForm.Show();                
        }

        private void DashboardFinancas_Btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            Menus_TabControl.SelectedTab = Menus_TabControl.TabPages["tabDashboardFinancas"];
        }

        private void Defincoes_Btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            Menus_TabControl.SelectedTab = Menus_TabControl.TabPages["tabDashboardDefinicoes"];
            //settingsForm.TopLevel = false;
            //settingsForm.FormBorderStyle = FormBorderStyle.None;
            //settingsForm.Dock = DockStyle.Fill;
            //Menus_TabControl.SelectedTab.Controls.Add(settingsForm);
            //settingsForm.BringToFront();
            //settingsForm.Show();
        }

        private void CalcularValorAPagar_button_Click(object sender, EventArgs e)
        {

            CalcularValorForm listarFuncionariosForm = new CalcularValorForm();
            listarFuncionariosForm.TopLevel = false;
            listarFuncionariosForm.FormBorderStyle = FormBorderStyle.None;
            listarFuncionariosForm.Dock = DockStyle.Fill;

            Menus_TabControl.SelectedTab.Controls.Add(listarFuncionariosForm);

            listarFuncionariosForm.BringToFront();
            listarFuncionariosForm.Show();



        }
    }
}
