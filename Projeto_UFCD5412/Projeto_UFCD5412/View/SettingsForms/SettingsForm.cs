using Projeto_UFCD5412.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
           dateTimeController.SetDateTime(DataSistema_DateTimePicker.Value);
           MessageBox.Show("Data alterada com sucesso");
        }
    }
}
