using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;

namespace Capa_Negocio
{
    public class CajaCierreBL
    {
        CajaCierreDAO CCierreDAO = new CajaCierreDAO();
        public DataTable obtenerListadoCajaCerrado(string idEmpresa)
        {
           return CCierreDAO.obtenerListadoCajaCerrado(idEmpresa);
        }
    }
}
