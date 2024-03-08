namespace Projeto_UFCD5412.View.SettingsForms
{
    partial class SettingsForm
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
            this.DataSistema_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ExportCsv_Btn = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ExportCsv_Btn)).BeginInit();
            this.SuspendLayout();
            // 
            // DataSistema_DateTimePicker
            // 
            this.DataSistema_DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataSistema_DateTimePicker.Location = new System.Drawing.Point(23, 61);
            this.DataSistema_DateTimePicker.Name = "DataSistema_DateTimePicker";
            this.DataSistema_DateTimePicker.Size = new System.Drawing.Size(241, 26);
            this.DataSistema_DateTimePicker.TabIndex = 0;
            this.DataSistema_DateTimePicker.ValueChanged += new System.EventHandler(this.DataSistema_DateTimePicker_ValueChanged);
            // 
            // ExportCsv_Btn
            // 
            this.ExportCsv_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExportCsv_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.ExportCsv_Btn.BackgroundImage = global::Projeto_UFCD5412.Properties.Resources.exportcsvicon_removebg_preview;
            this.ExportCsv_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExportCsv_Btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExportCsv_Btn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ExportCsv_Btn.IconColor = System.Drawing.SystemColors.ControlText;
            this.ExportCsv_Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ExportCsv_Btn.IconSize = 61;
            this.ExportCsv_Btn.Location = new System.Drawing.Point(11, 378);
            this.ExportCsv_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.ExportCsv_Btn.Name = "ExportCsv_Btn";
            this.ExportCsv_Btn.Size = new System.Drawing.Size(98, 61);
            this.ExportCsv_Btn.TabIndex = 1;
            this.ExportCsv_Btn.TabStop = false;
            this.ExportCsv_Btn.Click += new System.EventHandler(this.ExportCsv_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Controlador da data do software";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExportCsv_Btn);
            this.Controls.Add(this.DataSistema_DateTimePicker);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.ExportCsv_Btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DataSistema_DateTimePicker;
        private FontAwesome.Sharp.IconPictureBox ExportCsv_Btn;
        private System.Windows.Forms.Label label1;
    }
}