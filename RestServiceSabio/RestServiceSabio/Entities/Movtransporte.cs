using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("MOVTRANSPORTE")]
    public partial class Movtransporte
    {
        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("NUMTRA")]
        public int Numtra { get; set; }
        [Column("NUMVEH")]
        public short Numveh { get; set; }
        [Column("NUMCHO")]
        public short Numcho { get; set; }
        [Column("NUMMOV")]
        public int Nummov { get; set; }
        [Column("HORCAR", TypeName = "TIME")]
        public DateTime? Horcar { get; set; }
    }
}
