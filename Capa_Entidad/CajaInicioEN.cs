using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class CajaInicioEN
    {
        public string ID { get; set; }
        public DateTime Fecha { get; set; }
        public string IDEmpresa { get; set; }
        public int IDDocumento { get; set; }
        public string Serie { get; set; }
        public string Numero { get; set; }
        public decimal Importe { get; set; }
        public byte Estado { get; set; }


    }
}
