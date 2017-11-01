using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("COTIZACIONES")]
    public partial class Cotizaciones
    {
        [Column("MONEDA")]
        public short Moneda { get; set; }
        [Column("FECHA")]
        public DateTime Fecha { get; set; }
        [Column("RESPEC")]
        public short? Respec { get; set; }
    }
}
