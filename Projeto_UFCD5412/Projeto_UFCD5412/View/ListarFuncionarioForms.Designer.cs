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
            this.SearchName_TextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            // SearchName_TextBox
            // 
            this.SearchName_TextBox.Location = new System.Drawing.Point(23, 526);
            this.SearchName_TextBox.Name = "SearchName_TextBox";
            this.SearchName_TextBox.Size = new System.Drawing.Size(100, 20);
            this.SearchName_TextBox.TabIndex = 3;
            this.SearchName_TextBox.TextChanged += new System.EventHandler(this.SearchName_TextBox_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(170, 524);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ListarFuncionarioForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SearchName_TextBox);
            this.Controls.Add(this.AdicionarFuncionario_Btn);
            this.Controls.Add(this.FuncionariosList_DataGrid);
            this.Name = "ListarFuncionarioForms";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ListarFuncionarioForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FuncionariosList_DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView FuncionariosList_DataGrid;
        private FontAwesome.Sharp.IconButton AdicionarFuncionario_Btn;
        private System.Windows.Forms.TextBox SearchName_TextBox;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}