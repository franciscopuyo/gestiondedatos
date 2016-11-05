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
           Timetable.cancelPeriod(dni, professionCode, dateFrom.Value.Date, dateTo.Value.Date, reasonInput.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agenda agenda = new Agenda(professionCode, dni);
            agenda.Show();
        }
    }
}
