using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("PLANES_PRO")]
    public partial class PlanesPro
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("FECHA", TypeName = "DATE")]
        public DateTime? Fecha { get; set; }
        [Column("ESTADO")]
        public short? Estado { get; set; }
        [Column("RESPON")]
        public short? Respon { get; set; }
        [Column("OBSERV")]
        [StringLength(250)]
        public string Observ { get; set; }
    }
}
