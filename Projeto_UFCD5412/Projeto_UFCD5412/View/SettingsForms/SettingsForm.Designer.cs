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
            this.DateTime_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DataSistema_DateTimePicker
            // 
            this.DataSistema_DateTimePicker.Location = new System.Drawing.Point(80, 91);
            this.DataSistema_DateTimePicker.Name = "DataSistema_DateTimePicker";
            this.DataSistema_DateTimePicker.Size = new System.Drawing.Size(289, 20);
            this.DataSistema_DateTimePicker.TabIndex = 0;
            this.DataSistema_DateTimePicker.ValueChanged += new System.EventHandler(this.DataSistema_DateTimePicker_ValueChanged);
            // 
            // DateTime_Label
            // 
            this.DateTime_Label.AutoSize = true;
            this.DateTime_Label.Location = new System.Drawing.Point(301, 230);
            this.DateTime_Label.Name = "DateTime_Label";
            this.DateTime_Label.Size = new System.Drawing.Size(35, 13);
            this.DateTime_Label.TabIndex = 1;
            this.DateTime_Label.Text = "label1";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DateTime_Label);
            this.Controls.Add(this.DataSistema_DateTimePicker);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DataSistema_DateTimePicker;
        private System.Windows.Forms.Label DateTime_Label;
    }
}