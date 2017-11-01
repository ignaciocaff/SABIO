using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("ASIXMOVBAN")]
    public partial class Asixmovban
    {
        [Column("ASIENT")]
        public int Asient { get; set; }
        [Column("MOVBAN")]
        public short Movban { get; set; }
        [Column("ASIBAN")]
        public int Asiban { get; set; }
        [Column("REGBAN")]
        public short Regban { get; set; }
    }
}
