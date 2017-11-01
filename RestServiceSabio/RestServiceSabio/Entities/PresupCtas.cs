using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("PRESUP_CTAS")]
    public partial class PresupCtas
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("CENCOS")]
        public short Cencos { get; set; }
        [Required]
        [Column("CUENTA")]
        [StringLength(12)]
        public string Cuenta { get; set; }
        [Column("FECDES", TypeName = "DATE")]
        public DateTime? Fecdes { get; set; }
        [Column("FECHAS", TypeName = "DATE")]
        public DateTime? Fechas { get; set; }

        [ForeignKey("Cuenta")]
        [InverseProperty("PresupCtas")]
        public Plancuentas CuentaNavigation { get; set; }
    }
}
