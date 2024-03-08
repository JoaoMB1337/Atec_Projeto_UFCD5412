namespace Projeto_UFCD5412.View.LoginForms
{
    partial class AlterarPasswordForm
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
            this.NovaPassword_TextBox = new System.Windows.Forms.TextBox();
            this.ConfirmarPassword_TextBox = new System.Windows.Forms.TextBox();
            this.ConfirmarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NovaPassword_TextBox
            // 
            this.NovaPassword_TextBox.Location = new System.Drawing.Point(64, 68);
            this.NovaPassword_TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NovaPassword_TextBox.Name = "NovaPassword_TextBox";
            this.NovaPassword_TextBox.PasswordChar = '*';
            this.NovaPassword_TextBox.Size = new System.Drawing.Size(265, 22);
            this.NovaPassword_TextBox.TabIndex = 0;
            // 
            // ConfirmarPassword_TextBox
            // 
            this.ConfirmarPassword_TextBox.Location = new System.Drawing.Point(64, 100);
            this.ConfirmarPassword_TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConfirmarPassword_TextBox.Name = "ConfirmarPassword_TextBox";
            this.ConfirmarPassword_TextBox.PasswordChar = '*';
            this.ConfirmarPassword_TextBox.Size = new System.Drawing.Size(265, 22);
            this.ConfirmarPassword_TextBox.TabIndex = 1;
            // 
            // ConfirmarBtn
            // 
            this.ConfirmarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(171)))));
            this.ConfirmarBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ConfirmarBtn.Location = new System.Drawing.Point(64, 132);
            this.ConfirmarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConfirmarBtn.Name = "ConfirmarBtn";
            this.ConfirmarBtn.Size = new System.Drawing.Size(120, 28);
            this.ConfirmarBtn.TabIndex = 2;
            this.ConfirmarBtn.Text = "Confirmar";
            this.ConfirmarBtn.UseVisualStyleBackColor = false;
            this.ConfirmarBtn.Click += new System.EventHandler(this.ConfirmarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(59, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Insira uma nova password";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(171)))));
            this.CancelarBtn.ForeColor = System.Drawing.Color.Snow;
            this.CancelarBtn.Location = new System.Drawing.Point(211, 132);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(120, 28);
            this.CancelarBtn.TabIndex = 4;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = false;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // AlterarPasswordForm
            // 
            this.AcceptButton = this.ConfirmarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(393, 177);
            this.ControlBox = false;
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmarBtn);
            this.Controls.Add(this.ConfirmarPassword_TextBox);
            this.Controls.Add(this.NovaPassword_TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlterarPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alterar Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NovaPassword_TextBox;
        private System.Windows.Forms.TextBox ConfirmarPassword_TextBox;
        private System.Windows.Forms.Button ConfirmarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelarBtn;
    }

}