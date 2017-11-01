using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("INTERNACIONAL")]
    public partial class Internacional
    {
        [Column("CODIGO")]
        [StringLength(100)]
        public string Codigo { get; set; }
        [Column("PAIS")]
        public short Pais { get; set; }
        [Column("VALOR")]
        [StringLength(1024)]
        public string Valor { get; set; }
    }
}
