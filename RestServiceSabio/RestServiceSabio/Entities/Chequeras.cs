using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("CHEQUERAS")]
    public partial class Chequeras
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("CUENTA")]
        public short Cuenta { get; set; }
        [Column("DESDE")]
        public int Desde { get; set; }
        [Column("HASTA")]
        public int Hasta { get; set; }
        [Column("TIPO")]
        public short Tipo { get; set; }
        [Column("ANULAD")]
        public DateTime? Anulad { get; set; }
    }
}
