using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_UFCD5412.View
{
    public partial class AdicionarFuncionarioForms : Form
    {
        public AdicionarFuncionarioForms()
        {
            InitializeComponent();
            LoadTipoFuncionario();
        }

        private void TipoFuncionario_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TipoFuncionario_ComboBox.SelectedItem.ToString())
            {
                case "Funcionario":
                    break;
                case "Formador":

                    break;
                case "Coordenador":
                    break;
                case "Secretaria":
                    break;
                case "Diretor":
                    break;
                default:
                    break;
            }
        }

        private void LoadTipoFuncionario()
        {
            TipoFuncionario_ComboBox.Items.Add("Funcionario");
            TipoFuncionario_ComboBox.Items.Add("Formador");
            TipoFuncionario_ComboBox.Items.Add("Coordenador");
            TipoFuncionario_ComboBox.Items.Add("Secretaria");
            TipoFuncionario_ComboBox.Items.Add("Diretor");
            TipoFuncionario_ComboBox.SelectedItem = "Funcionario"; //Valor Default
        }
    }
}
