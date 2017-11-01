using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("PLANTRAN")]
    public partial class Plantran
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("TABLA")]
        [StringLength(20)]
        public string Tabla { get; set; }
        [Column("PRESUP")]
        public short? Presup { get; set; }
        [Column("CODIGO")]
        [StringLength(20)]
        public string Codigo { get; set; }
        [Column("DESTIN")]
        public short? Destin { get; set; }
        [Column("ACCION")]
        [StringLength(10)]
        public string Accion { get; set; }
        [Column("FORANE")]
        public short? Forane { get; set; }
        [Column("PARADO")]
        public short? Parado { get; set; }
        [Column("DESCRI")]
        [StringLength(40)]
        public string Descri { get; set; }
        [Column("PTOVTA")]
        public short? Ptovta { get; set; }
        [Column("FECNOV")]
        public DateTime? Fecnov { get; set; }
        [Column("OBSERV", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Observ { get; set; }
    }
}
