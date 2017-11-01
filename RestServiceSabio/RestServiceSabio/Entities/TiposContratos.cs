using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("TIPOS_CONTRATOS")]
    public partial class TiposContratos
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("DESCRI", TypeName = "VARCHAR(10240)")]
        public string Descri { get; set; }
        [Column("DEBAJA")]
        public short? Debaja { get; set; }
    }
}
