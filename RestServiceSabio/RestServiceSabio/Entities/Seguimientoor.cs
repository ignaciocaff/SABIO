using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("SEGUIMIENTOOR")]
    public partial class Seguimientoor
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("ORDREP")]
        public int Ordrep { get; set; }
        [Column("FECHA", TypeName = "DATE")]
        public DateTime Fecha { get; set; }
        [Column("HORA", TypeName = "TIME")]
        public DateTime Hora { get; set; }
        [Column("USUARI")]
        public short Usuari { get; set; }
        [Required]
        [Column("DESCRI")]
        [StringLength(250)]
        public string Descri { get; set; }
    }
}
