using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("TIPOMONEDAS")]
    public partial class Tipomonedas
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("NUMMON")]
        public short Nummon { get; set; }
        [Column("TIPO")]
        public short Tipo { get; set; }
    }
}
