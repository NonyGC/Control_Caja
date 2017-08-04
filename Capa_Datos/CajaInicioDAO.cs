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
    public class CajaInicioDAO:BaseDAO
    {
        public string ObtenerCodigo()
        {
            string Codigo; 
            SqlCommand cmd = CommandProcedure("USP_CajaInicio_CODIGOAUTOGENERADO");
            Codigo= cmd.ExecuteScalar().ToString();
            // return dtConcepto; 
            return Codigo;
        }

        public bool GuardarNuevaCajaInicio(CajaInicioEN cajaIniEN)
        {
            try
            {
                int i;
                var _ = cajaIniEN;
                SqlCommand cmd = CommandProcedure("USP_CajaInicio_REGISTRAR");
                object[] env = { _.ID,_.Fecha,_.IDEmpresa,_.IDDocumento,_.Serie,_.Numero,_.Importe,_.Estado };
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

        public bool ActualizarCajaInicio(CajaInicioEN cajaIniEN)
        {
            try
            {
                int i;
                var _ = cajaIniEN;
                SqlCommand cmd = CommandProcedure("USP_CajaInicio_ACTUALIZAR");
                object[] env = { _.ID, _.Fecha, _.IDDocumento, _.Serie, _.Numero, _.Importe};
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

        public DataTable ObtenerListadoCajaInicio(string idEmpresa)
        {
            DataTable dtCajaIncio = new DataTable();
            SqlCommand cmd = CommandProcedure("USP_CajaInicio_LISTAR");
            cmd.Parameters.AddWithValue("@IDEmpresa",idEmpresa);
            dtCajaIncio = GetDataTable(cmd);
            return dtCajaIncio;
           
        }
    }
}
