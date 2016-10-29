using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ClinicaFrba.util;

namespace ClinicaFrba.Model
{
    class Role
    {
        public static DataTable getUserRoles(int dni)
        {
            string posibleRolesQuery = "select * from Roles r join Usuario_Roles ur ON ( ur.rol_codigo = r.codigo) join Usuarios u ON ( u.usuario_dni = ur.usuario_dni) where u.usuario_dni = {0}";
            posibleRolesQuery = String.Format(posibleRolesQuery, Session.dni);
            return Sql.query(posibleRolesQuery);
        }
    }
}
