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

namespace Projeto_UFCD5412.View.SettingsForms
{
    public partial class SettingsForm : Form
    {
        DateTimeController dateTimeController = DateTimeController.Instance;
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void DataSistema_DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateTimeController.IsTimerPaused = true;

            DateTime newDateTime = DataSistema_DateTimePicker.Value;

            // Define a nova data e hora no DateTimeController
            dateTimeController.SetDateTime(newDateTime);

            // Retoma o timer após alterar a hora
            dateTimeController.IsTimerPaused = false;
        }
    }
}
