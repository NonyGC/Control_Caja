using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Telerik.WinControls;

namespace Capa_Datos
{
    public class MoviminetoDAO : BaseDAO
    {
        public decimal obtenerSaldoInicial(string idEmpresa, string Codigo, string fecha)
        {
            SqlCommand cmd = CommandProcedure("USP_CajaInicio_SALDOINICIAL");
            string[] env = { idEmpresa, Codigo, fecha };
            cmd = Parameters(cmd, env);
            return Convert.ToDecimal(cmd.ExecuteScalar().ToString());
        }

        public DataTable obtenerSaldoInicial(string idEmpresa)
        {
            DataTable dtCajaIni = new DataTable();
            SqlCommand cmd = CommandProcedure("USP_Movimineto_CajaInicio_CODIGOCABECERA");
            string[] env = { idEmpresa };
            cmd = Parameters(cmd, env);
            dtCajaIni = GetDataTable(cmd);
            return dtCajaIni;
        }

        public DataTable ObtenerListadoMoviento(string IDCaja)
        {
            DataTable dtMovi = new DataTable();
            SqlCommand cmd = CommandProcedure("[USP_Movimiento_LISTADO]");
            string[] env = { IDCaja };
            cmd = Parameters(cmd, env);
            dtMovi = GetDataTable(cmd);
            return dtMovi;
        }

        public bool AgregarNuevoMovimiento(MovimientoEN movEN)
        {
            try
            {
                int i;
                var _ = movEN;
                SqlCommand cmd = CommandProcedure("USP_Movimiento_REGISTRAR");
                object[] env = { _.IDCaja, _.Concepto, _.Observacion, _.IDDocumento, _.Serie, _.Numero, _.TipoMovimiento, _.Monto };
                cmd = Parameters(cmd, env);
                i = cmd.ExecuteNonQuery();
                return i > 0 ? true : false;
            }
            catch (SqlException ex)
            {
                RadMessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CloseDB();
            }
        }
    }
}
