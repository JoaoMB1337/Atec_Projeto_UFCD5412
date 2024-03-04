namespace Projeto_UFCD5412
{
    partial class MainWindow
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Exit_Btn = new FontAwesome.Sharp.IconPictureBox();
            this.Defincoes_Btn = new FontAwesome.Sharp.IconButton();
            this.DashboardFinancas_Btn = new FontAwesome.Sharp.IconButton();
            this.DashboardFuncionario_Btn = new FontAwesome.Sharp.IconButton();
            this.Dashboard_Btn = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.Home_Btn = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.timer_label = new System.Windows.Forms.Label();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.Menus_TabControl = new System.Windows.Forms.TabControl();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.BemVindo_Label = new System.Windows.Forms.Label();
            this.tabDashboardFuncionario = new System.Windows.Forms.TabPage();
            this.tabDashboardFormadoes = new System.Windows.Forms.TabPage();
            this.tabDashboardFinancas = new System.Windows.Forms.TabPage();
            this.tabDashboardDefinicoes = new System.Windows.Forms.TabPage();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Btn)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Home_Btn)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.Menus_TabControl.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panelMenu.Controls.Add(this.Exit_Btn);
            this.panelMenu.Controls.Add(this.Defincoes_Btn);
            this.panelMenu.Controls.Add(this.DashboardFinancas_Btn);
            this.panelMenu.Controls.Add(this.DashboardFuncionario_Btn);
            this.panelMenu.Controls.Add(this.Dashboard_Btn);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(293, 725);
            this.panelMenu.TabIndex = 1;
            // 
            // Exit_Btn
            // 
            this.Exit_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Exit_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.Exit_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit_Btn.ForeColor = System.Drawing.SystemColors.Window;
            this.Exit_Btn.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.Exit_Btn.IconColor = System.Drawing.SystemColors.Window;
            this.Exit_Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Exit_Btn.IconSize = 75;
            this.Exit_Btn.Location = new System.Drawing.Point(12, 638);
            this.Exit_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit_Btn.Name = "Exit_Btn";
            this.Exit_Btn.Size = new System.Drawing.Size(276, 75);
            this.Exit_Btn.TabIndex = 9;
            this.Exit_Btn.TabStop = false;
            this.Exit_Btn.Text = "Sair";
            this.Exit_Btn.Click += new System.EventHandler(this.Exit_Btn_Click);
            // 
            // Defincoes_Btn
            // 
            this.Defincoes_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Defincoes_Btn.FlatAppearance.BorderSize = 0;
            this.Defincoes_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Defincoes_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Defincoes_Btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.Defincoes_Btn.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.Defincoes_Btn.IconColor = System.Drawing.Color.Gainsboro;
            this.Defincoes_Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Defincoes_Btn.IconSize = 32;
            this.Defincoes_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Defincoes_Btn.Location = new System.Drawing.Point(0, 358);
            this.Defincoes_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Defincoes_Btn.Name = "Defincoes_Btn";
            this.Defincoes_Btn.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.Defincoes_Btn.Size = new System.Drawing.Size(293, 62);
            this.Defincoes_Btn.TabIndex = 7;
            this.Defincoes_Btn.Text = "Definições";
            this.Defincoes_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Defincoes_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Defincoes_Btn.UseVisualStyleBackColor = true;
            this.Defincoes_Btn.Click += new System.EventHandler(this.Defincoes_Btn_Click);
            // 
            // DashboardFinancas_Btn
            // 
            this.DashboardFinancas_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashboardFinancas_Btn.FlatAppearance.BorderSize = 0;
            this.DashboardFinancas_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardFinancas_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardFinancas_Btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.DashboardFinancas_Btn.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.DashboardFinancas_Btn.IconColor = System.Drawing.Color.Gainsboro;
            this.DashboardFinancas_Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DashboardFinancas_Btn.IconSize = 32;
            this.DashboardFinancas_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardFinancas_Btn.Location = new System.Drawing.Point(0, 296);
            this.DashboardFinancas_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DashboardFinancas_Btn.Name = "DashboardFinancas_Btn";
            this.DashboardFinancas_Btn.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.DashboardFinancas_Btn.Size = new System.Drawing.Size(293, 62);
            this.DashboardFinancas_Btn.TabIndex = 6;
            this.DashboardFinancas_Btn.Text = "Finanças";
            this.DashboardFinancas_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardFinancas_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DashboardFinancas_Btn.UseVisualStyleBackColor = true;
            this.DashboardFinancas_Btn.Click += new System.EventHandler(this.DashboardFinancas_Btn_Click);
            // 
            // DashboardFuncionario_Btn
            // 
            this.DashboardFuncionario_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashboardFuncionario_Btn.FlatAppearance.BorderSize = 0;
            this.DashboardFuncionario_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardFuncionario_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardFuncionario_Btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.DashboardFuncionario_Btn.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.DashboardFuncionario_Btn.IconColor = System.Drawing.Color.Gainsboro;
            this.DashboardFuncionario_Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DashboardFuncionario_Btn.IconSize = 32;
            this.DashboardFuncionario_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardFuncionario_Btn.Location = new System.Drawing.Point(0, 234);
            this.DashboardFuncionario_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DashboardFuncionario_Btn.Name = "DashboardFuncionario_Btn";
            this.DashboardFuncionario_Btn.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.DashboardFuncionario_Btn.Size = new System.Drawing.Size(293, 62);
            this.DashboardFuncionario_Btn.TabIndex = 1;
            this.DashboardFuncionario_Btn.Text = "Funcionários";
            this.DashboardFuncionario_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardFuncionario_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DashboardFuncionario_Btn.UseVisualStyleBackColor = true;
            this.DashboardFuncionario_Btn.Click += new System.EventHandler(this.DashboardFuncionario_Btn_Click);
            // 
            // Dashboard_Btn
            // 
            this.Dashboard_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dashboard_Btn.FlatAppearance.BorderSize = 0;
            this.Dashboard_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard_Btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.Dashboard_Btn.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.Dashboard_Btn.IconColor = System.Drawing.Color.Gainsboro;
            this.Dashboard_Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Dashboard_Btn.IconSize = 32;
            this.Dashboard_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard_Btn.Location = new System.Drawing.Point(0, 172);
            this.Dashboard_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dashboard_Btn.Name = "Dashboard_Btn";
            this.Dashboard_Btn.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.Dashboard_Btn.Size = new System.Drawing.Size(293, 62);
            this.Dashboard_Btn.TabIndex = 0;
            this.Dashboard_Btn.Text = "Dashboard";
            this.Dashboard_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Dashboard_Btn.UseVisualStyleBackColor = true;
            this.Dashboard_Btn.Click += new System.EventHandler(this.Dashboard_Btn_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.panelLogo.Controls.Add(this.Home_Btn);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(293, 172);
            this.panelLogo.TabIndex = 0;
            // 
            // Home_Btn
            // 
            this.Home_Btn.Image = global::Projeto_UFCD5412.Properties.Resources.LogoEmpresa_removebg_preview;
            this.Home_Btn.Location = new System.Drawing.Point(69, 15);
            this.Home_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Home_Btn.Name = "Home_Btn";
            this.Home_Btn.Size = new System.Drawing.Size(151, 138);
            this.Home_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Home_Btn.TabIndex = 0;
            this.Home_Btn.TabStop = false;
            this.Home_Btn.Click += new System.EventHandler(this.Home_Btn_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.panelTitleBar.Controls.Add(this.timer_label);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(293, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(984, 98);
            this.panelTitleBar.TabIndex = 2;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // timer_label
            // 
            this.timer_label.AutoSize = true;
            this.timer_label.Dock = System.Windows.Forms.DockStyle.Right;
            this.timer_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_label.ForeColor = System.Drawing.Color.White;
            this.timer_label.Location = new System.Drawing.Point(984, 0);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(0, 20);
            this.timer_label.TabIndex = 0;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(293, 98);
            this.panelShadow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(984, 74);
            this.panelShadow.TabIndex = 3;
            // 
            // Menus_TabControl
            // 
            this.Menus_TabControl.Controls.Add(this.tabDashboard);
            this.Menus_TabControl.Controls.Add(this.tabDashboardFuncionario);
            this.Menus_TabControl.Controls.Add(this.tabDashboardFormadoes);
            this.Menus_TabControl.Controls.Add(this.tabDashboardFinancas);
            this.Menus_TabControl.Controls.Add(this.tabDashboardDefinicoes);
            this.Menus_TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Menus_TabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.Menus_TabControl.Location = new System.Drawing.Point(293, 172);
            this.Menus_TabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Menus_TabControl.Name = "Menus_TabControl";
            this.Menus_TabControl.SelectedIndex = 0;
            this.Menus_TabControl.Size = new System.Drawing.Size(984, 553);
            this.Menus_TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Menus_TabControl.TabIndex = 4;
            // 
            // tabDashboard
            // 
            this.tabDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.tabDashboard.Controls.Add(this.BemVindo_Label);
            this.tabDashboard.Location = new System.Drawing.Point(4, 25);
            this.tabDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDashboard.Size = new System.Drawing.Size(976, 524);
            this.tabDashboard.TabIndex = 0;
            this.tabDashboard.Text = "tabPage1";
            // 
            // BemVindo_Label
            // 
            this.BemVindo_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BemVindo_Label.AutoSize = true;
            this.BemVindo_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BemVindo_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BemVindo_Label.Location = new System.Drawing.Point(105, 214);
            this.BemVindo_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BemVindo_Label.Name = "BemVindo_Label";
            this.BemVindo_Label.Size = new System.Drawing.Size(721, 54);
            this.BemVindo_Label.TabIndex = 0;
            this.BemVindo_Label.Text = "Bem Vindo/a à Nossa Academia";
            // 
            // tabDashboardFuncionario
            // 
            this.tabDashboardFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDashboardFuncionario.Location = new System.Drawing.Point(4, 25);
            this.tabDashboardFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDashboardFuncionario.Name = "tabDashboardFuncionario";
            this.tabDashboardFuncionario.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDashboardFuncionario.Size = new System.Drawing.Size(976, 524);
            this.tabDashboardFuncionario.TabIndex = 1;
            this.tabDashboardFuncionario.Text = "tabPage2";
            this.tabDashboardFuncionario.UseVisualStyleBackColor = true;
            // 
            // tabDashboardFormadoes
            // 
            this.tabDashboardFormadoes.Location = new System.Drawing.Point(4, 25);
            this.tabDashboardFormadoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDashboardFormadoes.Name = "tabDashboardFormadoes";
            this.tabDashboardFormadoes.Size = new System.Drawing.Size(976, 524);
            this.tabDashboardFormadoes.TabIndex = 2;
            this.tabDashboardFormadoes.Text = "tabPage3";
            this.tabDashboardFormadoes.UseVisualStyleBackColor = true;
            // 
            // tabDashboardFinancas
            // 
            this.tabDashboardFinancas.Location = new System.Drawing.Point(4, 25);
            this.tabDashboardFinancas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDashboardFinancas.Name = "tabDashboardFinancas";
            this.tabDashboardFinancas.Size = new System.Drawing.Size(976, 524);
            this.tabDashboardFinancas.TabIndex = 3;
            this.tabDashboardFinancas.Text = "tabPage4";
            this.tabDashboardFinancas.UseVisualStyleBackColor = true;
            // 
            // tabDashboardDefinicoes
            // 
            this.tabDashboardDefinicoes.Location = new System.Drawing.Point(4, 25);
            this.tabDashboardDefinicoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDashboardDefinicoes.Name = "tabDashboardDefinicoes";
            this.tabDashboardDefinicoes.Size = new System.Drawing.Size(976, 524);
            this.tabDashboardDefinicoes.TabIndex = 4;
            this.tabDashboardDefinicoes.Text = "tabPage5";
            this.tabDashboardDefinicoes.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 725);
            this.Controls.Add(this.Menus_TabControl);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Academia de Formação";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Btn)).EndInit();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Home_Btn)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.Menus_TabControl.ResumeLayout(false);
            this.tabDashboard.ResumeLayout(false);
            this.tabDashboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton Dashboard_Btn;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton DashboardFuncionario_Btn;
        private System.Windows.Forms.PictureBox Home_Btn;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelShadow;
        private FontAwesome.Sharp.IconButton DashboardFinancas_Btn;
        private FontAwesome.Sharp.IconButton Defincoes_Btn;
        private System.Windows.Forms.TabControl Menus_TabControl;
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.TabPage tabDashboardFuncionario;
        private System.Windows.Forms.TabPage tabDashboardFormadoes;
        private System.Windows.Forms.TabPage tabDashboardFinancas;
        private System.Windows.Forms.TabPage tabDashboardDefinicoes;
        private System.Windows.Forms.Label timer_label;
        private System.Windows.Forms.Label BemVindo_Label;
        private FontAwesome.Sharp.IconPictureBox Exit_Btn;
    }
}

