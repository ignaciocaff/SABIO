using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("REGLASCOMPRO")]
    public partial class Reglascompro
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Required]
        [Column("RESCOM", TypeName = "CHAR(3) CHARACTER SET NONE")]
        public string Rescom { get; set; }
        [Required]
        [Column("CUACOM", TypeName = "CHAR(3) CHARACTER SET NONE")]
        public string Cuacom { get; set; }
        [Column("CTACTE")]
        public int Ctacte { get; set; }
    }
}
