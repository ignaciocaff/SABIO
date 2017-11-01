using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("ESTADOS_LOGREPARTOS")]
    public partial class EstadosLogrepartos
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Required]
        [Column("NOMBRE")]
        [StringLength(50)]
        public string Nombre { get; set; }
    }
}
