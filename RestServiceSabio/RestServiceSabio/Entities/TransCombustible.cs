using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("TRANS_COMBUSTIBLE")]
    public partial class TransCombustible
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
        [Column("NUMCHO")]
        public short? Numcho { get; set; }
        [Column("NUMVEH")]
        public short? Numveh { get; set; }
        [Column("DESTIN")]
        public short? Destin { get; set; }
        [Column("KMS")]
        public int? Kms { get; set; }
        [Column("REGSUR")]
        public int? Regsur { get; set; }
        [Column("OBSERV")]
        [StringLength(250)]
        public string Observ { get; set; }
        [Column("NUMSTK")]
        public int? Numstk { get; set; }
    }
}
