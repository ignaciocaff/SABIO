using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DET_LIQUIDACIONES_X_MONTO")]
    public partial class DetLiquidacionesXMonto
    {
        [Column("DETREM")]
        public int Detrem { get; set; }
        [Column("ASIENT")]
        public int Asient { get; set; }
        [Column("REGLON")]
        public short Reglon { get; set; }
        [Column("COMLIQ")]
        public int Comliq { get; set; }

        [ForeignKey("Asient,Reglon")]
        [InverseProperty("DetLiquidacionesXMonto")]
        public Detmovcontables Detmovcontables { get; set; }
    }
}
