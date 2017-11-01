using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("SERIALES")]
    public partial class Seriales
    {
        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("SERIAL")]
        [StringLength(40)]
        public string Serial { get; set; }
        [Column("CODART")]
        [StringLength(20)]
        public string Codart { get; set; }
        [Column("PROVEE")]
        public int? Provee { get; set; }
        [Column("GTACOM")]
        public short? Gtacom { get; set; }
        [Column("GTAVTA")]
        public short? Gtavta { get; set; }
    }
}
