namespace Projeto_UFCD5412.View.Forms
{
    partial class AdicionarFuncionarioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarFuncionarioForm));
            this.labelIDFuncionario = new System.Windows.Forms.Label();
            this.id_textbox = new System.Windows.Forms.TextBox();
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
            this.addFoto_btn = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.addFuncionarioSistema_btn = new FontAwesome.Sharp.IconButton();
            this.Sair_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIDFuncionario
            // 
            this.labelIDFuncionario.AutoSize = true;
            this.labelIDFuncionario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelIDFuncionario.Location = new System.Drawing.Point(563, 108);
            this.labelIDFuncionario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIDFuncionario.Name = "labelIDFuncionario";
            this.labelIDFuncionario.Size = new System.Drawing.Size(23, 16);
            this.labelIDFuncionario.TabIndex = 2;
            this.labelIDFuncionario.Text = "ID:";
            // 
            // id_textbox
            // 
            this.id_textbox.Location = new System.Drawing.Point(608, 105);
            this.id_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(132, 22);
            this.id_textbox.TabIndex = 3;
            // 
            // NomeFunc_Label
            // 
            this.NomeFunc_Label.AutoSize = true;
            this.NomeFunc_Label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NomeFunc_Label.Location = new System.Drawing.Point(549, 145);
            this.NomeFunc_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NomeFunc_Label.Name = "NomeFunc_Label";
            this.NomeFunc_Label.Size = new System.Drawing.Size(47, 16);
            this.NomeFunc_Label.TabIndex = 4;
            this.NomeFunc_Label.Text = "Nome:";
            // 
            // MoradaFunc_Label
            // 
            this.MoradaFunc_Label.AutoSize = true;
            this.MoradaFunc_Label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MoradaFunc_Label.Location = new System.Drawing.Point(539, 176);
            this.MoradaFunc_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MoradaFunc_Label.Name = "MoradaFunc_Label";
            this.MoradaFunc_Label.Size = new System.Drawing.Size(57, 16);
            this.MoradaFunc_Label.TabIndex = 5;
            this.MoradaFunc_Label.Text = "Morada:";
            // 
            // ContactoFunc_Label
            // 
            this.ContactoFunc_Label.AutoSize = true;
            this.ContactoFunc_Label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ContactoFunc_Label.Location = new System.Drawing.Point(529, 213);
            this.ContactoFunc_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContactoFunc_Label.Name = "ContactoFunc_Label";
            this.ContactoFunc_Label.Size = new System.Drawing.Size(63, 16);
            this.ContactoFunc_Label.TabIndex = 6;
            this.ContactoFunc_Label.Text = "Contacto:";
            // 
            // TipoFunc_Label
            // 
            this.TipoFunc_Label.AutoSize = true;
            this.TipoFunc_Label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TipoFunc_Label.Location = new System.Drawing.Point(539, 251);
            this.TipoFunc_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TipoFunc_Label.Name = "TipoFunc_Label";
            this.TipoFunc_Label.Size = new System.Drawing.Size(38, 16);
            this.TipoFunc_Label.TabIndex = 7;
            this.TipoFunc_Label.Text = "Tipo:";
            // 
            // DataContrato_Label
            // 
            this.DataContrato_Label.AutoSize = true;
            this.DataContrato_Label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataContrato_Label.Location = new System.Drawing.Point(951, 116);
            this.DataContrato_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DataContrato_Label.Name = "DataContrato_Label";
            this.DataContrato_Label.Size = new System.Drawing.Size(109, 16);
            this.DataContrato_Label.TabIndex = 8;
            this.DataContrato_Label.Text = "Data do contrato:";
            // 
            // FimContrato_Label
            // 
            this.FimContrato_Label.AutoSize = true;
            this.FimContrato_Label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FimContrato_Label.Location = new System.Drawing.Point(951, 145);
            this.FimContrato_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FimContrato_Label.Name = "FimContrato_Label";
            this.FimContrato_Label.Size = new System.Drawing.Size(148, 16);
            this.FimContrato_Label.TabIndex = 9;
            this.FimContrato_Label.Text = "Data do fim de contrato:";
            // 
            // DataRegistoCriminal_Label
            // 
            this.DataRegistoCriminal_Label.AutoSize = true;
            this.DataRegistoCriminal_Label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataRegistoCriminal_Label.Location = new System.Drawing.Point(951, 181);
            this.DataRegistoCriminal_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DataRegistoCriminal_Label.Name = "DataRegistoCriminal_Label";
            this.DataRegistoCriminal_Label.Size = new System.Drawing.Size(140, 16);
            this.DataRegistoCriminal_Label.TabIndex = 10;
            this.DataRegistoCriminal_Label.Text = "Data Registo Criminal:";
            // 
            // nome_textbox
            // 
            this.nome_textbox.Location = new System.Drawing.Point(608, 137);
            this.nome_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.nome_textbox.Name = "nome_textbox";
            this.nome_textbox.Size = new System.Drawing.Size(247, 22);
            this.nome_textbox.TabIndex = 11;
            // 
            // morada_textbox
            // 
            this.morada_textbox.Location = new System.Drawing.Point(608, 172);
            this.morada_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.morada_textbox.Name = "morada_textbox";
            this.morada_textbox.Size = new System.Drawing.Size(247, 22);
            this.morada_textbox.TabIndex = 12;
            // 
            // contacto_textbox
            // 
            this.contacto_textbox.Location = new System.Drawing.Point(608, 209);
            this.contacto_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.contacto_textbox.Name = "contacto_textbox";
            this.contacto_textbox.Size = new System.Drawing.Size(132, 22);
            this.contacto_textbox.TabIndex = 13;
            // 
            // TipoFuncionario_ComboBox
            // 
            this.TipoFuncionario_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoFuncionario_ComboBox.FormattingEnabled = true;
            this.TipoFuncionario_ComboBox.Location = new System.Drawing.Point(608, 241);
            this.TipoFuncionario_ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.TipoFuncionario_ComboBox.Name = "TipoFuncionario_ComboBox";
            this.TipoFuncionario_ComboBox.Size = new System.Drawing.Size(160, 24);
            this.TipoFuncionario_ComboBox.TabIndex = 14;
            this.TipoFuncionario_ComboBox.SelectedIndexChanged += new System.EventHandler(this.TipoFuncionario_ComboBox_SelectedIndexChanged);
            // 
            // DataContrato_DateTimePicker
            // 
            this.DataContrato_DateTimePicker.Location = new System.Drawing.Point(1132, 108);
            this.DataContrato_DateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.DataContrato_DateTimePicker.Name = "DataContrato_DateTimePicker";
            this.DataContrato_DateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.DataContrato_DateTimePicker.TabIndex = 15;
            // 
            // DataFimContrato_DateTimePicker
            // 
            this.DataFimContrato_DateTimePicker.Location = new System.Drawing.Point(1132, 140);
            this.DataFimContrato_DateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.DataFimContrato_DateTimePicker.Name = "DataFimContrato_DateTimePicker";
            this.DataFimContrato_DateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.DataFimContrato_DateTimePicker.TabIndex = 16;
            // 
            // DataRegistoCriminal_DateTimePicker
            // 
            this.DataRegistoCriminal_DateTimePicker.Location = new System.Drawing.Point(1132, 181);
            this.DataRegistoCriminal_DateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.DataRegistoCriminal_DateTimePicker.Name = "DataRegistoCriminal_DateTimePicker";
            this.DataRegistoCriminal_DateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.DataRegistoCriminal_DateTimePicker.TabIndex = 17;
            // 
            // DataFimRegistoCriminal_Label
            // 
            this.DataFimRegistoCriminal_Label.AutoSize = true;
            this.DataFimRegistoCriminal_Label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataFimRegistoCriminal_Label.Location = new System.Drawing.Point(951, 218);
            this.DataFimRegistoCriminal_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DataFimRegistoCriminal_Label.Name = "DataFimRegistoCriminal_Label";
            this.DataFimRegistoCriminal_Label.Size = new System.Drawing.Size(165, 16);
            this.DataFimRegistoCriminal_Label.TabIndex = 18;
            this.DataFimRegistoCriminal_Label.Text = "Data Fim Registo Criminal:";
            // 
            // DataFimRegistoCriminal_DateTimePicker
            // 
            this.DataFimRegistoCriminal_DateTimePicker.Location = new System.Drawing.Point(1132, 218);
            this.DataFimRegistoCriminal_DateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.DataFimRegistoCriminal_DateTimePicker.Name = "DataFimRegistoCriminal_DateTimePicker";
            this.DataFimRegistoCriminal_DateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.DataFimRegistoCriminal_DateTimePicker.TabIndex = 19;
            // 
            // addFoto_btn
            // 
            this.addFoto_btn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.addFoto_btn.IconColor = System.Drawing.Color.Black;
            this.addFoto_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addFoto_btn.Location = new System.Drawing.Point(167, 308);
            this.addFoto_btn.Margin = new System.Windows.Forms.Padding(4);
            this.addFoto_btn.Name = "addFoto_btn";
            this.addFoto_btn.Size = new System.Drawing.Size(255, 28);
            this.addFoto_btn.TabIndex = 22;
            this.addFoto_btn.Text = "Adicionar foto";
            this.addFoto_btn.UseVisualStyleBackColor = true;
            this.addFoto_btn.Click += new System.EventHandler(this.addFoto_btn_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.iconPictureBox1.BackgroundImage = global::Projeto_UFCD5412.Properties.Resources.rm314_adj_02;
            this.iconPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.GhostWhite;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.GhostWhite;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 233;
            this.iconPictureBox1.Location = new System.Drawing.Point(167, 55);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(254, 233);
            this.iconPictureBox1.TabIndex = 21;
            this.iconPictureBox1.TabStop = false;
            // 
            // addFuncionarioSistema_btn
            // 
            this.addFuncionarioSistema_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addFuncionarioSistema_btn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.addFuncionarioSistema_btn.IconColor = System.Drawing.Color.Black;
            this.addFuncionarioSistema_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addFuncionarioSistema_btn.Location = new System.Drawing.Point(1153, 274);
            this.addFuncionarioSistema_btn.Margin = new System.Windows.Forms.Padding(4);
            this.addFuncionarioSistema_btn.Name = "addFuncionarioSistema_btn";
            this.addFuncionarioSistema_btn.Size = new System.Drawing.Size(244, 28);
            this.addFuncionarioSistema_btn.TabIndex = 20;
            this.addFuncionarioSistema_btn.Text = "Adicionar ao sistema";
            this.addFuncionarioSistema_btn.UseVisualStyleBackColor = false;
            this.addFuncionarioSistema_btn.Click += new System.EventHandler(this.addFuncionarioSistema_btn_Click);
            // 
            // Sair_Btn
            // 
            this.Sair_Btn.Location = new System.Drawing.Point(1065, 567);
            this.Sair_Btn.Name = "Sair_Btn";
            this.Sair_Btn.Size = new System.Drawing.Size(142, 40);
            this.Sair_Btn.TabIndex = 23;
            this.Sair_Btn.Text = "Sair";
            this.Sair_Btn.UseVisualStyleBackColor = true;
            this.Sair_Btn.Click += new System.EventHandler(this.Sair_Btn_Click);
            // 
            // AdicionarFuncionarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1238, 619);
            this.Controls.Add(this.Sair_Btn);
            this.Controls.Add(this.addFoto_btn);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.addFuncionarioSistema_btn);
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
            this.Controls.Add(this.id_textbox);
            this.Controls.Add(this.labelIDFuncionario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdicionarFuncionarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar funcionario";
            this.Load += new System.EventHandler(this.AdicionarFuncionarioForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelIDFuncionario;
        private System.Windows.Forms.TextBox id_textbox;
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
        private FontAwesome.Sharp.IconButton addFuncionarioSistema_btn;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton addFoto_btn;
        private System.Windows.Forms.Button Sair_Btn;
    }
}