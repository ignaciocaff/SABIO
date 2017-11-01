using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DETPRORRATEOS")]
    public partial class Detprorrateos
    {
        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("FECDES", TypeName = "DATE")]
        public DateTime? Fecdes { get; set; }
        [Column("FECHAS", TypeName = "DATE")]
        public DateTime? Fechas { get; set; }
        [Column("CUENTA")]
        [StringLength(12)]
        public string Cuenta { get; set; }
        [Column("CENCOS")]
        public short? Cencos { get; set; }

        [ForeignKey("Cuenta")]
        [InverseProperty("Detprorrateos")]
        public Plancuentas CuentaNavigation { get; set; }
    }
}
