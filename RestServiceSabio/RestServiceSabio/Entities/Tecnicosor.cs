using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("TECNICOSOR")]
    public partial class Tecnicosor
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("CLAVE")]
        [StringLength(10)]
        public string Clave { get; set; }
        [Column("CANSER")]
        public short? Canser { get; set; }
    }
}
