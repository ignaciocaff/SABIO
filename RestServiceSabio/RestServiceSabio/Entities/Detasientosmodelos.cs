using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DETASIENTOSMODELOS")]
    public partial class Detasientosmodelos
    {
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("REGLON")]
        public short Reglon { get; set; }
        [Required]
        [Column("CUENTA")]
        [StringLength(12)]
        public string Cuenta { get; set; }
        [Required]
        [Column("TIPO")]
        [StringLength(1)]
        public string Tipo { get; set; }
        [Column("OBSERV")]
        [StringLength(50)]
        public string Observ { get; set; }
        [Column("CENCOS")]
        public short Cencos { get; set; }

        [ForeignKey("Cuenta")]
        [InverseProperty("Detasientosmodelos")]
        public Plancuentas CuentaNavigation { get; set; }
        [ForeignKey("Numero")]
        [InverseProperty("Detasientosmodelos")]
        public Asientosmodelos NumeroNavigation { get; set; }
    }
}
