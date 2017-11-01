using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DETCOMPXSTK")]
    public partial class Detcompxstk
    {
        [Column("DETCOM")]
        public int Detcom { get; set; }
        [Column("DETSTK")]
        public int Detstk { get; set; }
    }
}
