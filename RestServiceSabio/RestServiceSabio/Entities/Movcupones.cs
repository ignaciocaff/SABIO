using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("MOVCUPONES")]
    public partial class Movcupones
    {
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("ASIENT")]
        public int Asient { get; set; }
        [Column("REGLON")]
        public short Reglon { get; set; }
        [Column("ESTADO")]
        public short Estado { get; set; }
        [Column("FECHA", TypeName = "DATE")]
        public DateTime? Fecha { get; set; }
        [Column("CAJA")]
        public int Caja { get; set; }

        [ForeignKey("Numint")]
        [InverseProperty("Movcupones")]
        public Cupones NumintNavigation { get; set; }
    }
}
