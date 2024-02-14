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
            this.editarfuncionario_textbox = new System.Windows.Forms.Button();
            this.addfuncionario_textbox = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListaFuncionarios_DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaFuncionarios_DataGrid
            // 
            this.ListaFuncionarios_DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListaFuncionarios_DataGrid.ColumnHeadersHeight = 50;
            this.ListaFuncionarios_DataGrid.Location = new System.Drawing.Point(16, 76);
            this.ListaFuncionarios_DataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.ListaFuncionarios_DataGrid.Name = "ListaFuncionarios_DataGrid";
            this.ListaFuncionarios_DataGrid.ReadOnly = true;
            this.ListaFuncionarios_DataGrid.RowHeadersWidth = 51;
            this.ListaFuncionarios_DataGrid.Size = new System.Drawing.Size(1035, 475);
            this.ListaFuncionarios_DataGrid.TabIndex = 0;
            this.ListaFuncionarios_DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // 
            // PesquisarFuncinarioPorNome_Textbox
            // 
            this.PesquisarFuncinarioPorNome_Textbox.Location = new System.Drawing.Point(16, 15);
            this.PesquisarFuncinarioPorNome_Textbox.Margin = new System.Windows.Forms.Padding(4);
            this.PesquisarFuncinarioPorNome_Textbox.Name = "PesquisarFuncinarioPorNome_Textbox";
            this.PesquisarFuncinarioPorNome_Textbox.Size = new System.Drawing.Size(248, 22);
            this.PesquisarFuncinarioPorNome_Textbox.TabIndex = 1;
            this.PesquisarFuncinarioPorNome_Textbox.TextChanged += new System.EventHandler(this.PesquisarFuncinarioPorNome_Textbox_TextChanged);
            // 
            // TipoFuncionario_ComboBox
            // 
            this.TipoFuncionario_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoFuncionario_ComboBox.FormattingEnabled = true;
            this.TipoFuncionario_ComboBox.Location = new System.Drawing.Point(851, 15);
            this.TipoFuncionario_ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.TipoFuncionario_ComboBox.Name = "TipoFuncionario_ComboBox";
            this.TipoFuncionario_ComboBox.Size = new System.Drawing.Size(160, 24);
            this.TipoFuncionario_ComboBox.TabIndex = 2;
            this.TipoFuncionario_ComboBox.SelectedIndexChanged += new System.EventHandler(this.TipoFuncionario_ComboBox_SelectedIndexChanged);
            // 
            // Sair_Btn
            // 
            this.Sair_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Sair_Btn.Location = new System.Drawing.Point(879, 559);
            this.Sair_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Sair_Btn.Name = "Sair_Btn";
            this.Sair_Btn.Size = new System.Drawing.Size(172, 37);
            this.Sair_Btn.TabIndex = 3;
            this.Sair_Btn.Text = "Voltar";
            this.Sair_Btn.UseVisualStyleBackColor = true;
            this.Sair_Btn.Click += new System.EventHandler(this.Sair_Btn_Click);
            // 
            // RegistoCriminal_CheckBox
            // 
            this.RegistoCriminal_CheckBox.AutoSize = true;
            this.RegistoCriminal_CheckBox.Location = new System.Drawing.Point(628, 20);
            this.RegistoCriminal_CheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.RegistoCriminal_CheckBox.Name = "RegistoCriminal_CheckBox";
            this.RegistoCriminal_CheckBox.Size = new System.Drawing.Size(184, 20);
            this.RegistoCriminal_CheckBox.TabIndex = 5;
            this.RegistoCriminal_CheckBox.Text = "Registo Criminal Expirado";
            this.RegistoCriminal_CheckBox.UseVisualStyleBackColor = true;
            this.RegistoCriminal_CheckBox.CheckedChanged += new System.EventHandler(this.RegistoCriminal_CheckBox_CheckedChanged);
            // 
            // editarfuncionario_textbox
            // 
            this.editarfuncionario_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editarfuncionario_textbox.Location = new System.Drawing.Point(208, 559);
            this.editarfuncionario_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.editarfuncionario_textbox.Name = "editarfuncionario_textbox";
            this.editarfuncionario_textbox.Size = new System.Drawing.Size(172, 37);
            this.editarfuncionario_textbox.TabIndex = 6;
            this.editarfuncionario_textbox.Text = "Editar ";
            this.editarfuncionario_textbox.UseVisualStyleBackColor = true;
            this.editarfuncionario_textbox.Click += new System.EventHandler(this.editarfuncionario_textbox_Click);
            // 
            // addfuncionario_textbox
            // 
            this.addfuncionario_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addfuncionario_textbox.Location = new System.Drawing.Point(16, 559);
            this.addfuncionario_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.addfuncionario_textbox.Name = "addfuncionario_textbox";
            this.addfuncionario_textbox.Size = new System.Drawing.Size(172, 37);
            this.addfuncionario_textbox.TabIndex = 7;
            this.addfuncionario_textbox.Text = "Adicionar";
            this.addfuncionario_textbox.UseVisualStyleBackColor = true;
            this.addfuncionario_textbox.Click += new System.EventHandler(this.addfuncionario_textbox_Click);
            // 
            // ListarFuncionariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 602);
            this.Controls.Add(this.addfuncionario_textbox);
            this.Controls.Add(this.editarfuncionario_textbox);
            this.Controls.Add(this.RegistoCriminal_CheckBox);
            this.Controls.Add(this.Sair_Btn);
            this.Controls.Add(this.TipoFuncionario_ComboBox);
            this.Controls.Add(this.PesquisarFuncinarioPorNome_Textbox);
            this.Controls.Add(this.ListaFuncionarios_DataGrid);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button editarfuncionario_textbox;
        private System.Windows.Forms.Button addfuncionario_textbox;
    }
}