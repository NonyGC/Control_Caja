using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class ConceptoBL
    {
        ConceptoDAO ConDAO = new ConceptoDAO();

        public DataTable ObtenerConceptoBL() 
        {
            return ConDAO.ObtenerConcepto();
        }

        public bool RegistrarNuevoConcepto(ConceptoEN conEN)
        {
            return ConDAO.RegistrarNuevoConcepto(conEN);
        }

        public bool ActualizarConcepto(ConceptoEN conEN)
        {
            return ConDAO.ActualizarConcepto(conEN); 
        }
    }
}
