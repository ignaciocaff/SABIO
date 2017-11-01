using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("MONTOS_X_CUENTA")]
    public partial class MontosXCuenta
    {
        [Key]
        [Column("CTACTE")]
        public int Ctacte { get; set; }
        [Column("OBSERV")]
        [StringLength(100)]
        public string Observ { get; set; }
    }
}
