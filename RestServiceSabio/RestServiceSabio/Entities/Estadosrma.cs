using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("ESTADOSRMA")]
    public partial class Estadosrma
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("COMPRO", TypeName = "CHAR(3) CHARACTER SET NONE")]
        public string Compro { get; set; }
        [Column("DEPOSI")]
        public short? Deposi { get; set; }
    }
}
