namespace Projeto_UFCD5412.View.CoordenacaoForms
{
    partial class CoordenacaoMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.timer_label = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Sair_btn = new System.Windows.Forms.Button();
            this.DashboardCalendario_Btn = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.Home_Btn = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTitleBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Home_Btn)).BeginInit();
            this.SuspendLayout();
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.Gray;
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 140);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(631, 9);
            this.panelShadow.TabIndex = 7;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.panelTitleBar.Controls.Add(this.timer_label);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(631, 140);
            this.panelTitleBar.TabIndex = 6;
            // 
            // timer_label
            // 
            this.timer_label.AutoSize = true;
            this.timer_label.Dock = System.Windows.Forms.DockStyle.Right;
            this.timer_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_label.ForeColor = System.Drawing.Color.White;
            this.timer_label.Location = new System.Drawing.Point(631, 0);
            this.timer_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(0, 17);
            this.timer_label.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.Sair_btn);
            this.panelMenu.Controls.Add(this.DashboardCalendario_Btn);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 474);
            this.panelMenu.TabIndex = 5;
            // 
            // Sair_btn
            // 
            this.Sair_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Sair_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.Sair_btn.FlatAppearance.BorderSize = 0;
            this.Sair_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sair_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sair_btn.ForeColor = System.Drawing.Color.White;
            this.Sair_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Sair_btn.Location = new System.Drawing.Point(9, 429);
            this.Sair_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Sair_btn.Name = "Sair_btn";
            this.Sair_btn.Size = new System.Drawing.Size(193, 32);
            this.Sair_btn.TabIndex = 9;
            this.Sair_btn.Text = "Sair";
            this.Sair_btn.UseVisualStyleBackColor = false;
            this.Sair_btn.Click += new System.EventHandler(this.Sair_btn_Click_1);
            // 
            // DashboardCalendario_Btn
            // 
            this.DashboardCalendario_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashboardCalendario_Btn.FlatAppearance.BorderSize = 0;
            this.DashboardCalendario_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardCalendario_Btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.DashboardCalendario_Btn.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.DashboardCalendario_Btn.IconColor = System.Drawing.Color.Gainsboro;
            this.DashboardCalendario_Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DashboardCalendario_Btn.IconSize = 32;
            this.DashboardCalendario_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardCalendario_Btn.Location = new System.Drawing.Point(0, 140);
            this.DashboardCalendario_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.DashboardCalendario_Btn.Name = "DashboardCalendario_Btn";
            this.DashboardCalendario_Btn.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.DashboardCalendario_Btn.Size = new System.Drawing.Size(218, 49);
            this.DashboardCalendario_Btn.TabIndex = 7;
            this.DashboardCalendario_Btn.Text = "Calendário";
            this.DashboardCalendario_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardCalendario_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DashboardCalendario_Btn.UseVisualStyleBackColor = true;
            this.DashboardCalendario_Btn.Click += new System.EventHandler(this.DashboardCalendario_Btn_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.panelLogo.Controls.Add(this.Home_Btn);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(218, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // Home_Btn
            // 
            this.Home_Btn.Image = global::Projeto_UFCD5412.Properties.Resources.LogoEmpresa_removebg_preview;
            this.Home_Btn.Location = new System.Drawing.Point(52, 12);
            this.Home_Btn.Name = "Home_Btn";
            this.Home_Btn.Size = new System.Drawing.Size(113, 112);
            this.Home_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Home_Btn.TabIndex = 0;
            this.Home_Btn.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(220, 140);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(632, 333);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // CoordenacaoMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 474);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CoordenacaoMainForm";
            this.Text = "CoordenacaoMainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Home_Btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label timer_label;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton DashboardCalendario_Btn;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox Home_Btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Sair_btn;
    }
}