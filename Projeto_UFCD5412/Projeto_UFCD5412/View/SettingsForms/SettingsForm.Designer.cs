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
            this.ExportJson_Btn = new FontAwesome.Sharp.IconPictureBox();
            this.ExportCsv_Btn = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExportJson_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportCsv_Btn)).BeginInit();
            this.SuspendLayout();
            // 
            // DataSistema_DateTimePicker
            // 
            this.DataSistema_DateTimePicker.Location = new System.Drawing.Point(21, 46);
            this.DataSistema_DateTimePicker.Name = "DataSistema_DateTimePicker";
            this.DataSistema_DateTimePicker.Size = new System.Drawing.Size(193, 20);
            this.DataSistema_DateTimePicker.TabIndex = 0;
            this.DataSistema_DateTimePicker.ValueChanged += new System.EventHandler(this.DataSistema_DateTimePicker_ValueChanged);
            // 
            // ExportJson_Btn
            // 
            this.ExportJson_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExportJson_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.ExportJson_Btn.BackgroundImage = global::Projeto_UFCD5412.Properties.Resources.jsonexport_removebg_preview;
            this.ExportJson_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExportJson_Btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExportJson_Btn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ExportJson_Btn.IconColor = System.Drawing.SystemColors.ControlText;
            this.ExportJson_Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ExportJson_Btn.IconSize = 50;
            this.ExportJson_Btn.Location = new System.Drawing.Point(118, 379);
            this.ExportJson_Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExportJson_Btn.Name = "ExportJson_Btn";
            this.ExportJson_Btn.Size = new System.Drawing.Size(50, 61);
            this.ExportJson_Btn.TabIndex = 2;
            this.ExportJson_Btn.TabStop = false;
            this.ExportJson_Btn.Click += new System.EventHandler(this.ExportJson_Btn_Click);
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
            this.ExportCsv_Btn.Location = new System.Drawing.Point(9, 379);
            this.ExportCsv_Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExportCsv_Btn.Name = "ExportCsv_Btn";
            this.ExportCsv_Btn.Size = new System.Drawing.Size(98, 61);
            this.ExportCsv_Btn.TabIndex = 1;
            this.ExportCsv_Btn.TabStop = false;
            this.ExportCsv_Btn.Click += new System.EventHandler(this.ExportCsv_Btn_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExportJson_Btn);
            this.Controls.Add(this.ExportCsv_Btn);
            this.Controls.Add(this.DataSistema_DateTimePicker);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.ExportJson_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportCsv_Btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DataSistema_DateTimePicker;
        private FontAwesome.Sharp.IconPictureBox ExportCsv_Btn;
        private FontAwesome.Sharp.IconPictureBox ExportJson_Btn;
    }
}