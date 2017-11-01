using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DETPLANCUOTAS")]
    public partial class Detplancuotas
    {
        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("NUMPLA")]
        public int Numpla { get; set; }
        [Column("NUMCUO")]
        public short? Numcuo { get; set; }
        [Column("FECVEN", TypeName = "DATE")]
        public DateTime? Fecven { get; set; }
    }
}
