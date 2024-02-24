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
using Projeto_UFCD5412.Data;

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

        private void ExportCsv_Btn_Click(object sender, EventArgs e)
        {
            CSVHandler csvHandler = new CSVHandler();
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Arquivos CSV (*.csv)|*.csv";

            saveFileDialog.Title = "Salvar arquivo CSV";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = saveFileDialog.FileName;
                    csvHandler.ExportCsvToSystem(filePath);
                    MessageBox.Show("Ficheiro CSV exportado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao exportar o ficheiro CSV: " + ex.Message);
                }
            }
        }

        private void ExportJson_Btn_Click(object sender, EventArgs e)
        {

        }
    }
}

