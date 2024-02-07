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
            ((System.ComponentModel.ISupportInitialize)(this.FuncionariosList_DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FuncionariosList_DataGrid
            // 
            this.FuncionariosList_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FuncionariosList_DataGrid.Location = new System.Drawing.Point(12, 12);
            this.FuncionariosList_DataGrid.Name = "FuncionariosList_DataGrid";
            this.FuncionariosList_DataGrid.Size = new System.Drawing.Size(776, 426);
            this.FuncionariosList_DataGrid.TabIndex = 0;
            // 
            // ListarFuncionarioForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FuncionariosList_DataGrid);
            this.Name = "ListarFuncionarioForms";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.FuncionariosList_DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FuncionariosList_DataGrid;
    }
}