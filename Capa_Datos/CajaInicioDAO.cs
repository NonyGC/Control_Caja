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
    public class CajaInicioDAO : BaseDAO
    {


        public bool GuardarNuevaCajaInicio(CajaInicioEN cajaIniEN)
        {
            try
            {
                int i;
                var _ = cajaIniEN;
                SqlCommand cmd = CommandProcedure("USP_CajaInicio_REGISTRAR");
                object[] env = { _.ID, _.Fecha, _.IDEmpresa, _.IDDocumento, _.Serie, _.Numero, _.Importe, _.Estado };
                cmd = Parameters(cmd, env);
                i = cmd.ExecuteNonQuery();
                return i > 0 ? true : false;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    RadMessageBox.Show("Inicio de Caja mas de una vez por dia NO PERMITIDO","",System.Windows.Forms.MessageBoxButtons.OK,RadMessageIcon.Error);
                }
                //else
                {
                    RadMessageBox.Show(ex.Message);
                }
                return false;
            }
            finally
            {
                CloseDB();
            }
        }
        public string ObtenerCodigo()
        {
            string Codigo;
            SqlCommand cmd = CommandProcedure("USP_CajaInicio_CODIGOAUTOGENERADO");
            Codigo = cmd.ExecuteScalar().ToString();
            return Codigo;
        }

        public bool EliminarCajaInicio(CajaInicioEN cajaIniEN, string idEmpresa)
        {
            try
            {
                int i = 0;
                SqlCommand cmd = CommandProcedure("USP_CajaCierre_ELIMINAR");
                cmd.Parameters.AddWithValue("@IDCAJA", cajaIniEN.ID);
                cmd.Parameters.AddWithValue("@IDEmpresa", idEmpresa);
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
                object[] env = { _.ID, _.Fecha, _.IDDocumento, _.Serie, _.Numero, _.Importe };
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
            cmd.Parameters.AddWithValue("@IDEmpresa", idEmpresa);
            dtCajaIncio = GetDataTable(cmd);
            return dtCajaIncio;

        }
    }
}
