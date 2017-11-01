using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("VEHXTRA")]
    public partial class Vehxtra
    {
        [Column("NUMTRA")]
        public int Numtra { get; set; }
        [Column("NUMVEH")]
        public short Numveh { get; set; }
    }
}
