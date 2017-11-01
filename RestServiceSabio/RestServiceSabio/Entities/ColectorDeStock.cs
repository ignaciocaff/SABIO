using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("COLECTOR_DE_STOCK")]
    public partial class ColectorDeStock
    {
        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Required]
        [Column("CODART")]
        [StringLength(20)]
        public string Codart { get; set; }
        [Column("DEPOSI")]
        public short Deposi { get; set; }
        [Column("USUARI")]
        public short Usuari { get; set; }
    }
}
