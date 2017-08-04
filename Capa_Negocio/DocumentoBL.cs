using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class DocumentoBL
    {
        DocumentoDAO DocDAO = new DocumentoDAO();

        public DataTable ObtenerTipoDocumentoBL()
        {
            return DocDAO.ObtenerTipoDocumento();
        }

        public bool RegistrarNuevoDocumento(DocumentoEN docEN)
        {
            return DocDAO.RegistrarNuevoDocumento(docEN);
        }

        public bool ActualizarDocumento(DocumentoEN docEN)
        {
            return DocDAO.ActualizarDocumento(docEN);
        }

        public bool EliminarDocumento(DocumentoEN docEN)
        {
            return DocDAO.EliminarDocumento(docEN);
        }
    }
}
