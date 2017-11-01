using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("CTACAJA")]
    public partial class Ctacaja
    {
        [Column("CTACAJ")]
        [StringLength(12)]
        public string Ctacaj { get; set; }
        [Column("CAJA")]
        public short Caja { get; set; }
    }
}
