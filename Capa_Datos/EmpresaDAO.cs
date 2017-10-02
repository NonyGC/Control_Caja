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
    public class EmpresaDAO : BaseDAO
    {
        public DataTable ObtenerEmpresa()
        {
            DataTable dtEmpresa = new DataTable();
            SqlCommand cmd = CommandProcedure("USP_Empresa_LISTAR");
            dtEmpresa = GetDataTable(cmd);
            return dtEmpresa;
        }
        public bool RegistrarEmpresa(EmpresaEN empEN) 
        {
            try
            {
                int i;
                SqlCommand cmd = CommandProcedure("USP_Empresa_REGISTRAR");
                string[] env = { empEN.ruc,empEN.RazonSocial, empEN.Direccion };
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

        public bool ActualizarEmpresa(EmpresaEN empEN)
        {
            try
            {
                int i;
                SqlCommand cmd = CommandProcedure("USP_Empresa_ACTUALIZAR");
                string[] env = { empEN.idEmpresa, empEN.ruc,empEN.RazonSocial,empEN.Direccion };
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

        public bool EliminarEmpresa(string id) 
        {
            try
            {
                int i;
                SqlCommand cmd = CommandProcedure("USP_Empresa_ELIMINAR");
                string[] env = { id };
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
