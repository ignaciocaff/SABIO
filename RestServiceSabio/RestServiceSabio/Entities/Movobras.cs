using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("MOVOBRAS")]
    public partial class Movobras
    {
        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("NUMMOV")]
        public int Nummov { get; set; }
        [Column("NUMOBR")]
        public int Numobr { get; set; }
    }
}
