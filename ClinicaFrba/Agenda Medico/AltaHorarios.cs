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
        private int dni;
        private DateTime mondayFromPrev;
        private DateTime mondayToPrev;
        private DateTime tuesdayFromPrev;
        private DateTime tuesdayToPrev;
        private DateTime wednesdayFromPrev;
        private DateTime wednesdayToPrev;
        private DateTime thursdayFromPrev;
        private DateTime thursdayToPrev;
        private DateTime fridayFromPrev;
        private DateTime fridayToPrev;
        private DateTime saturdayFromPrev;
        private DateTime saturdayToPrev;

        private bool initialized = false;

        public AltaHorarios(int dni)
        {
            this.dni = dni;
            InitializeComponent();

            this.initializeDatePickerTime(ref mondayTo, ref mondayToPrev);
            this.initializeDatePickerTime(ref mondayFrom, ref mondayFromPrev);
            this.initializeDatePickerTime(ref tuesdayTo, ref tuesdayToPrev);
            this.initializeDatePickerTime(ref tuesdayFrom, ref tuesdayFromPrev);
            this.initializeDatePickerTime(ref wednesdayTo, ref wednesdayToPrev);
            this.initializeDatePickerTime(ref wednesdayFrom, ref wednesdayFromPrev);
            this.initializeDatePickerTime(ref thursdayTo, ref thursdayToPrev);
            this.initializeDatePickerTime(ref thursdayFrom, ref thursdayFromPrev);
            this.initializeDatePickerTime(ref fridayTo, ref fridayToPrev);
            this.initializeDatePickerTime(ref fridayFrom, ref fridayFromPrev);
            this.initializeDatePickerTime(ref saturdayTo, ref saturdayToPrev);
            this.initializeDatePickerTime(ref saturdayFrom, ref saturdayFromPrev);

            this.initialized = true;
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

            int professionCode = Profession.getCodeByDescription(especialidadesCombo.Text);

            Timetable.create(professionCode, dni, from.Value, to.Value);
            
            if (mondayEnabled.Checked)
            {
                Timetable.addWorkDay(1, mondayFrom.Value, mondayTo.Value);
            }

            if (tuesdayEnabled.Checked)
            {
                Timetable.addWorkDay(2, tuesdayFrom.Value, tuesdayTo.Value);
            }

            if (wednesdayEnabled.Checked)
            {
                Timetable.addWorkDay(3, wednesdayFrom.Value, wednesdayTo.Value);
            }

            if (thursdayEnabled.Checked)
            {
                Timetable.addWorkDay(4, thursdayFrom.Value, thursdayTo.Value);
            }

            if (fridayEnabled.Checked)
            {
                Timetable.addWorkDay(5, fridayFrom.Value, fridayTo.Value);
            }

            if (saturdayEnabled.Checked)
            {
                Timetable.addWorkDay(6, saturdayFrom.Value, saturdayTo.Value);
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

            TimeSpan fromWeekDays = new TimeSpan(6, 59, 0);
            TimeSpan toWeekDays = new TimeSpan(21, 1, 0);

            double hours = 0;
            if (mondayEnabled.Checked) { 
                Validations.validateHourAfter(mondayFrom, fromWeekDays, errorProviderMondayFrom, "A esa hora la clinica se encuentra cerrada", ref isValid);
                Validations.validateHourBefore(mondayTo, toWeekDays, errorProviderMondayTo, "A esa hora la clinica se encuentra cerrada", ref isValid);
                Validations.validateHourAfter(mondayTo, mondayFrom.Value.TimeOfDay, errorProviderMondayFrom, "La hora de salida no puede ser anterior a la de entrada", ref isValid);
                hours += (mondayTo.Value.TimeOfDay - mondayFrom.Value.TimeOfDay).TotalHours;
            }

            if (tuesdayEnabled.Checked)
            {
                Validations.validateHourAfter(tuesdayFrom, fromWeekDays, errorProviderTuesdayFrom, "A esa hora la clinica se encuentra cerrada", ref isValid);
                Validations.validateHourBefore(tuesdayTo, toWeekDays, errorProviderTuesdayTo, "A esa hora la clinica se encuentra cerrada", ref isValid);
                Validations.validateHourAfter(tuesdayTo, tuesdayFrom.Value.TimeOfDay, errorProviderTuesdayFrom, "La hora de salida no puede ser anterior a la de entrada", ref isValid);
                hours += (tuesdayTo.Value.TimeOfDay - tuesdayFrom.Value.TimeOfDay).TotalHours;
            }

            if (wednesdayEnabled.Checked)
            {
                Validations.validateHourAfter(wednesdayFrom, fromWeekDays, errorProviderWednesdayFrom, "A esa hora la clinica se encuentra cerrada", ref isValid);
                Validations.validateHourBefore(wednesdayTo, toWeekDays, errorProviderWednesdayTo, "A esa hora la clinica se encuentra cerrada", ref isValid);
                Validations.validateHourAfter(wednesdayTo, wednesdayFrom.Value.TimeOfDay, errorProviderWednesdayFrom, "La hora de salida no puede ser anterior a la de entrada", ref isValid);
                hours += (mondayTo.Value.TimeOfDay - wednesdayFrom.Value.TimeOfDay).TotalHours;
            }

            if (thursdayEnabled.Checked)
            {
                Validations.validateHourAfter(thursdayFrom, fromWeekDays, errorProviderThursdayFrom, "A esa hora la clinica se encuentra cerrada", ref isValid);
                Validations.validateHourBefore(thursdayTo, toWeekDays, errorProviderThursdayTo, "A esa hora la clinica se encuentra cerrada", ref isValid);
                Validations.validateHourAfter(thursdayTo, thursdayFrom.Value.TimeOfDay, errorProviderThursdayFrom, "La hora de salida no puede ser anterior a la de entrada", ref isValid);
                hours += (thursdayTo.Value.TimeOfDay - thursdayFrom.Value.TimeOfDay).TotalHours;
            }

            if (fridayEnabled.Checked)
            {
                Validations.validateHourAfter(fridayFrom, fromWeekDays, errorProviderFridayFrom, "A esa hora la clinica se encuentra cerrada", ref isValid);
                Validations.validateHourBefore(fridayTo, toWeekDays, errorProviderFridayTo, "A esa hora la clinica se encuentra cerrada", ref isValid);
                Validations.validateHourAfter(fridayTo, fridayFrom.Value.TimeOfDay, errorProviderFridayFrom, "La hora de salida no puede ser anterior a la de entrada", ref isValid);
                hours += (fridayTo.Value.TimeOfDay - fridayFrom.Value.TimeOfDay).TotalHours;
            }

            TimeSpan fromSaturday = new TimeSpan(9, 59, 0);
            TimeSpan toSaturday = new TimeSpan(15, 1, 0);

            if (saturdayEnabled.Checked)
            {
                Validations.validateHourAfter(saturdayFrom, fromSaturday, errorProviderSaturdayFrom, "A esa hora la clinica se encuentra cerrada", ref isValid);
                Validations.validateHourBefore(saturdayTo, toSaturday, errorProviderSaturdayTo, "A esa hora la clinica se encuentra cerrada", ref isValid);
                Validations.validateHourAfter(saturdayTo, saturdayFrom.Value.TimeOfDay, errorProviderSaturdayFrom, "La hora de salida no puede ser anterior a la de entrada", ref isValid);
                hours += (saturdayTo.Value.TimeOfDay - saturdayFrom.Value.TimeOfDay).TotalHours;
            }

            if (hours > 48)
            {
                MessageBox.Show("Un medico no puede trabajar mas de 48 horas semanales");
                isValid = false;
            }


            int professionCode = Profession.getCodeByDescription(especialidadesCombo.Text);
            bool hayAgendaEnPeriodo = Timetable.hayAgendaEnPeriodo(to.Value, from.Value, this.dni, professionCode);

            if (hayAgendaEnPeriodo)
            {
                MessageBox.Show("Ya hay una agenda en ese periodo");
                isValid = false;
            }

            return isValid;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void loadEspecialidades()
        {
            DataTable especialidades = Profession.getByDni(this.dni);
            List<String> options = new List<string>();
            for (int i = 0; i < especialidades.Rows.Count; i++)
            {
                options.Add(especialidades.Rows[i][0].ToString());
            }
            especialidadesCombo.DataSource = options;
        }

        private void AltaHorarios_Load(object sender, EventArgs e)
        {
            DataTable professional = Professional.getProfessionalByDni(this.dni);
              
            labelProfesional.Text = professional.Rows[0]["nombre"].ToString() + " " + professional.Rows[0]["apellido"].ToString();
            loadEspecialidades();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agendas timetables = new Agendas(this.dni);
            timetables.Show();
        }

        private void initializeDatePickerTime(ref DateTimePicker timePicker, ref DateTime prevDate)
        {
            DateTime dt = timePicker.Value;
            timePicker.Value = dt.AddSeconds(-dt.Second);
            timePicker.CustomFormat = "HH:mm";
            timePicker.Format = DateTimePickerFormat.Custom;

            if (dt.Minute % 30 > 15) {
                timePicker.Value = dt.AddMinutes(30 - dt.Minute % 30);
            }
            else
            {
                timePicker.Value = dt.AddMinutes(-(dt.Minute % 30));
            }

            prevDate = timePicker.Value;
        }

        private void updateTimePicker(ref DateTimePicker timePicker, ref DateTime prevDate)
        {

            if (!this.initialized) return;

            DateTime dt = timePicker.Value;
            TimeSpan diff = dt - prevDate;

            if (diff.Ticks < 0  || 
                (prevDate.Minute == 0 && dt.Minute == 59 && prevDate.Hour == dt.Hour))
                timePicker.Value = prevDate.AddMinutes(-30).AddSeconds(-prevDate.Second);
            else
                timePicker.Value = prevDate.AddMinutes(30).AddSeconds(-prevDate.Second);

            prevDate = timePicker.Value;
        }

        private void mondayFrom_ValueChanged(object sender, EventArgs e)
        {
            this.updateTimePicker(ref mondayFrom, ref mondayFromPrev);
        }

        private void mondayTo_ValueChanged(object sender, EventArgs e)
        {
            this.updateTimePicker(ref mondayTo, ref mondayToPrev);
        }

        private void tuesdayFrom_ValueChanged(object sender, EventArgs e)
        {
            this.updateTimePicker(ref tuesdayFrom, ref tuesdayFromPrev);
        }

        private void wednesdayFrom_ValueChanged(object sender, EventArgs e)
        {
            this.updateTimePicker(ref wednesdayFrom, ref wednesdayFromPrev);
        }

        private void thursdayFrom_ValueChanged(object sender, EventArgs e)
        {
            this.updateTimePicker(ref thursdayFrom, ref thursdayFromPrev);
        }

        private void fridayFrom_ValueChanged(object sender, EventArgs e)
        {
            this.updateTimePicker(ref fridayFrom, ref fridayFromPrev);
        }

        private void saturdayFrom_ValueChanged(object sender, EventArgs e)
        {
            this.updateTimePicker(ref saturdayFrom, ref saturdayFromPrev);
        }

        private void tuesdayTo_ValueChanged(object sender, EventArgs e)
        {
            this.updateTimePicker(ref tuesdayTo, ref tuesdayToPrev);
        }

        private void wednesdayTo_ValueChanged(object sender, EventArgs e)
        {
            this.updateTimePicker(ref wednesdayTo, ref wednesdayToPrev);
        }

        private void thursdayTo_ValueChanged(object sender, EventArgs e)
        {
            this.updateTimePicker(ref thursdayTo, ref thursdayToPrev);
        }

        private void fridayTo_ValueChanged(object sender, EventArgs e)
        {
            this.updateTimePicker(ref fridayTo, ref fridayToPrev);
        }

        private void saturdayTo_ValueChanged(object sender, EventArgs e)
        {
            this.updateTimePicker(ref saturdayTo, ref saturdayToPrev);
        }
    }
}
