namespace Projeto_UFCD5412.View.CoordenacaoForms
{
    partial class AdicionarFormacaoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataInicio_calendar = new System.Windows.Forms.DateTimePicker();
            this.DataFim_calendar = new System.Windows.Forms.DateTimePicker();
            this.HoraIncio_combo = new System.Windows.Forms.ComboBox();
            this.HoraFim_combo = new System.Windows.Forms.ComboBox();
            this.FormadorNomes_combo = new System.Windows.Forms.ComboBox();
            this.Turmas_combo = new System.Windows.Forms.ComboBox();
            this.AdicionarFormacao_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data de início";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(472, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de fim";
            // 
            // DataInicio_calendar
            // 
            this.DataInicio_calendar.Location = new System.Drawing.Point(220, 155);
            this.DataInicio_calendar.Margin = new System.Windows.Forms.Padding(2);
            this.DataInicio_calendar.Name = "DataInicio_calendar";
            this.DataInicio_calendar.Size = new System.Drawing.Size(186, 20);
            this.DataInicio_calendar.TabIndex = 11;
            // 
            // DataFim_calendar
            // 
            this.DataFim_calendar.Location = new System.Drawing.Point(592, 154);
            this.DataFim_calendar.Margin = new System.Windows.Forms.Padding(2);
            this.DataFim_calendar.Name = "DataFim_calendar";
            this.DataFim_calendar.Size = new System.Drawing.Size(186, 20);
            this.DataFim_calendar.TabIndex = 12;
            // 
            // HoraIncio_combo
            // 
            this.HoraIncio_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HoraIncio_combo.FormattingEnabled = true;
            this.HoraIncio_combo.Items.AddRange(new object[] {
            "07:00 AM",
            "08:00 AM",
            "09:00 AM",
            "10:00 AM",
            "11:00 AM",
            "12:00 PM",
            "01:00 PM",
            "02:00 PM",
            "03:00 PM",
            "04:00 PM",
            "05:00 PM",
            "06:00 PM",
            "07:00 PM",
            "08:00 PM",
            "09:00 PM",
            "10:00 PM",
            "11:00 PM"});
            this.HoraIncio_combo.Location = new System.Drawing.Point(268, 218);
            this.HoraIncio_combo.Margin = new System.Windows.Forms.Padding(2);
            this.HoraIncio_combo.Name = "HoraIncio_combo";
            this.HoraIncio_combo.Size = new System.Drawing.Size(130, 21);
            this.HoraIncio_combo.TabIndex = 21;
            // 
            // HoraFim_combo
            // 
            this.HoraFim_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HoraFim_combo.FormattingEnabled = true;
            this.HoraFim_combo.Items.AddRange(new object[] {
            "07:00 AM",
            "08:00 AM",
            "09:00 AM",
            "10:00 AM",
            "11:00 AM",
            "12:00 PM",
            "01:00 PM",
            "02:00 PM",
            "03:00 PM",
            "04:00 PM",
            "05:00 PM",
            "06:00 PM",
            "07:00 PM",
            "08:00 PM",
            "09:00 PM",
            "10:00 PM",
            "11:00 PM"});
            this.HoraFim_combo.Location = new System.Drawing.Point(654, 218);
            this.HoraFim_combo.Margin = new System.Windows.Forms.Padding(2);
            this.HoraFim_combo.Name = "HoraFim_combo";
            this.HoraFim_combo.Size = new System.Drawing.Size(123, 21);
            this.HoraFim_combo.TabIndex = 23;
            // 
            // FormadorNomes_combo
            // 
            this.FormadorNomes_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormadorNomes_combo.FormattingEnabled = true;
            this.FormadorNomes_combo.Location = new System.Drawing.Point(220, 288);
            this.FormadorNomes_combo.Margin = new System.Windows.Forms.Padding(2);
            this.FormadorNomes_combo.Name = "FormadorNomes_combo";
            this.FormadorNomes_combo.Size = new System.Drawing.Size(186, 21);
            this.FormadorNomes_combo.TabIndex = 24;
            // 
            // Turmas_combo
            // 
            this.Turmas_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Turmas_combo.FormattingEnabled = true;
            this.Turmas_combo.Location = new System.Drawing.Point(592, 288);
            this.Turmas_combo.Margin = new System.Windows.Forms.Padding(2);
            this.Turmas_combo.Name = "Turmas_combo";
            this.Turmas_combo.Size = new System.Drawing.Size(186, 21);
            this.Turmas_combo.TabIndex = 25;
            // 
            // AdicionarFormacao_btn
            // 
            this.AdicionarFormacao_btn.Location = new System.Drawing.Point(669, 383);
            this.AdicionarFormacao_btn.Margin = new System.Windows.Forms.Padding(2);
            this.AdicionarFormacao_btn.Name = "AdicionarFormacao_btn";
            this.AdicionarFormacao_btn.Size = new System.Drawing.Size(107, 23);
            this.AdicionarFormacao_btn.TabIndex = 26;
            this.AdicionarFormacao_btn.Text = "Adicionar";
            this.AdicionarFormacao_btn.UseVisualStyleBackColor = true;
            this.AdicionarFormacao_btn.Click += new System.EventHandler(this.AdicionarFormacao_btn_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Hora de inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(458, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Hora de fim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 288);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Formador";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(472, 288);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "Turma";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(189, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(539, 55);
            this.label7.TabIndex = 31;
            this.label7.Text = "Agendamento de UFCD";
            // 
            // AdicionarFormacaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 471);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AdicionarFormacao_btn);
            this.Controls.Add(this.Turmas_combo);
            this.Controls.Add(this.FormadorNomes_combo);
            this.Controls.Add(this.HoraFim_combo);
            this.Controls.Add(this.HoraIncio_combo);
            this.Controls.Add(this.DataFim_calendar);
            this.Controls.Add(this.DataInicio_calendar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdicionarFormacaoForm";
            this.Text = "AdicionarFormacaoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DataInicio_calendar;
        private System.Windows.Forms.DateTimePicker DataFim_calendar;
        private System.Windows.Forms.ComboBox HoraIncio_combo;
        private System.Windows.Forms.ComboBox HoraFim_combo;
        private System.Windows.Forms.ComboBox FormadorNomes_combo;
        private System.Windows.Forms.ComboBox Turmas_combo;
        private System.Windows.Forms.Button AdicionarFormacao_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}