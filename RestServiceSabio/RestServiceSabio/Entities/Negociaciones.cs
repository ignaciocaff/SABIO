using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("NEGOCIACIONES")]
    public partial class Negociaciones
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("CODART")]
        [StringLength(20)]
        public string Codart { get; set; }
        [Column("FECINI", TypeName = "DATE")]
        public DateTime? Fecini { get; set; }
        [Column("HORINI", TypeName = "TIME")]
        public DateTime? Horini { get; set; }
        [Column("FECFIN", TypeName = "DATE")]
        public DateTime? Fecfin { get; set; }
        [Column("HORFIN", TypeName = "TIME")]
        public DateTime? Horfin { get; set; }
        [Column("AUTORI")]
        public int? Autori { get; set; }
        [Column("ENVIAD")]
        public short? Enviad { get; set; }
    }
}
