﻿using Projeto_UFCD5412.Controller;
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
using Projeto_UFCD5412.Data;

namespace Projeto_UFCD5412.View.Forms
{
    public partial class AdicionarFuncionarioForm : Form
    {
        private bool posLaboral; 
        private bool laboral;

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

            username_label.Visible = false;
            username_textbox.Visible = false;

            cursoresponsavel_textbox.Visible = false;


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
                case 0: // Funcionario
                    username_label.Visible = true;
                    username_textbox.Visible = true;
                    ValorHoralabel.Visible = false;
                    areaensino_textbox.Visible = false;
                    cursoresponsavel_textbox.Visible = false;


                    break;
                case 1: //Diretor
                    isencaohorario_checkbox.Visible = true;
                    bonusmensal_checkbox.Visible = true;
                    carroempresa_checkbox.Visible = true;
                    password_textbox.Visible = true;                
                    username_label.Visible = true;
                    username_textbox.Visible = true;    
                    poslaboral_checkbox.Visible = false;
                    laboral_checkbox.Visible = false;
                    valorhora_textbox.Visible = false;
                    ValorHoralabel.Visible = false;
                    areaensino_textbox.Visible = false;    
                    secretariaNomeDiretor_textbox.Visible = false;
                    salario_textbox.Visible = true;
                    salario_label.Visible = true;
                    cursoresponsavel_textbox.Visible = false;



                    break;
                case 2: //Formador
                    poslaboral_checkbox.Visible = true;
                    laboral_checkbox.Visible = true;
                    valorhora_textbox.Visible = true;
                    ValorHoralabel.Visible = true;
                    areaensino_textbox.Visible = true;
                    password_textbox.Visible = true;
                    username_label.Visible = true;
                    username_textbox.Visible = true;
                    isencaohorario_checkbox.Visible = false;
                    bonusmensal_checkbox.Visible = false;
                    carroempresa_checkbox.Visible = false;
                    secretariaNomeDiretor_textbox.Visible = false;
                    salario_textbox.Visible = false;
                    salario_label.Visible = false;
                    cursoresponsavel_textbox.Visible = false;


