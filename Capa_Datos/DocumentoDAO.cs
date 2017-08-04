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
    public class DocumentoDAO : BaseDAO
    {
        public DataTable ObtenerTipoDocumento()
        {
            DataTable dtTipDocumento = new DataTable();
            SqlCommand cmd = CommandProcedure("USP_Documento_LISTAR");
            dtTipDocumento = GetDataTable(cmd);
            return dtTipDocumento;
        }

        public bool RegistrarNuevoDocumento(DocumentoEN docEN)
        {
            try
            {
                int i;
                SqlCommand cmd = CommandProcedure("USP_Documento_REGISTRAR");
                string[] env = { docEN.NroComprobante, docEN.DescripcionComprobante };
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

        public bool EliminarDocumento(DocumentoEN docEN)
        {
            try
            {
                int i;
                SqlCommand cmd = CommandProcedure("USP_Documento_ELIMINAR");
                string[] env = { docEN.ID };
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

        public bool ActualizarDocumento(DocumentoEN docEN)
        {
            try
            {
                int i;
                SqlCommand cmd = CommandProcedure("USP_Documento_ACTUALIZAR");
                string[] env = { docEN.ID, docEN.NroComprobante, docEN.DescripcionComprobante };
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
