using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DET_CONTRATOS")]
    public partial class DetContratos
    {
        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("NUMCON")]
        public int? Numcon { get; set; }
        [Column("DESDE")]
        public short? Desde { get; set; }
        [Column("HASTA")]
        public short? Hasta { get; set; }
        [Column("CODART")]
        [StringLength(20)]
        public string Codart { get; set; }
        [Column("DESCRI")]
        [StringLength(250)]
        public string Descri { get; set; }
        [Column("FORMUL")]
        [StringLength(100)]
        public string Formul { get; set; }
    }
}
