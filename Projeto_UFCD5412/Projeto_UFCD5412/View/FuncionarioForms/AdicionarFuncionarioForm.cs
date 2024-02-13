using Projeto_UFCD5412.Controller;
using Projeto_UFCD5412.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_UFCD5412.Controller;

namespace Projeto_UFCD5412.View.Forms
{
    public partial class AdicionarFuncionarioForm : Form
    {
        private EmpresaController empresaController = EmpresaController.Instance;
        public AdicionarFuncionarioForm()
        {
            InitializeComponent();     
            isencaohorario_checkbox.Visible = false;
            bonusmensal_checkbox.Visible = false;
            carroempresa_checkbox.Visible = false;

            secretariaNomeDiretor_textbox.Visible = false;
            secretariaNomeDiretor_textbox.Text = "Introduza o nome do diretor de departamento"; 
            secretariaNomeDiretor_textbox.ForeColor = SystemColors.GrayText;

            valorhora_textbox.Visible = false;
            valorhora_textbox.Text = "Introduza o valor da hora";
            valorhora_textbox.ForeColor = SystemColors.GrayText;

            areaensino_textbox.Visible = false;
            areaensino_textbox.Text = "Introduza a área de ensino";
            areaensino_textbox.ForeColor = SystemColors.GrayText;



            poslaboral_checkbox.Visible = false;
            laboral_checkbox.Visible = false;
            valorhora_textbox.Visible =false;
            areaensino_textbox.Visible = false;
        }

