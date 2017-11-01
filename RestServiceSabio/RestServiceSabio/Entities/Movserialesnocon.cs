using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("MOVSERIALESNOCON")]
    public partial class Movserialesnocon
    {
        [Column("NOCONT")]
        public int Nocont { get; set; }
        [Column("NROSER")]
        public int Nroser { get; set; }
    }
}
