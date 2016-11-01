using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.Abm_Afiliado
{
    public class Afiliado
    {
        public String nombre;
        public String apellido;
        public String tipoDocumento;
        public int documento;
        public String direccion;
        public String telefono;
        public String mail;
        public DateTime fechaNacimiento;
        public String sexo;
        public String estadoCivil;
        public int cantidadResponsables;
        public String planMedico;
        public String planMedicoViejo;

        public Afiliado conyugue;
        public List<Afiliado> responsables = new List<Afiliado>();
        public Boolean ingresarProximoResponsable = true;

        public String username;
        public String password;

        private int count = 1;

        private void persistAfiliadoPrincipal(SqlConnection connection)
        {
            String insertAfiliadoPrincipal = "INSERT INTO Afiliados(afiliado_dni, tipo_documento,nro_afiliado,plan_medico_codigo, cantidad_consultas_realizadas) VALUES({0},'{1}',{2},{3},0)";
            insertAfiliadoPrincipal = String.Format(insertAfiliadoPrincipal,
                                                    this.documento,
                                                    this.tipoDocumento,
                                                    this.documento.ToString() + "0" + count.ToString(),
                                                    "(select codigo from Planes_Medicos where descripcion = '" + this.planMedico + "')");
            SqlCommand command = new SqlCommand(insertAfiliadoPrincipal, connection);
            command.ExecuteNonQuery();
            count++;

            persistPersonDetails(connection, this);
        }

        private void persistAfiliadoConyugue(SqlConnection connection)
        {
            if(this.conyugue == null){
                return;
            }

            String insertAfiliadoConyugue = @"INSERT INTO Afiliados(afiliado_dni,tipo_documento, nro_afiliado, afiliado_conyugue,  plan_medico_codigo, cantidad_consultas_realizadas) VALUES({0},'{1}',{2},{3},{4},0)";
            insertAfiliadoConyugue = String.Format(insertAfiliadoConyugue,
                                                    this.conyugue.documento,
                                                    this.conyugue.tipoDocumento,
                                                    this.documento.ToString() + "0" + count.ToString(),
                                                    this.documento.ToString(),
                                                    "(select codigo from Planes_Medicos where descripcion = '" + this.planMedico + "')");
            SqlCommand command = new SqlCommand(insertAfiliadoConyugue, connection);
            command.ExecuteNonQuery();
            count++;

            persistPersonDetails(connection, this.conyugue);
            relateMainWithConyugue(connection, this.conyugue.documento);
        }

        public void persistResponsables(SqlConnection connection)
        {
            foreach(Afiliado responsable in this.responsables)
            {
                String insertAfiliadoConyugue = @"INSERT INTO Afiliados(afiliado_dni, tipo_documento, nro_afiliado, afiliado_responsable, plan_medico_codigo, cantidad_consultas_realizadas) VALUES({0},'{1}',{2},{3},{4},0)";
                insertAfiliadoConyugue = String.Format(insertAfiliadoConyugue,
                                                        responsable.documento,
                                                        responsable.tipoDocumento,
                                                        this.documento.ToString() + "0" + count.ToString(),
                                                        this.documento.ToString(),
                                                        "(select codigo from Planes_Medicos where descripcion = '" + this.planMedico + "')");
                SqlCommand command = new SqlCommand(insertAfiliadoConyugue, connection);
                command.ExecuteNonQuery();
                count++;

                persistPersonDetails(connection, responsable);
            }
        }

        private void relateMainWithConyugue(SqlConnection connection, int conyugue)
        {
            String update = "UPDATE Afiliados SET afiliado_conyugue={0} WHERE nro_afiliado={1}";
            update = String.Format(update, conyugue, this.documento.ToString());
            SqlCommand command = new SqlCommand(update, connection);
            command.ExecuteNonQuery();
        }

        private void persistPersonDetails(SqlConnection connection, Afiliado afiliado)
        {
            String insert = @"INSERT INTO Personas_Detalle(dni,direccion,telefono, mail, nacimiento, sexo,nombre,  apellido,  estado_civil) VALUES({0},'{1}',{2},'{3}','{4}',{5},'{6}','{7}',{8})";

            int sexoInt;
            int estadoCivilInt;

            Type estadosCivil = typeof(EstadoCivil);
            Type sexos = typeof(Sexo);

            sexoInt = int.Parse(Enum.Format(sexos, Enum.Parse(sexos, sexo), "d"));
            estadoCivilInt = int.Parse(Enum.Format(estadosCivil, Enum.Parse(estadosCivil, estadoCivil), "d"));
 
            insert = String.Format(insert, afiliado.documento,
                                            afiliado.direccion,
                                            afiliado.telefono,
                                            afiliado.mail, 
                                            afiliado.fechaNacimiento, 
                                            sexoInt, 
                                            afiliado.nombre, 
                                            afiliado.apellido, 
                                            estadoCivilInt);

            SqlCommand command = new SqlCommand(insert, connection);
            command.ExecuteNonQuery();
        }

        public void persist()
        {
            SqlConnection connection = util.Sql.connect("gd");

            persistAfiliadoPrincipal(connection);
            persistAfiliadoConyugue(connection);
            persistResponsables(connection);

            createAndPersistUser(connection);

            connection.Close();
        }

        private void createAndPersistUser(SqlConnection connection)
        {
            this.password = this.apellido + this.nombre;
            this.username = this.documento.ToString();

            String createUser = "INSERT INTO Usuarios(contrasena, usuario, usuario_dni, activo, cantidad_intentos_login) VALUES({0}, '{1}', {2}, 1, 0)";
            createUser = String.Format(createUser, "HASHBYTES('SHA2_256', '"+ this.password + "')", this.username, this.documento);
            SqlCommand command = new SqlCommand(createUser, connection);
            command.ExecuteNonQuery();

            String assignRole = "INSERT INTO Usuario_Roles(rol_codigo,usuario_dni) VALUES({0}, {1})";
            assignRole = String.Format(assignRole, 2, this.documento);
            command = new SqlCommand(assignRole, connection);
            command.ExecuteNonQuery();
        }

        public static Boolean documentoYaExiste(String documento) 
        {
            String query = "select * from Afiliados where afiliado_dni = {0}";
            query = String.Format(query, documento);
            DataTable dataTable = util.Sql.query(query);
            return dataTable.Rows.Count > 0;
        }



        public static Afiliado GetAfiliado(string documento)
        {
            String query = "select *, (select descripcion from Planes_Medicos where codigo = plan_medico_codigo ) as planMedico from Personas_Detalle,Afiliados where dni = {0}";
            query = String.Format(query, documento);
            DataTable dataTable = util.Sql.query(query);

            Afiliado afiliado = new Afiliado();
            afiliado.nombre = dataTable.Rows[0]["nombre"].ToString();
            afiliado.apellido = dataTable.Rows[0]["apellido"].ToString();
            afiliado.documento = int.Parse(documento);
            afiliado.direccion = dataTable.Rows[0]["direccion"].ToString();
            afiliado.telefono = dataTable.Rows[0]["telefono"].ToString();
            afiliado.mail = dataTable.Rows[0]["mail"].ToString();
            afiliado.fechaNacimiento = Convert.ToDateTime(dataTable.Rows[0]["nacimiento"].ToString());

            Type sexos = typeof(Sexo);
            afiliado.sexo = dataTable.Rows[0]["sexo"].ToString();
            if (afiliado.sexo == "")
            {
                afiliado.sexo = "F";
            }
            afiliado.sexo = Enum.Parse(sexos, afiliado.sexo).ToString();

            Type estadosCivil = typeof(EstadoCivil);
            afiliado.estadoCivil = dataTable.Rows[0]["estado_civil"].ToString();
            if (afiliado.estadoCivil == "")
            {
                afiliado.estadoCivil = "Soltero";
            }
            afiliado.estadoCivil = Enum.Parse(estadosCivil, afiliado.estadoCivil).ToString();

            afiliado.planMedico = dataTable.Rows[0]["planMedico"].ToString();

            afiliado.planMedicoViejo = afiliado.planMedico;
            return afiliado;

        }

        public void update()
        {
            int sexoInt;
            int estadoCivilInt;

            Type estadosCivil = typeof(EstadoCivil);
            Type sexos = typeof(Sexo);

            sexoInt = int.Parse(Enum.Format(sexos, Enum.Parse(sexos, sexo), "d"));
            estadoCivilInt = int.Parse(Enum.Format(estadosCivil, Enum.Parse(estadosCivil, estadoCivil), "d"));

            String update = "UPDATE Personas_Detalle SET nombre='{0}', apellido='{1}', direccion='{2}', telefono={3}, mail='{4}', nacimiento='{5}', sexo={6}, estado_civil={7} WHERE dni={8}";
            update = String.Format(update, this.nombre, this.apellido, this.direccion, this.telefono, this.mail, this.fechaNacimiento, sexoInt, estadoCivilInt, this.documento);

            SqlConnection connection = util.Sql.connect("gd");
            SqlCommand command = new SqlCommand(update, connection);
            command.ExecuteNonQuery();

            connection.Close();
        }

        internal void persitirCambioDePlan(string motivo)
        {
            String insert = "insert into Cambios_De_Plan(plan_viejo, plan_nuevo, fecha, motivo, afiliados_dni) values({0},{1},GETDATE(),'{2}',{3})";
            insert = String.Format(insert, "(select codigo from Planes_Medicos where descripcion = '" + this.planMedicoViejo + "')", "(select codigo from Planes_Medicos where descripcion = '" + this.planMedico + "')", motivo, this.documento);

            SqlConnection connection = util.Sql.connect("gd");
            SqlCommand command = new SqlCommand(insert, connection);
            command.ExecuteNonQuery();

            connection.Close();
        }

        public static void borrar(string dni)
        {
            String update = "update Afiliados set activo = 0 where afiliado_dni = {0}";
            update = String.Format(update, dni);

            SqlConnection connection = util.Sql.connect("gd");
            SqlCommand command = new SqlCommand(update, connection);
            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
