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
            this.dt_trainingStartDate = new System.Windows.Forms.DateTimePicker();
            this.dt_trainingEndDate = new System.Windows.Forms.DateTimePicker();
            this.cmb_startingHour = new System.Windows.Forms.ComboBox();
            this.cmb_endingHour = new System.Windows.Forms.ComboBox();
            this.cmb_trainers = new System.Windows.Forms.ComboBox();
            this.cmb_classes = new System.Windows.Forms.ComboBox();
            this.btn_saveTraining = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(109, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data de início";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(630, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de fim";
            // 
            // dt_trainingStartDate
            // 
            this.dt_trainingStartDate.Location = new System.Drawing.Point(294, 191);
            this.dt_trainingStartDate.Name = "dt_trainingStartDate";
            this.dt_trainingStartDate.Size = new System.Drawing.Size(247, 22);
            this.dt_trainingStartDate.TabIndex = 11;
            // 
            // dt_trainingEndDate
            // 
            this.dt_trainingEndDate.Location = new System.Drawing.Point(789, 189);
            this.dt_trainingEndDate.Name = "dt_trainingEndDate";
            this.dt_trainingEndDate.Size = new System.Drawing.Size(246, 22);
            this.dt_trainingEndDate.TabIndex = 12;
            // 
            // cmb_startingHour
            // 
            this.cmb_startingHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_startingHour.FormattingEnabled = true;
            this.cmb_startingHour.Items.AddRange(new object[] {
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
            this.cmb_startingHour.Location = new System.Drawing.Point(357, 268);
            this.cmb_startingHour.Name = "cmb_startingHour";
            this.cmb_startingHour.Size = new System.Drawing.Size(172, 24);
            this.cmb_startingHour.TabIndex = 21;
            // 
            // cmb_endingHour
            // 
            this.cmb_endingHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_endingHour.FormattingEnabled = true;
            this.cmb_endingHour.Items.AddRange(new object[] {
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
            this.cmb_endingHour.Location = new System.Drawing.Point(872, 268);
            this.cmb_endingHour.Name = "cmb_endingHour";
            this.cmb_endingHour.Size = new System.Drawing.Size(163, 24);
            this.cmb_endingHour.TabIndex = 23;
            // 
            // cmb_trainers
            // 
            this.cmb_trainers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_trainers.FormattingEnabled = true;
            this.cmb_trainers.Location = new System.Drawing.Point(294, 354);
            this.cmb_trainers.Name = "cmb_trainers";
            this.cmb_trainers.Size = new System.Drawing.Size(247, 24);
            this.cmb_trainers.TabIndex = 24;
            // 
            // cmb_classes
            // 
            this.cmb_classes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_classes.FormattingEnabled = true;
            this.cmb_classes.Location = new System.Drawing.Point(789, 354);
            this.cmb_classes.Name = "cmb_classes";
            this.cmb_classes.Size = new System.Drawing.Size(246, 24);
            this.cmb_classes.TabIndex = 25;
            // 
            // btn_saveTraining
            // 
            this.btn_saveTraining.Location = new System.Drawing.Point(892, 471);
            this.btn_saveTraining.Name = "btn_saveTraining";
            this.btn_saveTraining.Size = new System.Drawing.Size(143, 28);
            this.btn_saveTraining.TabIndex = 26;
            this.btn_saveTraining.Text = "Save";
            this.btn_saveTraining.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 29);
            this.label3.TabIndex = 27;
            this.label3.Text = "Hora de inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(611, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 29);
            this.label4.TabIndex = 28;
            this.label4.Text = "Hora de fim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 29);
            this.label5.TabIndex = 29;
            this.label5.Text = "Formador";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(630, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 29);
            this.label6.TabIndex = 30;
            this.label6.Text = "Turma";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(252, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(665, 69);
            this.label7.TabIndex = 31;
            this.label7.Text = "Agendamento de UFCD";
            // 
            // AdicionarFormacaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 580);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_saveTraining);
            this.Controls.Add(this.cmb_classes);
            this.Controls.Add(this.cmb_trainers);
            this.Controls.Add(this.cmb_endingHour);
            this.Controls.Add(this.cmb_startingHour);
            this.Controls.Add(this.dt_trainingEndDate);
            this.Controls.Add(this.dt_trainingStartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdicionarFormacaoForm";
            this.Text = "AdicionarFormacaoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_trainingStartDate;
        private System.Windows.Forms.DateTimePicker dt_trainingEndDate;
        private System.Windows.Forms.ComboBox cmb_startingHour;
        private System.Windows.Forms.ComboBox cmb_endingHour;
        private System.Windows.Forms.ComboBox cmb_trainers;
        private System.Windows.Forms.ComboBox cmb_classes;
        private System.Windows.Forms.Button btn_saveTraining;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}