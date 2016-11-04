using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba.Abm_Profesional;
using ClinicaFrba.Abm_Especialidades_Medicas;
using ClinicaFrba.util;

namespace ClinicaFrba.Agenda_Medico
{
    public partial class AltaHorarios : Form
    {
        private int professionCode;
        private int dni;

        public AltaHorarios(int professionCode, int dni)
        {
            this.professionCode = professionCode;
            this.dni = dni;
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!this.validateCalendar()) {
                MessageBox.Show("Los horarios ingresados no son validos");
                return;
            }

            Timetable.create(professionCode, dni, from.Value, to.Value);
            
            if (mondayEnabled.Checked)
            {
                Timetable.addWorkDay(1, professionCode, dni, mondayFrom.Value, mondayTo.Value);
            }

            if (tuesdayEnabled.Checked)
            {
                Timetable.addWorkDay(2, professionCode, dni, tuesdayFrom.Value, tuesdayTo.Value);
            }

            if (wednesdayEnabled.Checked)
            {
                Timetable.addWorkDay(3, professionCode, dni, wednesdayFrom.Value, wednesdayTo.Value);
            }

            if (thursdayEnabled.Checked)
            {
                Timetable.addWorkDay(4, professionCode, dni, thursdayFrom.Value, thursdayTo.Value);
            }

            if (fridayEnabled.Checked)
            {
                Timetable.addWorkDay(5, professionCode, dni, fridayFrom.Value, fridayTo.Value);
            }

            if (saturdayEnabled.Checked)
            {
                Timetable.addWorkDay(6, professionCode, dni, saturdayFrom.Value, saturdayTo.Value);
            }

            MessageBox.Show("Agenda creada exitosamente");
            this.Hide();
            Agendas timetables = new Agendas(this.dni);
            timetables.Show();

        }

        private bool validateCalendar()
        {
            bool isValid = true;
            Validations.validateDateAfterNow(from, errorProviderFrom, "La fecha de inicio de la agenda no puede ser menor a la actual", ref isValid);
            Validations.validateDateAfter(to, from, errorProviderTo, "La fecha de inicio no puede ser anterior a la de final", ref isValid);

            TimeSpan fromWeekDays = new TimeSpan(7, 0, 0);
            TimeSpan toWeekDays = new TimeSpan(21, 0, 0);

            if (mondayEnabled.Checked) { 
                Validations.validateHourAfter(mondayFrom, fromWeekDays, errorProviderMondayFrom, "A esa hora la clinica se encuentra cerrada", ref isValid);
                Validations.validateHourBefore(mondayTo, toWeekDays, errorProviderMondayTo, "A esa hora la clinica se encuentra cerrada", ref isValid);
                Validations.validateHourAfter(mondayTo, mondayFrom.Value.TimeOfDay, errorProviderMondayFrom, "La hora de salida no puede ser anterior a la de entrada", ref isValid);
            }

            if (tuesdayEnabled.Checked)
            {
                Validations.validateHourAfter(tuesdayFrom, fromWeekDays, errorProviderTuesdayFrom, "A esa hora la clinica se encuentra cerrada", ref isValid);
                Validations.validateHourBefore(tuesdayTo, toWeekDays, errorProviderTuesdayTo, "A esa hora la clinica se encuentra cerrada", ref isValid);
                Validations.validateHourAfter(tuesdayTo, tuesdayFrom.Value.TimeOfDay, errorProviderTuesdayFrom, "La hora de salida no puede ser anterior a la de entrada", ref isValid);
            }

            if (wednesdayEnabled.Checked)
            {
                Validations.validateHourAfter(wednesdayFrom, fromWeekDays, errorProviderWednesdayFrom, "A esa hora la clinica se encuentra cerrada", ref isValid);
                Validations.validateHourBefore(wednesdayTo, toWeekDays, errorProviderWednesdayTo, "A esa hora la clinica se encuentra cerrada", ref isValid);
                Validations.validateHourAfter(wednesdayTo, wednesdayFrom.Value.TimeOfDay, errorProviderWednesdayFrom, "La hora de salida no puede ser anterior a la de entrada", ref isValid);
            }

            if (thursdayEnabled.Checked)
            {
                Validations.validateHourAfter(thursdayFrom, fromWeekDays, errorProviderThursdayFrom, "A esa hora la clinica se encuentra cerrada", ref isValid);
                Validations.validateHourBefore(thursdayTo, toWeekDays, errorProviderThursdayTo, "A esa hora la clinica se encuentra cerrada", ref isValid);
                Validations.validateHourAfter(thursdayTo, thursdayFrom.Value.TimeOfDay, errorProviderThursdayFrom, "La hora de salida no puede ser anterior a la de entrada", ref isValid);
            }

            if (fridayEnabled.Checked)
            {
                Validations.validateHourAfter(fridayFrom, fromWeekDays, errorProviderFridayFrom, "A esa hora la clinica se encuentra cerrada", ref isValid);
                Validations.validateHourBefore(fridayTo, toWeekDays, errorProviderFridayTo, "A esa hora la clinica se encuentra cerrada", ref isValid);
                Validations.validateHourAfter(fridayTo, fridayFrom.Value.TimeOfDay, errorProviderFridayFrom, "La hora de salida no puede ser anterior a la de entrada", ref isValid);
            }

            TimeSpan fromSaturday = new TimeSpan(10, 0, 0);
            TimeSpan toSaturday = new TimeSpan(15, 0, 0);

            if (saturdayEnabled.Checked)
            {
                Validations.validateHourAfter(saturdayFrom, fromSaturday, errorProviderSaturdayFrom, "A esa hora la clinica se encuentra cerrada", ref isValid);
                Validations.validateHourBefore(saturdayTo, toSaturday, errorProviderSaturdayTo, "A esa hora la clinica se encuentra cerrada", ref isValid);
                Validations.validateHourAfter(saturdayTo, saturdayFrom.Value.TimeOfDay, errorProviderSaturdayFrom, "La hora de salida no puede ser anterior a la de entrada", ref isValid);
            }

            return isValid;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AltaHorarios_Load(object sender, EventArgs e)
        {
            DataTable professional = Professional.getProfessionalByDni(this.dni);
            DataTable profession = Profession.getProfessionByCode(this.professionCode);

            labelProfesional.Text = professional.Rows[0]["nombre"].ToString() + " " + professional.Rows[0]["apellido"].ToString();
            labelEspecialidad.Text = profession.Rows[0]["descripcion"].ToString();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agendas timetables = new Agendas(this.dni);
            timetables.Show();
        }
    }
}
