namespace Projeto_UFCD5412.View
{
    partial class ListarFuncionarioForms
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
            this.FuncionariosList_DataGrid = new System.Windows.Forms.DataGridView();
            this.AdicionarFuncionario_Btn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.FuncionariosList_DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FuncionariosList_DataGrid
            // 
            this.FuncionariosList_DataGrid.AllowUserToAddRows = false;
            this.FuncionariosList_DataGrid.AllowUserToDeleteRows = false;
            this.FuncionariosList_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FuncionariosList_DataGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.FuncionariosList_DataGrid.Location = new System.Drawing.Point(12, 12);
            this.FuncionariosList_DataGrid.Name = "FuncionariosList_DataGrid";
            this.FuncionariosList_DataGrid.ReadOnly = true;
            this.FuncionariosList_DataGrid.Size = new System.Drawing.Size(976, 426);
            this.FuncionariosList_DataGrid.TabIndex = 1;
            // 
            // AdicionarFuncionario_Btn
            // 
            this.AdicionarFuncionario_Btn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AdicionarFuncionario_Btn.IconColor = System.Drawing.Color.Black;
            this.AdicionarFuncionario_Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AdicionarFuncionario_Btn.Location = new System.Drawing.Point(805, 493);
            this.AdicionarFuncionario_Btn.Name = "AdicionarFuncionario_Btn";
            this.AdicionarFuncionario_Btn.Size = new System.Drawing.Size(173, 80);
            this.AdicionarFuncionario_Btn.TabIndex = 2;
            this.AdicionarFuncionario_Btn.Text = "AdicionarFunc";
            this.AdicionarFuncionario_Btn.UseVisualStyleBackColor = true;
            this.AdicionarFuncionario_Btn.Click += new System.EventHandler(this.AdicionarFuncionario_Btn_Click);
            // 
            // ListarFuncionarioForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.AdicionarFuncionario_Btn);
            this.Controls.Add(this.FuncionariosList_DataGrid);
            this.Name = "ListarFuncionarioForms";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ListarFuncionarioForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FuncionariosList_DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView FuncionariosList_DataGrid;
        private FontAwesome.Sharp.IconButton AdicionarFuncionario_Btn;
    }
}