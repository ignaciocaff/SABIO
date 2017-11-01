using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("MOV_RELACIONES")]
    public partial class MovRelaciones
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("TIPREL")]
        public short? Tiprel { get; set; }
        [Column("CUENTA")]
        public int? Cuenta { get; set; }
        [Column("ESTADO")]
        public short? Estado { get; set; }
        [Column("FECALT", TypeName = "DATE")]
        public DateTime? Fecalt { get; set; }
        [Column("HORALT", TypeName = "TIME")]
        public DateTime? Horalt { get; set; }
        [Column("DESPRO")]
        [StringLength(250)]
        public string Despro { get; set; }
        [Column("FECVEN", TypeName = "DATE")]
        public DateTime? Fecven { get; set; }
        [Column("HORVEN", TypeName = "TIME")]
        public DateTime? Horven { get; set; }
        [Column("DESSOL")]
        [StringLength(250)]
        public string Dessol { get; set; }
        [Column("RESPON")]
        public short? Respon { get; set; }
        [Column("FECREA", TypeName = "DATE")]
        public DateTime? Fecrea { get; set; }
        [Column("HORREA", TypeName = "TIME")]
        public DateTime? Horrea { get; set; }
        [Column("NUMMOT")]
        public short Nummot { get; set; }
        [Column("PAGO")]
        public short? Pago { get; set; }
        [Column("USUARI")]
        public short Usuari { get; set; }
    }
}
