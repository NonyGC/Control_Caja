using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class CajaCierreDAO : BaseDAO
    {
        public DataTable obtenerListadoCajaCerrado(string idEmpresa)
        {
            DataTable dtCajaCierre = new DataTable();
            SqlCommand cmd = CommandProcedure("USP_CajaCierre_LISTAR");
            cmd.Parameters.AddWithValue("@IDEmpresa", idEmpresa);
            dtCajaCierre = GetDataTable(cmd);
            return dtCajaCierre;
        }
    }
}
