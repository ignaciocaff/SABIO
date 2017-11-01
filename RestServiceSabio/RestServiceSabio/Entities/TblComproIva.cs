using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("TBL_COMPRO_IVA")]
    public partial class TblComproIva
    {
        [Column("CODCOM")]
        [StringLength(3)]
        public string Codcom { get; set; }
        [Column("LETRA")]
        [StringLength(1)]
        public string Letra { get; set; }
        [Column("CODIGO")]
        public short Codigo { get; set; }
    }
}
