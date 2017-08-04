using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class EmpresaDAO : BaseDAO
    {
        public DataTable ObtenerEmpresa()
        {
            DataTable dtEmpresa = new DataTable();
            SqlCommand cmd = CommandProcedure("USP_empresa_LISTAR");
            dtEmpresa = GetDataTable(cmd);
            return dtEmpresa;
        }
    }
}
