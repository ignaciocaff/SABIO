using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("TERCERIZACIONESOR")]
    public partial class Tercerizacionesor
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("ORDREP")]
        public int? Ordrep { get; set; }
        [Column("FECSAL", TypeName = "DATE")]
        public DateTime? Fecsal { get; set; }
        [Column("FECING", TypeName = "DATE")]
        public DateTime? Fecing { get; set; }
        [Column("CUENTA")]
        public int? Cuenta { get; set; }
        [Column("OBSERV")]
        [StringLength(250)]
        public string Observ { get; set; }
    }
}
