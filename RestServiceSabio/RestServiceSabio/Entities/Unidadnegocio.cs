using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("UNIDADNEGOCIO")]
    public partial class Unidadnegocio
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Required]
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("EMPRES")]
        public short Empres { get; set; }
        [Required]
        [Column("CTACOS")]
        [StringLength(12)]
        public string Ctacos { get; set; }
    }
}
