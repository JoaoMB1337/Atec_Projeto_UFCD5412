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
            this.SuspendLayout();
            // 
            // NovaPassword_TextBox
            // 
            this.NovaPassword_TextBox.Location = new System.Drawing.Point(48, 55);
            this.NovaPassword_TextBox.Name = "NovaPassword_TextBox";
            this.NovaPassword_TextBox.PasswordChar = '*';
            this.NovaPassword_TextBox.Size = new System.Drawing.Size(200, 20);
            this.NovaPassword_TextBox.TabIndex = 0;
            // 
            // ConfirmarPassword_TextBox
            // 
            this.ConfirmarPassword_TextBox.Location = new System.Drawing.Point(48, 81);
            this.ConfirmarPassword_TextBox.Name = "ConfirmarPassword_TextBox";
            this.ConfirmarPassword_TextBox.PasswordChar = '*';
            this.ConfirmarPassword_TextBox.Size = new System.Drawing.Size(200, 20);
            this.ConfirmarPassword_TextBox.TabIndex = 1;
            // 
            // ConfirmarBtn
            // 
            this.ConfirmarBtn.Location = new System.Drawing.Point(111, 107);
            this.ConfirmarBtn.Name = "ConfirmarBtn";
            this.ConfirmarBtn.Size = new System.Drawing.Size(75, 23);
            this.ConfirmarBtn.TabIndex = 2;
            this.ConfirmarBtn.Text = "Confirmar";
            this.ConfirmarBtn.UseVisualStyleBackColor = true;
            this.ConfirmarBtn.Click += new System.EventHandler(this.ConfirmarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(44, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Insira uma nova password";
            // 
            // AlterarPasswordForm
            // 
            this.AcceptButton = this.ConfirmarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 144);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmarBtn);
            this.Controls.Add(this.ConfirmarPassword_TextBox);
            this.Controls.Add(this.NovaPassword_TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
    }

}