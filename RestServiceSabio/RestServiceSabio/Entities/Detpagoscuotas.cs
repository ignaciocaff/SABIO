using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DETPAGOSCUOTAS")]
    public partial class Detpagoscuotas
    {
        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("NUMCUO")]
        public int Numcuo { get; set; }
        [Column("ASIENT")]
        public int Asient { get; set; }
        [Column("FECHA", TypeName = "DATE")]
        public DateTime? Fecha { get; set; }

        [ForeignKey("Asient")]
        [InverseProperty("Detpagoscuotas")]
        public Movcontables AsientNavigation { get; set; }
    }
}
