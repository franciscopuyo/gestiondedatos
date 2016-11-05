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
        public CancelarPeriodo()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
           // Agenda.cancelatePeriod(dni, professionCode, dateFrom.Value.Date, dateTo.Value.Date);
        }
    }
}
