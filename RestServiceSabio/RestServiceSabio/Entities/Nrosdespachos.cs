using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("NROSDESPACHOS")]
    public partial class Nrosdespachos
    {
        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Required]
        [Column("CODART")]
        [StringLength(20)]
        public string Codart { get; set; }
        [Required]
        [Column("NRODES")]
        [StringLength(100)]
        public string Nrodes { get; set; }
        [Column("CANTID")]
        public int? Cantid { get; set; }
        [Column("DEPOSI")]
        public short Deposi { get; set; }
    }
}
