using Projeto_UFCD5412.Controller;
using System;
using System.Windows.Forms;

namespace Projeto_UFCD5412.View.SettingsForms
{
    public partial class SettingsForm : Form
    {
        DateTimeController dateTimeController = DateTimeController.Instance;

        public SettingsForm()
        {
            InitializeComponent();
            Console.WriteLine("SettingsForm - DateTimeController Instance: " + ReferenceEquals(dateTimeController, DateTimeController.Instance));
            DateTimeController.DateTimeChanged += DateTimeController_DateTimeChanged;
            DateTime_Label.Text = dateTimeController.GetDateTime().ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void DateTimeController_DateTimeChanged(object sender, DateTimeChangedEventArgs e)
        {
            DateTime_Label.Text = e.NewDateTime.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void DataSistema_DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateTimeController.SetDateTime(DataSistema_DateTimePicker.Value);
            MessageBox.Show("Data alterada com sucesso");
        }
    }
}
