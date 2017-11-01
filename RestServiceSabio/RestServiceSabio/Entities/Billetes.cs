using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("BILLETES")]
    public partial class Billetes
    {
        [Column("CAJA")]
        public int Caja { get; set; }
        [Column("TIPO")]
        public short Tipo { get; set; }
        [Column("CANTID")]
        public short Cantid { get; set; }
    }
}
