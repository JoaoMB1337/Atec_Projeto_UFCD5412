using System.Windows.Forms;
using System.Drawing;
using System;


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
            this.Definicoes_Btn = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.DashboardFormadores_Btn = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.Home_Btn = new System.Windows.Forms.PictureBox();
            this.containerDias = new System.Windows.Forms.TableLayoutPanel(); // Alterado para TableLayoutPanel
            this.panelTitleBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Home_Btn)).BeginInit();
            this.SuspendLayout();
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(293, 98);
            this.panelShadow.Margin = new System.Windows.Forms.Padding(4);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1406, 11);
            this.panelShadow.TabIndex = 7;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelTitleBar.Controls.Add(this.timer_label);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(293, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1406, 98);
            this.panelTitleBar.TabIndex = 6;
            // 
            // timer_label
            // 
            this.timer_label.AutoSize = true;
            this.timer_label.Dock = System.Windows.Forms.DockStyle.Right;
            this.timer_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_label.ForeColor = System.Drawing.Color.White;
            this.timer_label.Location = new System.Drawing.Point(1406, 0);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(0, 17);
            this.timer_label.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelMenu.Controls.Add(this.Definicoes_Btn);
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Controls.Add(this.DashboardFormadores_Btn);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(293, 840);
            this.panelMenu.TabIndex = 5;
            // 
            // Definicoes_Btn
            // 
            this.Definicoes_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Definicoes_Btn.FlatAppearance.BorderSize = 0;
            this.Definicoes_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Definicoes_Btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.Definicoes_Btn.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.Definicoes_Btn.IconColor = System.Drawing.Color.Gainsboro;
            this.Definicoes_Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Definicoes_Btn.IconSize = 32;
            this.Definicoes_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Definicoes_Btn.Location = new System.Drawing.Point(0, 232);
            this.Definicoes_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Definicoes_Btn.Name = "Definicoes_Btn";
            this.Definicoes_Btn.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.Definicoes_Btn.Size = new System.Drawing.Size(293, 60);
            this.Definicoes_Btn.TabIndex = 7;
            this.Definicoes_Btn.Text = "Definições";
            this.Definicoes_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Definicoes_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Definicoes_Btn.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(4, 784);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(283, 41);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Sair";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // DashboardFormadores_Btn
            // 
            this.DashboardFormadores_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashboardFormadores_Btn.FlatAppearance.BorderSize = 0;
            this.DashboardFormadores_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardFormadores_Btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.DashboardFormadores_Btn.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.DashboardFormadores_Btn.IconColor = System.Drawing.Color.Gainsboro;
            this.DashboardFormadores_Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DashboardFormadores_Btn.IconSize = 32;
            this.DashboardFormadores_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardFormadores_Btn.Location = new System.Drawing.Point(0, 172);
            this.DashboardFormadores_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DashboardFormadores_Btn.Name = "DashboardFormadores_Btn";
            this.DashboardFormadores_Btn.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.DashboardFormadores_Btn.Size = new System.Drawing.Size(293, 60);
            this.DashboardFormadores_Btn.TabIndex = 2;
            this.DashboardFormadores_Btn.Text = "Formadores";
            this.DashboardFormadores_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardFormadores_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DashboardFormadores_Btn.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.Home_Btn);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(293, 172);
            this.panelLogo.TabIndex = 0;
            // 
            // Home_Btn
            // 
            this.Home_Btn.Image = global::Projeto_UFCD5412.Properties.Resources.icon_ADOSMELHORES_removebg_preview;
            this.Home_Btn.Location = new System.Drawing.Point(69, 15);
            this.Home_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Home_Btn.Name = "Home_Btn";
            this.Home_Btn.Size = new System.Drawing.Size(151, 138);
            this.Home_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Home_Btn.TabIndex = 0;
            this.Home_Btn.TabStop = false;
            // 



            // containerDias
            // 
            // Definindo o TableLayoutPanel containerDias
            this.containerDias.ColumnCount = 7;
            this.containerDias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.containerDias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.containerDias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.containerDias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.containerDias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.containerDias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.containerDias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));

            // Definindo o tamanho e a localização do containerDias
            this.containerDias.Size = new Size(this.ClientSize.Width - this.panelMenu.Width, this.ClientSize.Height - this.panelTitleBar.Height);
            this.containerDias.Location = new Point(this.panelMenu.Width, this.panelTitleBar.Height);
            // Ajustando o Dock do containerDias para preencher o restante do espaço disponível
            this.containerDias.Dock = DockStyle.Fill;


            // 
            // CoordenacaoMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1699, 840);
            this.Controls.Add(this.containerDias);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CoordenacaoMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoordenacaoMainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Home_Btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label timer_label;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton Definicoes_Btn;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton DashboardFormadores_Btn;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox Home_Btn;
        private System.Windows.Forms.TableLayoutPanel containerDias; // Alterado para TableLayoutPanel
    }
}
