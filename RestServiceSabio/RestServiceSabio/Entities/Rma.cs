using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("RMA")]
    public partial class Rma
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("NROSER")]
        public int Nroser { get; set; }
        [Column("DEFECT")]
        public short? Defect { get; set; }
        [Column("TECNIC")]
        public short? Tecnic { get; set; }
        [Column("RECONO")]
        public short? Recono { get; set; }
        [Column("ASIVTA")]
        public int? Asivta { get; set; }
        [Column("REGVTA")]
        public short? Regvta { get; set; }
        [Column("ASICOM")]
        public int? Asicom { get; set; }
        [Column("REGCOM")]
        public short? Regcom { get; set; }
        [Column("NOCCOM")]
        public int? Noccom { get; set; }
        [Column("RECHAZ")]
        public short? Rechaz { get; set; }
        [Column("NOCVTA")]
        public int? Nocvta { get; set; }
        [Column("FECANU", TypeName = "DATE")]
        public DateTime? Fecanu { get; set; }
    }
}
