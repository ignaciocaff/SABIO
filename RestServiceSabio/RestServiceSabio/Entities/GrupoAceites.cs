using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("GRUPO_ACEITES")]
    public partial class GrupoAceites
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Required]
        [Column("NOMBRE")]
        [StringLength(100)]
        public string Nombre { get; set; }
    }
}
