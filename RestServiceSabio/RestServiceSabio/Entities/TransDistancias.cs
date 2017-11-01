using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("TRANS_DISTANCIAS")]
    public partial class TransDistancias
    {
        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("ORIGEN")]
        public int Origen { get; set; }
        [Column("DESTIN")]
        public int Destin { get; set; }
        [Column("KMS")]
        public short Kms { get; set; }
    }
}
