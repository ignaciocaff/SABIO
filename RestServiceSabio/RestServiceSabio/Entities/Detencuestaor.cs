using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DETENCUESTAOR")]
    public partial class Detencuestaor
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("ORDREP")]
        public int Ordrep { get; set; }
        [Column("NUMPRE")]
        public short Numpre { get; set; }
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("RESPUE")]
        public short? Respue { get; set; }
    }
}
