using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DET_LIQUIDACIONES_ANUL")]
    public partial class DetLiquidacionesAnul
    {
        [Column("DETREM")]
        public int Detrem { get; set; }
        [Column("COMLIQ")]
        public int Comliq { get; set; }
    }
}
