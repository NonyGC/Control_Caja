using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    
    public class EmpresaBL
    {
        EmpresaDAO EmpDao = new EmpresaDAO();

        public DataTable obtenerEmpresa()
        {
            return EmpDao.ObtenerEmpresa();
        }
    }
}
