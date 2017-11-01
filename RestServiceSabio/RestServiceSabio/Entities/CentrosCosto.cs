using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("CENTROS_COSTO")]
    public partial class CentrosCosto
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("DESHAB")]
        public short? Deshab { get; set; }
        [Column("UNINEG")]
        public short Unineg { get; set; }
    }
}
