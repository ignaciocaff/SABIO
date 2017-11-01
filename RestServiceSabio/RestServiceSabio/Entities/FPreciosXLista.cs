using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("F_PRECIOS_X_LISTA")]
    public partial class FPreciosXLista
    {
        [Column("CANAL")]
        public int Canal { get; set; }
        [Column("LISTA")]
        public short Lista { get; set; }
        [Column("CODART")]
        [StringLength(20)]
        public string Codart { get; set; }
        [Column("FECVIG", TypeName = "DATE")]
        public DateTime Fecvig { get; set; }
        [Column("CLIENT")]
        public int Client { get; set; }
        [Column("YAGRAB", TypeName = "DATE")]
        public DateTime? Yagrab { get; set; }
    }
}
