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
            this.atualizarCsv_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListaFuncionarios_DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaFuncionarios_DataGrid
            // 
            this.ListaFuncionarios_DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListaFuncionarios_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaFuncionarios_DataGrid.Location = new System.Drawing.Point(16, 76);
            this.ListaFuncionarios_DataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListaFuncionarios_DataGrid.Name = "ListaFuncionarios_DataGrid";
            this.ListaFuncionarios_DataGrid.ReadOnly = true;
            this.ListaFuncionarios_DataGrid.RowHeadersWidth = 51;
            this.ListaFuncionarios_DataGrid.Size = new System.Drawing.Size(1035, 475);
            this.ListaFuncionarios_DataGrid.TabIndex = 0;
            // 
            // PesquisarFuncinarioPorNome_Textbox
            // 
            this.PesquisarFuncinarioPorNome_Textbox.Location = new System.Drawing.Point(16, 15);
            this.PesquisarFuncinarioPorNome_Textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PesquisarFuncinarioPorNome_Textbox.Name = "PesquisarFuncinarioPorNome_Textbox";
            this.PesquisarFuncinarioPorNome_Textbox.Size = new System.Drawing.Size(248, 22);
            this.PesquisarFuncinarioPorNome_Textbox.TabIndex = 1;
            this.PesquisarFuncinarioPorNome_Textbox.TextChanged += new System.EventHandler(this.PesquisarFuncinarioPorNome_Textbox_TextChanged);
            // 
            // TipoFuncionario_ComboBox
            // 
            this.TipoFuncionario_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoFuncionario_ComboBox.FormattingEnabled = true;
            this.TipoFuncionario_ComboBox.Location = new System.Drawing.Point(816, 16);
            this.TipoFuncionario_ComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TipoFuncionario_ComboBox.Name = "TipoFuncionario_ComboBox";
            this.TipoFuncionario_ComboBox.Size = new System.Drawing.Size(160, 24);
            this.TipoFuncionario_ComboBox.TabIndex = 2;
            this.TipoFuncionario_ComboBox.SelectedIndexChanged += new System.EventHandler(this.TipoFuncionario_ComboBox_SelectedIndexChanged);
            // 
            // Sair_Btn
            // 
            this.Sair_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Sair_Btn.Location = new System.Drawing.Point(784, 526);
            this.Sair_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Sair_Btn.Name = "Sair_Btn";
            this.Sair_Btn.Size = new System.Drawing.Size(200, 62);
            this.Sair_Btn.TabIndex = 3;
            this.Sair_Btn.Text = "Sair";
            this.Sair_Btn.UseVisualStyleBackColor = true;
            this.Sair_Btn.Click += new System.EventHandler(this.Sair_Btn_Click);
            // 
            // atualizarCsv_btn
            // 
            this.atualizarCsv_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.atualizarCsv_btn.Location = new System.Drawing.Point(576, 526);
            this.atualizarCsv_btn.Margin = new System.Windows.Forms.Padding(4);
            this.atualizarCsv_btn.Name = "atualizarCsv_btn";
            this.atualizarCsv_btn.Size = new System.Drawing.Size(200, 62);
            this.atualizarCsv_btn.TabIndex = 4;
            this.atualizarCsv_btn.Text = "Atualizar CSV";
            this.atualizarCsv_btn.UseVisualStyleBackColor = true;
            this.atualizarCsv_btn.Click += new System.EventHandler(this.atualizarCsv_btn_Click);
            // 
            // ListarFuncionariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 602);
            this.Controls.Add(this.atualizarCsv_btn);
            this.Controls.Add(this.Sair_Btn);
            this.Controls.Add(this.TipoFuncionario_ComboBox);
            this.Controls.Add(this.PesquisarFuncinarioPorNome_Textbox);
            this.Controls.Add(this.ListaFuncionarios_DataGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button atualizarCsv_btn;
    }
}