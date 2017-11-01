using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("COMPROXTAL")]
    public partial class Comproxtal
    {
        [Column("COMPRO")]
        [StringLength(3)]
        public string Compro { get; set; }
        [Column("TALONA")]
        public short Talona { get; set; }
        [Required]
        [Column("LETRA", TypeName = "CHAR(1) CHARACTER SET NONE")]
        public string Letra { get; set; }
    }
}
