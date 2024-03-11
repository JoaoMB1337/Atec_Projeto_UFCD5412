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
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExportCsv_Btn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataSistema_DateTimePicker
            // 
            this.DataSistema_DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataSistema_DateTimePicker.Location = new System.Drawing.Point(149, 147);
            this.DataSistema_DateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataSistema_DateTimePicker.Name = "DataSistema_DateTimePicker";
            this.DataSistema_DateTimePicker.Size = new System.Drawing.Size(445, 46);
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
            this.ExportCsv_Btn.IconSize = 75;
            this.ExportCsv_Btn.Location = new System.Drawing.Point(15, 465);
            this.ExportCsv_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExportCsv_Btn.Name = "ExportCsv_Btn";
            this.ExportCsv_Btn.Size = new System.Drawing.Size(131, 75);
            this.ExportCsv_Btn.TabIndex = 1;
            this.ExportCsv_Btn.TabStop = false;
            this.ExportCsv_Btn.Click += new System.EventHandler(this.ExportCsv_Btn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(105, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Controlador da data do software";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DataSistema_DateTimePicker);
            this.panel1.Location = new System.Drawing.Point(157, 81);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 291);
            this.panel1.TabIndex = 3;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.iconPictureBox1.BackgroundImage = global::Projeto_UFCD5412.Properties.Resources.LogoEmpresa_removebg_preview;
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 215;
            this.iconPictureBox1.Location = new System.Drawing.Point(516, 41);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(244, 215);
            this.iconPictureBox1.TabIndex = 3;
            this.iconPictureBox1.TabStop = false;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ExportCsv_Btn);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.ExportCsv_Btn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DataSistema_DateTimePicker;
        private FontAwesome.Sharp.IconPictureBox ExportCsv_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}