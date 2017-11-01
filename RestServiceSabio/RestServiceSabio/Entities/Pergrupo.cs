using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("PERGRUPO")]
    public partial class Pergrupo
    {
        [Column("CASOUS")]
        [StringLength(10)]
        public string Casous { get; set; }
        [Column("GRUPO")]
        public short Grupo { get; set; }
    }
}
