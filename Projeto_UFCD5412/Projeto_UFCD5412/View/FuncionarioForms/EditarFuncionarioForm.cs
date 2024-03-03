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
using System.Windows.Input;

namespace Projeto_UFCD5412.View.FuncionarioForms
{
    public partial class EditarFuncionarioForm : Form
    {
        public int _funcionarioId;
        private EmpresaController empresaController = EmpresaController.Instance;
        public EditarFuncionarioForm()
        {
            InitializeComponent();
        }

        internal void SetParameter(int funcionarioId)
        {
           _funcionarioId = funcionarioId;
        }

        private void LoadInformacaoFuncionario()
        {
            var funcionario = empresaController.GetFuncionarioById(_funcionarioId);
            var formador = empresaController.GetFormadorById(_funcionarioId);
            if(funcionario == null)
            {
                MessageBox.Show("Funcionário não encontrado");
                this.Close();
            }
            else
            {
                nome_textbox.Text = funcionario.Nome;
                morada_textbox.Text = funcionario.Morada;
                contacto_textbox.Text = funcionario.Contacto;
                TipoFuncionario_ComboBox.SelectedItem = funcionario.Tipo;             
                DataContrato_DateTimePicker.Value = funcionario.DataContrato;
                DataFimContrato_DateTimePicker.Value = funcionario.DataFimContrato;
                DataRegistoCriminal_DateTimePicker.Value = funcionario.DataRegistoCriminal;
                DataFimRegistoCriminal_DateTimePicker.Value = funcionario.DataFimRegistoCriminal;
                DataNascimento_DateTimePicker.Value = funcionario.DataAniversario;
                salario_textbox.Text = funcionario.Salario.ToString();
                TipoFuncionario_ComboBox.SelectedItem = funcionario.Tipo;

                if (funcionario.Tipo == "Formador")
                {
                    SalarioHoraTextBox.Text = formador.ValorHora.ToString();
                }
            }
           
        }



        private void LoadTipoFuncionarioComboBox()
        {
            TipoFuncionario_ComboBox.Items.Add("Funcionario");
            TipoFuncionario_ComboBox.Items.Add("Diretor");
            TipoFuncionario_ComboBox.Items.Add("Formador");
            TipoFuncionario_ComboBox.Items.Add("Secretaria");
            TipoFuncionario_ComboBox.Items.Add("Coordenador");
        }

        private void EditarFuncionarioForm_Load(object sender, EventArgs e)
        {
            LoadTipoFuncionarioComboBox();
            LoadInformacaoFuncionario();
        }

        private void EditFuncionario_Btn_Click(object sender, EventArgs e)
        {
            UpdateInfoFuncionario();
        }


        private void UpdateInfoFuncionario()
        {   
          
            var formador = empresaController.GetFormadorById(_funcionarioId);

            if (formador == null)
            {
                MessageBox.Show("Funcionário não encontrado");
                this.Close();
            }
            else
            {
                formador.Nome = nome_textbox.Text;
                formador.Morada = morada_textbox.Text;
                formador.Contacto = contacto_textbox.Text;
                formador.Tipo = TipoFuncionario_ComboBox.SelectedItem.ToString();
                formador.DataContrato = DataContrato_DateTimePicker.Value;
                formador.DataFimContrato = DataFimContrato_DateTimePicker.Value;
                formador.DataRegistoCriminal = DataRegistoCriminal_DateTimePicker.Value;
                formador.DataFimRegistoCriminal = DataFimRegistoCriminal_DateTimePicker.Value;
                formador.DataAniversario = DataNascimento_DateTimePicker.Value;
                formador.Salario = decimal.Parse(salario_textbox.Text);

                if (formador.Tipo == "Formador")
                {
                   formador.ValorHora = decimal.Parse(SalarioHoraTextBox.Text);
                }
           


                // Verificar se o TextBox está vazio antes de tentar converter para decimal
                if (!string.IsNullOrWhiteSpace(salario_textbox.Text) && decimal.TryParse(salario_textbox.Text, out decimal salario))
                {
                    formador.Salario = salario; 
                }
                else
                {
                    MessageBox.Show("Por favor, insira um valor de salário válido.");
                    return;
                }

                empresaController.UpdateFuncionario(formador);
                MessageBox.Show("Funcionário atualizado com sucesso");
                this.Close();
            }
        }


        private void RemoverFuncionario_Btn_Click(object sender, EventArgs e)
        {
            var funcionario = empresaController.GetFuncionarioById(_funcionarioId);

            if (funcionario == null)
            {
                MessageBox.Show("Funcionário não encontrado");
                this.Close();
            }
            else
            {
                var confirmResult = MessageBox.Show("Tem certeza que deseja remover este funcionário?", "Confirmar Remoção", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    empresaController.RemoverFuncionario(funcionario);
                    MessageBox.Show("Funcionário removido com sucesso");
                    this.Close();
                }
            }
        }

        private void Sair_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TipoFuncionario_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TipoFuncionario_ComboBox.SelectedIndex)
            {
                case 0: //Funcionario
                    SalarioHoralabel.Visible = false;
                    SalarioHoraTextBox.Visible = false;
                    salario_label.Visible = true;
                    salario_textbox.Visible = true;
                    break;
                case 1: //Diretor
                    SalarioHoralabel.Visible = false;
                    SalarioHoraTextBox.Visible = false;
                    salario_label.Visible = true;
                    salario_textbox.Visible = true;
                    break;
                case 2: //Formador
                    salario_label.Visible = false;
                    salario_textbox.Visible = false;
                    SalarioHoralabel.Visible = true;
                    SalarioHoraTextBox.Visible = true;

                    break;
                case 3: //Secretaria
                    SalarioHoralabel.Visible = false;
                    SalarioHoraTextBox.Visible = false;
                    salario_label.Visible = true;
                    salario_textbox.Visible = true;
                    break;
                case 4: //Coordenador
                    SalarioHoralabel.Visible = false;
                    SalarioHoraTextBox.Visible = false;
                    salario_label.Visible = true;
                    salario_textbox.Visible = true;
                    break;

               }
            }
        }
    }
