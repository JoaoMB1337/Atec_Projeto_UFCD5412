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
            this.RegistoCriminal_CheckBox = new System.Windows.Forms.CheckBox();
            this.Editarfuncionario_Btn = new System.Windows.Forms.Button();
            this.Addfuncionario_Btn = new System.Windows.Forms.Button();
            this.ContratoValido_CheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ListaFuncionarios_DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaFuncionarios_DataGrid
            // 
            this.ListaFuncionarios_DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListaFuncionarios_DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListaFuncionarios_DataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.ListaFuncionarios_DataGrid.ColumnHeadersHeight = 50;
            this.ListaFuncionarios_DataGrid.Location = new System.Drawing.Point(16, 76);
            this.ListaFuncionarios_DataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.ListaFuncionarios_DataGrid.Name = "ListaFuncionarios_DataGrid";
            this.ListaFuncionarios_DataGrid.ReadOnly = true;
            this.ListaFuncionarios_DataGrid.RowHeadersWidth = 51;
            this.ListaFuncionarios_DataGrid.Size = new System.Drawing.Size(1035, 475);
            this.ListaFuncionarios_DataGrid.TabIndex = 0;
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
            this.TipoFuncionario_ComboBox.Location = new System.Drawing.Point(879, 16);
            this.TipoFuncionario_ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.TipoFuncionario_ComboBox.Name = "TipoFuncionario_ComboBox";
            this.TipoFuncionario_ComboBox.Size = new System.Drawing.Size(160, 24);
            this.TipoFuncionario_ComboBox.TabIndex = 2;
            this.TipoFuncionario_ComboBox.SelectedIndexChanged += new System.EventHandler(this.TipoFuncionario_ComboBox_SelectedIndexChanged);
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
            // Editarfuncionario_Btn
            // 
            this.Editarfuncionario_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Editarfuncionario_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.Editarfuncionario_Btn.ForeColor = System.Drawing.Color.White;
            this.Editarfuncionario_Btn.Location = new System.Drawing.Point(208, 559);
            this.Editarfuncionario_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Editarfuncionario_Btn.Name = "Editarfuncionario_Btn";
            this.Editarfuncionario_Btn.Size = new System.Drawing.Size(172, 37);
            this.Editarfuncionario_Btn.TabIndex = 6;
            this.Editarfuncionario_Btn.Text = "Editar ";
            this.Editarfuncionario_Btn.UseVisualStyleBackColor = false;
            this.Editarfuncionario_Btn.Click += new System.EventHandler(this.Editarfuncionario_Btn_Click);
            // 
            // Addfuncionario_Btn
            // 
            this.Addfuncionario_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Addfuncionario_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.Addfuncionario_Btn.ForeColor = System.Drawing.Color.White;
            this.Addfuncionario_Btn.Location = new System.Drawing.Point(16, 559);
            this.Addfuncionario_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Addfuncionario_Btn.Name = "Addfuncionario_Btn";
            this.Addfuncionario_Btn.Size = new System.Drawing.Size(172, 37);
            this.Addfuncionario_Btn.TabIndex = 7;
            this.Addfuncionario_Btn.Text = "Adicionar";
            this.Addfuncionario_Btn.UseVisualStyleBackColor = false;
            this.Addfuncionario_Btn.Click += new System.EventHandler(this.Addfuncionario_Btn_Click);
            // 
            // ContratoValido_CheckBox
            // 
            this.ContratoValido_CheckBox.AutoSize = true;
            this.ContratoValido_CheckBox.Location = new System.Drawing.Point(436, 20);
            this.ContratoValido_CheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.ContratoValido_CheckBox.Name = "ContratoValido_CheckBox";
            this.ContratoValido_CheckBox.Size = new System.Drawing.Size(119, 20);
            this.ContratoValido_CheckBox.TabIndex = 8;
            this.ContratoValido_CheckBox.Text = "Contrato válido";
            this.ContratoValido_CheckBox.UseVisualStyleBackColor = true;
            this.ContratoValido_CheckBox.CheckedChanged += new System.EventHandler(this.ContratoValido_CheckBox_CheckedChanged);
            // 
            // ListarFuncionariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1067, 602);
            this.Controls.Add(this.ContratoValido_CheckBox);
            this.Controls.Add(this.Addfuncionario_Btn);
            this.Controls.Add(this.Editarfuncionario_Btn);
            this.Controls.Add(this.RegistoCriminal_CheckBox);
            this.Controls.Add(this.TipoFuncionario_ComboBox);
            this.Controls.Add(this.PesquisarFuncinarioPorNome_Textbox);
            this.Controls.Add(this.ListaFuncionarios_DataGrid);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListarFuncionariosForm";
            this.Text = "Listar Funcionarios";
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
        private System.Windows.Forms.CheckBox RegistoCriminal_CheckBox;
        private System.Windows.Forms.Button Editarfuncionario_Btn;
        private System.Windows.Forms.Button Addfuncionario_Btn;
        private CheckBox ContratoValido_CheckBox;
    }
}