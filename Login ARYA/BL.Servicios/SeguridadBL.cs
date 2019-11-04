using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Servicios
{
    public class SeguridadBL
    {
        public bool Autorizar(string usuario, string contrasena)
        {
            if ((usuario == "admin" && contrasena == "123") || (usuario == "general" && contrasena == "456"))
            {
                return true;

            }
            else
            {
                if ((usuario == "admin" && contrasena == "123") || (usuario == "general" && contrasena == "456"))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
