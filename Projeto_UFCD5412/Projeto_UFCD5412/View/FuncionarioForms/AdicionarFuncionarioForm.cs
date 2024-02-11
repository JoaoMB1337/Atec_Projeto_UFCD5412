using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_UFCD5412.View.Forms
{
    public partial class AdicionarFuncionarioForm : Form
    {
        public AdicionarFuncionarioForm()
        {
            InitializeComponent();
        }

        private void TipoFuncionario_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TipoFuncionario_ComboBox.SelectedIndex)
            {
                case 0: // Funcionaria
                    break;
                case 1: //Diretor
                    break;
                case 2: //Formador
                    break;
                case 3: //Secretaria
                   break;
                case 4: //Coordenador
                    break;

            }
        }
        private void AdicionarFuncionarioForm_Load(object sender, EventArgs e)
        {
            LoadTipoFuncionarioComboBox();
        }
        private void LoadTipoFuncionarioComboBox()
        {
            TipoFuncionario_ComboBox.Items.Add("Funcionario");
            TipoFuncionario_ComboBox.Items.Add("Diretor");
            TipoFuncionario_ComboBox.Items.Add("Formador");
            TipoFuncionario_ComboBox.Items.Add("Secretaria");
            TipoFuncionario_ComboBox.Items.Add("Coordenador");

            TipoFuncionario_ComboBox.SelectedIndex = 0;
        }

        private void Sair_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
