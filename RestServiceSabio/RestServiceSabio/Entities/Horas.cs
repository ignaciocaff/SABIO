using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("HORAS")]
    public partial class Horas
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("PROFES")]
        public short? Profes { get; set; }
        [Column("PROYEC")]
        public int? Proyec { get; set; }
        [Column("DOCUME")]
        public short? Docume { get; set; }
        [Column("FECINI", TypeName = "DATE")]
        public DateTime? Fecini { get; set; }
        [Column("FECFIN", TypeName = "DATE")]
        public DateTime? Fecfin { get; set; }
        [Column("HORINI", TypeName = "TIME")]
        public DateTime? Horini { get; set; }
        [Column("HORFIN", TypeName = "TIME")]
        public DateTime? Horfin { get; set; }
        [Column("FEINSE", TypeName = "DATE")]
        public DateTime? Feinse { get; set; }
        [Column("FEFISE", TypeName = "DATE")]
        public DateTime? Fefise { get; set; }
        [Column("HOINSE", TypeName = "TIME")]
        public DateTime? Hoinse { get; set; }
        [Column("HOFISE", TypeName = "TIME")]
        public DateTime? Hofise { get; set; }
        [Column("ESTADO")]
        [StringLength(10)]
        public string Estado { get; set; }
        [Column("OBSERV")]
        [StringLength(100)]
        public string Observ { get; set; }
    }
}
