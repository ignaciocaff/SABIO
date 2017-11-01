using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("MONEDAS")]
    public partial class Monedas
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Required]
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("SIMBOL")]
        [StringLength(10)]
        public string Simbol { get; set; }
        [Column("CODIVA")]
        [StringLength(10)]
        public string Codiva { get; set; }
    }
}
