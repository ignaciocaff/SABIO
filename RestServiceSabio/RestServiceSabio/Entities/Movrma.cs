using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("MOVRMA")]
    public partial class Movrma
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("NRORMA")]
        public int Nrorma { get; set; }
        [Column("ESTADO")]
        public short? Estado { get; set; }
        [Column("FECHA", TypeName = "DATE")]
        public DateTime? Fecha { get; set; }
        [Column("USUARI")]
        public short? Usuari { get; set; }
        [Column("NOCONT")]
        public int? Nocont { get; set; }
        [Column("OBSERV")]
        [StringLength(250)]
        public string Observ { get; set; }
    }
}
