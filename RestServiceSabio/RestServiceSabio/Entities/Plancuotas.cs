using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("PLANCUOTAS")]
    public partial class Plancuotas
    {
        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("ASIENT")]
        public int Asient { get; set; }
        [Column("CUOTAS")]
        public short? Cuotas { get; set; }
        [Column("OBSERV")]
        [StringLength(250)]
        public string Observ { get; set; }

        [ForeignKey("Asient")]
        [InverseProperty("Plancuotas")]
        public Movcontables AsientNavigation { get; set; }
    }
}
