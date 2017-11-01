using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DET_LIQUIDACIONES")]
    public partial class DetLiquidaciones
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
        [InverseProperty("DetLiquidaciones")]
        public Detmovcontables Detmovcontables { get; set; }
    }
}
