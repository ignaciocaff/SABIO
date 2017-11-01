using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DETPLANESXSTK")]
    public partial class Detplanesxstk
    {
        [Column("DETPLA")]
        public int Detpla { get; set; }
        [Column("DETSTK")]
        public int Detstk { get; set; }
    }
}
