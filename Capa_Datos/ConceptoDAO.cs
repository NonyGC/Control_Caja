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
    public class ConceptoDAO : BaseDAO
    {
        public DataTable ObtenerConcepto()
        {
            DataTable dtConcepto = new DataTable();
            SqlCommand cmd = CommandProcedure("USP_Concepto_LISTAR");
            dtConcepto = GetDataTable(cmd);
            return dtConcepto;
        }

        public bool RegistrarNuevoConcepto(ConceptoEN conEN)
        {
            try
            {
                int i;
                SqlCommand cmd = CommandProcedure("USP_Documento_REGISTRAR");
                string[] env = { conEN.Descripcion };
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

        public bool ActualizarConcepto(ConceptoEN conEN)
        {
            try
            {
                int i;
                SqlCommand cmd = CommandProcedure("USP_Documento_ACTUALIZAR");
                string[] env = { conEN.ID, conEN.Descripcion };
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
