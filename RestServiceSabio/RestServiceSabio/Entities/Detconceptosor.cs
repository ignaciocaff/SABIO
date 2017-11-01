using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DETCONCEPTOSOR")]
    public partial class Detconceptosor
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("ORDREP")]
        public int? Ordrep { get; set; }
        [Column("NUMCON")]
        public short? Numcon { get; set; }
        [Column("DESCRI")]
        [StringLength(250)]
        public string Descri { get; set; }
    }
}
