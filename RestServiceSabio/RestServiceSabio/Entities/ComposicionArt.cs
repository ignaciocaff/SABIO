using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("COMPOSICION_ART")]
    public partial class ComposicionArt
    {
        [Column("CODART")]
        [StringLength(20)]
        public string Codart { get; set; }
        [Column("NUMPRO")]
        public short Numpro { get; set; }
        [Column("CODINS")]
        [StringLength(20)]
        public string Codins { get; set; }
        [Column("OPCION")]
        public short? Opcion { get; set; }
        [Column("FORMUL")]
        [StringLength(250)]
        public string Formul { get; set; }
        [Column("SUMPRE")]
        public short? Sumpre { get; set; }
    }
}
