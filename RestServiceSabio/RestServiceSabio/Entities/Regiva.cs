using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("REGIVA")]
    public partial class Regiva
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Required]
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("DISIVA")]
        public short? Disiva { get; set; }
        [Column("CODABR")]
        [StringLength(10)]
        public string Codabr { get; set; }
        [Column("IDENTI")]
        public short? Identi { get; set; }
        [Column("CODIVA")]
        public short? Codiva { get; set; }
    }
}
