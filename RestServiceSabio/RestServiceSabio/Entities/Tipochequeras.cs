using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("TIPOCHEQUERAS")]
    public partial class Tipochequeras
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Required]
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("ORIENT")]
        public short? Orient { get; set; }
        [Column("TIPHOJ")]
        public short? Tiphoj { get; set; }
        [Column("HLEFT")]
        public float? Hleft { get; set; }
        [Column("HRIGHT")]
        public float? Hright { get; set; }
        [Column("HTOP")]
        public float? Htop { get; set; }
        [Column("HBOTTO")]
        public float? Hbotto { get; set; }
        [Column("XMLLAY", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Xmllay { get; set; }
    }
}
