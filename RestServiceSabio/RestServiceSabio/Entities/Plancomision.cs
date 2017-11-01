using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("PLANCOMISION")]
    public partial class Plancomision
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("DESCRI")]
        [StringLength(40)]
        public string Descri { get; set; }
        [Column("FORMU1")]
        [StringLength(100)]
        public string Formu1 { get; set; }
        [Column("FORMU2")]
        [StringLength(100)]
        public string Formu2 { get; set; }
        [Column("VENDED")]
        public short? Vended { get; set; }
        [Column("RUBRO")]
        public short? Rubro { get; set; }
        [Column("SUBRUB")]
        public short? Subrub { get; set; }
        [Column("LISPRE")]
        public short? Lispre { get; set; }
        [Column("PRIORI")]
        public short? Priori { get; set; }
        [Column("TIPPRO")]
        public short? Tippro { get; set; }
        [Column("CLIENT")]
        public int? Client { get; set; }
    }
}
