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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NomeFunc_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sair_Btn = new System.Windows.Forms.Button();
            this.PesquisarFuncinarioPorNome_Textbox = new System.Windows.Forms.TextBox();
            this.TipoFuncionario_ComboBox = new System.Windows.Forms.ComboBox();
            this.CalcularFormadorBtnButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NomeFunc_label
            // 
            this.NomeFunc_label.AutoSize = true;
            this.NomeFunc_label.Location = new System.Drawing.Point(10, 5);
            this.NomeFunc_label.Name = "NomeFunc_label";
            this.NomeFunc_label.Size = new System.Drawing.Size(38, 13);
            this.NomeFunc_label.TabIndex = 0;
            this.NomeFunc_label.Text = "Nome:";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.PeachPuff;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(3, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(792, 358);
            this.dataGridView1.TabIndex = 1;
            // 
            // Sair_Btn
            // 
            this.Sair_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Sair_Btn.Location = new System.Drawing.Point(659, 408);
            this.Sair_Btn.Name = "Sair_Btn";
            this.Sair_Btn.Size = new System.Drawing.Size(129, 30);
            this.Sair_Btn.TabIndex = 4;
            this.Sair_Btn.Text = "Voltar";
            this.Sair_Btn.UseVisualStyleBackColor = true;
            // 
            // PesquisarFuncinarioPorNome_Textbox
            // 
            this.PesquisarFuncinarioPorNome_Textbox.Location = new System.Drawing.Point(54, 2);
            this.PesquisarFuncinarioPorNome_Textbox.Name = "PesquisarFuncinarioPorNome_Textbox";
            this.PesquisarFuncinarioPorNome_Textbox.Size = new System.Drawing.Size(187, 20);
            this.PesquisarFuncinarioPorNome_Textbox.TabIndex = 5;
            this.PesquisarFuncinarioPorNome_Textbox.TextChanged += new System.EventHandler(this.PesquisarFuncinarioPorNome_Textbox_TextChanged);
            // 
            // TipoFuncionario_ComboBox
            // 
            this.TipoFuncionario_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoFuncionario_ComboBox.FormattingEnabled = true;
            this.TipoFuncionario_ComboBox.Location = new System.Drawing.Point(647, 12);
            this.TipoFuncionario_ComboBox.Name = "TipoFuncionario_ComboBox";
            this.TipoFuncionario_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.TipoFuncionario_ComboBox.TabIndex = 6;
            this.TipoFuncionario_ComboBox.SelectedIndexChanged += new System.EventHandler(this.TipoFuncionario_ComboBox_SelectedIndexChanged);
            // 
            // CalcularFormadorBtnButton
            // 
            this.CalcularFormadorBtnButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.CalcularFormadorBtnButton.IconColor = System.Drawing.Color.Black;
            this.CalcularFormadorBtnButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CalcularFormadorBtnButton.Location = new System.Drawing.Point(472, 10);
            this.CalcularFormadorBtnButton.Name = "CalcularFormadorBtnButton";
            this.CalcularFormadorBtnButton.Size = new System.Drawing.Size(75, 23);
            this.CalcularFormadorBtnButton.TabIndex = 7;
            this.CalcularFormadorBtnButton.Text = "CalcularValorBtn_Click";
            this.CalcularFormadorBtnButton.UseVisualStyleBackColor = true;
            this.CalcularFormadorBtnButton.Click += new System.EventHandler(this.CalcularFormadorBtnButton_Click);
            // 
            // CalcularValorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CalcularFormadorBtnButton);
            this.Controls.Add(this.TipoFuncionario_ComboBox);
            this.Controls.Add(this.PesquisarFuncinarioPorNome_Textbox);
            this.Controls.Add(this.Sair_Btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NomeFunc_label);
            this.Name = "CalcularValorForm";
            this.Text = "CalcularValorForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NomeFunc_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Sair_Btn;
        private System.Windows.Forms.TextBox PesquisarFuncinarioPorNome_Textbox;
        private System.Windows.Forms.ComboBox TipoFuncionario_ComboBox;
        private FontAwesome.Sharp.IconButton CalcularFormadorBtnButton;
    }
}