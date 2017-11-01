using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("F_CANALES")]
    public partial class FCanales
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("NOMBRE")]
        [StringLength(80)]
        public string Nombre { get; set; }
    }
}
