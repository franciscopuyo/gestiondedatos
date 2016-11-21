using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ClinicaFrba.util
{
    class Date
    {
        public static string getDate()
        {
            return ConfigurationManager.AppSettings["fechaDelSistema"];
        }
        
        public static DateTime getDateTime()
        {
            return DateTime.ParseExact(getDate(), "yyyy-MM-dd HH:mm:ss.fff",
                                       System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
