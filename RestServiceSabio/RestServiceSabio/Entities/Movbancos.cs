using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("MOVBANCOS")]
    public partial class Movbancos
    {
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("FECHA")]
        public DateTime Fecha { get; set; }
        [Column("FECVEN")]
        public DateTime? Fecven { get; set; }
        [Column("TIPMOV")]
        public short Tipmov { get; set; }
        [Column("ASIENT")]
        public int Asient { get; set; }
        [Column("REGLON")]
        public short Reglon { get; set; }
        [Column("OBSERV")]
        [StringLength(50)]
        public string Observ { get; set; }
        [Column("NROCOM")]
        [StringLength(20)]
        public string Nrocom { get; set; }
        [Column("MESCON")]
        public short? Mescon { get; set; }
        [Column("ANICON")]
        public short? Anicon { get; set; }
        [Column("FECCON", TypeName = "DATE")]
        public DateTime? Feccon { get; set; }
        [Column("EXTCON")]
        [StringLength(40)]
        public string Extcon { get; set; }

        [ForeignKey("Numero")]
        [InverseProperty("Movbancos")]
        public Cuebancos NumeroNavigation { get; set; }
    }
}
