using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DETTIPOSLAYOUT")]
    public partial class Dettiposlayout
    {
        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("TIPLAY")]
        public short Tiplay { get; set; }
        [Column("CONTRO")]
        [StringLength(20)]
        public string Contro { get; set; }
        [Column("FIELD")]
        [StringLength(20)]
        public string Field { get; set; }
        [Column("LABEL")]
        [StringLength(40)]
        public string Label { get; set; }
    }
}
