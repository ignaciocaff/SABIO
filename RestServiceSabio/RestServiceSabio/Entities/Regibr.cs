using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("REGIBR")]
    public partial class Regibr
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Required]
        [Column("NOMBRE")]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Column("CALNET")]
        public short? Calnet { get; set; }
    }
}
