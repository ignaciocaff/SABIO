using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("OBRAS")]
    public partial class Obras
    {
        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("CUENTA")]
        public int Cuenta { get; set; }
        [Required]
        [Column("DESCRI")]
        [StringLength(40)]
        public string Descri { get; set; }
        [Column("LISPRE")]
        public short? Lispre { get; set; }
        [Column("DIAVEN")]
        public short? Diaven { get; set; }
        [Column("FECVEN", TypeName = "DATE")]
        public DateTime? Fecven { get; set; }
        [Column("OBSERV")]
        [StringLength(100)]
        public string Observ { get; set; }
        [Column("DEPOSI")]
        public short Deposi { get; set; }
    }
}
