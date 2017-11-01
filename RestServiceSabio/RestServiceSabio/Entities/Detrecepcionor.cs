using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DETRECEPCIONOR")]
    public partial class Detrecepcionor
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("ORDREP")]
        public int? Ordrep { get; set; }
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("CHEKEA")]
        public short? Chekea { get; set; }
        [Column("DESCRI")]
        [StringLength(250)]
        public string Descri { get; set; }
    }
}
