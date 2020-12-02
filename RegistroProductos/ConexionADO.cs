using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace RegistroProductos
{
    public class ConexionADO
    {
        public String GetCnx()
        {
            String strCnx =
                ConfigurationManager.ConnectionStrings["Data"].ConnectionString;
            if (object.ReferenceEquals(strCnx, String.Empty))
            {
                return String.Empty;
            }
            else
            {
                return strCnx;
            }
        }
    }
}