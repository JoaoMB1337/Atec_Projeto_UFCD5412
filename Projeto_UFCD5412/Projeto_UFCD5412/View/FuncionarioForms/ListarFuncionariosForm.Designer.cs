using System.Windows.Forms;

namespace Projeto_UFCD5412.View.FuncionarioForms
{
    partial class ListarFuncionariosForm
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
            this.ListaFuncionarios_DataGrid = new System.Windows.Forms.DataGridView();
            this.PesquisarFuncinarioPorNome_Textbox = new System.Windows.Forms.TextBox();
            this.TipoFuncionario_ComboBox = new System.Windows.Forms.ComboBox();
            this.Sair_Btn = new System.Windows.Forms.Button();
            this.RegistoCriminal_CheckBox = new System.Windows.Forms.CheckBox();
            this.EditarFuncionario_Btn = new System.Windows.Forms.Button();
            this.AddFuncionario_Btn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ListaFuncionarios_DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaFuncionarios_DataGrid
            // 
            this.ListaFuncionarios_DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListaFuncionarios_DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListaFuncionarios_DataGrid.ColumnHeadersHeight = 50;
            this.ListaFuncionarios_DataGrid.Location = new System.Drawing.Point(12, 62);
            this.ListaFuncionarios_DataGrid.Name = "ListaFuncionarios_DataGrid";
            this.ListaFuncionarios_DataGrid.ReadOnly = true;
            this.ListaFuncionarios_DataGrid.RowHeadersWidth = 51;
            this.ListaFuncionarios_DataGrid.Size = new System.Drawing.Size(776, 386);
            this.ListaFuncionarios_DataGrid.TabIndex = 0;
            // 
            // PesquisarFuncinarioPorNome_Textbox
            // 
            this.PesquisarFuncinarioPorNome_Textbox.Location = new System.Drawing.Point(12, 12);
            this.PesquisarFuncinarioPorNome_Textbox.Name = "PesquisarFuncinarioPorNome_Textbox";
            this.PesquisarFuncinarioPorNome_Textbox.Size = new System.Drawing.Size(187, 20);
            this.PesquisarFuncinarioPorNome_Textbox.TabIndex = 1;
            this.PesquisarFuncinarioPorNome_Textbox.TextChanged += new System.EventHandler(this.PesquisarFuncinarioPorNome_Textbox_TextChanged);
            // 
            // TipoFuncionario_ComboBox
            // 
            this.TipoFuncionario_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoFuncionario_ComboBox.FormattingEnabled = true;
            this.TipoFuncionario_ComboBox.Location = new System.Drawing.Point(638, 12);
            this.TipoFuncionario_ComboBox.Name = "TipoFuncionario_ComboBox";
            this.TipoFuncionario_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.TipoFuncionario_ComboBox.TabIndex = 2;
            this.TipoFuncionario_ComboBox.SelectedIndexChanged += new System.EventHandler(this.TipoFuncionario_ComboBox_SelectedIndexChanged);
            // 
            // Sair_Btn
            // 
            this.Sair_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Sair_Btn.Location = new System.Drawing.Point(659, 454);
            this.Sair_Btn.Name = "Sair_Btn";
            this.Sair_Btn.Size = new System.Drawing.Size(129, 30);
            this.Sair_Btn.TabIndex = 3;
            this.Sair_Btn.Text = "Voltar";
            this.Sair_Btn.UseVisualStyleBackColor = true;
            this.Sair_Btn.Click += new System.EventHandler(this.Sair_Btn_Click);
            // 
            // RegistoCriminal_CheckBox
            // 
            this.RegistoCriminal_CheckBox.AutoSize = true;
            this.RegistoCriminal_CheckBox.Location = new System.Drawing.Point(471, 16);
            this.RegistoCriminal_CheckBox.Name = "RegistoCriminal_CheckBox";
            this.RegistoCriminal_CheckBox.Size = new System.Drawing.Size(145, 17);
            this.RegistoCriminal_CheckBox.TabIndex = 5;
            this.RegistoCriminal_CheckBox.Text = "Registo Criminal Expirado";
            this.RegistoCriminal_CheckBox.UseVisualStyleBackColor = true;
            this.RegistoCriminal_CheckBox.CheckedChanged += new System.EventHandler(this.RegistoCriminal_CheckBox_CheckedChanged);
            // 
            // EditarFuncionario_Btn
            // 
            this.EditarFuncionario_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditarFuncionario_Btn.Location = new System.Drawing.Point(156, 454);
            this.EditarFuncionario_Btn.Name = "EditarFuncionario_Btn";
            this.EditarFuncionario_Btn.Size = new System.Drawing.Size(129, 30);
            this.EditarFuncionario_Btn.TabIndex = 6;
            this.EditarFuncionario_Btn.Text = "Editar ";
            this.EditarFuncionario_Btn.UseVisualStyleBackColor = true;
            this.EditarFuncionario_Btn.Click += new System.EventHandler(this.EditarFuncionario_Btn_Click);
            // 
            // AddFuncionario_Btn
            // 
            this.AddFuncionario_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddFuncionario_Btn.Location = new System.Drawing.Point(12, 454);
            this.AddFuncionario_Btn.Name = "AddFuncionario_Btn";
            this.AddFuncionario_Btn.Size = new System.Drawing.Size(129, 30);
            this.AddFuncionario_Btn.TabIndex = 7;
            this.AddFuncionario_Btn.Text = "Adicionar";
            this.AddFuncionario_Btn.UseVisualStyleBackColor = true;
            this.AddFuncionario_Btn.Click += new System.EventHandler(this.AddFuncionario_Btn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(327, 16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Contrato válido";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ListarFuncionariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.AddFuncionario_Btn);
            this.Controls.Add(this.EditarFuncionario_Btn);
            this.Controls.Add(this.RegistoCriminal_CheckBox);
            this.Controls.Add(this.Sair_Btn);
            this.Controls.Add(this.TipoFuncionario_ComboBox);
            this.Controls.Add(this.PesquisarFuncinarioPorNome_Textbox);
            this.Controls.Add(this.ListaFuncionarios_DataGrid);
            this.Name = "ListarFuncionariosForm";
            this.Text = "ListarFuncionariosForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListarFuncionariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaFuncionarios_DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListaFuncionarios_DataGrid;
        private System.Windows.Forms.TextBox PesquisarFuncinarioPorNome_Textbox;
        private System.Windows.Forms.ComboBox TipoFuncionario_ComboBox;
        private System.Windows.Forms.Button Sair_Btn;
        private System.Windows.Forms.CheckBox RegistoCriminal_CheckBox;
        private System.Windows.Forms.Button EditarFuncionario_Btn;
        private System.Windows.Forms.Button AddFuncionario_Btn;
        private CheckBox checkBox1;
    }
}