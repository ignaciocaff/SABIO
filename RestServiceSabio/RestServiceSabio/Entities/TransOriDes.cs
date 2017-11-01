using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("TRANS_ORI_DES")]
    public partial class TransOriDes
    {
        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("CLIENT")]
        public int Client { get; set; }
        [Column("DESCRI")]
        [StringLength(60)]
        public string Descri { get; set; }
        [Column("DOMICI")]
        [StringLength(60)]
        public string Domici { get; set; }
        [Column("LOCALI")]
        public short Locali { get; set; }
    }
}
