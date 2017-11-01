using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("LOGREPARTOS")]
    public partial class Logrepartos
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("FECHA", TypeName = "DATE")]
        public DateTime Fecha { get; set; }
        [Column("HORA", TypeName = "TIME")]
        public DateTime Hora { get; set; }
        [Column("USUARI")]
        public short Usuari { get; set; }
        [Column("OBSERV")]
        [StringLength(255)]
        public string Observ { get; set; }
        [Column("ESTADO")]
        public short Estado { get; set; }
    }
}
