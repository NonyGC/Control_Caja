using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class MovimientoBL
    {
        MoviminetoDAO MovDAO = new MoviminetoDAO();
        public decimal obtenerSaldoInicial(string idEmpresa,string Codigo, string text)
        {
            return MovDAO.obtenerSaldoInicial(idEmpresa, Codigo, text);
        }

        public DataTable cargarDatosDeSaldoInicial(string idEmpresa)
        {
            return MovDAO.obtenerSaldoInicial(idEmpresa);
        }

        public bool AgregarNuevoMovimiento(MovimientoEN movEN)
        {
            return MovDAO.AgregarNuevoMovimiento(movEN);
        }

        public DataTable ObtenerListadoMoviento(string v)
        {
            return MovDAO.ObtenerListadoMoviento(v);
        }
    }
}
