using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("CODBANCOS")]
    public partial class Codbancos
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Required]
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Required]
        [Column("SIGNO")]
        [StringLength(1)]
        public string Signo { get; set; }
        [Required]
        [Column("CUENTA")]
        [StringLength(12)]
        public string Cuenta { get; set; }
        [Column("SISTEM")]
        public short? Sistem { get; set; }
        [Column("AFEIVA")]
        public short? Afeiva { get; set; }
        [Column("CONTRA")]
        public short? Contra { get; set; }
        [Column("PERCEP")]
        public short? Percep { get; set; }
        [Column("LIBIVA")]
        public short? Libiva { get; set; }

        [ForeignKey("Cuenta")]
        [InverseProperty("Codbancos")]
        public Plancuentas CuentaNavigation { get; set; }
    }
}
