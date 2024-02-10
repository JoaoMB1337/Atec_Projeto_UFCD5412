namespace Projeto_UFCD5412.View
{
    partial class AdicionarFuncionarioForms
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
            this.Nome_TextBox = new System.Windows.Forms.TextBox();
            this.Morada_TextBox = new System.Windows.Forms.TextBox();
            this.Contacto_TextBox = new System.Windows.Forms.TextBox();
            this.ID_TextBox = new System.Windows.Forms.TextBox();
            this.DataContrato_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.TipoFuncionario_ComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Nome_TextBox
            // 
            this.Nome_TextBox.Location = new System.Drawing.Point(28, 69);
            this.Nome_TextBox.Name = "Nome_TextBox";
            this.Nome_TextBox.Size = new System.Drawing.Size(190, 20);
            this.Nome_TextBox.TabIndex = 0;
            // 
            // Morada_TextBox
            // 
            this.Morada_TextBox.Location = new System.Drawing.Point(28, 109);
            this.Morada_TextBox.Name = "Morada_TextBox";
            this.Morada_TextBox.Size = new System.Drawing.Size(190, 20);
            this.Morada_TextBox.TabIndex = 1;
            // 
            // Contacto_TextBox
            // 
            this.Contacto_TextBox.Location = new System.Drawing.Point(28, 148);
            this.Contacto_TextBox.Name = "Contacto_TextBox";
            this.Contacto_TextBox.Size = new System.Drawing.Size(190, 20);
            this.Contacto_TextBox.TabIndex = 2;
            // 
            // ID_TextBox
            // 
            this.ID_TextBox.Location = new System.Drawing.Point(28, 31);
            this.ID_TextBox.Name = "ID_TextBox";
            this.ID_TextBox.Size = new System.Drawing.Size(100, 20);
            this.ID_TextBox.TabIndex = 3;
            // 
            // DataContrato_DateTimePicker
            // 
            this.DataContrato_DateTimePicker.Location = new System.Drawing.Point(28, 193);
            this.DataContrato_DateTimePicker.Name = "DataContrato_DateTimePicker";
            this.DataContrato_DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DataContrato_DateTimePicker.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(28, 230);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(28, 270);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 6;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(28, 309);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker4.TabIndex = 7;
            // 
            // TipoFuncionario_ComboBox
            // 
            this.TipoFuncionario_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoFuncionario_ComboBox.FormattingEnabled = true;
            this.TipoFuncionario_ComboBox.Location = new System.Drawing.Point(419, 30);
            this.TipoFuncionario_ComboBox.Name = "TipoFuncionario_ComboBox";
            this.TipoFuncionario_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.TipoFuncionario_ComboBox.TabIndex = 8;
            this.TipoFuncionario_ComboBox.SelectedIndexChanged += new System.EventHandler(this.TipoFuncionario_ComboBox_SelectedIndexChanged);
            // 
            // AdicionarFuncionarioForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TipoFuncionario_ComboBox);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.DataContrato_DateTimePicker);
            this.Controls.Add(this.ID_TextBox);
            this.Controls.Add(this.Contacto_TextBox);
            this.Controls.Add(this.Morada_TextBox);
            this.Controls.Add(this.Nome_TextBox);
            this.Name = "AdicionarFuncionarioForms";
            this.Text = "AdicionarFuncionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nome_TextBox;
        private System.Windows.Forms.TextBox Morada_TextBox;
        private System.Windows.Forms.TextBox Contacto_TextBox;
        private System.Windows.Forms.TextBox ID_TextBox;
        private System.Windows.Forms.DateTimePicker DataContrato_DateTimePicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.ComboBox TipoFuncionario_ComboBox;
    }
}