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
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.ExportCsv_iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportCsv_iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataSistema_DateTimePicker
            // 
            this.DataSistema_DateTimePicker.Location = new System.Drawing.Point(158, 94);
            this.DataSistema_DateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.DataSistema_DateTimePicker.Name = "DataSistema_DateTimePicker";
            this.DataSistema_DateTimePicker.Size = new System.Drawing.Size(384, 22);
            this.DataSistema_DateTimePicker.TabIndex = 0;
            this.DataSistema_DateTimePicker.ValueChanged += new System.EventHandler(this.DataSistema_DateTimePicker_ValueChanged);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.iconPictureBox1.BackgroundImage = global::Projeto_UFCD5412.Properties.Resources.jsonexport_removebg_preview;
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 67;
            this.iconPictureBox1.Location = new System.Drawing.Point(158, 467);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(67, 75);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // ExportCsv_iconPictureBox1
            // 
            this.ExportCsv_iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExportCsv_iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.ExportCsv_iconPictureBox1.BackgroundImage = global::Projeto_UFCD5412.Properties.Resources.exportcsvicon_removebg_preview;
            this.ExportCsv_iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExportCsv_iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExportCsv_iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ExportCsv_iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.ExportCsv_iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ExportCsv_iconPictureBox1.IconSize = 75;
            this.ExportCsv_iconPictureBox1.Location = new System.Drawing.Point(12, 467);
            this.ExportCsv_iconPictureBox1.Name = "ExportCsv_iconPictureBox1";
            this.ExportCsv_iconPictureBox1.Size = new System.Drawing.Size(131, 75);
            this.ExportCsv_iconPictureBox1.TabIndex = 1;
            this.ExportCsv_iconPictureBox1.TabStop = false;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.ExportCsv_iconPictureBox1);
            this.Controls.Add(this.DataSistema_DateTimePicker);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportCsv_iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DataSistema_DateTimePicker;
        private FontAwesome.Sharp.IconPictureBox ExportCsv_iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}