using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("NEGO_NOCON")]
    public partial class NegoNocon
    {
        [Column("NEGOCI")]
        public int Negoci { get; set; }
        [Column("NOCONT")]
        public int Nocont { get; set; }
    }
}
