using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("TRANS_CISTERNA")]
    public partial class TransCisterna
    {
        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("FECHA", TypeName = "DATE")]
        public DateTime? Fecha { get; set; }
        [Column("HORA", TypeName = "TIME")]
        public DateTime? Hora { get; set; }
        [Column("SURTID")]
        public short? Surtid { get; set; }
        [Column("REGSUR")]
        public int? Regsur { get; set; }
        [Column("OBSERV")]
        [StringLength(250)]
        public string Observ { get; set; }
    }
}
