using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("TALONARIOS")]
    public partial class Talonarios
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("BOCA")]
        public short Boca { get; set; }
        [Column("IMPRIM")]
        public short? Imprim { get; set; }
        [Column("PUERTO")]
        [StringLength(100)]
        public string Puerto { get; set; }
        [Column("COPIAS")]
        public short? Copias { get; set; }
        [Column("PREGUN")]
        public short? Pregun { get; set; }
        [Column("ESTILO")]
        public short Estilo { get; set; }
        [Column("TIPIMP")]
        public short Tipimp { get; set; }
        [Column("NUMTAL")]
        public int? Numtal { get; set; }
        [Column("NOPCOP")]
        public short? Nopcop { get; set; }
        [Column("ELIIMP")]
        public short? Eliimp { get; set; }
        [Column("VISPRE")]
        public short? Vispre { get; set; }
        [Column("LOCAL")]
        public short? Local { get; set; }
        [Column("CONCAE")]
        public short? Concae { get; set; }
        [Column("UNINEG")]
        public short Unineg { get; set; }
        [Column("FECCAI", TypeName = "DATE")]
        public DateTime? Feccai { get; set; }
        [Column("DIACAI")]
        public short? Diacai { get; set; }
        [Column("ULTNUM")]
        public int? Ultnum { get; set; }
    }
}
