using System;
using System.Collections.Generic;

namespace RestServiceSabio.Model
{
    public class Item
    {
        public String codigoArticulo { get; set; }
        public String descripcion { get; set; }
        public int unidad { get; set; }
        public double cantidad { get; set; }
        public double kilos { get; set; }
        public double puedePickear { get; set; }
        public double saldo { get; set; }
        public List<Serial> seriales { get; set; }
    }

}
