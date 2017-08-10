using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class CajaCierre
    {
        public string id;

        public string Empresa { get; set; }
        public string Observacion { get; set; }
        public decimal SaldoFinal { get; set; }
        public decimal SaldoIncial { get; set; }
        public decimal TotalEgreso { get; set; }
        public decimal TotalIngreso { get; set; }
    }
}