        private void valorhora_textbox_GotFocus(object sender, EventArgs e)
        {
            if (valorhora_textbox.Text == "Introduza o valor da hora")
            {
                valorhora_textbox.Text = "";
                valorhora_textbox.ForeColor = SystemColors.WindowText;
            }
        }
        private void valorhora_textbox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(valorhora_textbox.Text))
            {
                valorhora_textbox.Text = "Introduza o valor da hora";
                valorhora_textbox.ForeColor = SystemColors.GrayText;
            }
        }
        //
        private void areaensino_textbox_GotFocus(object sender, EventArgs e)
        {
            if (areaensino_textbox.Text == "Introduza a área de ensino")
            {
                areaensino_textbox.Text = "";
                areaensino_textbox.ForeColor = SystemColors.WindowText;
            }
        }
        private void areaensino_textbox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(areaensino_textbox.Text))
            {
                areaensino_textbox.Text = "Introduza a área de ensino";
                areaensino_textbox.ForeColor = SystemColors.GrayText;
            }
        }
        /// 
        private void secretariaNomeDiretor_textbox_GotFocus(object sender, EventArgs e)
        {
            if (secretariaNomeDiretor_textbox.Text == "Introduza o nome do diretor de departamento")
            {
                secretariaNomeDiretor_textbox.Text = "";
                secretariaNomeDiretor_textbox.ForeColor = SystemColors.WindowText; 
            }
        }
        private void secretariaNomeDiretor_textbox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(secretariaNomeDiretor_textbox.Text))
            {
                secretariaNomeDiretor_textbox.Text = "Introduza o nome do diretor de departamento";
                secretariaNomeDiretor_textbox.ForeColor = SystemColors.GrayText; 
            }
        }

        private void TipoFuncionario_ComboBox_SelectedIndexChanged(object sender, EventArgs e){
            switch (TipoFuncionario_ComboBox.SelectedIndex)
            {
                case 0: // Funcionaria
                    break;
                case 1: //Diretor
                    isencaohorario_checkbox.Visible = true;
                    bonusmensal_checkbox.Visible = true;
                    carroempresa_checkbox.Visible = true;
                    //se mudar outra vez para outro tipo de funcionario esconder os campos
                    poslaboral_checkbox.Visible = false;
                    laboral_checkbox.Visible = false;
                    valorhora_textbox.Visible = false;
                    areaensino_textbox.Visible = false;    
                    secretariaNomeDiretor_textbox.Visible = false;
                    break;
                case 2: //Formador
                    poslaboral_checkbox.Visible = true;
                    laboral_checkbox.Visible = true;
                    valorhora_textbox.Visible = true;
                    areaensino_textbox.Visible = true;
                    //se mudar outra vez para outro tipo de funcionario esconder os campos
                    isencaohorario_checkbox.Visible = false;
                    bonusmensal_checkbox.Visible = false;
                    carroempresa_checkbox.Visible = false;
                    secretariaNomeDiretor_textbox.Visible = false;
                    break;
                case 3: //Secretaria
                    secretariaNomeDiretor_textbox.Visible = true;
                    //se mudar outra vez para outro tipo de funcionario esconder os campos
                    isencaohorario_checkbox.Visible = false;
                    bonusmensal_checkbox.Visible = false;
                    carroempresa_checkbox.Visible = false;
                    poslaboral_checkbox.Visible = false;
                    laboral_checkbox.Visible = false;
                    valorhora_textbox.Visible = false;
                    areaensino_textbox.Visible = false;
                   break;
                case 4: //Coordenador
                    secretariaNomeDiretor_textbox.Visible = false;
                    isencaohorario_checkbox.Visible = false;
                    bonusmensal_checkbox.Visible = false;
                    carroempresa_checkbox.Visible = false;
                    poslaboral_checkbox.Visible = false;
                    laboral_checkbox.Visible = false;
                    valorhora_textbox.Visible = false;
                    areaensino_textbox.Visible = false;
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

        private void addFuncionarioSistema_btn_Click(object sender, EventArgs e)
        {
            // Verificar se todos os campos obrigatórios estão preenchidos
            if (string.IsNullOrEmpty(nome_textbox.Text) ||
                string.IsNullOrEmpty(morada_textbox.Text) ||
                string.IsNullOrEmpty(contacto_textbox.Text) ||
                TipoFuncionario_ComboBox.SelectedItem == null)
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return;
            }

            // Obter valores dos campos
            string nome = nome_textbox.Text;
            DateTime dataAniversario = DataNascimento_DateTimePicker.Value;
            string morada = morada_textbox.Text;
            string contacto = contacto_textbox.Text;
            DateTime dataContrato = DataContrato_DateTimePicker.Value;
            DateTime dataFimContrato = DataFimContrato_DateTimePicker.Value;
            DateTime dataRegistoCriminal = DataRegistoCriminal_DateTimePicker.Value;
            DateTime dataFimRegistoCriminal = DataFimRegistoCriminal_DateTimePicker.Value;
            string tipoFuncionario = TipoFuncionario_ComboBox.SelectedItem.ToString();
            bool isencaoHorario = isencaohorario_checkbox.Checked;
            bool bonusMensal = bonusmensal_checkbox.Checked;
            bool carroEmpresa = carroempresa_checkbox.Checked;
            bool posLaboral = poslaboral_checkbox.Checked;
            bool laboral = laboral_checkbox.Checked;
            string areaEnsino = areaensino_textbox.Text;
            string nomeDiretor = secretariaNomeDiretor_textbox.Text;
            decimal valorHora = 0;

            switch (tipoFuncionario)
            {
                case "Funcionario":                 
                    break;
                case "Diretor":
                   
                    break;
                case "Formador":
                    break;
                case "Secretaria":
                    break;
                case "Coordenador":
                    break;
                default:
                    break;
            }

            // Converter o valor do salário para decimal
            if (!decimal.TryParse(salario_textbox.Text, out decimal salario))
            {
                MessageBox.Show("Por favor, insira um valor de salário válido.");
                return;
            }

            // Criar um novo objeto Funcionario com os valores obtidos
            Funcionario novoFuncionario = new Funcionario(
                id: 0,
                nome: nome,
                morada: morada,
                contacto: contacto,
                tipo: tipoFuncionario,
                salario: salario, // Usar o valor do salário convertido
                dataAniverario: dataAniversario,
                dataContrato: dataContrato,
                dataFimContrato: dataFimContrato,
                dataRegistoCriminal: dataRegistoCriminal,
                dataFimRegistoCriminal: dataFimRegistoCriminal,
                username: "",
                password: "",
                primeiroLogin: true
            );

            // Adicionar o novo funcionário
            empresaController.AdicionarFuncionario(novoFuncionario);

            // Limpar os campos após adicionar o funcionário
            LimparCampos();
        }



        private void LimparCampos()
        {
            nome_textbox.Text = string.Empty;
            morada_textbox.Text = string.Empty;
            contacto_textbox.Text = string.Empty;
        }

        private void addFoto_btn_Click(object sender, EventArgs e)
        {//adicionar foto de funcionario
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imageLocation = openFileDialog.FileName;
                iconPictureBox1.ImageLocation = imageLocation;
                iconPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
