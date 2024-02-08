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
            HideAllControls();

            switch (TipoFuncionario_ComboBox.SelectedIndex)
            {
                case 0: // Funcionaria
                    break;
                case 1: //Diretor
                    InitializeDiretorControls();
                    break;
                case 2: //Formador
                    InitializeFormadorControls();
                    break;
                case 3: //Secretaria
                    InitializeSecretariaControls();
                   break;
                case 4: //Coordenador
                    InitializeCoordenadorControls();
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

        private void HideAllControls()
        {
            // Secretaria
            DiretorResponsavel_Label.Visible = false;
            DiretorResponsavel_TextBox.Visible = false;
            Area_Label.Visible = false;
            Area_TextBox.Visible = false;

            // Diretor
            DiretorCurso_Label.Visible = false;
            DiretorCurso_TextBox.Visible = false;

            // Formador
            AreaLecionada_Label.Visible = false;
            AreaLecionada_TextBox.Visible = false;
            Disponibilidade_Label.Visible = false;
            Disponibilidade_TextBox.Visible = false;
            ValorHora_Label.Visible = false;
            ValorHora_TextBox.Visible = false;

            // Coordenador
            IseHorario_Label.Visible = false;
            IseHorario_TextBox.Visible = false;
            BonusMensal_Label.Visible = false;
            BonusMensal_TextBox.Visible = false;
            CarroEmpresa_Label.Visible = false;
            CarroEmpresa_TextBox.Visible = false;
            Departamento_Label.Visible = false;
            Departamento_TextBox.Visible = false;

            


        }

        private void InitializeDiretorControls()
        {
            //diretor
            DiretorCurso_Label.Visible = true;
            DiretorCurso_TextBox.Visible = true;

        }

        private void InitializeFormadorControls()
        {
            //formador
            AreaLecionada_Label.Visible = true;
            AreaLecionada_TextBox.Visible = true;
            Disponibilidade_Label.Visible = true;
            Disponibilidade_TextBox.Visible = true;
            ValorHora_Label.Visible = true;
            ValorHora_TextBox.Visible = true;

        }


        private void InitializeSecretariaControls()
        {
            //secretaria
            DiretorResponsavel_Label.Visible = true;
            DiretorResponsavel_TextBox.Visible = true;
            Area_Label.Visible = true;
            Area_TextBox.Visible = true;

        }

        private void InitializeCoordenadorControls()
        {
            //coordenador
            IseHorario_Label.Visible = true;
            IseHorario_TextBox.Visible = true;
            BonusMensal_Label.Visible = true;
            BonusMensal_TextBox.Visible = true;
            CarroEmpresa_Label.Visible = true;
            CarroEmpresa_TextBox.Visible = true;
            Departamento_Label.Visible = true;
            Departamento_TextBox.Visible = true;

        }

    }
}
