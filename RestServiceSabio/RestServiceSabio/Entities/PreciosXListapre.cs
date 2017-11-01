using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("PRECIOS_X_LISTAPRE")]
    public partial class PreciosXListapre
    {
        [Column("LISTA")]
        public short Lista { get; set; }
        [Column("CODART")]
        [StringLength(20)]
        public string Codart { get; set; }
        [Column("FECVIG", TypeName = "DATE")]
        public DateTime Fecvig { get; set; }
    }
}
