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
                SqlCommand cmd = CommandText("INSERT INTO [dbo].[Concepto] ([Descripcion]) VALUES (@Descripcion)");
                cmd.Parameters.AddWithValue("@Descripcion",conEN.Descripcion);
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

        public bool EliminarDocumento(ConceptoEN conEN)
        {
            try
            {
                int i;
                SqlCommand cmd = CommandText("DELETE FROM [dbo].[Concepto] WHERE [ID] = @ID");
                cmd.Parameters.AddWithValue("@ID", conEN.ID);
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
                SqlCommand cmd = CommandText("UPDATE [dbo].[Concepto] SET [Descripcion] = @Descripcion WHERE [ID]=@ID");
                cmd.Parameters.AddWithValue("@ID", conEN.ID);
                cmd.Parameters.AddWithValue("@Descripcion", conEN.Descripcion);
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
