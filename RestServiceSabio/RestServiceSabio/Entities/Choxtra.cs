using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("CHOXTRA")]
    public partial class Choxtra
    {
        [Column("NUMTRA")]
        public int Numtra { get; set; }
        [Column("NUMCHO")]
        public short Numcho { get; set; }
    }
}
