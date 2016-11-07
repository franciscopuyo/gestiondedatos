using ClinicaFrba.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Listado_Funcionalidad
{
    public partial class ListadoFuncionalidad : Form
    {
        public ListadoFuncionalidad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ListadoFuncionalidad_Load(object sender, EventArgs e)
        {
            String query = "select funcionalidad from  group_by.Rol_Funcionalidades, group_by.Funcionalidades where rol_codigo = {0} and codigo = funcionalidad_codigo";
            query = string.Format(query, Session.role);
            DataTable results = util.Sql.query(query);

            int buttonHeight = 40;
            int buttonWidth = 220;

            for (int i = 0; i < results.Rows.Count; i++)
            {
                Button button = new Button();
                String funcionalidad = results.Rows[i][0].ToString();
                button.Name = funcionalidad;
                button.Text = funcionalidad;
                button.Width = buttonWidth;
                button.Location = new Point((this.Width / 2) - (button.Width / 2), (i * buttonHeight) + 10);
                button.Click += (s, eventE) => { goToAction((Button) s); };
                this.Controls.Add(button);
            }

            this.Height = (results.Rows.Count + 1) * buttonHeight;
        }

        private void goToAction(Button button){
            Form selectedAction = new Form();
            String action = button.Text;
           
            if(action == "Gestionar afiliados"){
                selectedAction = new Abm_Afiliado.List();
            }

            if(action == "Gestionar roles"){
                selectedAction = new Abm_Rol.List();
            }

            if (action == "Comprar bonos")
            {
                if(!Session.isAfiliado()){
                    selectedAction = new Compra_Bono.CompraAdministrativo();
                } else{
                    selectedAction = new Compra_Bono.CompraAfiliado();
                }
            }

            if(action == "Gestionar agendas"){
                if (Session.isProfesional())
                {
                    selectedAction = new Agenda_Medico.Agendas(Session.dni);
                } else { 
                    selectedAction = new Agenda_Medico.ElegirProfesional();
                }
            }

            if(action == "Pedir turno") {
                selectedAction = new Pedir_Turno.PedirTurno();
            }

            if(action == "Registrar llegada para atencion"){
                selectedAction = new Registro_Llegada.RegistroLlegada();
            }

            if(action == "Registrar resultado de atencion"){
                if (Session.isProfesional()) { 
                    selectedAction = new Registrar_Atencion.SeleccionConsulta(Session.dni);
                } else
                {
                    selectedAction = new Registrar_Atenccion.ElegirMedico();
                }
            }

            if(action == "Cancelar atencion") {
                if (Session.isAfiliado())
                {
                    selectedAction = new Cancelar_Turno.Listado(Session.dni);
                } else {
                    selectedAction = new Cancelar_Turno.List();
                }
            }

            if(action == "Listados estadisticos"){
                selectedAction = new Listados.Statistics();
            }

            this.Hide();
            selectedAction.Show();
        }
         
    }
}