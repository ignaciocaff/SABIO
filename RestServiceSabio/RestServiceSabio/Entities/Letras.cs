using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("LETRAS")]
    public partial class Letras
    {
        [Column("EMITE")]
        public short Emite { get; set; }
        [Column("RECIBE")]
        public short Recibe { get; set; }
        [Required]
        [Column("LETRA", TypeName = "CHAR(1) CHARACTER SET NONE")]
        public string Letra { get; set; }
    }
}
