using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_UFCD5412.Model;


namespace Projeto_UFCD5412.View.CoordenacaoForms
{
    public partial class CoordenacaoMainForm : Form
    {
        private DateTime currentDate;

        public CoordenacaoMainForm()
        {
            InitializeComponent();
            currentDate = DateTime.Today;
            AtualizarCalendario(currentDate);
        }
        private void AtualizarCalendario(DateTime date)
        {
            containerDias.Controls.Clear();

            Label lblMonthYear = new Label();
            lblMonthYear.Text = date.ToString("MMMM yyyy");
            lblMonthYear.AutoSize = true;
            lblMonthYear.Dock = DockStyle.Top;
            containerDias.Controls.Add(lblMonthYear);

            Button btnRetroceder = new Button();
            btnRetroceder.Text = "<";
            btnRetroceder.Font = new Font("Arial", 12, FontStyle.Bold);
            btnRetroceder.Size = new Size(40, 30);
            btnRetroceder.Click += btnRetroceder_Click;
            containerDias.Controls.Add(btnRetroceder);

            Button btnAvancar = new Button();
            btnAvancar.Text = ">";
            btnAvancar.Font = new Font("Arial", 12, FontStyle.Bold);
            btnAvancar.Size = new Size(40, 30);
            btnAvancar.Click += btnAvancar_Click;
            containerDias.Controls.Add(btnAvancar);

            string[] diasSemana = { "Dom", "Seg", "Ter", "Qua", "Qui", "Sex", "Sáb" };

            // Adicionando os nomes dos dias da semana
            for (int i = 0; i < 7; i++)
            {
                Label lblDiaSemana = new Label();
                lblDiaSemana.Text = diasSemana[i];
                lblDiaSemana.AutoSize = false;
                lblDiaSemana.TextAlign = ContentAlignment.MiddleCenter;
                lblDiaSemana.Dock = DockStyle.Fill; // Adicionado para alinhar os dias com os nomes
                containerDias.Controls.Add(lblDiaSemana);
            }

            lblMonthYear.BorderStyle = BorderStyle.FixedSingle;

            DateTime firstDayOfMonth = new DateTime(date.Year, date.Month, 1);

            // Ajustar o primeiro dia da semana para iniciar no domingo
            int diaSemanaInicio = ((int)firstDayOfMonth.DayOfWeek) % 7;

            int numDias = DateTime.DaysInMonth(date.Year, date.Month);
            int dayCounter = 1;
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (i == 1 && j < diaSemanaInicio)
                    {
                        containerDias.Controls.Add(new Label());
                    }
                    else if (dayCounter <= numDias)
                    {
                        Button btnDia = new Button();
                        btnDia.Text = dayCounter.ToString();
                        btnDia.Margin = new Padding(0);
                        btnDia.Tag = new DateTime(date.Year, date.Month, dayCounter);
                        btnDia.FlatStyle = FlatStyle.Flat;
                        btnDia.FlatAppearance.BorderSize = 1;
                        btnDia.FlatAppearance.BorderColor = Color.Black;
                        btnDia.BackColor = (DateTime.Today.Date == btnDia.Tag as DateTime?) ? Color.LightBlue : Color.White;

                        int btnWidth = containerDias.Width / 7;
                        int btnHeight = (containerDias.Height - lblMonthYear.Height - 20) / 6;
                        btnDia.Size = new Size(btnWidth, btnHeight);

                        btnDia.Click += BtnDia_Click;
                        containerDias.Controls.Add(btnDia);
                        dayCounter++;
                    }
                    else
                    {
                        containerDias.Controls.Add(new Label());
                    }
                }
            }
        }





        private void BtnDia_Click(object sender, EventArgs e)
        {
            Button btnDia = sender as Button;
            DateTime selectedDate = (DateTime)btnDia.Tag;
            MessageBox.Show("Você selecionou o dia " + selectedDate.ToString("dd/MM/yyyy"));
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddMonths(1);
            AtualizarCalendario(currentDate);
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddMonths(-1);
            AtualizarCalendario(currentDate);
        }

       
    }
}
