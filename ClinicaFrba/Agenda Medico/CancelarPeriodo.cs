using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Agenda_Medico
{
    public partial class CancelarPeriodo : Form
    {
        private int dni;
        private int professionCode;

        public CancelarPeriodo(int dni, int professionCode)
        {
            this.dni = dni;
            this.professionCode = professionCode;
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if (!this.validate()) return;

           Timetable.cancelPeriod(dni, professionCode, dateFrom.Value.Date, dateTo.Value.Date, reasonInput.Text);
            MessageBox.Show("Periodo cancelado con éxito");
            this.Hide();
            Agendas agendas = new Agendas(dni);
            agendas.Show();
        }

        private bool validate()
        {
            bool valid = dateFrom.Value.Ticks < dateTo.Value.Ticks;

            if (!valid)
            {
                errorProviderDateFrom.SetError(dateFrom, "La fecha DESDE debe ser menor que HASTA");
            }
            return valid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agendas agendas = new Agendas(dni);
            agendas.Show();
        }

        private void oneDayCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (oneDayCheckbox.Checked)
            {
                dateTo.Hide();

                dateFrom.Value = dateFrom.Value.AddHours(-dateFrom.Value.Hour);
                dateFrom.Value = dateFrom.Value.AddMinutes(-dateFrom.Value.Minute);
                dateFrom.Value = dateFrom.Value.AddSeconds(-dateFrom.Value.Second);
                dateTo.Value = dateFrom.Value.AddDays(1);
            } else
            {
                dateTo.Show();
            }
        }

        private void CancelarPeriodo_Load(object sender, EventArgs e)
        {
            dateFrom.Format = DateTimePickerFormat.Custom;
            dateFrom.CustomFormat = "dd/MM/yyyy HH:mm:ss";

            dateTo.Format = DateTimePickerFormat.Custom;
            dateTo.CustomFormat = "dd/MM/yyyy HH:mm:ss";
        }
    }
}
