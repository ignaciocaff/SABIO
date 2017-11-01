using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("PICKING")]
    public partial class Picking
    {
        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("ORDEN")]
        public int? Orden { get; set; }
        [Column("ESTADO")]
        public int? Estado { get; set; }
        [Column("FECHA", TypeName = "DATE")]
        public DateTime? Fecha { get; set; }
        [Column("HORA", TypeName = "TIME")]
        public DateTime? Hora { get; set; }
        [Column("OBSERV")]
        [StringLength(100)]
        public string Observ { get; set; }
    }
}
