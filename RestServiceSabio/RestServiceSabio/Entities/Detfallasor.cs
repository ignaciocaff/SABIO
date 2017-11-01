using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DETFALLASOR")]
    public partial class Detfallasor
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("ORDREP")]
        public int? Ordrep { get; set; }
        [Column("NUMFAL")]
        public short? Numfal { get; set; }
        [Column("DESCRI")]
        [StringLength(250)]
        public string Descri { get; set; }
    }
}