                    break;
                case 3: //Secretaria
                    secretariaNomeDiretor_textbox.Visible = true;
                    password_textbox.Visible = true;
                    username_label.Visible = true;
                    username_textbox.Visible = true; 
                    isencaohorario_checkbox.Visible = false;
                    bonusmensal_checkbox.Visible = false;
                    carroempresa_checkbox.Visible = false;
                    poslaboral_checkbox.Visible = false;
                    laboral_checkbox.Visible = false;
                    valorhora_textbox.Visible = false;
                    ValorHoralabel.Visible = false;
                    areaensino_textbox.Visible = false;
                    salario_textbox.Visible = true;
                    salario_label.Visible = true;
                    cursoresponsavel_textbox.Visible = false;
                    break;
                case 4: //Coordenador
                    password_textbox.Visible = true;
                    username_label.Visible = true;
                    username_textbox.Visible = true;
                    secretariaNomeDiretor_textbox.Visible = false;
                    isencaohorario_checkbox.Visible = false;
                    bonusmensal_checkbox.Visible = false;
                    carroempresa_checkbox.Visible = false;
                    poslaboral_checkbox.Visible = false;
                    laboral_checkbox.Visible = false;
                    valorhora_textbox.Visible = false;
                    ValorHoralabel.Visible = false;
                    areaensino_textbox.Visible = false;
                    cursoresponsavel_textbox.Visible = true;
                    salario_textbox.Visible = true;
                    salario_label.Visible = true;
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
            if (string.IsNullOrWhiteSpace(nome_textbox.Text) ||
       string.IsNullOrWhiteSpace(morada_textbox.Text) ||
       string.IsNullOrWhiteSpace(contacto_textbox.Text) ||
       string.IsNullOrWhiteSpace(salario_textbox.Text) ||
       string.IsNullOrWhiteSpace(valorhora_textbox.Text) ||
       string.IsNullOrWhiteSpace(username_textbox.Text) ||
       string.IsNullOrWhiteSpace(password_textbox.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            // Verifica se o número de telefone é válido
            if (!empresaController.VerificarNumerosTelefone(contacto_textbox.Text))
            {
                MessageBox.Show("Número de telefone inválido.");
                return;
            }

            // Verificações adicionais...
            if (!empresaController.VerificarSeDataNascimentoValida(DataNascimento_DateTimePicker.Value))
            {
                MessageBox.Show("Data de nascimento inválida.");
                return;
            }

            if (!empresaController.VerificarSeDataContratoValida(DataContrato_DateTimePicker.Value))
            {
                MessageBox.Show("Data de contrato inválida.");
                return;
            }

            if (!empresaController.VerificarSeDataFimContratoValida(DataFimContrato_DateTimePicker.Value, DataContrato_DateTimePicker.Value))
            {
                MessageBox.Show("Data de fim de contrato inválida.");
                return;
            }

            decimal salario;
            if (!decimal.TryParse(salario_textbox.Text, out salario) || salario <= 0)
            {
                MessageBox.Show("Salário inválido.");
                return;
            }

           /* if (!empresaController.VerificarSeUsernameExite(username_textbox.Text))
            {
                MessageBox.Show("Username já existe.");
                return;
            }*/

            string nome = nome_textbox.Text;
                string morada = morada_textbox.Text;
                string contacto = contacto_textbox.Text;
                decimal valorHora = 0;
                decimal.TryParse(valorhora_textbox.Text, out valorHora);
                decimal.TryParse(salario_textbox.Text, out salario);
                DateTime dataAniversario = DataNascimento_DateTimePicker.Value;
                DateTime dataContrato = DataContrato_DateTimePicker.Value;
                DateTime dataFimContrato = DataFimContrato_DateTimePicker.Value;
                DateTime dataRegistoCriminal = DataRegistoCriminal_DateTimePicker.Value;
                DateTime dataFimRegistoCriminal = DataFimRegistoCriminal_DateTimePicker.Value;
                string tipoFuncionario = TipoFuncionario_ComboBox.SelectedItem.ToString();
                bool isencaoHorario = isencaohorario_checkbox.Checked;
                bool bonusMensal = bonusmensal_checkbox.Checked;
                bool carroEmpresa = carroempresa_checkbox.Checked;
                string departamento = areaensino_textbox.Text;
                string nomeDiretor = secretariaNomeDiretor_textbox.Text;
                string areaEnsino = areaensino_textbox.Text;

                string passwordEncriptada = EncryptController.EncryptPasswordStatic(password_textbox.Text);



                Funcionario novoFuncionario = null;

                switch (tipoFuncionario)
                {
                    case "Funcionario":
                        novoFuncionario = new Funcionario(
                             id: 0,
                             nome: nome,
                             morada: morada,
                             contacto: contacto,
                             tipo: tipoFuncionario,
                             salario: salario,
                             dataAniverario: dataAniversario,
                             dataContrato: dataContrato,
                             dataFimContrato: dataFimContrato,
                             dataRegistoCriminal: dataRegistoCriminal,
                             dataFimRegistoCriminal: dataFimRegistoCriminal,
                             username: username_textbox.Text,
                             password: passwordEncriptada,
                             primeiroLogin: true
                             );
                        break;

                    case "Diretor":
                        novoFuncionario = new Diretor(
                            id: 0,
                            nome: nome,
                            morada: morada,
                            contacto: contacto,
                            tipo: tipoFuncionario,
                            salario: salario,
                            dataAniverario: dataAniversario,
                            dataContrato: dataContrato,
                            dataFimContrato: dataFimContrato,
                            dataRegistoCriminal: dataRegistoCriminal,
                            dataFimRegistoCriminal: dataFimRegistoCriminal,
                            username: username_textbox.Text,
                            password: passwordEncriptada,
                            primeiroLogin: true,
                            isencaoHorario: isencaoHorario,
                            bonusMensal: bonusMensal ? salario : 0,
                            carroEmpresa: carroEmpresa,
                            departamento: departamento
                        );
                        break;
                    case "Secretaria":


                    if (string.IsNullOrWhiteSpace(cursoresponsavel_textbox.Text))
                    {
                        MessageBox.Show("Por favor, insira o nome do diretor responsável.");
                        return;
                    }

                    novoFuncionario = new Secretaria(
                            id: 0,
                            nome: nome,
                            morada: morada,
                            contacto: contacto,
                            tipo: tipoFuncionario,
                            salario: salario,
                            dataAniverario: dataAniversario,
                            dataContrato: dataContrato,
                            dataFimContrato: dataFimContrato,
                            dataRegistoCriminal: dataRegistoCriminal,
                            dataFimRegistoCriminal: dataFimRegistoCriminal,
                            username: username_textbox.Text,
                            password: passwordEncriptada,
                            primeiroLogin: true,
                            diretorResponsavel: nomeDiretor,
                            area: areaEnsino
                        );

                        break;
                    case "Formador":
                    if (!empresaController.VerificarSeValorHoraValido(decimal.Parse(valorhora_textbox.Text)))
                    {
                        MessageBox.Show("Valor da hora inválido.");
                        return;
                    }

                    if (!poslaboral_checkbox.Checked && !laboral_checkbox.Checked)
                    {
                        MessageBox.Show("Selecione a disponibilidade do formador.");
                        return;
                    }

                    novoFuncionario = new Formador(
                            id: 0,
                            nome: nome,
                            morada: morada,
                            contacto: contacto,
                            tipo: tipoFuncionario,
                            salario: salario,
                            dataAniverario: dataAniversario,
                            dataContrato: dataContrato,
                            dataFimContrato: dataFimContrato,
                            dataRegistoCriminal: dataRegistoCriminal,
                            dataFimRegistoCriminal: dataFimRegistoCriminal,
                            username: username_textbox.Text,
                            password: passwordEncriptada,
                            primeiroLogin: true,
                            areaLecionada: areaEnsino,
                            disponibilidade: posLaboral ? "Pós-laboral" : (laboral ? "Laboral" : "Ambas"),
                            valorHora: valorHora

                        );
                        break;
                    case "Coordenador":

                    if (string.IsNullOrWhiteSpace(cursoresponsavel_textbox.Text))
                    {
                        MessageBox.Show("Por favor, insira o curso responsável.");
                        return;
                    }

                    novoFuncionario = new Coordenador(
                            id: 0,
                            nome: nome,
                            morada: morada,
                            contacto: contacto,
                            tipo: tipoFuncionario,
                            salario: salario,
                            dataAniverario: dataAniversario,
                            dataContrato: dataContrato,
                            dataFimContrato: dataFimContrato,
                            dataRegistoCriminal: dataRegistoCriminal,
                            dataFimRegistoCriminal: dataFimRegistoCriminal,
                            username: username_textbox.Text,
                            password: passwordEncriptada,
                            primeiroLogin: true,
                            curso: cursoresponsavel_textbox.Text,
                            formadoresAssociados: new List<Formador>()
                        );
                        break;

                    default:
                        MessageBox.Show("Tipo de funcionário não suportado.");
                        return;
                }

                empresaController.AdicionarFuncionario(novoFuncionario);
                CSVHandler.ExportToCSV(empresaController.Funcionarios);
                MessageBox.Show("Funcionário adicionado com sucesso!");

                LimparCampos();
            
        }

        private void LimparCampos()
        {
            nome_textbox.Text = string.Empty;
            morada_textbox.Text = string.Empty;
            contacto_textbox.Text = string.Empty;
            salario_textbox.Text = string.Empty;
            valorhora_textbox.Text = string.Empty;
            DataNascimento_DateTimePicker.Value = DateTime.Now;
            DataContrato_DateTimePicker.Value = DateTime.Now;
            DataFimContrato_DateTimePicker.Value = DateTime.Now;
            DataRegistoCriminal_DateTimePicker.Value = DateTime.Now;
            DataFimRegistoCriminal_DateTimePicker.Value = DateTime.Now;
            TipoFuncionario_ComboBox.SelectedIndex = 0;
            isencaohorario_checkbox.Checked = false;
            bonusmensal_checkbox.Checked = false;
            carroempresa_checkbox.Checked = false;
            secretariaNomeDiretor_textbox.Text = "Introduza o nome do diretor de departamento";
            secretariaNomeDiretor_textbox.ForeColor = SystemColors.GrayText;
            areaensino_textbox.Text = "Introduza a área de ensino";
            areaensino_textbox.ForeColor = SystemColors.GrayText;
            valorhora_textbox.Text = "Introduza o valor da hora";
            valorhora_textbox.ForeColor = SystemColors.GrayText;
            poslaboral_checkbox.Checked = false;
            laboral_checkbox.Checked = false;
            username_textbox.Text = string.Empty;
            password_textbox.Text = string.Empty;
            cursoresponsavel_textbox.Text = string.Empty;
        }


    }
}
