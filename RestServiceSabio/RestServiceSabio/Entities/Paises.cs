using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("PAISES")]
    public partial class Paises
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Required]
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("CODAFI")]
        public short? Codafi { get; set; }
        [Column("CUIT")]
        [StringLength(13)]
        public string Cuit { get; set; }
    }
}
