using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("MOVVENTAS")]
    public partial class Movventas
    {
        [Column("ASIENT")]
        public int Asient { get; set; }
        [Column("VENDED")]
        public short Vended { get; set; }

        [ForeignKey("Asient")]
        [InverseProperty("Movventas")]
        public Movcontables AsientNavigation { get; set; }
    }
}
