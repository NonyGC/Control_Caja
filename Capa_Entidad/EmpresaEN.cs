using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class EmpresaEN
    {
        static string _idEmpresa ;
        static string _RazonSocial ;
        public static string idEmpresa 
        {
            get { return _idEmpresa; }
            set { _idEmpresa = value; }
        }
        public static string RazonSocial
        {
            get { return _RazonSocial; }
            set { _RazonSocial = value; }
        }
    }
}
