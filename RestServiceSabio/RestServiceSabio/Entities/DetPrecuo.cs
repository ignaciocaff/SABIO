using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DET_PRECUO")]
    public partial class DetPrecuo
    {
        [Column("PRESEN")]
        public int Presen { get; set; }
        [Column("ASICUO")]
        public int Asicuo { get; set; }
    }
}
