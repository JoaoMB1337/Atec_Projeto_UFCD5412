namespace Projeto_UFCD5412.View.FinancasForms
{
    partial class CalcularValorForm
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
            this.NomeFunc_Label = new System.Windows.Forms.Label();
            this.nome_textbox = new System.Windows.Forms.TextBox();
            this.TipoFuncionario_ComboBox = new System.Windows.Forms.ComboBox();
            this.Filtrar_label = new System.Windows.Forms.Label();
            this.ListaFuncionariosValorAPagar_DataGrid = new System.Windows.Forms.DataGridView();
            this.Sair_Btn = new System.Windows.Forms.Button();
            this.atualizarCsv_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListaFuncionariosValorAPagar_DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // NomeFunc_Label
            // 
            this.NomeFunc_Label.AutoSize = true;
            this.NomeFunc_Label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NomeFunc_Label.Location = new System.Drawing.Point(49, 14);
            this.NomeFunc_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NomeFunc_Label.Name = "NomeFunc_Label";
            this.NomeFunc_Label.Size = new System.Drawing.Size(38, 13);
            this.NomeFunc_Label.TabIndex = 5;
            this.NomeFunc_Label.Text = "Nome:";
            // 
            // nome_textbox
            // 
            this.nome_textbox.Location = new System.Drawing.Point(95, 12);
            this.nome_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.nome_textbox.Name = "nome_textbox";
            this.nome_textbox.Size = new System.Drawing.Size(82, 20);
            this.nome_textbox.TabIndex = 12;
            // 
            // TipoFuncionario_ComboBox
            // 
            this.TipoFuncionario_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoFuncionario_ComboBox.FormattingEnabled = true;
            this.TipoFuncionario_ComboBox.Location = new System.Drawing.Point(625, 8);
            this.TipoFuncionario_ComboBox.Name = "TipoFuncionario_ComboBox";
            this.TipoFuncionario_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.TipoFuncionario_ComboBox.TabIndex = 13;
            this.TipoFuncionario_ComboBox.SelectedIndexChanged += new System.EventHandler(this.TipoFuncionario_ComboBox_SelectedIndexChanged);
            // 
            // Filtrar_label
            // 
            this.Filtrar_label.AutoSize = true;
            this.Filtrar_label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Filtrar_label.Location = new System.Drawing.Point(571, 12);
            this.Filtrar_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Filtrar_label.Name = "Filtrar_label";
            this.Filtrar_label.Size = new System.Drawing.Size(35, 13);
            this.Filtrar_label.TabIndex = 14;
            this.Filtrar_label.Text = "Filtrar:";
            // 
            // ListaFuncionariosValorAPagar_DataGrid
            // 
            this.ListaFuncionariosValorAPagar_DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListaFuncionariosValorAPagar_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaFuncionariosValorAPagar_DataGrid.Location = new System.Drawing.Point(12, 35);
            this.ListaFuncionariosValorAPagar_DataGrid.Name = "ListaFuncionariosValorAPagar_DataGrid";
            this.ListaFuncionariosValorAPagar_DataGrid.ReadOnly = true;
            this.ListaFuncionariosValorAPagar_DataGrid.RowHeadersWidth = 51;
            this.ListaFuncionariosValorAPagar_DataGrid.Size = new System.Drawing.Size(776, 386);
            this.ListaFuncionariosValorAPagar_DataGrid.TabIndex = 15;
            // 
            // Sair_Btn
            // 
            this.Sair_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Sair_Btn.Location = new System.Drawing.Point(625, 399);
            this.Sair_Btn.Name = "Sair_Btn";
            this.Sair_Btn.Size = new System.Drawing.Size(150, 50);
            this.Sair_Btn.TabIndex = 16;
            this.Sair_Btn.Text = "Sair";
            this.Sair_Btn.UseVisualStyleBackColor = true;
            // 
            // atualizarCsv_btn
            // 
            this.atualizarCsv_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.atualizarCsv_btn.Location = new System.Drawing.Point(469, 399);
            this.atualizarCsv_btn.Name = "atualizarCsv_btn";
            this.atualizarCsv_btn.Size = new System.Drawing.Size(150, 50);
            this.atualizarCsv_btn.TabIndex = 17;
            this.atualizarCsv_btn.Text = "Atualizar CSV";
            this.atualizarCsv_btn.UseVisualStyleBackColor = true;
            // 
            // CalcularValorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.atualizarCsv_btn);
            this.Controls.Add(this.Sair_Btn);
            this.Controls.Add(this.ListaFuncionariosValorAPagar_DataGrid);
            this.Controls.Add(this.Filtrar_label);
            this.Controls.Add(this.TipoFuncionario_ComboBox);
            this.Controls.Add(this.nome_textbox);
            this.Controls.Add(this.NomeFunc_Label);
            this.Name = "CalcularValorForm";
            this.Text = "CalcularValorForm";
            ((System.ComponentModel.ISupportInitialize)(this.ListaFuncionariosValorAPagar_DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NomeFunc_Label;
        private System.Windows.Forms.TextBox nome_textbox;
        private System.Windows.Forms.ComboBox TipoFuncionario_ComboBox;
        private System.Windows.Forms.Label Filtrar_label;
        private System.Windows.Forms.DataGridView ListaFuncionariosValorAPagar_DataGrid;
        private System.Windows.Forms.Button Sair_Btn;
        private System.Windows.Forms.Button atualizarCsv_btn;
    }
}