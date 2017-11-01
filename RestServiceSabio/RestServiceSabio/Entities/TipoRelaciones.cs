using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("TIPO_RELACIONES")]
    public partial class TipoRelaciones
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("ORDTAB")]
        public short? Ordtab { get; set; }
        [Column("ORIDAT")]
        [StringLength(40)]
        public string Oridat { get; set; }
        [Column("CAPPRO")]
        [StringLength(40)]
        public string Cappro { get; set; }
        [Column("CAPSOL")]
        [StringLength(40)]
        public string Capsol { get; set; }
        [Column("CAPRES")]
        [StringLength(40)]
        public string Capres { get; set; }
        [Column("TIPCUE")]
        public short? Tipcue { get; set; }
    }
}
