using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DETESTILOSIMPRESION")]
    public partial class Detestilosimpresion
    {
        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("NUMEST")]
        public short Numest { get; set; }
        [Column("TIPLAY")]
        public short Tiplay { get; set; }
        [Column("OCULTA")]
        public short? Oculta { get; set; }
        [Column("XMLLAY", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Xmllay { get; set; }
    }
}
