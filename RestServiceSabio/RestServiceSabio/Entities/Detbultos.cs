using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DETBULTOS")]
    public partial class Detbultos
    {
        [Column("NUMBUL")]
        public int Numbul { get; set; }
        [Column("NUMDET")]
        public int Numdet { get; set; }
    }
}
