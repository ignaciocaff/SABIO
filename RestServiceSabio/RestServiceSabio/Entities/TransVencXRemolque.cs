using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("TRANS_VENC_X_REMOLQUE")]
    public partial class TransVencXRemolque
    {
        [Column("NUMREM")]
        public short Numrem { get; set; }
        [Column("NUMDOC")]
        public short Numdoc { get; set; }
        [Column("FECVEN", TypeName = "DATE")]
        public DateTime? Fecven { get; set; }
        [Column("ANULA")]
        public short? Anula { get; set; }
    }
}
