using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DETOFERTA")]
    public partial class Detoferta
    {
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("NUMOFE")]
        public int Numofe { get; set; }
        [Required]
        [Column("CODART")]
        [StringLength(20)]
        public string Codart { get; set; }
    }
}
