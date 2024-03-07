using Projeto_UFCD5412.View.Forms;

namespace Projeto_UFCD5412.View.FuncionarioForms
{
    partial class EditarFuncionarioForm
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

        private void InitializeComponent()
        {
            this.NomeFunc_Label = new System.Windows.Forms.Label();
            this.MoradaFunc_Label = new System.Windows.Forms.Label();
            this.ContactoFunc_Label = new System.Windows.Forms.Label();
            this.TipoFunc_Label = new System.Windows.Forms.Label();
            this.DataContrato_Label = new System.Windows.Forms.Label();
            this.FimContrato_Label = new System.Windows.Forms.Label();
            this.DataRegistoCriminal_Label = new System.Windows.Forms.Label();
            this.nome_textbox = new System.Windows.Forms.TextBox();
            this.morada_textbox = new System.Windows.Forms.TextBox();
            this.contacto_textbox = new System.Windows.Forms.TextBox();
            this.TipoFuncionario_ComboBox = new System.Windows.Forms.ComboBox();
            this.DataContrato_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DataFimContrato_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DataRegistoCriminal_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DataFimRegistoCriminal_Label = new System.Windows.Forms.Label();
            this.DataFimRegistoCriminal_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DataNascimento_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.salario_textbox = new System.Windows.Forms.TextBox();
            this.salario_label = new System.Windows.Forms.Label();
            this.EditFuncionario_Btn = new FontAwesome.Sharp.IconButton();
            this.SalarioHoraTextBox = new System.Windows.Forms.TextBox();
            this.SalarioHoralabel = new System.Windows.Forms.Label();
            this.RemoverFuncionario_Btn = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // NomeFunc_Label
            // 
            this.NomeFunc_Label.AutoSize = true;
            this.NomeFunc_Label.BackColor = System.Drawing.Color.Transparent;
            this.NomeFunc_Label.ForeColor = System.Drawing.Color.White;
            this.NomeFunc_Label.Location = new System.Drawing.Point(381, 150);
            this.NomeFunc_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NomeFunc_Label.Name = "NomeFunc_Label";
            this.NomeFunc_Label.Size = new System.Drawing.Size(67, 24);
            this.NomeFunc_Label.TabIndex = 4;
            this.NomeFunc_Label.Text = "Nome:";
            // 
            // MoradaFunc_Label
            // 
            this.MoradaFunc_Label.AutoSize = true;
            this.MoradaFunc_Label.BackColor = System.Drawing.Color.Transparent;
            this.MoradaFunc_Label.ForeColor = System.Drawing.Color.White;
            this.MoradaFunc_Label.Location = new System.Drawing.Point(369, 233);
            this.MoradaFunc_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MoradaFunc_Label.Name = "MoradaFunc_Label";
            this.MoradaFunc_Label.Size = new System.Drawing.Size(79, 24);
            this.MoradaFunc_Label.TabIndex = 5;
            this.MoradaFunc_Label.Text = "Morada:";
            // 
            // ContactoFunc_Label
            // 
            this.ContactoFunc_Label.AutoSize = true;
            this.ContactoFunc_Label.BackColor = System.Drawing.Color.Transparent;
            this.ContactoFunc_Label.ForeColor = System.Drawing.Color.White;
            this.ContactoFunc_Label.Location = new System.Drawing.Point(358, 279);
            this.ContactoFunc_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContactoFunc_Label.Name = "ContactoFunc_Label";
            this.ContactoFunc_Label.Size = new System.Drawing.Size(89, 24);
            this.ContactoFunc_Label.TabIndex = 6;
            this.ContactoFunc_Label.Text = "Contacto:";
            // 
            // TipoFunc_Label
            // 
            this.TipoFunc_Label.AutoSize = true;
            this.TipoFunc_Label.BackColor = System.Drawing.Color.Transparent;
            this.TipoFunc_Label.ForeColor = System.Drawing.Color.White;
            this.TipoFunc_Label.Location = new System.Drawing.Point(369, 336);
            this.TipoFunc_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TipoFunc_Label.Name = "TipoFunc_Label";
            this.TipoFunc_Label.Size = new System.Drawing.Size(53, 24);
            this.TipoFunc_Label.TabIndex = 7;
            this.TipoFunc_Label.Text = "Tipo:";
            // 
            // DataContrato_Label
            // 
            this.DataContrato_Label.AutoSize = true;
            this.DataContrato_Label.BackColor = System.Drawing.Color.Transparent;
            this.DataContrato_Label.ForeColor = System.Drawing.Color.White;
            this.DataContrato_Label.Location = new System.Drawing.Point(867, 187);
            this.DataContrato_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DataContrato_Label.Name = "DataContrato_Label";
            this.DataContrato_Label.Size = new System.Drawing.Size(151, 24);
            this.DataContrato_Label.TabIndex = 8;
            this.DataContrato_Label.Text = "Data do contrato:";
            // 
            // FimContrato_Label
            // 
            this.FimContrato_Label.AutoSize = true;
            this.FimContrato_Label.BackColor = System.Drawing.Color.Transparent;
            this.FimContrato_Label.ForeColor = System.Drawing.Color.White;
            this.FimContrato_Label.Location = new System.Drawing.Point(867, 238);
            this.FimContrato_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FimContrato_Label.Name = "FimContrato_Label";
            this.FimContrato_Label.Size = new System.Drawing.Size(207, 24);
            this.FimContrato_Label.TabIndex = 9;
            this.FimContrato_Label.Text = "Data do fim de contrato:";
            // 
            // DataRegistoCriminal_Label
            // 
            this.DataRegistoCriminal_Label.AutoSize = true;
            this.DataRegistoCriminal_Label.BackColor = System.Drawing.Color.Transparent;
            this.DataRegistoCriminal_Label.ForeColor = System.Drawing.Color.White;
            this.DataRegistoCriminal_Label.Location = new System.Drawing.Point(867, 291);
            this.DataRegistoCriminal_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DataRegistoCriminal_Label.Name = "DataRegistoCriminal_Label";
            this.DataRegistoCriminal_Label.Size = new System.Drawing.Size(193, 24);
            this.DataRegistoCriminal_Label.TabIndex = 10;
            this.DataRegistoCriminal_Label.Text = "Data Registo Criminal:";
            // 
            // nome_textbox
            // 
            this.nome_textbox.Location = new System.Drawing.Point(447, 141);
            this.nome_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.nome_textbox.Name = "nome_textbox";
            this.nome_textbox.Size = new System.Drawing.Size(277, 29);
            this.nome_textbox.TabIndex = 11;
            // 
            // morada_textbox
            // 
            this.morada_textbox.Location = new System.Drawing.Point(447, 229);
            this.morada_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.morada_textbox.Name = "morada_textbox";
            this.morada_textbox.Size = new System.Drawing.Size(277, 29);
            this.morada_textbox.TabIndex = 12;
            // 
            // contacto_textbox
            // 
            this.contacto_textbox.Location = new System.Drawing.Point(447, 275);
            this.contacto_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.contacto_textbox.Name = "contacto_textbox";
            this.contacto_textbox.Size = new System.Drawing.Size(148, 29);
            this.contacto_textbox.TabIndex = 13;
            // 
            // TipoFuncionario_ComboBox
            // 
            this.TipoFuncionario_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoFuncionario_ComboBox.FormattingEnabled = true;
            this.TipoFuncionario_ComboBox.Location = new System.Drawing.Point(447, 325);
            this.TipoFuncionario_ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.TipoFuncionario_ComboBox.Name = "TipoFuncionario_ComboBox";
            this.TipoFuncionario_ComboBox.Size = new System.Drawing.Size(180, 32);
            this.TipoFuncionario_ComboBox.TabIndex = 14;
            this.TipoFuncionario_ComboBox.SelectedIndexChanged += new System.EventHandler(this.TipoFuncionario_ComboBox_SelectedIndexChanged);
            // 
            // DataContrato_DateTimePicker
            // 
            this.DataContrato_DateTimePicker.Location = new System.Drawing.Point(1071, 178);
            this.DataContrato_DateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.DataContrato_DateTimePicker.Name = "DataContrato_DateTimePicker";
            this.DataContrato_DateTimePicker.Size = new System.Drawing.Size(298, 29);
            this.DataContrato_DateTimePicker.TabIndex = 15;
            // 
            // DataFimContrato_DateTimePicker
            // 
            this.DataFimContrato_DateTimePicker.Location = new System.Drawing.Point(1071, 232);
            this.DataFimContrato_DateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.DataFimContrato_DateTimePicker.Name = "DataFimContrato_DateTimePicker";
            this.DataFimContrato_DateTimePicker.Size = new System.Drawing.Size(298, 29);
            this.DataFimContrato_DateTimePicker.TabIndex = 16;
            // 
            // DataRegistoCriminal_DateTimePicker
            // 
            this.DataRegistoCriminal_DateTimePicker.Location = new System.Drawing.Point(1071, 291);
            this.DataRegistoCriminal_DateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.DataRegistoCriminal_DateTimePicker.Name = "DataRegistoCriminal_DateTimePicker";
            this.DataRegistoCriminal_DateTimePicker.Size = new System.Drawing.Size(298, 29);
            this.DataRegistoCriminal_DateTimePicker.TabIndex = 17;
            // 
            // DataFimRegistoCriminal_Label
            // 
            this.DataFimRegistoCriminal_Label.AutoSize = true;
            this.DataFimRegistoCriminal_Label.BackColor = System.Drawing.Color.Transparent;
            this.DataFimRegistoCriminal_Label.ForeColor = System.Drawing.Color.White;
            this.DataFimRegistoCriminal_Label.Location = new System.Drawing.Point(867, 346);
            this.DataFimRegistoCriminal_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DataFimRegistoCriminal_Label.Name = "DataFimRegistoCriminal_Label";
            this.DataFimRegistoCriminal_Label.Size = new System.Drawing.Size(230, 24);
            this.DataFimRegistoCriminal_Label.TabIndex = 18;
            this.DataFimRegistoCriminal_Label.Text = "Data Fim Registo Criminal:";
            // 
            // DataFimRegistoCriminal_DateTimePicker
            // 
            this.DataFimRegistoCriminal_DateTimePicker.Location = new System.Drawing.Point(1071, 346);
            this.DataFimRegistoCriminal_DateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.DataFimRegistoCriminal_DateTimePicker.Name = "DataFimRegistoCriminal_DateTimePicker";
            this.DataFimRegistoCriminal_DateTimePicker.Size = new System.Drawing.Size(298, 29);
            this.DataFimRegistoCriminal_DateTimePicker.TabIndex = 19;
            // 
            // DataNascimento_DateTimePicker
            // 
            this.DataNascimento_DateTimePicker.Location = new System.Drawing.Point(447, 189);
            this.DataNascimento_DateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.DataNascimento_DateTimePicker.Name = "DataNascimento_DateTimePicker";
            this.DataNascimento_DateTimePicker.Size = new System.Drawing.Size(298, 29);
            this.DataNascimento_DateTimePicker.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(285, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Data de nascimento";
            // 
            // salario_textbox
            // 
            this.salario_textbox.Location = new System.Drawing.Point(447, 375);
            this.salario_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.salario_textbox.Name = "salario_textbox";
            this.salario_textbox.Size = new System.Drawing.Size(148, 29);
            this.salario_textbox.TabIndex = 27;
            // 
            // salario_label
            // 
            this.salario_label.AutoSize = true;
            this.salario_label.BackColor = System.Drawing.Color.Transparent;
            this.salario_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.salario_label.Location = new System.Drawing.Point(358, 379);
            this.salario_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salario_label.Name = "salario_label";
            this.salario_label.Size = new System.Drawing.Size(72, 24);
            this.salario_label.TabIndex = 26;
            this.salario_label.Text = "Salário:";
            // 
            // EditFuncionario_Btn
            // 
            this.EditFuncionario_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(171)))));
            this.EditFuncionario_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditFuncionario_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditFuncionario_Btn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.EditFuncionario_Btn.IconColor = System.Drawing.Color.Black;
            this.EditFuncionario_Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditFuncionario_Btn.Location = new System.Drawing.Point(854, 637);
            this.EditFuncionario_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.EditFuncionario_Btn.Name = "EditFuncionario_Btn";
            this.EditFuncionario_Btn.Size = new System.Drawing.Size(274, 46);
            this.EditFuncionario_Btn.TabIndex = 20;
            this.EditFuncionario_Btn.Text = "Editar Informações";
            this.EditFuncionario_Btn.UseVisualStyleBackColor = false;
            this.EditFuncionario_Btn.Click += new System.EventHandler(this.EditFuncionario_Btn_Click);
            // 
            // SalarioHoraTextBox
            // 
            this.SalarioHoraTextBox.Location = new System.Drawing.Point(447, 376);
            this.SalarioHoraTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SalarioHoraTextBox.Name = "SalarioHoraTextBox";
            this.SalarioHoraTextBox.Size = new System.Drawing.Size(148, 29);
            this.SalarioHoraTextBox.TabIndex = 28;
            // 
            // SalarioHoralabel
            // 
            this.SalarioHoralabel.AutoSize = true;
            this.SalarioHoralabel.BackColor = System.Drawing.Color.Transparent;
            this.SalarioHoralabel.ForeColor = System.Drawing.Color.White;
            this.SalarioHoralabel.Location = new System.Drawing.Point(315, 382);
            this.SalarioHoralabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SalarioHoralabel.Name = "SalarioHoralabel";
            this.SalarioHoralabel.Size = new System.Drawing.Size(118, 24);
            this.SalarioHoralabel.TabIndex = 29;
            this.SalarioHoralabel.Text = "Salário Hora:";
            // 
            // RemoverFuncionario_Btn
            // 
            this.RemoverFuncionario_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(171)))));
            this.RemoverFuncionario_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoverFuncionario_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RemoverFuncionario_Btn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.RemoverFuncionario_Btn.IconColor = System.Drawing.Color.Black;
            this.RemoverFuncionario_Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RemoverFuncionario_Btn.Location = new System.Drawing.Point(1149, 637);
            this.RemoverFuncionario_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.RemoverFuncionario_Btn.Name = "RemoverFuncionario_Btn";
            this.RemoverFuncionario_Btn.Size = new System.Drawing.Size(274, 46);
            this.RemoverFuncionario_Btn.TabIndex = 28;
            this.RemoverFuncionario_Btn.Text = "Remover Funcionario";
            this.RemoverFuncionario_Btn.UseVisualStyleBackColor = false;
            this.RemoverFuncionario_Btn.Click += new System.EventHandler(this.RemoverFuncionario_Btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Location = new System.Drawing.Point(261, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 412);
            this.panel1.TabIndex = 30;
            // 
            // EditarFuncionarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1604, 696);
            this.Controls.Add(this.SalarioHoralabel);
            this.Controls.Add(this.SalarioHoraTextBox);
            this.Controls.Add(this.RemoverFuncionario_Btn);
            this.Controls.Add(this.salario_textbox);
            this.Controls.Add(this.salario_label);
            this.Controls.Add(this.DataNascimento_DateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditFuncionario_Btn);
            this.Controls.Add(this.DataFimRegistoCriminal_DateTimePicker);
            this.Controls.Add(this.DataFimRegistoCriminal_Label);
            this.Controls.Add(this.DataRegistoCriminal_DateTimePicker);
            this.Controls.Add(this.DataFimContrato_DateTimePicker);
            this.Controls.Add(this.DataContrato_DateTimePicker);
            this.Controls.Add(this.TipoFuncionario_ComboBox);
            this.Controls.Add(this.contacto_textbox);
            this.Controls.Add(this.morada_textbox);
            this.Controls.Add(this.nome_textbox);
            this.Controls.Add(this.DataRegistoCriminal_Label);
            this.Controls.Add(this.FimContrato_Label);
            this.Controls.Add(this.DataContrato_Label);
            this.Controls.Add(this.TipoFunc_Label);
            this.Controls.Add(this.ContactoFunc_Label);
            this.Controls.Add(this.MoradaFunc_Label);
            this.Controls.Add(this.NomeFunc_Label);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditarFuncionarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Funcionario";
            this.Load += new System.EventHandler(this.EditarFuncionarioForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NomeFunc_Label;
        private System.Windows.Forms.Label MoradaFunc_Label;
        private System.Windows.Forms.Label ContactoFunc_Label;
        private System.Windows.Forms.Label TipoFunc_Label;
        private System.Windows.Forms.Label DataContrato_Label;
        private System.Windows.Forms.Label FimContrato_Label;
        private System.Windows.Forms.Label DataRegistoCriminal_Label;
        private System.Windows.Forms.TextBox nome_textbox;
        private System.Windows.Forms.TextBox morada_textbox;
        private System.Windows.Forms.TextBox contacto_textbox;
        private System.Windows.Forms.ComboBox TipoFuncionario_ComboBox;
        private System.Windows.Forms.DateTimePicker DataContrato_DateTimePicker;
        private System.Windows.Forms.DateTimePicker DataFimContrato_DateTimePicker;
        private System.Windows.Forms.DateTimePicker DataRegistoCriminal_DateTimePicker;
        private System.Windows.Forms.Label DataFimRegistoCriminal_Label;
        private System.Windows.Forms.DateTimePicker DataFimRegistoCriminal_DateTimePicker;
        private FontAwesome.Sharp.IconButton EditFuncionario_Btn;
        private System.Windows.Forms.DateTimePicker DataNascimento_DateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salario_textbox;
        private System.Windows.Forms.Label salario_label;
        private System.Windows.Forms.TextBox SalarioHoraTextBox;
        private System.Windows.Forms.Label SalarioHoralabel;
        private FontAwesome.Sharp.IconButton RemoverFuncionario_Btn;
        private System.Windows.Forms.Panel panel1;
    }
}