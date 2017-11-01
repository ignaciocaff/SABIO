using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("TIPO_PAGO")]
    public partial class TipoPago
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Required]
        [Column("NOMBRE")]
        [StringLength(20)]
        public string Nombre { get; set; }
    }
}
