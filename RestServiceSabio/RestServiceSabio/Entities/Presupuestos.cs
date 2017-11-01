using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("PRESUPUESTOS")]
    public partial class Presupuestos
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("FECHA", TypeName = "DATE")]
        public DateTime? Fecha { get; set; }
        [Column("ESTADO")]
        public short? Estado { get; set; }
        [Column("PROYEC")]
        public int? Proyec { get; set; }
        [Column("FEULMO", TypeName = "DATE")]
        public DateTime? Feulmo { get; set; }
        [Column("CUENTA")]
        public int? Cuenta { get; set; }
    }
}
