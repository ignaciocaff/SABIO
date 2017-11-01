using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("MOVSERIALESART")]
    public partial class Movserialesart
    {
        [Column("MOVART")]
        public int Movart { get; set; }
        [Column("NROSER")]
        public int Nroser { get; set; }
    }
}
