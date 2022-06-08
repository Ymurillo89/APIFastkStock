using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIFastkStock.Models.ViewModels
{
    public class GetProveedores
    {
        public int idNit { get; set; }
        public string strNombre { get; set; }
        public long bigintTelefono { get; set; }
        public long bigintMovil { get; set; }
        public long bigintC_Bancaria { get; set; }
    }
}
