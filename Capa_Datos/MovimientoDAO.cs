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

        public bool AgregarNuevoCajaCierre(CajaCierre cajCEN)
        {
            try
            {
                int i;
                var _ = cajCEN;
                SqlCommand cmd = CommandProcedure("USP_CajaCierre_REGISTRAR");
                object[] env = { _.id,_.Empresa, _.SaldoIncial, _.TotalIngreso, _.TotalEgreso, _.SaldoFinal, _.Observacion };
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


        public DataTable cargarDatosDeCabeceraReporte(string iDCaja)
        {
            DataTable dtCabecera = new DataTable();
            SqlCommand cmd = CommandProcedure("USP_Movimiento_REPORTE_CABECERA");
            cmd.Parameters.AddWithValue("@IDCaja", iDCaja);
            dtCabecera = GetDataTable(cmd);
            return dtCabecera;
        } 

        public bool EliminarMovimento(MovimientoEN movEN)
        {
            try
            {
                int i;
                SqlCommand cmd = CommandProcedure("USP_Movimiento_ELIMINAR");
                cmd.Parameters.AddWithValue("@IdMov", movEN.IdMov);
                cmd.Parameters.AddWithValue("@IDCaja", movEN.IDCaja);
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

        public bool actualizarMovimiento(MovimientoEN movEN)
        {
            try
            {
                int i;
                var _ = movEN;
                SqlCommand cmd = CommandProcedure("USP_Movimiento_ACTUALIZAR");
                object[] env = { _.IdMov,_.IDCaja, _.Concepto, _.Observacion, _.IDDocumento, _.Serie, _.Numero, _.TipoMovimiento, _.Monto };
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

        public bool ActualizarEtadoCaja(string idCajaInicio)
        {
            try
            {
                int i;
                SqlCommand cmd = CommandText("UPDATE [dbo].[CajaInicio]  SET [Estado] = '1' WHERE [ID]=@id");
                cmd.Parameters.AddWithValue("@id", idCajaInicio);
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
