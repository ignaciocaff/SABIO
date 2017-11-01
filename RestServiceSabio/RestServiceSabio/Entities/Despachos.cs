using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DESPACHOS")]
    public partial class Despachos
    {
        [Key]
        [Column("DESPAC")]
        [StringLength(100)]
        public string Despac { get; set; }
        [Column("FECHA", TypeName = "DATE")]
        public DateTime? Fecha { get; set; }
        [Column("OBSERV")]
        [StringLength(200)]
        public string Observ { get; set; }
        [Column("ESTADO")]
        public short Estado { get; set; }
        [Column("PAISOR")]
        public short Paisor { get; set; }
    }
}
