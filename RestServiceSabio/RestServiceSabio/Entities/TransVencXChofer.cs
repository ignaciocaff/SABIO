using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("TRANS_VENC_X_CHOFER")]
    public partial class TransVencXChofer
    {
        [Column("NUMCHO")]
        public short Numcho { get; set; }
        [Column("NUMDOC")]
        public short Numdoc { get; set; }
        [Column("FECVEN", TypeName = "DATE")]
        public DateTime? Fecven { get; set; }
        [Column("ANULA")]
        public short? Anula { get; set; }
    }
}
