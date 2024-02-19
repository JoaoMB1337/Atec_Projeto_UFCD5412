namespace Projeto_UFCD5412.View.LoginForms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Home_Btn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.User_Textbox = new System.Windows.Forms.TextBox();
            this.UserLogin_Btn = new FontAwesome.Sharp.IconButton();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Home_Btn)).BeginInit();
            this.SuspendLayout();
            // 
            // Home_Btn
            // 
            this.Home_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Home_Btn.Image = global::Projeto_UFCD5412.Properties.Resources.icon_ADOSMELHORES_removebg_preview;
            this.Home_Btn.Location = new System.Drawing.Point(240, 108);
            this.Home_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Home_Btn.Name = "Home_Btn";
            this.Home_Btn.Size = new System.Drawing.Size(151, 138);
            this.Home_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Home_Btn.TabIndex = 1;
            this.Home_Btn.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(218, 302);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(175, 362);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // User_Textbox
            // 
            this.User_Textbox.Location = new System.Drawing.Point(303, 309);
            this.User_Textbox.Name = "User_Textbox";
            this.User_Textbox.Size = new System.Drawing.Size(135, 19);
            this.User_Textbox.TabIndex = 4;
            // 
            // UserLogin_Btn
            // 
            this.UserLogin_Btn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.UserLogin_Btn.IconColor = System.Drawing.Color.Black;
            this.UserLogin_Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UserLogin_Btn.Location = new System.Drawing.Point(180, 428);
            this.UserLogin_Btn.Name = "UserLogin_Btn";
            this.UserLogin_Btn.Size = new System.Drawing.Size(272, 29);
            this.UserLogin_Btn.TabIndex = 6;
            this.UserLogin_Btn.Text = "Entrar";
            this.UserLogin_Btn.UseVisualStyleBackColor = true;
            this.UserLogin_Btn.Click += new System.EventHandler(this.UserLogin_Btn_Click);
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Location = new System.Drawing.Point(303, 369);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.PasswordChar = '*';
            this.Password_TextBox.Size = new System.Drawing.Size(135, 19);
            this.Password_TextBox.TabIndex = 5;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = global::Projeto_UFCD5412.Properties.Resources._3408105;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 650);
            this.Controls.Add(this.UserLogin_Btn);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.User_Textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Home_Btn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.Home_Btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Home_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox User_Textbox;
        private FontAwesome.Sharp.IconButton UserLogin_Btn;
        private System.Windows.Forms.TextBox Password_TextBox;
    }
}