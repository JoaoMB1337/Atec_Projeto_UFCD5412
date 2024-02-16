using Projeto_UFCD5412.Controller;
using System;
using System.Windows.Forms;

namespace Projeto_UFCD5412.View.CoordenacaoForms
{
    public partial class AdicionarFormacaoForm : Form
    {
        DateTimeController dateTimeController = DateTimeController.Instance;

        public AdicionarFormacaoForm()
        {
            InitializeComponent();
            Console.WriteLine("SettingsForm - DateTimeController Instance: " + ReferenceEquals(dateTimeController, DateTimeController.Instance));
            DateTimeController.DateTimeChanged += DateTimeController_DateTimeChanged;
        }

        private void DateTimeController_DateTimeChanged(object sender, DateTimeChangedEventArgs e)
        {
        }

        private void DataSistema_DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Data alterada com sucesso");
        }
    }
}
