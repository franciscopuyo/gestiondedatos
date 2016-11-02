using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ClinicaFrba.util;
using System.Windows.Forms;

namespace ClinicaFrba.Abm_Rol
{
    class Role
    {
        public static DataTable getUserRoles(int dni)
        {
            string query = "select * from Roles r join Usuario_Roles ur ON ( ur.rol_codigo = r.codigo) join Usuarios u ON ( u.usuario_dni = ur.usuario_dni) where u.usuario_dni = {0} and r.activo = 1";
            query = String.Format(query, Session.dni);
            return Sql.query(query);
        }

        public static DataTable getRolesToTable()
        {
            string query = "select codigo, descripcion, 'Editar' as Editar, 'Borrar' as Borrar from Roles where activo = 1";
            return Sql.query(query);
        }

        public static DataTable getFunctionalityByRole(int roleCode)
        {
            string query = "select *, CASE WHEN EXISTS(select * from Rol_Funcionalidades where rol_codigo = {0} and funcionalidad_codigo = Funcionalidades.codigo) THEN 1 ELSE 0 END as habilitada from Funcionalidades";
            query = String.Format(query, roleCode);
            return Sql.query(query);
        }

        public static void update(string description, IEnumerable<ComboBoxItem> functionalities, int roleCode)
        {
            string query = "update Roles set descripcion = '{0}' where codigo = {1}";
            query = String.Format(query, description, roleCode);
            Sql.update(query);
            Role.updateFunctionalities(roleCode, functionalities);
        }

        public static void create(string description, IEnumerable<ComboBoxItem> functionalities)
        {
            string query = "insert into Roles (descripcion, activo) values ('{0}', 1)";
            query = String.Format(query, description);
            Sql.update(query);
            DataTable lastRoleCreated = Sql.query("SELECT IDENT_CURRENT('Roles')");
            int roleCode = Int32.Parse(lastRoleCreated.Rows[0][0].ToString());
            Role.updateFunctionalities(roleCode, functionalities);
        }

        public static void updateFunctionalities(int roleCode, IEnumerable<ComboBoxItem> functionalities)
        {
            string query = "delete from Rol_Funcionalidades where rol_codigo = {0}";
            query = String.Format(query, roleCode);
            Sql.update(query);

            foreach (var functionality in functionalities)
            {
                query = "insert into Rol_Funcionalidades (rol_codigo, funcionalidad_codigo) VALUES ({0}, {1})";
                query = String.Format(query, roleCode, functionality.Value);
                Sql.query(query);
            }
        }

        public static void remove(int roleCode)
        {
            String query = "update Roles set activo = 0 where codigo = {0}";
            query = String.Format(query, roleCode);
            Sql.update(query);
        }
    }
}
