using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("AUTOASIENTO")]
    public partial class Autoasiento
    {
        [Column("UNINEG")]
        public short Unineg { get; set; }
        [Column("COMPRO")]
        [StringLength(3)]
        public string Compro { get; set; }
        [Column("CODIMP")]
        public short Codimp { get; set; }
        [Required]
        [Column("TIPO")]
        [StringLength(1)]
        public string Tipo { get; set; }
        [Required]
        [Column("CUENTA")]
        [StringLength(12)]
        public string Cuenta { get; set; }
        [Column("ORDEN")]
        public short? Orden { get; set; }
        [Column("CENCOS")]
        public short Cencos { get; set; }
        [Column("DEFECT")]
        public short? Defect { get; set; }

        [ForeignKey("Cuenta")]
        [InverseProperty("Autoasiento")]
        public Plancuentas CuentaNavigation { get; set; }
    }
}
