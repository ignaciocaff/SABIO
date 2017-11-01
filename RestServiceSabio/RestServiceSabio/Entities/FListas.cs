using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("F_LISTAS")]
    public partial class FListas
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("NOMBRE")]
        [StringLength(80)]
        public string Nombre { get; set; }
        [Column("CANAL")]
        public int Canal { get; set; }
    }
}
