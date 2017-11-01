using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("TIPOCUENTA")]
    public partial class Tipocuenta
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Required]
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("ESDEUD")]
        public short? Esdeud { get; set; }
        [Column("CUENTA")]
        [StringLength(12)]
        public string Cuenta { get; set; }

        [ForeignKey("Cuenta")]
        [InverseProperty("Tipocuenta")]
        public Plancuentas CuentaNavigation { get; set; }
    }
}
