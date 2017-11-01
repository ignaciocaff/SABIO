using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("NOCONXCON")]
    public partial class Noconxcon
    {
        [Column("NUMNCO")]
        public int Numnco { get; set; }
        [Column("NUMCON")]
        public int Numcon { get; set; }
    }
}
