using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DET_COLECTOR")]
    public partial class DetColector
    {
        [Column("COLECT")]
        public int Colect { get; set; }
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Required]
        [Column("SERIAL")]
        [StringLength(40)]
        public string Serial { get; set; }
        [Column("CONSTK")]
        public short? Constk { get; set; }
        [Column("SINSTK")]
        public short? Sinstk { get; set; }
        [Column("DEPOSI")]
        public short? Deposi { get; set; }
    }
}
