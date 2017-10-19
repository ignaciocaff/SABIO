using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestServiceSabio.Model
{
    public class Comprobante
    {
        public int? numeroPick { get; set; }
        public int orden { get; set; }
        public String observaciones { get; set; }
        public int puedeUsuario { get; set; }
        public List<Item> items { get; set; }
    }
}
