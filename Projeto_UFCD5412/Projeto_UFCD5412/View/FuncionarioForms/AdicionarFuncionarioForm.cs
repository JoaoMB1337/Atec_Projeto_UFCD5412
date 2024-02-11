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

        private void addFuncionarioSistema_btn_Click(object sender, EventArgs e)
        {
            string nome = nome_textbox.Text;
            string morada = morada_textbox.Text;
            string contacto = contacto_textbox.Text;
            DateTime dataContrato = DataContrato_DateTimePicker.Value;
            DateTime dataFimContrato = DataFimContrato_DateTimePicker.Value;
            DateTime dataRegistoCriminal = DataRegistoCriminal_DateTimePicker.Value;
            DateTime dataFimRegistoCriminal = DataFimRegistoCriminal_DateTimePicker.Value;
            string tipoFuncionario = TipoFuncionario_ComboBox.SelectedItem.ToString();

            Funcionario novoFuncionario = new Funcionario(
                id: 0, 
                nome: nome,
                morada: morada,
                contacto: contacto,
                tipo: tipoFuncionario,
                salario: 0, 
                dataAniverario: DateTime.MinValue, 
                dataContrato: dataContrato,
                dataFimContrato: dataFimContrato,
                dataRegistoCriminal: dataRegistoCriminal,
                dataFimRegistoCriminal: dataFimRegistoCriminal,
                username: "", 
                password: "", 
                primeiroLogin: true 
            );

            empresaController.AdicionarFuncionario(novoFuncionario);

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
